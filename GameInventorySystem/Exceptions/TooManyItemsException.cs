using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInventorySystem
{
    /// <summary>
    /// to restrict inventory items amount
    /// </summary>
    public class TooManyItemsException : Exception
    {
       
        private  const String msg = "You can only have 10 items in your bag!";

        /// <summary>
        /// constructor
        /// </summary>
        public TooManyItemsException():base(msg)
        { }
    }
}
