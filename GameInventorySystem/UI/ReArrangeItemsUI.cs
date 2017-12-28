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
    public partial class ReArrangeItemsUI : Form
    {
        public ReArrangeItemsUI()
        {
            InitializeComponent();
        }

        public static ItemList inventory;

        private void ReArrangeItemsUI_Load(object sender, EventArgs e)
        {
            if(ReferenceEquals(null,inventory))
            {
                inventory = MainUIFrm.player1.inven;
            }
        }

        public void PopulateList(ItemList items)
        {
            lstItems.Items.Clear();
            for(int i=0;i<items.GetInventoryCount();i++)
            {
                lstItems.Items.Add(items[i]);
            }
        }
    }
}
