using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinacialStatement.Models.Structures
{
    public class ColumnStructure
    {
        public bool IgnoreTitleRow { get; set; }
        public int Date { get; set; }
        public int Description { get; set; }
        public int? TransactionType { get; set; }
        public int Amount { get; set; }
        public int Balance { get; set; }
    }
}