using System.Collections.Generic;
using System.Web.Http;
using FinacialStatement.Models.Transactions;

namespace FinacialStatement.Controllers.Api
{
    public class DataController : ApiController
    {
        [HttpGet]
        public List<Transaction> Deposits()
        {
            // return all deposits
            return null;
        }

        [HttpGet]
        public Transaction Deposit(int id)
        {
            return null;
        }
    }
}
