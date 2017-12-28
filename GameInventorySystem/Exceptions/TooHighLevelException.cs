using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInventorySystem
{
    class TooHighLevelException :Exception
    {
        //this is to stop the player leveling up too high
        private const String msg = "Your level cannot be higher then 50";

        public TooHighLevelException() : base(msg) { }
    }
}
