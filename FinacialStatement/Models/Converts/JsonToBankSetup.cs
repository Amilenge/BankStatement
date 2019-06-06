using System;
using System.Web.Script.Serialization;
using FinacialStatement.Models.BankSetups;

namespace FinacialStatement.Models.Converts
{
    public static class _JsonToBankSetup
    {
        /// <summary>
        /// Convert stringified json string to object
        /// </summary>
        /// <param name="bankName"></param>
        /// <returns>BankSetup</returns>
        public static BankSetup ToBankSetup(this string bankName)
        {
            try
            {
                string contents = System.IO.File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + string.Format(@"/banksetups/{0}.json", bankName));

                return new JavaScriptSerializer().Deserialize<BankSetup>( contents );
            }
            catch (Exception ex)
            {
                throw new Exception("Could not read bank' configuration json file. Make sure it exists.");
            }

        }
    }
}