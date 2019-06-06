using System.Collections.Generic;
using System.Web;
using FinacialStatement.Models.Banks;
using FinacialStatement.Models.Transactions;

namespace FinacialStatement.Models.Formats
{
    public interface IFormat
    {
        List<Transaction> GetContents( HttpPostedFile file_, string bank);

        IBank GetBank(string bank);

    }
}
