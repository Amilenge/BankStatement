using System;
using FinacialStatement.Models.BankSetups;
using FinacialStatement.Models.Transactions;

namespace FinacialStatement.Models.Banks
{
    /// <summary>  
    ///  This class applies to FNB bank  
    /// </summary> 
    public class Fnb : Bank, IBank
    {
        public BankSetup setup { get; set; }

        public TypeLookup _transactionLookup
        {
            get
            {
                return new TypeLookup
                {
                    Deposit = new string[] { },
                    Withdrawal = new string[] { },
                    PrepaidElectricity = new string[] { },
                    PrepaidAirtime = new string[] { },
                    PaymentMade = new string[] { },
                    PaymentReceived = new string[] { },
                    PointOfSale = new string[] { },
                    OverseePurchase = new string[] { },
                    TransactionCharges = new string[] { },
                    AdminCharges = new string[] { },
                    MonthlyAccountCharges = new string[] { },
                    NotificationFee = new string[] { }
                };
            }
            set
            {
                throw new Exception("fails to assign value to a readonly property");
            }
        }

        // Bank name must be the classname in lowercase
        public string _name { get { return "fnb";  } }

        public BankSetup _setup { get; set; }

        public Fnb()
        {
            this._setup = base.loadBankSetup(_name);
        }

        public BankSetup _getBankSetup()
        {
            if (_setup == null)
            {
                this._setup = base.loadBankSetup( this._name );
            }

            return this._setup;
        }
    }
}