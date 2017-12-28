using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInventorySystem
{
    /// <summary>
    /// interface to enable ploymorphism between different UIs, this way the program can be easily converted into a console application or other
    /// things
    /// </summary>
   public interface IUserInterface
    {
       /// <summary>
       /// display the players details (name, level etc)
       /// </summary>
       /// <param name="p"></param>

        void DisplayDetails(Player p);

       /// <summary>
       /// display the players inventory in a list
       /// </summary>
       /// <param name="inven"></param>
        void DisplayInventory(ItemList inven);

       /// <summary>
       /// load data from a file via deserialization
       /// </summary>
        void LoadData();

       /// <summary>
       /// save data to a file via serialization
       /// </summary>
        void SaveData();
    }
}
