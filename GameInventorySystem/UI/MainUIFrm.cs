using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameInventorySystem
{
    /// <summary>
    /// the main form where the majority of the functionality is carried out. 
    /// </summary>
    public partial class MainUIFrm : Form, IUserInterface
    {
        public MainUIFrm()
        {
            InitializeComponent();
        }

        //insantiate the player object. set it to public static so they can be accessed on the other forms. the player will always be created by the user in some way, so it
        //does not have any sort of full instance. the player data will either be loaded in or created by the user. it is not created in the code.
        public static Player player1;
        private IFileWriterReader fileHandler;

        #region form event controls
        private void Form1_Load(object sender, EventArgs e)
        {
            //create instance of fileHandler
            fileHandler = new DataFileReaderWriter();
            
           
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {



        }

        /// <summary>
        /// asks the player if they wish to save their data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (!ReferenceEquals(null, player1))
            {
                DialogResult dr = MessageBox.Show("Would you like to save your current game status?", "Save/Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    SaveData();
                }
            }
        }

        #endregion

        #region user defined functions
        /// <summary>
        /// display the players details. this includes their name, their level, how much money they have. and how many items they have in their inventory in comparison with the max amount they're allowed, this 
        /// information is in AppData/AppData.MAX_BAG_ITEMS
        /// </summary>
        /// <param name="p"></param>
        public void DisplayDetails(Player p)
        {
            if (p != null)
            {
                lblPlayer.Text = p.ToString();

                lblMoney.Text = p.Money.ToString("C");
                
                lblBagAmount.Text = player1.inven.GetInventoryCount() + "/" + AppData.MAX_BAG_ITEMS;

                if(!ReferenceEquals(p.weapon,null))
                {
                    btnUnEquip.Visible = true;
                }
            }


        }

        /// <summary>
        /// display the players inventory in a list
        /// </summary>
        /// <param name="iv"></param>
        public void DisplayInventory(ItemList iv)
        {
            lstItems.Items.Clear();
            if (iv != null)
            {
                for (int i = 0; i < iv.GetInventoryCount(); i++)
                {
                    lstItems.Items.Add(iv[i]);
                }
            }
        }

        /// <summary>
        /// load the users data, this function loads both the shop and the player data from the GameData object
        /// </summary>
        public void LoadData()
        {
            try
            {


                GameData gameData = new GameData();

                gameData = fileHandler.LoadGameData(gameData, AppData.GAME_DATA);


                ShopUI.store = gameData.shop;
                player1 = gameData.player;

               

                DisplayDetails(player1);
                DisplayInventory(player1.inven);

                MessageBox.Show("Game data has been successfully loaded");

            }
            catch (FileNotLoadedProperlyException file)
            {
                MessageBox.Show(file.Message);
            }

        }

        /// <summary>
        /// save the gamedata. create a new instance of GameData, assign the appriopriate values to it's variables through a method and then
        /// save the gamedata object
        /// </summary>
        public void SaveData()
        {
            GameData gameData = new GameData();

            gameData.SetData(player1, ShopUI.store);

            fileHandler.SaveGameData(gameData, AppData.GAME_DATA);

            MessageBox.Show("Game data was successfully saved");
        }

        #endregion

        #region button_controls

        /// <summary>
        /// the shop button opens up the shop form if there is a player (if there is no player, there is no way they can store items as the inventory is part of the player class). if the shop form returns
        /// a dialog result of "OK" then the system will add the item the player has bought to their inventory list and then updates the appropriate information. it holds a try and catch to catch an exception
        /// for the player trying to add more then AppData.MAX_BAG_ITEMS to their inventory.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShop_Click(object sender, EventArgs e)
        {
            ShopUI shopFrm = new ShopUI();

            if (player1 == null)
            {
                MessageBox.Show(AppData.NULL_PLAYER_MSG);
            }
            else if (shopFrm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    player1.inven.AddItem(shopFrm.BuyItem());
                    DisplayInventory(player1.inven);
                    DisplayDetails(player1);
                }
                catch (TooManyItemsException te)
                {
                    //if the player has too many items in their inventory, throw exception
                    MessageBox.Show(te.Message);
                }

            }
            else
            {
                //if the user has chosen to back out of the shop without buying anything if we reach this stage
                DisplayDetails(player1);
                DisplayInventory(player1.inven);
            }

        }




        /// <summary>
        /// allows the player to remove
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemove_Click(object sender, EventArgs e)
        {
            IUseableItem item = (IUseableItem)lstItems.SelectedItem;

            //if the item is null, or not selected, inform the user
            if (ReferenceEquals(null, item))
            {
                MessageBox.Show(AppData.NULL_ITEM_SELECTED);
            }
            else
            {
                DialogResult dr = MessageBox.Show("Are you sure?", "Remove Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    //else, remove the item and update form objects with new information
                    player1.inven.RemoveItem(item);
                    DisplayDetails(player1);
                    DisplayInventory(player1.inven);
                }
            }
        }


        /// <summary>
        /// shows more information about the selected item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDetails_Click(object sender, EventArgs e)
        {
            IUseableItem show = (IUseableItem)lstItems.SelectedItem;

            //displays more info about the item selected.
            if (show == null)
            {
                MessageBox.Show(AppData.NULL_ITEM_SELECTED);
            }
            else
            {
                MessageBox.Show(show.Display());
            }
        }


        /// <summary>
        /// opens up the create player form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreate_Click(object sender, EventArgs e)
        {
            //if a player already exists, dont let them create a player, if it doesnt, and the createFrm returns a dialogresult value of OK, then create
            //the player and update form objects
            CreatePlayerUI createFrm = new CreatePlayerUI();
            if (player1 != null)
            {
                MessageBox.Show("A player already exists");
            }
            else if (createFrm.ShowDialog() == DialogResult.OK)
            {
                player1 = createFrm.createPlayer();
                if (player1 != null)
                {
                    DisplayDetails(player1);
                    DisplayInventory(player1.inven);
                }
            }
        }


        /// <summary>
        /// lets the player use the selected item. it will throw an exception if the players level is too high. information for this is in AppData/AppData.MAX_LEVEL
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUseItem_Click(object sender, EventArgs e)
        {
            //check the user has selected something, else inform the player of this
            if (lstItems.SelectedIndex > -1)
            {
                try
                {
                    IUseableItem item = (IUseableItem)lstItems.SelectedItem;

                    //if so, let them use it, and update form objects
                    item.useItem(player1);
                    DisplayInventory(player1.inven);
                    DisplayDetails(player1);
                    if (item is Weapon)
                    {
                        btnUnEquip.Visible = true;
                    }
                    //display message box information the player of their updated stats
                    MessageBox.Show("Stat Increased " + Environment.NewLine + player1.Display(), "Stats Increased!");
                }
                catch (TooHighLevelException th)
                {
                    //if the item is a level up item, and the player is already level 50, throw exception
                    MessageBox.Show(th.Message);
                }
                catch(EquipWeaponException equipExc)
                {
                    MessageBox.Show(equipExc.Message);
                }
            }
            else
            {
                MessageBox.Show(AppData.NULL_ITEM_SELECTED);
            }
        }

        /// <summary>
        /// displays more information about the player. i.e their stats
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlayerInfo_Click(object sender, EventArgs e)
        {
            //check something is selected, if not inform the player, if so, display message box that displays all their information (including stats etc)
            if (player1 != null)
            {
                MessageBox.Show(player1.Display(), "Player Information");
                
                
                    DisplayInventory(player1.inven);
                    DisplayDetails(player1);
                
            }
            else
            {
                MessageBox.Show(AppData.NULL_PLAYER_MSG);
            }
        }

        /// <summary>
        /// opens up the scavenge form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLook_Click(object sender, EventArgs e)
        {
            ScavengeUI scavengeFrm = new ScavengeUI();
            if (player1 == null)
            {
                MessageBox.Show(AppData.NULL_PLAYER_MSG);
            }
            else
            {
                if (scavengeFrm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        player1.inven.AddItem(scavengeFrm.ScavengeForItem());
                        DisplayDetails(player1);
                        DisplayInventory(player1.inven);
                    }
                    catch (TooManyItemsException tooMany)
                    {
                        MessageBox.Show(tooMany.Message);
                    }
                }
            }
        }

  /// <summary>
        /// this is the unequip button. it only appears if the player has an item equipped.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Unequip " + player1.weapon + "?", "UnEquip", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                player1.UnEquipWeapon(player1.weapon);
                btnUnEquip.Visible = false;
                DisplayDetails(player1);
                DisplayInventory(player1.inven);
            }
        }
        #endregion

        #region menu strips

        /// <summary>
        /// lets the player save their data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!ReferenceEquals(null, player1))
            {
                DialogResult dr = MessageBox.Show("Would you like to save your current game status?", "Save/Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    SaveData();
                }
            }
            else
            {
                MessageBox.Show("There is no data to save");
            }
        }

        /// <summary>
        /// lets the player load data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (player1 != null)
            {
                DialogResult dr = MessageBox.Show("There is already a player. Continue with loading?", "Load", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    LoadData();

                }
            }
            else
            {
                DialogResult dr = MessageBox.Show("Load data from a file?", "Load", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    LoadData();
                }
            }
        }

        #endregion

        private void reArrangeItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReArrangeItemsUI reArrangeFrm = new ReArrangeItemsUI();

            reArrangeFrm.ShowDialog();
        }

      


    }
}
