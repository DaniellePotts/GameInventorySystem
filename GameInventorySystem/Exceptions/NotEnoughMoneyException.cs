using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInventorySystem
{
    /// <summary>
    /// to alert the user when they dont have enough money to buy an item
    /// </summary>
   public class NotEnoughMoneyException :Exception
    {

       private const String msg = "You don't have enough money";

       /// <summary>
       /// constructor
       /// </summary>
       public NotEnoughMoneyException():base(msg)
       { }
    }
}
