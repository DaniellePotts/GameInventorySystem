using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameInventorySystem;
using TestedClass = GameInventorySystem.Player;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;


namespace UnitTest2
{
    [TestClass]
    public class UnitTest1
    {
        private TestedClass testClass;
        private IUseableItem useable;
        private ItemList inventory;
        private Shop shop;
        private IFileWriterReader filehandler;
        private GameData gamedata;

        [TestInitialize]
        public void TestIntialize()
        {
            inventory = new ItemList();
            shop = new Shop();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            testClass = null;
            useable = null;
            inventory = null;
            shop = null;
            filehandler = null;
            gamedata = null;
        }

        #region TestValues

        const string NAME = "default";
        const int LEVEL = 1;
        const int HEALTH = 10;
        const int ATTACK_LEVEL = 10;
        const int DEFENSE_LEVEL = 10;
        const int SPEED_LEVEL = 10;
        const int MONEY = 50;

        const int PRICE = 10;
        #endregion

        #region testing useableitems

        /// <summary>
        /// testing some usable items. testing to see if the expected values are the correct values, if they are then the functions work
        /// as they are supposed to. these tests are all very similar so do not require invidual commenting.
        /// </summary>
        #region testing health items
        [TestMethod]
        public void TestingHealthItem_ValueOf10_Expecting20()
        {
            testClass = new TestedClass(NAME, HEALTH, ATTACK_LEVEL, DEFENSE_LEVEL, SPEED_LEVEL, MONEY, inventory);

            useable = new HealthItem(NAME, PRICE,3, 10);

            useable.useItem(testClass);

            var expectedValue = 20;

            var actualValue = testClass.Health;

            var failMsg = String.Format("Expecting {0} but got {1}", expectedValue, actualValue);

            Assert.AreEqual(expectedValue, actualValue, failMsg);

        }

        [TestMethod]
        public void TestingHealthItem_ValueOf40_Expecting_50()
        {
            testClass = new TestedClass(NAME, HEALTH, ATTACK_LEVEL, DEFENSE_LEVEL, SPEED_LEVEL, MONEY, inventory);
            useable = new HealthItem(NAME, PRICE,3, 40);

            var expectedValue = 50;

            useable.useItem(testClass);

            var actualValue = testClass.Health;

            var failMsg = String.Format("Expecting {0} but got {1}", expectedValue, actualValue);

            Assert.AreEqual(expectedValue, actualValue, failMsg);
        }

        [TestMethod]
        public void TestingHealthItem_ValueOf12_Expecting_22()
        {
            testClass = new TestedClass(NAME, HEALTH, ATTACK_LEVEL, DEFENSE_LEVEL, SPEED_LEVEL, MONEY, inventory);
            useable = new HealthItem(NAME, PRICE, 3,12);

            useable.useItem(testClass);

            var expectedValue = 22;
            var actualValue = testClass.Health;

            var failMsg = String.Format("Expecting {0} but got {1}", expectedValue, actualValue);

            Assert.AreEqual(expectedValue, actualValue, failMsg);
        }
        #endregion

        #region testing speed item
        [TestMethod]
        public void TestingSpeedItem_Expecting30()
        {
            testClass = new TestedClass(NAME, HEALTH, ATTACK_LEVEL, DEFENSE_LEVEL, SPEED_LEVEL, MONEY, inventory);
            useable = new SpeedItem(NAME, PRICE,20,3);

            useable.useItem(testClass);

            var expectedValue = 30;
            var actualValue = testClass.SpeedStat;

            var failMsg = String.Format("Expecting {0} but got {1}", expectedValue, actualValue);

            Assert.AreEqual(expectedValue, actualValue, failMsg);
        }

