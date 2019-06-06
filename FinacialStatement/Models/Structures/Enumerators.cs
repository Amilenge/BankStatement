
namespace FinacialStatement.Models.Structure
{
    /// <summary>  
    ///  Enumerator of all transaction type we have in the application
    /// </summary> 
    public class Enumerators
    {
        public enum TransactionType
        {
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
            Fee,
            // extend list here
            Unknown
        }
    }
}