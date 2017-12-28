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
    /// this form is the UI to allow the user to create a new player.
    /// </summary>
    public partial class CreatePlayerUI : Form
    {
        public CreatePlayerUI()
        {
            InitializeComponent();
        }

        

        private void btnCreatePlayer_Click(object sender, EventArgs e)
        {
           
        }

        /// <summary>
        /// creates a new player with the name the player gives it and return it to the mainUI to generate a new player
        /// </summary>
        /// <returns></returns>
        public Player createPlayer()
        {
            //if the text box is not empty, let the user create the player
            if (txtName.Text != "")
            {
                ItemList itemList = new ItemList();
                return new Player(txtName.Text, AppData.DEFAULT_HEALTH, AppData.DEFAULT_HEALTH, AppData.DEFAULT_DEFENSE_STAT, AppData.DEFAULT_SPEED_STAT, AppData.DEFAULT_MONEY_AMOUNT, itemList);
            }
            else
            {
                //else if it is, inform the player 
                MessageBox.Show("No data in the text box");
                return null;
            }

            
        }

        private void CreatePlayer_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// return the main UI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
