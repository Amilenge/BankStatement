using System.Collections.Generic;
using System.Linq;
using System.Web;
using FinacialStatement.Models.BankSetups;
using FinacialStatement.Models.Formats;
using FinacialStatement.Models.Structure;

namespace FinacialStatement.Models.Transactions
{
    public class TransactionType
    {
        public List<Transaction> GetContents(IFormat type, HttpPostedFile file_, string bank)
        {
            return type.GetContents(file_, bank);
        }

        public static string get(BankSetup _setup, string description)
        {
            description = description.ToUpper();

            if (_setup.Deposit.Any(n => description.IndexOf(n) != -1))
            {
                return Enumerators.TransactionType.Deposit.ToString();
            }
            else if (_setup.PaymentMade.Any(n => description.IndexOf(n) != -1))
            {
                return Enumerators.TransactionType.PaymentMade.ToString();
            }
            else if (_setup.PaymentReceived.Any(n => description.IndexOf(n) != -1))
            {
                return Enumerators.TransactionType.PaymentReceived.ToString();
            }
            else if (_setup.PointOfSale.Any(n => description.IndexOf(n) != -1))
            {
                return Enumerators.TransactionType.PointOfSale.ToString();
            }
            else if (_setup.Withdrawal.Any(n => description.IndexOf(n) != -1))
            {
                return Enumerators.TransactionType.Withdrawal.ToString();
            }
            else if (_setup.Purchase.Any(n => description.IndexOf(n) != -1))
            {
                return Enumerators.TransactionType.OverseePurchase.ToString();
            }
            else if (_setup.Charges.Any(n => description.IndexOf(n) != -1))
            {
                return Enumerators.TransactionType.TransactionCharges.ToString();
            }
            else if (_setup.PrepaidAirtime.Any(n => description.IndexOf(n) != -1))
            {
                return Enumerators.TransactionType.PrepaidAirtime.ToString();
            }
            else if (_setup.PrepaidElectricity.Any(n => description.IndexOf(n) != -1))
            {
                return Enumerators.TransactionType.PrepaidElectricity.ToString();
            }
            else if (_setup.Fee.Any(n => description.IndexOf(n) != -1))
            {
                return Enumerators.TransactionType.Fee.ToString();
            }
            // Extend transaction type here
            else
            {
                return Enumerators.TransactionType.Unknown.ToString();
            }
        }
    }
}