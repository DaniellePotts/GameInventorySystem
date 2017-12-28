using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInventorySystem
{
    public class FileNotLoadedProperlyException : Exception
    {
        private const String msg = "File has not loaded properly, file has either loaded as null or there was an error loading";

        public FileNotLoadedProperlyException():base(msg)
        { }
    }
}
