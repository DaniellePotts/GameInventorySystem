using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInventorySystem
{
    /// <summary>
    /// weapon class inherits from Iuseableitem interface and can be store in the item list. it improves the users attack power
    /// currently
    /// </summary>
    [Serializable]
    public class Weapon : IUseableItem
    {
        //this class currently acts in the same way as the consumeable one. all details of the functions are there.

        #region instance variables
        /// <summary>
        /// instance variables
        /// </summary>
        public string Name { get; set; }
        public int IncreaseAttack { get; set; }
        public double Price { get; set; }
       

        #endregion

        /// <summary>
        /// display the items details
        /// </summary>
        /// <returns></returns>
        public string Display()
        {
            string CR = Environment.NewLine;
            string msg = String.Format("{0}: Attack Bonus +{1} {2}", Name, IncreaseAttack, CR);

            return msg;
        }

        
        /// <summary>
        /// override string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Name;
        }

   /// <summary>
   /// constructor
   /// </summary>
   /// <param name="name"></param>
   /// <param name="attackInc"></param>
   /// <param name="Price"></param>
        public Weapon(string name, int attackInc, int Price)
        {

            this.Name = name;
            this.IncreaseAttack = attackInc;
            this.Price = Price;
        }

        /// <summary>
        /// let the player use the item. the player equips the item, the item is removed from their inventory, and the players attack stat is increased
        /// </summary>
        /// <param name="p"></param>
        public void useItem(Player p)
        {
            p.EquipWeapon(this);
            p.inven.RemoveItem(this);

            p.AttackPow += IncreaseAttack;
        }
    }
}