        [TestMethod]
        public void TestingSpeedItem_Value44_Expecting54()
        {
            testClass = new TestedClass(NAME, HEALTH, ATTACK_LEVEL, DEFENSE_LEVEL, SPEED_LEVEL, MONEY, inventory);

            useable = new SpeedItem(NAME, PRICE, 44,3);

            useable.useItem(testClass);

            var expectedValue = 54;
            var actualValue = testClass.SpeedStat;

            var failMsg = String.Format("Expecting {0} but got {1}", expectedValue, actualValue);

            Assert.AreEqual(expectedValue, actualValue, failMsg);
        }

        [TestMethod]
        public void TestingSpeedItem_Value3_Expecting13()
        {
            testClass = new TestedClass(NAME, HEALTH, ATTACK_LEVEL, DEFENSE_LEVEL, SPEED_LEVEL, MONEY, inventory);
            useable = new SpeedItem(NAME, PRICE,3, 3);

            useable.useItem(testClass);

            var expectedValue = 13;
            var actualValue = testClass.SpeedStat;

            var failMsg = String.Format("Expecting {0} but got {1}", expectedValue, actualValue);

            Assert.AreEqual(expectedValue, actualValue, failMsg);
        }
        #endregion

        #region testing defenseitems

        [TestMethod]
        public void TestingDefenseItem_Value75_Expecting85()
        {
            testClass = new TestedClass(NAME, HEALTH, ATTACK_LEVEL, DEFENSE_LEVEL, SPEED_LEVEL, MONEY, inventory);
            useable = new DefenseItem(NAME, PRICE, 3,75);

            useable.useItem(testClass);

            var expectedValue = 85;

            var actualValue = testClass.DefenseStat;

            var failMsg = String.Format("Expecting {0} but got {1}", expectedValue, actualValue);

            Assert.AreEqual(expectedValue, actualValue, failMsg);
        }

        [TestMethod]
        public void TestingDefenseItem_Value5_Expeting15()
        {
            testClass = new TestedClass(NAME, HEALTH, ATTACK_LEVEL, DEFENSE_LEVEL, SPEED_LEVEL, MONEY, inventory);
            useable = new DefenseItem(NAME, PRICE, 3,5);

            useable.useItem(testClass);

            var expectedValue = 15;
            var actualValue = testClass.DefenseStat;

            var failMsg = String.Format("Expecting {0} but got {1}", expectedValue, actualValue);
            Assert.AreEqual(expectedValue, actualValue, failMsg);
        }

        [TestMethod]
        public void TestinfDefenseItem_Value300_Expecting310()
        {
            testClass = new TestedClass(NAME,  HEALTH, ATTACK_LEVEL, DEFENSE_LEVEL, SPEED_LEVEL, MONEY, inventory);
            useable = new DefenseItem(NAME, PRICE, 3,300);

            useable.useItem(testClass);

            var expectedValue = 310;
            var actualValue = testClass.DefenseStat;

            var failMsg = String.Format("Expecting {0} but got {1}", expectedValue, actualValue);

            Assert.AreEqual(expectedValue, actualValue, failMsg);
        }
        #endregion

        #region testing weapon item

        [TestMethod]
        public void TestingWeapon_Value22_Expecting32()
        {
            testClass = new TestedClass(NAME,HEALTH, ATTACK_LEVEL, DEFENSE_LEVEL, SPEED_LEVEL, MONEY, inventory);
            useable = new Weapon(NAME, 22, PRICE);

            useable.useItem(testClass);

            var expectedValue = 32;
            var actualValue = testClass.AttackPow;

            var failMsg = String.Format("Expecing {0} but got {1}", expectedValue, actualValue);

            Assert.AreEqual(expectedValue, actualValue, failMsg);
        }

        [TestMethod]
        public void TestingWeapon_Value4_Expecting14()
        {
            testClass = new TestedClass(NAME, HEALTH, ATTACK_LEVEL, DEFENSE_LEVEL, SPEED_LEVEL, MONEY, inventory);
            useable = new Weapon(NAME, 4, PRICE);

            useable.useItem(testClass);

            var expectedValue = 14;
            var actualValue = testClass.AttackPow;

            var failMsg = String.Format("Expecting {0} but got {1}", expectedValue, actualValue);

            Assert.AreEqual(expectedValue, actualValue, failMsg);
        }

