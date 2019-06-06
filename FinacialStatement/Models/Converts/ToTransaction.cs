using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FinacialStatement.Models.Transactions;

namespace FinacialStatement.Models.Converts
{
    public static class _ToTransaction
    {
        /// <summary>
        /// Convert data to a transaction object
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static Transaction ToTransaction(this object data)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///  Connvert data to list or array of transaction
        /// </summary>
        /// <param name="data"></param>
        /// <param name="_type"></param>
        /// <returns></returns>
        public static Transaction ToTransactions(this object data, string _type )
        {
            throw new NotImplementedException();
        }
    }
}