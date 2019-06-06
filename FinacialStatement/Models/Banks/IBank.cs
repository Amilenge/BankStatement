using System.Collections.Generic;
using FinacialStatement.Models.BankSetups;
using FinacialStatement.Models.Transactions;

namespace FinacialStatement.Models.Banks
{
    /// <summary>  
    ///  Every bank should adhere to this contract
    /// </summary> 
    public interface IBank
    {
        /// <summary>
        /// Every back should have a bankname
        /// </summary>
        string _name { get; }

        /// <summary>
        /// Stores the bank' setup
        /// </summary>
        BankSetup _setup { get; set; }

        /// <summary>
        /// Retrieve the bank' Setup
        /// </summary>
        BankSetup _getBankSetup();

        /// <summary>
        /// transactionLookup
        /// </summary>
        TypeLookup _transactionLookup { get; set; }

    }
}
