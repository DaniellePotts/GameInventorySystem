using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInventorySystem
{
    /// <summary>
    /// class to increase players exp
    /// </summary>
    [Serializable]
    public class ExperiencePointBoost: IUseableItem
    {
        /// <summary>
        /// instance variables
        /// </summary>
        public string Name{get;set;}
        public int increaseEXP { get; set; }
        public double Price { get; set; }

        /// <summary>
        /// constructor to assign the name, exp amount and price of the item to be bought and sold
        /// </summary>
        /// <param name="name"></param>
        /// <param name="increaseEXP"></param>
        /// <param name="Price"></param>
        public ExperiencePointBoost(string name, int increaseEXP, double Price)
        {
            this.Name = name;
            this.increaseEXP = increaseEXP;
            this.Price = Price;
        }

        /// <summary>
        /// return the name of the item
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Name;
        }

        /// <summary>
        /// display more information about the item.
        /// </summary>
        /// <returns></returns>
        public string Display()
        {
            string CR = Environment.NewLine;
            string msg = String.Format("{0} {1}", Name, CR);
            msg += String.Format("EXP Boost +{0} {1}", increaseEXP, CR);

            return msg;
        }

        /// <summary>
        /// increases the users exp, the player may level up if it now means their exp is at 100 or more.
        /// </summary>
        /// <param name="p"></param>
        public void useItem(Player p)
        {
            p.inven.RemoveItem(this);
            p.LevelUp(increaseEXP);
        }
    }
}
