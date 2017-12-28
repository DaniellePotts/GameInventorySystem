using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInventorySystem
{
    /// <summary>
    /// this class will hold the games save data, which includes an instance of the shop class and an instance of the player class
    /// </summary>
    [Serializable]
    public class GameData
    {
        /// <summary>
        /// instance variables. these will hold the main csharp player and shop variable data to save, and will be used to assign loaded data to them 
        /// </summary>
        public Shop shop { get; set; }
        public Player player { get; set; }

        /// <summary>
        /// constructor with parameters
        /// </summary>
        /// <param name="player"></param>
        /// <param name="shop"></param>
        public GameData(Player player, Shop shop)
        {
            this.player = player;
            this.shop = shop;
        }

        /// <summary>
        /// parameterless constructor
        /// </summary>
        public GameData()
        {
            this.player = null;
            this.shop = null;
        }

        /// <summary>
        /// this sets the gamedata that needs to be saved. it checks to see if the shop is null (i.e, the user has not yet acccessed the shop
        /// before they saved the game and quit, so ShopUI.store is null) so this function creates a new instance of the shop.
        /// </summary>
        /// <param name="player"></param>
        /// <param name="shop"></param>
        public void SetData(Player player, Shop shop)
        {
            this.player = player;

            if(shop == null)
            {
                ItemList items = new ItemList();
                Shop s = new Shop(items);

                this.shop = s;
            }
            else
            {
                this.shop = shop;
            }
        }

      
    
    }
}
