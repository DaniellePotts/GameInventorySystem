using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInventorySystem
{
    /// <summary>
    /// this class lets the player look for an item in the scavengeUI form. it returns an item based on the random number generated. it can return any useable item.
    /// </summary>
    public class Scavenge
    {
        /// <summary>
        /// empty constructor.
        /// </summary>
        public Scavenge()
        {
          
        }

        /// <summary>
        /// returns an item based on a random number. 
        /// </summary>
        /// <returns></returns>
        public IUseableItem ScavengeForItem()
        {
            Random r = new Random();
            IUseableItem item = null;

            int generate = r.Next(1, 35);

            if(generate >= 1 && generate < 3)
            {
                item = new HealthItem("Herb", 15, 1, 10);
            }
            else if(generate >= 3 && generate <6 )
            {
                item=  new DefenseItem("Rock", 3, 1, 3);
            }
            else if(generate >= 6 && generate < 8)
            {
                item = new SpeedItem("Old Left Shoe", 5, 10, 10);
            }
            else if(generate >= 8 && generate < 9)
            {
                item = new SpeedItem("Old Right Shoe", 5, 1, 1);
            }
            else if(generate >= 9 && generate < 12)
            {
                item = new Weapon("Staple", 20, 12);
            }
            else if(generate >= 12 && generate < 15)
            {
                item = new HealthItem("Half Can of Pop", 2, 1, 5);
            }
            else if(generate >= 15 && generate < 18)
            {
                item = new HealthItem("Empty Bottle of Ketchup", 1, 1, 0);
            }
            else if(generate >= 18 && generate < 21)
            {
                item = new Weapon("Blunt Knife", 3, 15);
            }
            else if(generate >= 21 && generate < 24)
            {
                item = new DefenseItem("Steel Tray", 2, 1, 5);
            }
            else if(generate >= 24 && generate < 28)
            {
                item = new HealthItem("Chewed Gum", 1, 1, 1);
            }
            else if(generate >= 28 && generate < 30)
            {
                item = new SpeedItem("Full Coffee Jar", 5, 25, 1);
            }
            else if(generate >= 30 && generate < 34)
            {
                item = null;
            }
            else if(generate >= 34)
            {
                item = new ExperiencePointBoost("Cheat Cartridge", 100, 100);
            }

            return item;
        }
    }
}
