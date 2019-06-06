using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using FinacialStatement.Models.Formats;
using FinacialStatement.Models.Transactions;

namespace FinacialStatement.Models
{
    public static class Process
    {
        public static DataSet data = new DataSet();

        public static HashSet<string> acceptFormats = new HashSet<string>() { "csv" };

        public static IFormat getType(string type_ )
        {
            IFormat type = null;

            try
            {
                switch ( type_.ToLower())
                {
                    case "csv":
                        type = new CSV();
                        break;
                    case "xls":
                        type = new Xls();
                            break;
                    case "xlsx":
                        type = new Xlsx();
                            break;
                    // Expand list here
                }
            }
            catch (Exception)
            {
                throw new Exception("Incorrect file type");
            }

            return type;
        }

        public static List<Transaction> FileToTransaction(this object file, string bank)
        {
            try
            {
                HttpPostedFile file_ = (HttpPostedFile)file;

                if(acceptFormats.Contains(file_.FileName.Split('.')[1].ToLower()))
                {

                    Transactions.TransactionType objType = new Transactions.TransactionType();

                    IFormat type = Process.getType("csv");

                    return objType.GetContents(type, file_, bank);
                }
                else
                {
                    throw new Exception("Incorrect file format");
                }
            }
            catch (Exception)
            {
                throw new Exception("fails to read te file");
            }
        }
    }
}