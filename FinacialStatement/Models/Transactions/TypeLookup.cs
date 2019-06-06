using System.Linq;
using FinacialStatement.Models.Structure;

namespace FinacialStatement.Models.Transactions
{
    /// <summary>  
    ///  This class contros tags=words to look for in transaction descrition in order to know what type of transaction it is
    /// </summary> 
    public class TypeLookup
    {
        public string[]
            Deposit,
            Withdrawal,
            PrepaidElectricity,
            PrepaidAirtime,
            PaymentMade,
            PaymentReceived,
            PointOfSale,
            OverseePurchase,
            TransactionCharges,
            AdminCharges,
            MonthlyAccountCharges,
            NotificationFee;
                   

        public string getTransactionType(string description)
        {
            description = description.ToUpper();

            if ( Deposit.Any(n => description.IndexOf(n) != -1) )
            {
                return Enumerators.TransactionType.Deposit.ToString();
            }
            else if (PaymentMade.Any(n => description.IndexOf(n) != -1))
            {
                return Enumerators.TransactionType.PaymentMade.ToString();
            }
            else if (PaymentReceived.Any(n => description.IndexOf(n) != -1))
            {
                return Enumerators.TransactionType.PaymentReceived.ToString();
            }
            else if (PointOfSale.Any(n => description.IndexOf(n) != -1))
            {
                return Enumerators.TransactionType.PointOfSale.ToString();
            }
            else if (Withdrawal.Any(n => description.IndexOf(n) != -1))
            {
                return Enumerators.TransactionType.Withdrawal.ToString();
            }
            else if (OverseePurchase.Any(n => description.IndexOf(n) != -1))
            {
                return Enumerators.TransactionType.OverseePurchase.ToString();
            }
            else if (TransactionCharges.Any(n => description.IndexOf(n) != -1))
            {
                return Enumerators.TransactionType.TransactionCharges.ToString();
            }
            else if (AdminCharges.Any(n => description.IndexOf(n) != -1))
            {
                return Enumerators.TransactionType.AdminCharges.ToString();
            }
            else if (PrepaidAirtime.Any(n => description.IndexOf(n) != -1))
            {
                return Enumerators.TransactionType.PrepaidAirtime.ToString();
            }
            else if (MonthlyAccountCharges.Any(n => description.IndexOf(n) != -1))
            {
                return Enumerators.TransactionType.MonthlyAccountCharges.ToString();
            }
            // Extend transaction type here
            else
            {
                return Enumerators.TransactionType.Unknown.ToString();
            }
        }
    }
}