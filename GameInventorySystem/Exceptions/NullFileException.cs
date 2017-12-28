using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInventorySystem
{
    /// <summary>
    /// exception for a file having no data in it.
    /// </summary>
    public class NullFileException : Exception
    {
        //this is for in case a null file is returned or the file does not exist
        private const String msg = "The file you have tried to load has no data written to it";

        /// <summary>
        /// constructor
        /// </summary>
        public NullFileException():base(msg)
        { }
    }
}
