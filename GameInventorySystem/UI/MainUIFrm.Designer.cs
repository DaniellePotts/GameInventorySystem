namespace GameInventorySystem
{
    partial class MainUIFrm
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
            this.lstItems = new System.Windows.Forms.ListBox();
            this.btnShop = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnDetails = new System.Windows.Forms.Button();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.btnUseItem = new System.Windows.Forms.Button();
            this.lblBagAmount = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPlayerInfo = new System.Windows.Forms.Button();
            this.grpControls = new System.Windows.Forms.GroupBox();
            this.btnLook = new System.Windows.Forms.Button();
            this.menuFile = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUnEquip = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.useItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewItemInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equipmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.euipedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unEuipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reArrangeItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpControls.SuspendLayout();
            this.menuFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstItems
            // 
            this.lstItems.FormattingEnabled = true;
            this.lstItems.Location = new System.Drawing.Point(12, 93);
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(195, 212);
            this.lstItems.TabIndex = 0;
            // 
            // btnShop
            // 
            this.btnShop.Location = new System.Drawing.Point(16, 8);
            this.btnShop.Name = "btnShop";
            this.btnShop.Size = new System.Drawing.Size(169, 33);
            this.btnShop.TabIndex = 1;
            this.btnShop.Text = "&Shop";
            this.btnShop.UseVisualStyleBackColor = true;
            this.btnShop.Click += new System.EventHandler(this.btnShop_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(16, 81);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(169, 32);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "&Create Player";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(16, 244);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(169, 23);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "&Remove Item";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnDetails
            // 
            this.btnDetails.Location = new System.Drawing.Point(16, 215);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(169, 23);
            this.btnDetails.TabIndex = 5;
            this.btnDetails.Text = "&View Item Details";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // lblPlayer
            // 
            this.lblPlayer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPlayer.Font = new System.Drawing.Font("Minion Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.Location = new System.Drawing.Point(12, 45);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(195, 23);
            this.lblPlayer.TabIndex = 6;
            // 
            // btnUseItem
            // 
            this.btnUseItem.Location = new System.Drawing.Point(16, 186);
            this.btnUseItem.Name = "btnUseItem";
            this.btnUseItem.Size = new System.Drawing.Size(169, 23);
            this.btnUseItem.TabIndex = 7;
            this.btnUseItem.Text = "&Use Item";
            this.btnUseItem.UseVisualStyleBackColor = true;
            this.btnUseItem.Click += new System.EventHandler(this.btnUseItem_Click);
            // 
            // lblBagAmount
            // 
            this.lblBagAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBagAmount.Location = new System.Drawing.Point(186, 308);
            this.lblBagAmount.Name = "lblBagAmount";
            this.lblBagAmount.Size = new System.Drawing.Size(44, 23);
            this.lblBagAmount.TabIndex = 8;
            // 
            // lblMoney
            // 
            this.lblMoney.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMoney.Location = new System.Drawing.Point(57, 308);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(55, 23);
            this.lblMoney.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Money:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Total Items:";
            // 
            // btnPlayerInfo
            // 
            this.btnPlayerInfo.Location = new System.Drawing.Point(16, 157);
            this.btnPlayerInfo.Name = "btnPlayerInfo";
            this.btnPlayerInfo.Size = new System.Drawing.Size(169, 23);
            this.btnPlayerInfo.TabIndex = 12;
            this.btnPlayerInfo.Text = "&View Player Information";
            this.btnPlayerInfo.UseVisualStyleBackColor = true;
            this.btnPlayerInfo.Click += new System.EventHandler(this.btnPlayerInfo_Click);
            // 
            // grpControls
            // 
            this.grpControls.Controls.Add(this.btnLook);
            this.grpControls.Controls.Add(this.btnCreate);
            this.grpControls.Controls.Add(this.btnPlayerInfo);
            this.grpControls.Controls.Add(this.btnRemove);
            this.grpControls.Controls.Add(this.btnDetails);
            this.grpControls.Controls.Add(this.btnUseItem);
            this.grpControls.Controls.Add(this.btnShop);
            this.grpControls.Location = new System.Drawing.Point(249, 27);
            this.grpControls.Name = "grpControls";
            this.grpControls.Size = new System.Drawing.Size(200, 280);
            this.grpControls.TabIndex = 15;
            this.grpControls.TabStop = false;
            // 
            // btnLook
            // 
            this.btnLook.Location = new System.Drawing.Point(16, 44);
            this.btnLook.Name = "btnLook";
            this.btnLook.Size = new System.Drawing.Size(169, 31);
            this.btnLook.TabIndex = 14;
            this.btnLook.Text = "Look For Items";
            this.btnLook.UseVisualStyleBackColor = true;
            this.btnLook.Click += new System.EventHandler(this.btnLook_Click);
            // 
            // menuFile
            // 
            this.menuFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.inventoryToolStripMenuItem});
            this.menuFile.Location = new System.Drawing.Point(0, 0);
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(457, 24);
            this.menuFile.TabIndex = 16;
            this.menuFile.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // btnUnEquip
            // 
            this.btnUnEquip.Location = new System.Drawing.Point(265, 304);
            this.btnUnEquip.Name = "btnUnEquip";
            this.btnUnEquip.Size = new System.Drawing.Size(169, 23);
            this.btnUnEquip.TabIndex = 17;
            this.btnUnEquip.Text = "UnEquip";
            this.btnUnEquip.UseVisualStyleBackColor = true;
            this.btnUnEquip.Visible = false;
            this.btnUnEquip.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Player:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Inventory:";
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.useItemToolStripMenuItem,
            this.viewItemInformationToolStripMenuItem,
            this.removeItemToolStripMenuItem,
            this.equipmentToolStripMenuItem,
            this.reArrangeItemsToolStripMenuItem});
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            // 
            // useItemToolStripMenuItem
            // 
            this.useItemToolStripMenuItem.Name = "useItemToolStripMenuItem";
            this.useItemToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.useItemToolStripMenuItem.Text = "Use Item";
            // 
            // viewItemInformationToolStripMenuItem
            // 
            this.viewItemInformationToolStripMenuItem.Name = "viewItemInformationToolStripMenuItem";
            this.viewItemInformationToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.viewItemInformationToolStripMenuItem.Text = "View Item Information";
            // 
            // removeItemToolStripMenuItem
            // 
            this.removeItemToolStripMenuItem.Name = "removeItemToolStripMenuItem";
            this.removeItemToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.removeItemToolStripMenuItem.Text = "Remove Item";
            // 
            // equipmentToolStripMenuItem
            // 
            this.equipmentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.euipedToolStripMenuItem,
            this.unEuipToolStripMenuItem});
            this.equipmentToolStripMenuItem.Name = "equipmentToolStripMenuItem";
            this.equipmentToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.equipmentToolStripMenuItem.Text = "Equipment";
            // 
            // euipedToolStripMenuItem
            // 
            this.euipedToolStripMenuItem.Name = "euipedToolStripMenuItem";
            this.euipedToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.euipedToolStripMenuItem.Text = "Euiped";
            // 
            // unEuipToolStripMenuItem
            // 
            this.unEuipToolStripMenuItem.Name = "unEuipToolStripMenuItem";
            this.unEuipToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.unEuipToolStripMenuItem.Text = "UnEuip";
            // 
            // reArrangeItemsToolStripMenuItem
            // 
            this.reArrangeItemsToolStripMenuItem.Name = "reArrangeItemsToolStripMenuItem";
            this.reArrangeItemsToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.reArrangeItemsToolStripMenuItem.Text = "Re-Arrange Items";
            this.reArrangeItemsToolStripMenuItem.Click += new System.EventHandler(this.reArrangeItemsToolStripMenuItem_Click);
            // 
            // MainUIFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(457, 334);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnUnEquip);
            this.Controls.Add(this.grpControls);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.lblBagAmount);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.lstItems);
            this.Controls.Add(this.menuFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuFile;
            this.MaximizeBox = false;
            this.Name = "MainUIFrm";
            this.Text = "MainUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpControls.ResumeLayout(false);
            this.menuFile.ResumeLayout(false);
            this.menuFile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstItems;
        private System.Windows.Forms.Button btnShop;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Button btnUseItem;
        private System.Windows.Forms.Label lblBagAmount;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPlayerInfo;
        private System.Windows.Forms.GroupBox grpControls;
        private System.Windows.Forms.Button btnLook;
        private System.Windows.Forms.MenuStrip menuFile;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.Button btnUnEquip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem useItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewItemInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equipmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem euipedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unEuipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reArrangeItemsToolStripMenuItem;
    }
}

