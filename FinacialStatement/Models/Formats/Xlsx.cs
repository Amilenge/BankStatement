using System;
using System.Collections.Generic;
using System.Web;
using FinacialStatement.Models.Banks;
using FinacialStatement.Models.Transactions;

namespace FinacialStatement.Models.Formats
{
    /// <summary>
    /// Process a xlsx file 
    /// </summary>
    public class Xlsx : IFormat
    {
        public List<Transaction> GetContents(HttpPostedFile file_, string bank)
        {
            throw new NotImplementedException();
        }

        public IBank GetBank(string bank)
        {
            throw new NotImplementedException();
        }

    }
}