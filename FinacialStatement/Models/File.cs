using System.Collections.Generic;
using FinacialStatement.Models.Transactions;

namespace FinacialStatement.Models
{
    public class File
    {
        public string fileName { get;set; }

        public List<Transaction> transactions { get; set; }
    }
}