        [TestMethod]
        public void TestingWeapon_Value210_Expecting220()
        {
            testClass = new TestedClass(NAME, HEALTH, ATTACK_LEVEL, DEFENSE_LEVEL, SPEED_LEVEL, MONEY, inventory);

            useable = new Weapon(NAME, 210, PRICE);

            useable.useItem(testClass);

            var expectedValue = 220;
            var actualValue = testClass.AttackPow;

            var failMsg = String.Format("Expecting {0} but got {1}", expectedValue, actualValue);

            Assert.AreEqual(expectedValue, actualValue, failMsg);
        }
        #endregion

        #endregion

        #region test serilization

        /// <summary>
        /// try an catch an error with the serialization
        /// </summary>
        [TestMethod]
        public void testing_serialization_Test1()
        {
            
            testClass = new TestedClass(NAME, HEALTH, ATTACK_LEVEL, DEFENSE_LEVEL, SPEED_LEVEL, MONEY, inventory);
            shop = new Shop();
            filehandler = new DataFileReaderWriter();
            gamedata = new GameData();
            gamedata.shop = shop;
            gamedata.player = testClass;

            try
            {
                filehandler.SaveGameData(gamedata, AppData.PLAYER_TEST_FILE);
            }
            catch(Exception exception)
            {
                Assert.Fail(exception.Message);
            }
        }

        /// <summary>
        /// try and catch an error with serilization a second time with different object values
        /// </summary>
        [TestMethod]
        public void Testing_serialization_Test2()
        {
            
            testClass = new TestedClass("name", 2, 2, 2, 2, 2.2, inventory);
            gamedata = new GameData();
            shop = new Shop();

            filehandler = new DataFileReaderWriter();

            gamedata.player = testClass;
            gamedata.shop = shop;

            try
            {
                filehandler.SaveGameData(gamedata, AppData.PLAYER_TEST_FILE);
            }
            catch(Exception exception)
            {
                Assert.Fail(exception.Message);
            }
        }

        /// <summary>
        /// check that gameData2 is not null, if it isnt then the serilization and deserilization process was successfull
        /// </summary>
        [TestMethod]
        public void Testing_Deserialization_Test1()
        {
           
            gamedata = new GameData();
            GameData gameData2 = null;
            shop = new Shop();
            testClass = new TestedClass(NAME, HEALTH, ATTACK_LEVEL, DEFENSE_LEVEL, SPEED_LEVEL, MONEY, inventory);

            filehandler = new DataFileReaderWriter();

            gamedata.player = testClass;
            gamedata.shop = shop;

            filehandler.SaveGameData(gamedata, AppData.PLAYER_TEST_FILE);

            gameData2 = filehandler.LoadGameData(gameData2, AppData.PLAYER_TEST_FILE);
            
            Assert.IsNotNull(gameData2);

            
        }

        /// <summary>
        /// similar to the previous test. however here we check to see if the name that was returned from the file was the name we expected.
        /// </summary>
        [TestMethod]
        public void Testing_Deserialization_Test2()
        {
            
            gamedata = new GameData();
            GameData gamedata2 = new GameData();
            testClass = new TestedClass(NAME, HEALTH, ATTACK_LEVEL, DEFENSE_LEVEL, SPEED_LEVEL, MONEY, inventory);
            shop = new Shop();
            filehandler = new DataFileReaderWriter();

            gamedata.shop = shop;
            gamedata.player = testClass;

            filehandler.SaveGameData(gamedata, AppData.PLAYER_TEST_FILE);
            gamedata2 = filehandler.LoadGameData(gamedata2, AppData.PLAYER_TEST_FILE);

            var expectedResult = NAME;
            var actualResult = gamedata2.player.Name;

            var failMsg = String.Format("Expected {0} but got {1}", expectedResult, actualResult);

            Assert.AreEqual(expectedResult, actualResult);

        }

