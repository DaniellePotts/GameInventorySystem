using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInventorySystem
{
    /// <summary>
    /// item list exists to hold the players inventory items as well as the stock items of the store. it has a number of functions
    /// such as adding and removing items from list.
    /// </summary>
    [Serializable]
   public class ItemList 
    {
        //create a list to store all IUseableItems
        private List<IUseableItem> Inventory;

       /// <summary>
       /// return an item based on the index provided
       /// </summary>
       /// <param name="index"></param>
       /// <returns></returns>
        public IUseableItem this[int index]
        {
            get
            {
                if((index <0)|| (index > Inventory.Count))
                {
                    return null;
                }

                return Inventory[index];
            }
        }

        public void SetItem(int index, IUseableItem item)
        {
            Inventory[index] = item;
          
        }

        /// <summary>
        /// constructor
        /// </summary>
        public ItemList()
        {
            Inventory = new List<IUseableItem>();
        }

        /// <summary>
        /// return how many items there are in the inventory list
        /// </summary>
        /// <returns></returns>
        public int GetInventoryCount()
        {
            return Inventory.Count;
        }

        /// <summary>
        /// allow the user to add an item to the list. the user is able to add 2 of the same item to the list at this point, however
        /// the user is not allowed to add more then AppData.MAX_BAG_ITEMS to the list.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool AddItem(IUseableItem item)
        {
         
            //check item is not null, if so return false.
            if(ReferenceEquals(null, item))
            {
                return false;
            }
            else
            {
                //check that the inventory count of suitable amount, if not, throw exception
                if ( Inventory.Count >= AppData.MAX_BAG_ITEMS)
                {
                    TooManyItemsException maxExc = new TooManyItemsException();
                    throw (maxExc);
                }
                else
                {
                           //if it is, then add them item to the list  
                    Inventory.Add(item);                        
                    
                    return true;
                }
                
            }
        }

        /// <summary>
        /// let the user remove an item from their inventory
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool RemoveItem(IUseableItem item)
        {
            //check that the item is not null, if so, return false
            if(ReferenceEquals(null, item))
            {
                return false;
            }
            else
            {
               //else, remove the item from the list
                    Inventory.Remove(item);
                
                return true;
            }
        }

        /// <summary>
        /// clears the list. set as protected
        /// </summary>
        protected void ClearList()
        {
            Inventory.Clear();
        }
    }
}
