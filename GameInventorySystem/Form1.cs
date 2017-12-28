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
    public partial class Form1 : Form, IUserInterface
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static Player player1;
        public static ItemList inventory;
        private static IFileWriterReader fileHandler;
        

        #region form event controls
        private void Form1_Load(object sender, EventArgs e)
        {

            inventory = new ItemList();
            fileHandler = new DataFileReaderWriter();


        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {



        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Would you like to save your current Inventory items?", "Save/Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                fileHandler.SeralizeData(AppData.PLAYER_SAVE_FILE, player1);


                MessageBox.Show("Your inventory was successfully saved! :D");
            }

        }

        #endregion

        public void DisplayDetails(Player p)
        {
            if (p != null)
            {
                lblPlayer.Text = p.Name + " lvl: " + p.Level;

                lblMoney.Text = p.Money.ToString("C");
            }

            lblBagAmount.Text = player1.inven.GetInventoryCount() + "/" + AppData.MAX_BAG_ITEMS;

        }

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

        public void LoadInventoryData()
        {
            try
            {
                ISerializableObject P = new Player();
                P = fileHandler.DeserializeData(P, AppData.PLAYER_SAVE_FILE);

                player1 = (Player)P;

                ISerializableObject S = new Shop();
                S = fileHandler.DeserializeData(S, AppData.SHOP_SAVE_FILE);
                ShopUI.store = (Shop)S;

                if (player1 != null)
                {
                    DisplayInventory(player1.inven);
                    DisplayDetails(player1);
                    MessageBox.Show("Data successfully loaded");
                }

            }
            catch (FileNotLoadedProperlyException fe)
            {
                MessageBox.Show(fe.Message);
            }

        }     

       #region button_controls
        private void btnShop_Click(object sender, EventArgs e)
        {
            ShopUI shopFrm = new ShopUI();
            if(player1 == null)
            {
                MessageBox.Show("There is no player. Please create or load one first");
            }
            else  if(shopFrm.ShowDialog() == DialogResult.OK)
           {
               try
               {
                   player1.inven.AddItem(shopFrm.BuyItem());
                   DisplayInventory(player1.inven);
                   DisplayDetails(player1);
               }
                catch(TooManyItemsException te)
               {
                   MessageBox.Show(te.Message);
               }
                catch(NotEnoughMoneyException ne)
               {
                   MessageBox.Show(ne.Message);
               }
           }
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            if (player1 != null)
            {
                DialogResult dr = MessageBox.Show("There is already a player. Continue with loading?", "Load", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    LoadInventoryData();
                }
            }
            else
            {
                LoadInventoryData();
            }


        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

            IUseableItem item = (IUseableItem)lstItems.SelectedItem;

            if(ReferenceEquals(null,item))
            {
                MessageBox.Show("Nothing is selected!");
            }
            else
            {
                player1.inven.RemoveItem(item);
                DisplayDetails(player1);
                DisplayInventory(player1.inven);
            }
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            IUseableItem show = (IUseableItem)lstItems.SelectedItem;

            if (show == null)
            {
                MessageBox.Show("No item selected");
            }
            else
            {
                MessageBox.Show(show.Display());
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreatePlayer createFrm = new CreatePlayer();
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

        private void btnUseItem_Click(object sender, EventArgs e)
        {
            if (lstItems.SelectedIndex > -1)
            {
                try
                {
                    IUseableItem item = (IUseableItem)lstItems.SelectedItem;

                    item.useItem(player1);
                    player1.inven.RemoveItem(item);
                    DisplayInventory(player1.inven);
                    DisplayDetails(player1);

                    MessageBox.Show("New Stats: " + player1.Display(), "Stats Increased!");
                }
                catch(TooHighLevelException th)
                {
                    MessageBox.Show(th.Message);
                }
            }
            else
            {
                MessageBox.Show("Select an item!");
            }
        }

        private void btnPlayerInfo_Click(object sender, EventArgs e)
        {
            if (player1 != null)
            {
                MessageBox.Show(player1.Display());
            }
            else
            {
                MessageBox.Show("No player exists");
            }
        }

        #endregion

     
    }
}
