using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Web;
using System.Web.Http.Cors;
using FinacialStatement.Models;
using FinacialStatement.Models.Transactions;

namespace FinacialStatement.Controllers.Api
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class FileController : ApiController
    {
        [HttpPost]
        public List<File> Upload()
        {
            List<File> transaction = new List<File>();

            HttpRequest request = HttpContext.Current.Request;

            var files = request.Files;

            if ( files.Count > 0 )
            {
                foreach (string file in files)
                {
                    var file_ = files[file];

                    string bank = request.Params["bank"];

                    if ( !string.IsNullOrEmpty(bank) )
                    {
                        string[] fileNameAndFormat = file_.FileName.Split('.');

                        string fileName = fileNameAndFormat[0];

                        transaction.Add(
                            new File
                            {
                                fileName = fileName,
                                transactions = file_.FileToTransaction(bank)
                            }
                        );
                    }
                    else
                    {
                        throw new Exception("bank name must not be empty");
                    }
                }

                // TEST CALCULATIONS
                List<Transaction> ttr = transaction[0].transactions;

                //var data = ttr.GroupBy(x => x.TransactionType).Select(g => new { Type = g.Key , Total = g.Sum( x=> (x.Amount < 0)? -x.Amount : x.Amount ) });

                return transaction;
            }
            else
            {
                throw new Exception("at least one file must be provided");
            }
        }
    }
}
