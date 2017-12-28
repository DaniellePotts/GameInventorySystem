namespace GameInventorySystem
{
    partial class ShopUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstShop = new System.Windows.Forms.ListBox();
            this.btnBuy = new System.Windows.Forms.Button();
            this.btnViewItem = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.btnExpandForm = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lstSell = new System.Windows.Forms.ListBox();
            this.btnSell = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.grpControls = new System.Windows.Forms.GroupBox();
            this.lblPlayerMoney = new System.Windows.Forms.Label();
            this.lblItemPrice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstShop
            // 
            this.lstShop.FormattingEnabled = true;
            this.lstShop.Location = new System.Drawing.Point(12, 33);
            this.lstShop.Name = "lstShop";
            this.lstShop.Size = new System.Drawing.Size(260, 199);
            this.lstShop.TabIndex = 0;
            this.lstShop.SelectedIndexChanged += new System.EventHandler(this.lstShop_SelectedIndexChanged);
            // 
            // btnBuy
            // 
            this.btnBuy.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnBuy.Location = new System.Drawing.Point(91, 12);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(64, 23);
            this.btnBuy.TabIndex = 1;
            this.btnBuy.TabStop = false;
            this.btnBuy.Text = "&Buy";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // btnViewItem
            // 
            this.btnViewItem.Location = new System.Drawing.Point(16, 12);
            this.btnViewItem.Name = "btnViewItem";
            this.btnViewItem.Size = new System.Drawing.Size(69, 23);
            this.btnViewItem.TabIndex = 2;
            this.btnViewItem.Text = "View Item Details";
            this.btnViewItem.UseVisualStyleBackColor = true;
            this.btnViewItem.Click += new System.EventHandler(this.btnViewItem_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPrice.Location = new System.Drawing.Point(192, 235);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(80, 23);
            this.lblPrice.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cost:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Shop";
            // 
            // lblMoney
            // 
            this.lblMoney.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMoney.Location = new System.Drawing.Point(203, 4);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(66, 23);
            this.lblMoney.TabIndex = 6;
            // 
            // btnExpandForm
            // 
            this.btnExpandForm.Location = new System.Drawing.Point(161, 12);
            this.btnExpandForm.Name = "btnExpandForm";
            this.btnExpandForm.Size = new System.Drawing.Size(62, 23);
            this.btnExpandForm.TabIndex = 7;
            this.btnExpandForm.Text = "Sell Item";
            this.btnExpandForm.UseVisualStyleBackColor = true;
            this.btnExpandForm.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBack
            // 
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Ignore;
            this.btnBack.Location = new System.Drawing.Point(76, 38);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(98, 23);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back to MainUI";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lstSell
            // 
            this.lstSell.FormattingEnabled = true;
            this.lstSell.Location = new System.Drawing.Point(322, 33);
            this.lstSell.Name = "lstSell";
            this.lstSell.Size = new System.Drawing.Size(202, 199);
            this.lstSell.TabIndex = 9;
            this.lstSell.SelectedIndexChanged += new System.EventHandler(this.lstSell_SelectedIndexChanged);
            // 
            // btnSell
            // 
            this.btnSell.Location = new System.Drawing.Point(322, 246);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(75, 23);
            this.btnSell.TabIndex = 10;
            this.btnSell.Text = "&Sell Item";
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(449, 246);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 11;
            this.btnReturn.Text = "&Buy Item";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // grpControls
            // 
            this.grpControls.Controls.Add(this.btnBuy);
            this.grpControls.Controls.Add(this.btnViewItem);
            this.grpControls.Controls.Add(this.btnBack);
            this.grpControls.Controls.Add(this.btnExpandForm);
            this.grpControls.Location = new System.Drawing.Point(12, 261);
            this.grpControls.Name = "grpControls";
            this.grpControls.Size = new System.Drawing.Size(244, 66);
            this.grpControls.TabIndex = 12;
            this.grpControls.TabStop = false;
            // 
            // lblPlayerMoney
            // 
            this.lblPlayerMoney.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPlayerMoney.Location = new System.Drawing.Point(322, 4);
            this.lblPlayerMoney.Name = "lblPlayerMoney";
            this.lblPlayerMoney.Size = new System.Drawing.Size(66, 23);
            this.lblPlayerMoney.TabIndex = 13;
            // 
            // lblItemPrice
            // 
            this.lblItemPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblItemPrice.Location = new System.Drawing.Point(424, 299);
            this.lblItemPrice.Name = "lblItemPrice";
            this.lblItemPrice.Size = new System.Drawing.Size(100, 23);
            this.lblItemPrice.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Selling Price:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(424, 273);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 23);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "&Back to MainUI";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ShopUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 329);
            this.ControlBox = false;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblItemPrice);
            this.Controls.Add(this.lblPlayerMoney);
            this.Controls.Add(this.grpControls);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnSell);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lstSell);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstShop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShopUI";
            this.Text = "Shop";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ShopUI_FormClosing);
            this.Load += new System.EventHandler(this.Shop_Load);
            this.grpControls.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstShop;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Button btnViewItem;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Button btnExpandForm;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListBox lstSell;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.GroupBox grpControls;
        private System.Windows.Forms.Label lblPlayerMoney;
        private System.Windows.Forms.Label lblItemPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExit;
    }
}