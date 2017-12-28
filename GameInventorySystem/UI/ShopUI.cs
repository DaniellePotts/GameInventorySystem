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
    /// UI for the shop. this form contains all of the relevant controls for the shop system. including buying and selling.
    /// </summary>
    public partial class ShopUI : Form
    {

        public ShopUI()
        {
            InitializeComponent();
        }

        //form for the shop. this form displays the shops items. if there is a player loaded there's also a shop loaded, if not, then a new shop is created. everytime the shop runs out of stock, new items
        //are generated (this is because there is no other way for the shop to actually aquire items other then through action of the player selling, so it should constantly generate stuff if the list is
        //empty) realistically there could be adminstration side. the store allows the player to buy an sell items. 

        #region object variables
        public static Shop store;
        private ItemList shopItems;
        #endregion

        #region form events
        /// <summary>
        /// this will create a new shop if there isn't already one (if there is already one, then the player has loaded in a file) also, if the stores shopitem list is empty, it
        /// will generate a new array of items from the GenerateData function in the Shop class. this way, the shop will never be empty. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Shop_Load(object sender, EventArgs e)
        {
            
          //if the store is null then create a new one (if it's not then the player has chose to load the data)
            if(store == null)
            {
                shopItems = new ItemList();
                store = new Shop(shopItems);
                store.GenerateData(store.shopItems);
            }
             else if (store.shopItems.GetInventoryCount() <= 0 ) //so the shop can never be empty :)
            {
                 store.GenerateData(store.shopItems);
            }
           
            //display information
            DisplayShopItems(store);
            DisplayShopInformation(store);

            
        } 
        
        private void ShopUI_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        #endregion

        #region user defined controls

        /// <summary>
        /// display the shop inventory
        /// </summary>
        /// <param name="s"></param>
        public void DisplayShopItems(Shop s)
        {
            lstShop.Items.Clear();

            //populate list box with shopitems
            for (int i = 0; i < s.shopItems.GetInventoryCount(); i++)
            {
                lstShop.Items.Add(s.shopItems[i]);
            }
        }

        /// <summary>
        /// displays the shop item information i.e the price.
        /// </summary>
        /// <param name="s"></param>
        public void DisplayShopInformation(Shop s)
        {
            IUseableItem item = (IUseableItem)lstShop.SelectedItem;
            //display shops money 
            lblMoney.Text = s.Money.ToString("C");

            if (item != null)
            {
                lblPrice.Text = item.Price.ToString("C");
            }

        }

        /// <summary>
        /// lets the player buy an item if they have enough money. returns the item to the mainUI if they player has enough money. if not, then it throws and exception and returns
        /// a null value
        /// </summary>
        /// <returns></returns>
        public IUseableItem BuyItem()
        {
           
                IUseableItem item = (IUseableItem)lstShop.SelectedItem;
            
                
                if (ReferenceEquals(null, item)) {
                    MessageBox.Show("No item selected");
                    return null;
                }
                else
                {
                    
                        try
                        {
                            store.SellItem(MainUIFrm.player1, item);
                        }
                        catch (NotEnoughMoneyException ne)
                        {
                            MessageBox.Show(ne.Message);
                            return null;
                        }
                    
                   
                }
                return item;
        }
       
       /// <summary>
       /// if the width of the form is greater then 500 then the user has chosen to sell something. when this happens, a second list box will be populated containing the users 
       /// inventory items.
       /// </summary>
       /// <param name="p"></param>
        public void DisplayPlayersInventory(Player p)
        {
            //populate list box with players inventory items
            lstSell.Items.Clear();
            if (this.Width > 500)
            {
                for (int i = 0; i < p.inven.GetInventoryCount(); i++)
                {
                    lstSell.Items.Add(p.inven[i]);
                }
            }
        }

      /// <summary>
      /// similar to the inventory function, if the form width is greater then 500 then the player has chosen to sell something. if this is the case, then we want to
      /// display the players information. this for now, only includes how much money they have. but can change as the system is upgrade/updated
      /// </summary>
      /// <param name="p"></param>
        public void DisplayPlayersInformation(Player p)
        {
            if (this.Width > 500)
            {
                lblPlayerMoney.Text = p.Money.ToString("C");
            }

            if((IUseableItem)lstSell.SelectedItem != null)
            {
                IUseableItem item = (IUseableItem)lstSell.SelectedItem;
                lblItemPrice.Text = item.Price.ToString("C");
            }
           
        }

      
        #endregion

        #region list events
        //display the shops information based in the index selected.
        private void lstShop_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayShopInformation(store);
        }

        //display players information depending on which item is selected
        private void lstSell_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayPlayersInformation(MainUIFrm.player1);
        }  
        #endregion

        #region buttons

        private void btnBuy_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// goes back to the mainUI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            //go back to main UI
            this.Hide();           
        }

        /// <summary>
        /// displays more information about the item the player has selected.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnViewItem_Click(object sender, EventArgs e)
        {
            //view more info about the item selected
            if (lstShop.SelectedIndex > -1)
            {
                IUseableItem item = (IUseableItem)lstShop.SelectedItem;
                MessageBox.Show(item.Display());
            }
            else
            {
                MessageBox.Show(AppData.NULL_ITEM_SELECTED);
            }
        }

        /// <summary>
        /// this is btnExpandForm, this expands the forms width to display more functionality. it renders the grpBox controls as unuseable, and makes the shop list unable to
        /// to be selected. it also displays the players inventory and details.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //this is to allow the user to sell an item. 
            //increase the form width (to display new form objects with new controls)
            //display players inventory and infromation. dont let user interact with shop controls, only selling controls
            this.Width = 550;
            DisplayPlayersInventory(MainUIFrm.player1);
            DisplayPlayersInformation(MainUIFrm.player1);
            grpControls.Enabled = false;
            lstShop.Enabled = false;
        
        }

        /// <summary>
        /// this lets the shop buy an item from the player, if the shop has enough money, if it doesn't then it throws an exception. also, if the shop has too many items in stock
        /// it will throw an exception. it then updates all relevant information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSell_Click(object sender, EventArgs e)
        {
            if (lstSell.SelectedIndex > -1)
            {
                try
                {
                    //let the shop buy the item off of the player
                    DialogResult dr = MessageBox.Show("Sell " + (IUseableItem)lstSell.SelectedItem + "?", "Sell Item", MessageBoxButtons.YesNo);

                    if (dr == DialogResult.Yes)
                    {
                        store.BuyItem(MainUIFrm.player1, (IUseableItem)lstSell.SelectedItem);

                        //update all relevant information
                        DisplayPlayersInventory(MainUIFrm.player1);
                        DisplayPlayersInformation(MainUIFrm.player1);
                        DisplayShopItems(store);
                        DisplayShopInformation(store);
                    }

                }
                catch (NotEnoughMoneyException ne)
                {
                    //if the shop doesnt have enough money, throw exception
                    MessageBox.Show(ne.Message);
                }
                catch (TooManyItemsException te)
                {
                    //if the shop has too many items, throw exception
                    MessageBox.Show(te.Message);
                }
            }
            else
            {
                MessageBox.Show(AppData.NULL_ITEM_SELECTED);
            }
        }

        /// <summary>
        /// this button returns the player to the normal shopUI. it drops the width of the form back down and enables all functionality that is relevant.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReturn_Click(object sender, EventArgs e)
        {
            //return to regular shop. 
            this.Width = 298;
            grpControls.Enabled = true;
            lstShop.Enabled = true;
        }

        /// <summary>
        /// performs the same functionality as btnReturn but also closes the shopUI and returns the player back to the main UI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            //return to regular shop. 
            this.Width = 298;
            grpControls.Enabled = true;
            lstShop.Enabled = true;
            this.Close();
        }
        #endregion
       
    }
}



