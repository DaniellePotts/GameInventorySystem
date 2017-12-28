using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInventorySystem
{
    /// <summary>
    /// consumeable item is an abstract class. it inherits from IUsableItem and is serializable. 
    /// </summary>
    [Serializable]
    public abstract class ConsumableItem : IUseableItem
    {
        /// <summary>
        /// variables that all subclasses will inherit
        /// </summary>
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        #region contructors
        public ConsumableItem(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }

        public ConsumableItem(string name, double price, int quantity)
        {
            this.Name = name;
            this.Quantity = quantity;
            this.Price = price;
        }

        #endregion

        /// <summary>
        /// return name of item
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Name;
        }

        /// <summary>
        /// display method which is overridable by consumeables child classes. it outputs all information to do with each object.
        /// </summary>
        /// <returns></returns>
        public virtual string Display()
        {
            string msg = "";

            msg = String.Format("{0} {1}", Name, Environment.NewLine);
            return msg;
        }
        
        /// <summary>
        /// let the player use the item. this method is also overrideable. the method removes whatever item it is the player has selected from their list.
        /// </summary>
        /// <param name="p"></param>
        public virtual void useItem(Player p)
        {
            p.inven.RemoveItem(this);
        }
    }

    /// <summary>
    /// healthitem is an item that specializes in health increase. 
    /// </summary>
    [Serializable]
    public class HealthItem : ConsumableItem
    {
        /// <summary>
        /// unquie variable for this class. to increase the players health stat.
        /// </summary>
        public int IncreaseHealth { get; set; }

        #region constructors
     
        public HealthItem(string name, double price, int quantity,int health):base(name,price,quantity)
        {
            this.IncreaseHealth = health;
        }

        #endregion

        /// <summary>
        /// inherited from consumeable. it uses the base function of removing the item from the players item list, but also increases the players health sta
        /// </summary>
        /// <param name="p"></param>
        public override void useItem(Player p)
        {
            base.useItem(p);
            p.Health += IncreaseHealth;
        }

        /// <summary>
        /// inherited from cosumeable and also returns details in the string that are exclusive to health item
        /// </summary>
        /// <returns></returns>
        public override string Display()
        {
            //displays the same stuff as the super class, including the health bonus
            string CR = Environment.NewLine;

            string msg = base.Display();
            msg += String.Format("Health Bonus +{0} {1}", IncreaseHealth, CR);

            return msg;
        }
    }
    /// <summary>
    /// speed item, an item that specializes in speed increase
    /// </summary>
    [Serializable]
    public class SpeedItem : ConsumableItem
    {
        /// <summary>
        /// unqiue variable for this class. to imrpove the players speed stat
        /// </summary>
        public int increaseSpeed { get; set; }

        #region constructors
      

        public SpeedItem(string name, double price, int increaseSpeed, int quantity):base(name,price,quantity)
        {
            
            this.increaseSpeed = increaseSpeed;
        }
        #endregion

        /// <summary>
        /// inherited from consumeable. it includes information in the string that is exclusive to speed items
        /// </summary>
        /// <returns></returns>
        public override string Display()
        {
            string msg = base.Display();
            msg += String.Format("Speed Increase: +{0} {1}", increaseSpeed, Environment.NewLine);

            return msg;
        }


        /// <summary>
        /// inherited from consumeable. it performs the same actions as the parent class and also increases the players speed stat
        /// </summary>
        /// <param name="p"></param>
        public override void useItem(Player p)
        {
            base.useItem(p);
            p.SpeedStat += increaseSpeed;
        }
    
    }
    /// <summary>
    /// defense item, an item that specializes in defense increase
    /// </summary>
    [Serializable]
    public class DefenseItem : ConsumableItem
    {
        /// <summary>
        /// unquie variable for this class, to improve the players defense stat
        /// </summary>
        public int increaseDefense { get; set; }

        #region contructors
      
        public DefenseItem(string name, double price,int quantity, int increaseDefense):base(name,price,quantity)
        {
            this.increaseDefense = increaseDefense;
            
        }
        #endregion

        /// <summary>
        /// inherited from consumeable. it also returns information in the string that is exclusive to defense items
        /// </summary>
        /// <returns></returns>
        public override string Display()
        {
            string msg = base.Display();
            msg += String.Format("Defense increase +{0} {1}", increaseDefense, Environment.NewLine);

            return msg;
        }


        /// <summary>
        /// inherited from consumeable. it also increases the players defense stat.
        /// </summary>
        /// <param name="p"></param>
        public override void useItem(Player p)
        {
            base.useItem(p);
            p.DefenseStat += increaseDefense;
        }
    }
    /// <summary>
    /// level up item, this item levels up the player when used.
    /// </summary>
    [Serializable]
    public class LevelUpItem : ConsumableItem
    {
        /// <summary>
        /// unquie variable for this class, to imrpove the level of the player.
        /// </summary>
        public int LevelUpPlayer { get; set; }

        #region constructors
        

        public LevelUpItem(string name,double price,int quantity):base(name, price,quantity)
        {
            LevelUpPlayer = 1;
        }

        #endregion

        /// <summary>
        /// displays the same infromation as the super class, and also the level value of the item
        /// </summary>
        /// <returns></returns>
        public override string Display()
        {
            string msg = base.Display();
            msg += String.Format("+{0} Level {1}", LevelUpPlayer, Environment.NewLine);

            return msg;
        }


        /// <summary>
        /// inherits from the superclass, but also increases the players level when it is used. the game checks that the players level is below 50 first,
        ///if it isn't, it throws an exception
        /// </summary>
        /// <param name="p"></param>
        public override void useItem(Player p)
        {
            base.useItem(p);

            if (p.Level >= AppData.MAX_LEVEL)
            {
                TooHighLevelException th = new TooHighLevelException();
                throw (th);
            }
            else
            {
                base.useItem(p);
                p.Level += LevelUpPlayer;
            }
        }
    }
   
    
}
