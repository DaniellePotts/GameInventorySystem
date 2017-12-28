using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInventorySystem
{
    /// <summary>
    /// to hold constants and data file names
    /// </summary>
    public static  class AppData
    {

        #region data files

        public const string GAME_DATA = "gameData.dat";
        /// <summary>
        /// players file
        /// </summary>
        public const string PLAYER_SAVE_FILE = "player.dat";

        /// <summary>
        /// shop save file
        /// </summary>
        public const string SHOP_SAVE_FILE = "shop.dat";

        //testing files
        public const string PLAYER_TEST_FILE = "testPlayer.dat";
        public const string SHOP_TEST_FILE = "testShop.dat";

        #endregion

        #region maximums for exceptions
        public const int MAX_BAG_ITEMS = 15;

        public const int MAX_LEVEL = 50;

        public const int MAX_EXP = 100;
        #endregion

        #region common error messages
        public const string NULL_PLAYER_MSG = "There is no player. Please create one or load one";
        public const string NULL_ITEM_SELECTED = "There is no item selected";

        #endregion

        #region defaults for creating a new player
        public const int DEFAULT_ATTACK_STAT = 10;
        public const int DEFAULT_DEFENSE_STAT = 10;
        public const int DEFAULT_SPEED_STAT = 10;
        public const double DEFAULT_MONEY_AMOUNT = 100;
        public const int DEFAULT_HEALTH = 100;

        #endregion
    }
}
