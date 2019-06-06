using System;
using System.Collections.Generic;
using System.Web;
using FinacialStatement.Models.Banks;
using FinacialStatement.Models.Transactions;

namespace FinacialStatement.Models.Formats
{
    public class Xls : IFormat
    {
        public List<Transaction> GetContents(HttpPostedFile file_, string bank)
        {
            throw new NotImplementedException();
        }

        public IBank GetBank(string bank)
        {
            throw new NotImplementedException();
        }

        List<Transaction> IFormat.GetContents(HttpPostedFile file_, string bank)
        {
            throw new NotImplementedException();
        }

        IBank IFormat.GetBank(string bank)
        {
            throw new NotImplementedException();
        }
    }
}