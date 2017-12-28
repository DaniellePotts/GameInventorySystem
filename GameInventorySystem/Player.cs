using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInventorySystem
{
    /// <summary>
    /// serializable class. 
    /// </summary>
    [Serializable]
    public class Player 
    {
        #region instance variables
        public string Name { get; set; }
        public int Level { get; set; }
        public int Health { get; set; }
        public int AttackPow { get; set; }
        public int DefenseStat { get; set; }
        public int SpeedStat { get; set; }
        public int ExpPoints { get; set; }
        public double Money { get; set; }
        public Weapon weapon { get; set; }
        public ItemList inven;

       
        
        #endregion

        /// <summary>
        /// constructor 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="health"></param>
        /// <param name="atk"></param>
        /// <param name="defense"></param>
        /// <param name="speed"></param>
        /// <param name="money"></param>
        /// <param name="inven"></param>
        public Player(string name, int health, int atk,int defense,int speed,double money, ItemList inven)
        {
            this.Name = name;
            
            this.Health = health;
            this.AttackPow = atk;
            this.DefenseStat = defense;
            this.SpeedStat = speed;
            this.Money = money;
            //set some default values
            Level = 1;
            ExpPoints = 0;

            //set the players inventory
            this.inven = inven;
            weapon = null;
        }

        /// <summary>
        /// empty constructor for deserialization
        /// </summary>
        public Player()
        { }

        /// <summary>
        /// returns the players name and level
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            
                return Name + " Level: " + Level;
          
        }

        /// <summary>
        /// displays all of the players details. unlike tostring which only displays their name and level
        /// </summary>
        /// <returns></returns>
        public string Display()
        {
            string msg = "";
            string CR = Environment.NewLine;

            msg = String.Format(" {0} Lvl:{1} {2}", Name, Level, CR);
            msg += String.Format("HP: {0} {1}", Health, CR);
            msg += String.Format("Attack Power: {0} {1}", AttackPow, CR);
            msg += String.Format("Defense Stat: {0} {1}", DefenseStat, CR);
            msg += String.Format("Speed stat: {0} {1}", SpeedStat, CR);
            msg += String.Format("{0} {1}", Money.ToString("C"), CR);

            if(weapon != null)
            {
                msg += String.Format("Equipped: {0} {1}", weapon, CR);
            }
            msg += String.Format("EXP To Next Level {0} {1}", (AppData.MAX_EXP - ExpPoints), CR);

            return msg;
        }

        /// <summary>
        /// lets the player level up if they have enough experience points. if they have 100 then the player will level up. 
        /// </summary>
        /// <param name="exp"></param>
        public void LevelUp(int exp)
        {
            ExpPoints = exp;

            if(ExpPoints >= AppData.MAX_EXP)
            {
                    Level += 1;

                    Random r = new Random();
                    var Atkincrease = r.Next(2, Level +3 );
                    var speedIncrease = r.Next(2, Level + 3);
                    var defenseIncrease = r.Next(2, Level + 3);
                    AttackPow += Atkincrease;
                    SpeedStat += speedIncrease;
                    DefenseStat += defenseIncrease;
                    ExpPoints = 0;
                
               
            }
            else if(Level >= AppData.MAX_LEVEL)
            {
                TooHighLevelException tooHighLvl = new TooHighLevelException();
                throw (tooHighLvl);
            }
        }

        /// <summary>
        /// lets the user equip a weapon. throws exception if a weapon is already equipped
        /// </summary>
        /// <param name="weapon"></param>
        public void EquipWeapon(Weapon weapon)
        {
            if (this.weapon == null)
            {
                this.weapon = weapon;
                
            }
            else
            {
                EquipWeaponException equipException = new EquipWeaponException();
                throw (equipException);
            }
        }

        /// <summary>
        /// unequips whatever the weapon is the player has equipped
        /// </summary>
        /// <param name="weapon"></param>
        public void UnEquipWeapon(Weapon weapon)
        { 
            inven.AddItem(weapon);
            AttackPow -= weapon.IncreaseAttack;
            this.weapon = null;
           
        }
     
    }

    
}
