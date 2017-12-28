using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInventorySystem
{
    /// <summary>
    /// to allow for polymorphism in the itemlist
    /// </summary>
    public interface IUseableItem
    {
        //this interface allows for a number of items to be stored inside the list

        double Price { get; set; }
        
        void useItem(Player p);
        string Display();
    }
}
