using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInventorySystem
{
    /// <summary>
    /// shop class that inherits from ISerializableObject. this class handles the purchasing and selling of items between it and the
    /// player class. it is serializable and is serialized with the player as part of the entire game data
    /// </summary>
    [Serializable]
    public class Shop 
    {
        #region instance variables
        public ItemList shopItems { get; set; }
        public double Money { get; set; }
#endregion

        #region constructors
        public Shop(ItemList shopItems)
        {
            this.shopItems = shopItems;
            this.Money = 100;
        }

        // constructor for deserialization
        public Shop()
        { this.Money = 100; }

        #endregion

        /// <summary>
       /// let the player buy an item from the shop. if the player has enough money, they will be able to buy the item from the shop
       /// //if they do, the item will be removed from the shops inventory, the value of the item bought will be added to the shops
       /// money and deducted from the players
       /// </summary>
       /// <param name="p"></param>
       /// <param name="obj"></param>
       /// <returns></returns>
        public bool SellItem(Player p, IUseableItem obj)
        {
            //check the item is not null, if so, return false.
            if (ReferenceEquals(null, obj))
            {               
                return false;
            }
                //check that the player has enough money to buy the item
            else if(p.Money >= obj.Price)
            {
                //if they do have enough money, remove the item from the shop list, add the value of that object bought to the shops money value, and 
                //decrease the players money value by the object's price. return true.
                shopItems.RemoveItem(obj);
                Money += obj.Price;
                p.Money -= obj.Price;

                obj.Price = obj.Price / 2;
                return true;
            }
            else
            {

           //if they dont have enough money, throw an exception
                NotEnoughMoneyException ne = new NotEnoughMoneyException();
                throw(ne);
            }
          
           
        }

        /// <summary>
        /// this function allows the shop to buy an item from the player if the shop has enough money. if it does, then the item
        /// is removed from the players inventory,and the value of the item bought is added to the players money and deducted from
        /// the shops. 
        /// </summary>
        /// <param name="p"></param>
        /// <param name="obj"></param>
        /// <returns></returns>
        public bool BuyItem(Player p, IUseableItem obj)
        {
            if(ReferenceEquals(null,obj))
            {
                return false;
            }
            else  if (Money >= obj.Price)
            {
                Money -= obj.Price;
                p.Money += obj.Price;
                p.inven.RemoveItem(obj);
                shopItems.AddItem(obj);

                obj.Price = obj.Price * 2;
                return true;
            }
            else
            {
                NotEnoughMoneyException ne = new NotEnoughMoneyException();
                throw (ne);

            }
        }

        /// <summary>
        /// generate the shops data. this data is generated based on a random number and the random items are added to the shops
        /// item list
        /// </summary>
        /// <param name="items"></param>
        public void GenerateData(ItemList items)
        {
            List<IUseableItem> stuff = new List<IUseableItem>();
            int num = 0;
            int randomizeItems = 0;
            Random r = new Random();
            
            num = r.Next(5, 15);
            randomizeItems = r.Next(1, 20);
          
            //randomize the objects. the random number can be anything between 1 and 15. there are three conditions, if the number is lower then 5, if 
            //the number if greater or equal to 5 but less than 10, and if it is greater or equal to 10

            if (randomizeItems < 5)
            {
                stuff.Add(new HealthItem("Herb", 10, 5,num));
                stuff.Add(new SpeedItem("Speed Potion", 10, 3, num));
                stuff.Add(new DefenseItem("Defense Potion", 1, 10, num));
                stuff.Add(new Weapon("Sword", 10, 10));
                stuff.Add(new LevelUpItem("Rare Candy", 50, 2));
              
            }
            else if (randomizeItems >= 5 && randomizeItems < 10)
            {
                stuff.Add(new DefenseItem("Defense stick", 10, num,3));
                stuff.Add(new HealthItem("Super Herb", 10, num,3));
                stuff.Add(new Weapon("Dagger", 10,5));
                stuff.Add(new HealthItem("Super Health Potion", 25, 2, 20));
                stuff.Add(new Weapon("Flamethrower", 45, 45));
            }
            else if(randomizeItems >= 10 && randomizeItems < 15)
            {
                stuff.Add(new SpeedItem("Speed Shoes", 10,num,3));
                stuff.Add(new DefenseItem("Shield", 13, 10, 25));
                stuff.Add(new HealthItem("Pizza", 17, 1, 15));
            }
            else
            {
                stuff.Add(new Weapon("Leaf",45,2));
                stuff.Add(new Weapon("Gauntlets", 20, 20));
                stuff.Add(new Weapon("Chainsaw", 3, 100));
                stuff.Add(new HealthItem("Sponge Cake", 5, 1, 15));
            }

            randomizeItems = r.Next(1, 100);

            if(randomizeItems == 50)
            {
                stuff.Add(new ExperiencePointBoost("Cheat Cartridge", 100, 200));
            }
            //add the items to the list
           for(int i=0;i<stuff.Count;i++)
           {
               items.AddItem(stuff[i]);
           }
        }

        
    }
}
