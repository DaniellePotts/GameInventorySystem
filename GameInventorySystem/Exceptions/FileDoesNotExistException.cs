using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInventorySystem
{
    /// <summary>
    /// exception for a file not existing
    /// </summary>
    public class FileNotLoadedProperlyException : Exception
    {
        //this exception is for if the file hasnt loaded properly. so if it doesnt exist
        private const String msg = "The file does not exist";

        /// <summary>
        /// constructor
        /// </summary>
        public FileNotLoadedProperlyException():base(msg)
        { }
    }
}