        /// <summary>
        /// try and catch an error with deserilization
        /// </summary>
        [TestMethod]
        public void Testing_Deserilization_Test3()
        {
            testClass = new TestedClass(NAME, HEALTH, ATTACK_LEVEL, DEFENSE_LEVEL, SPEED_LEVEL, MONEY, inventory);
            filehandler = new DataFileReaderWriter();
            shop = new Shop();
            gamedata = new GameData();
            GameData gameData2 = new GameData();
            gamedata.shop = shop;
            gamedata.player = testClass;

            filehandler.SaveGameData(gamedata, AppData.PLAYER_TEST_FILE);

            try
            {
                gameData2 = filehandler.LoadGameData(gameData2, AppData.PLAYER_TEST_FILE);
            }
            catch(Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        #endregion

        #region test LevelingUp

        /// <summary>
        /// tests that the player levels up correctly. similar to the useable item tests
        /// </summary>
        [TestMethod]
        public void TestingLevelingUp_Expecting2()
        {
            testClass = new TestedClass(NAME, HEALTH, ATTACK_LEVEL, DEFENSE_LEVEL, SPEED_LEVEL, MONEY, inventory);

            var expectedVal = 2;

            testClass.LevelUp(100);

            var actualVal = testClass.Level;

            var failMsg = String.Format("Expected {0} but got {1}", expectedVal, actualVal);

            Assert.AreEqual(expectedVal, actualVal, failMsg);
        }

        [TestMethod]
        public void TestedLevelingUp_Expecting1()
        {
            testClass = new TestedClass(NAME, HEALTH, ATTACK_LEVEL, DEFENSE_LEVEL, SPEED_LEVEL, MONEY, inventory);

            var expectedVal = 1;

            testClass.LevelUp(69);

            var actualVal = testClass.Level;

            var failMsg = String.Format("Expected {0} but got {1}", expectedVal, actualVal);

            Assert.AreEqual(expectedVal, actualVal, failMsg);
        }

        [TestMethod]
        public void TestedLevelingUp_TestingEXPReseting()
        {
            testClass = new TestedClass(NAME, HEALTH, ATTACK_LEVEL, DEFENSE_LEVEL, SPEED_LEVEL, MONEY, inventory);

            var expectedVal = 0;

            testClass.LevelUp(100);

            var actualVal = testClass.ExpPoints;

            var failMsg = String.Format("Expected {0} but got {1}", expectedVal, actualVal);

            Assert.AreEqual(expectedVal, actualVal, failMsg);
        }
        #endregion

        #region test item list class

       
       
        
        
        /// <summary>
        /// trys to catch an error with adding the item to the list
        /// </summary>
        [TestMethod]
        public void TestItemList_Adding_Item()
        {
            
            useable = new HealthItem(NAME, MONEY, 23, HEALTH);
            testClass = new TestedClass(NAME, HEALTH, ATTACK_LEVEL, DEFENSE_LEVEL, SPEED_LEVEL, MONEY, inventory);

            inventory = new ItemList();
            try
            {
                testClass.inven.AddItem(useable);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// trys to catch an error with adding a different type of item to the list
        /// </summary>
        [TestMethod]
        public void TestItemList_Adding_Item2()
        {
            useable = new SpeedItem(NAME, MONEY, SPEED_LEVEL, 10);
            testClass = new TestedClass(NAME, HEALTH, ATTACK_LEVEL, DEFENSE_LEVEL, SPEED_LEVEL, MONEY, inventory);
            inventory = new ItemList();

            try
            {
                testClass.inven.AddItem(useable);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// checks to see if the addItem function returns a value of true, if it does, the item was successfully added to the list as expected
        /// </summary>
        [TestMethod]
        public void TestedItemList_Expecting_True()
        {
            useable = new Weapon(NAME, ATTACK_LEVEL, MONEY);
            testClass = new TestedClass(NAME, HEALTH, ATTACK_LEVEL, DEFENSE_LEVEL, SPEED_LEVEL, MONEY, inventory);
            inventory = new ItemList();

            var expectedValue = true;

            var actualValue = testClass.inven.AddItem(useable);

            var failMsg = String.Format("Expecting {0} but got {1}", expectedValue, actualValue);

            Assert.AreEqual(expectedValue, actualValue, failMsg);
        }

        /// <summary>
        /// similar to the previous test, however this time the expectedValue is false. this is because the addItem function should 
        /// not add an item to the list if the item is null. if the actualValue return false, then the test was successfull
        /// </summary>
        [TestMethod]
        public void TestItemList_Expecting_False()
        {
            useable = null;
            testClass = new TestedClass(NAME, HEALTH, ATTACK_LEVEL, DEFENSE_LEVEL, SPEED_LEVEL, MONEY, inventory);
            inventory = new ItemList();

            var expectedValue = false;
            var actualValue = testClass.inven.AddItem(useable);

            var failMsg = String.Format("Expecting {0} but got {1}", expectedValue, actualValue);

            Assert.AreEqual(expectedValue, actualValue, failMsg);
        }

        /// <summary>
        /// trys to catch an error with removing an item from the list
        /// </summary>
        [TestMethod]
        public void TestRemovingItem_FromItemList()
        {
            testClass = new TestedClass(NAME, HEALTH, ATTACK_LEVEL, DEFENSE_LEVEL, SPEED_LEVEL, MONEY, inventory);
            useable = new HealthItem(NAME, MONEY, 5, HEALTH);

            inventory = new ItemList();

            testClass.inven.AddItem(useable);

            try
            {
                testClass.inven.RemoveItem(useable);
            }
            catch(Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// similar to the previous test, however this time tries to remove a different type of item
        /// </summary>
        [TestMethod]
        public void TestRemovingItem_FromItemList2()
        {
            testClass = new TestedClass(NAME, HEALTH, ATTACK_LEVEL, DEFENSE_LEVEL, SPEED_LEVEL, MONEY, inventory);
            useable = new LevelUpItem(NAME, MONEY, 1);
            inventory = new ItemList();

            testClass.inven.AddItem(useable);

            try
            {
                testClass.inven.RemoveItem(useable);
            }
            catch(Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// the removeItem function returns a bool value depending on if removal was successful. here we expect it to, so if actualValue returns
        /// a value of true,  then the test was successfull
        /// </summary>
        [TestMethod]
        public void TestRemoveingItem_Expecting_True()
        {
            useable = new Weapon(NAME, ATTACK_LEVEL, MONEY);
            inventory = new ItemList();

            inventory.AddItem(useable);

            var expectedValue = true;
            var actualValue = inventory.RemoveItem(useable);

            var failMsg = String.Format("Expecting {0} but got {1}", expectedValue, actualValue);

            Assert.AreEqual(expectedValue, actualValue, failMsg);

        }

        /// <summary>
        /// similar to the previous test but this time we attempt to remove a null item, and we expect the function to return a value of
        /// false. if it does, the test was successfull.
        /// </summary>
        [TestMethod]
        public void TestRemoveItem_Expecting_False()
        {
            useable = new Weapon(NAME, ATTACK_LEVEL, MONEY);

            inventory = new ItemList();

            inventory.AddItem(useable);

            useable = null;

            var expectedValue = false;
            var actualValue = inventory.RemoveItem(useable);

            var failMsg = String.Format("Expecting {0} but got {1}", expectedValue, actualValue);

            Assert.AreEqual(expectedValue, actualValue, failMsg);
        }
        #endregion
    }
}
