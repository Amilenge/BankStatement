using System;
using FinacialStatement.Models.BankSetups;
using FinacialStatement.Models.Transactions;

namespace FinacialStatement.Models.Banks
{
    /// <summary>  
    ///  Applies to ABSA bank
    /// </summary> 
    public class Absa : Bank, IBank
    {
        public TypeLookup _transactionLookup
        {
            get 
            {
                return new TypeLookup
                {
                    Deposit = new string[] { "WESTERN UNION", "IBANK PAYMENT", "ACB CREDIT" },
                    Withdrawal = new string[] { "ATM WITHDRAWAL" },
                    PrepaidElectricity = new string[] { },
                    PrepaidAirtime = new string[] { "AIRTIME DEBIT" },
                    PaymentMade = new string[] { "IBANK PAYMENT TO" },
                    PaymentReceived = new string[] { "IBANK PAYMENT FROM" },
                    PointOfSale = new string[] { "POS PURCHASE", "POS PUR" },
                    OverseePurchase = new string[] { "OVERSEAS PURCHASE" },
                    TransactionCharges = new string[] { "TRANSACTION CHARGE" },
                    AdminCharges = new string[] { "ADMIN CHARGE" },
                    MonthlyAccountCharges = new string[] { "MONTHLY ACC" },
                    NotificationFee = new string[] { "NOTIFIC FEE" }
                };
            }
            set
            {
                throw new Exception("fails to assign value to a readonly property");
            }
        }

        // Bank name must be the classname in lowercase
        public string _name { get { return "absa"; } }

        public BankSetup _setup { get; set; }

        public Absa()
        {
            this._setup = base.loadBankSetup( _name );
        }

        public BankSetup _getBankSetup()
        {
            if( _setup == null)
            {
                this._setup = base.loadBankSetup( this._name );
            }

            return this._setup;
        }
    }
}