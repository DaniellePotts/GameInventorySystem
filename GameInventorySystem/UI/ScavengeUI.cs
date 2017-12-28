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
    /// this form lets the player scavenge for an item. it is a simple form with only one method 
    /// </summary>
    public partial class ScavengeUI : Form
    {
        public ScavengeUI()
        {
            InitializeComponent();
        }

        Scavenge scavenge;

        private void btnScavenge_Click(object sender, EventArgs e)
        {
            scavenge = new Scavenge();
        }

        /// <summary>
        /// generate a random item from the scavengeforitem function inside the scavenge class
        /// </summary>
        /// <returns></returns>
        public IUseableItem ScavengeForItem()
        {
            IUseableItem item = scavenge.ScavengeForItem();

            if (item != null)
            {
                DialogResult dr = MessageBox.Show("You found " + item + " would you like to put it in your inventory?", "You found something!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    MessageBox.Show(item + " was added to your inventory", "Item Added");
                    return item;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                MessageBox.Show("You didn't find anything");
            }

            return null;
           
        }

        /// <summary>
        /// go back to the main UI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ScavengeUI_Load(object sender, EventArgs e)
        {

        }
    }
}
