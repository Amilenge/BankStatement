using FinacialStatement.Models.Structures;

namespace FinacialStatement.Models.BankSetups
{
    public class BankSetup
    {
        public string[] Deposit {set; get;}
        public string[] Withdrawal {set; get;}
        public string[] PrepaidElectricity {set; get;}
        public string[] PrepaidAirtime {set; get;}
        public string[] PaymentMade {set; get;}
        public string[] PaymentReceived {set; get;}
        public string[] PointOfSale {set; get;}
        public string[] Purchase {set; get;}
        public string[] Charges { set; get;}
        public string[] Fee {set; get;}
        public ColumnStructure CsvColumnStructure { set; get; }
    }
}
