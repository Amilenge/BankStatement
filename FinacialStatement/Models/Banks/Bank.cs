using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;
using FinacialStatement.Models.BankSetups;
using FinacialStatement.Models.Converts;
using FinacialStatement.Models.Transactions;


namespace FinacialStatement.Models.Banks
{
    /// <summary>  
    ///  Abstract Bank class
    /// </summary> 
    public abstract class Bank
    {
        public List<Transaction> getCSV(List<string> fileLines = null, IBank bank = null)
        {
            List<Transaction> transactions = new List<Transaction>();

            try
            {
                // Check if row must be ignored
                if(bank._setup.CsvColumnStructure.IgnoreTitleRow)
                {
                    fileLines.RemoveAt(0);
                }

                Parallel.ForEach(fileLines, line =>
                {
                    string[] trnasaction = line.Trim().Split(',');

                    if ( trnasaction.Length == 4 )
                    {
                        try
                        {
                            /*
                             * Apply bank specific csv structure
                             */
                            string date = trnasaction[ bank._setup.CsvColumnStructure.Date ];

                            string Description = trnasaction[bank._setup.CsvColumnStructure.Description];

                            // Apply number format
                            var fmt = new NumberFormatInfo();

                            fmt.NegativeSign = "-";

                            double Amount = double.Parse( trnasaction[bank._setup.CsvColumnStructure.Amount].Trim(), fmt );

                            double Balance = double.Parse( trnasaction[bank._setup.CsvColumnStructure.Balance].Trim(), fmt );

                            // Lock object to avoid threading incorrectly modify the list
                            lock (transactions)
                            {
                                // Add new transaction record to list of transaction
                                transactions.Add
                                (
                                    new Transaction
                                    {
                                        Date = date,
                                        Description = Description,
                                        Amount = Amount,
                                        Balance = Balance,
                                        TransactionType = TransactionType.get( bank._setup, Description )
                                    }
                                );
                            }
                        }
                        catch (Exception ex) { throw ex; }
                    }
                    else
                    {
                        // A transacition line was not added properly
                    }
                });

            }
            catch (Exception)
            {
                throw new Exception("Transaction in incorrect format");
            }

            return transactions;
        }

        public List<Transaction> getPDF(Bank bank = null)
        {
            if (bank != null)
                return bank.getPDF();
            return null;
        }

        public List<Transaction> getXLS(Bank bank = null)
        {
            if (bank != null)
                return bank.getXLS();
            return null;
        }

        public List<Transaction> getXLSX(Bank bank = null)
        {
            if (bank != null)
                return bank.getXLSX();
            return null;
        }

        public BankSetup loadBankSetup(string _bankName)
        {
            return _bankName.ToBankSetup();
        }
    }
}
