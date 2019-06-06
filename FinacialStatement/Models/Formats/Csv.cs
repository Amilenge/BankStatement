using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using FinacialStatement.Models.Banks;
using FinacialStatement.Models.Transactions;

namespace FinacialStatement.Models.Formats
{
    /// <summary>
    /// Class used for CSV file type
    /// </summary>
    public class CSV : IFormat
    {
        public List<Transaction> GetContents(HttpPostedFile file_ , string _bankname)
        {
            try
            {
                /*
                 *  All banks must adhere to CSV standards coma-delimitated structure
                 */
                BinaryReader b = new BinaryReader(file_.InputStream);

                byte[] binaryData = b.ReadBytes(file_.ContentLength);

                string fileData = System.Text.Encoding.UTF8.GetString(binaryData).Trim();

                /*
                 *  Read all lines from the submitted file
                 */

                List<string> documentLines = fileData.Split(new[] { Environment.NewLine }, StringSplitOptions.None).ToList();
                
                // Get colums from each records(file lines) as per each bank format
                IBank bank = new CSV().GetBank( _bankname );

                // Inject IBank into objBank - DI: dependency injection.
                // Helps this to dont depend on ONE bank
                return (bank as Bank).getCSV(documentLines, bank );

                //-------------------CHECK above line for errors

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public IBank GetBank(string _bank)
        {
            IBank Ibank;

            switch ( _bank.ToLower() )
            {
                case "absa":
                    Ibank = new Absa();
                    break;
                case "fnb":
                    Ibank = new Fnb();
                    break;
                // Extend banks here
                default:
                    /*
                     * Log this so we know users from unsupported banks who would like their banks to be added in the future
                     */
                    throw new Exception("Insupported bank");
            }

            return Ibank;
        }
    }
}