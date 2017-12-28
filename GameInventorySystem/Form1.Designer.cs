namespace GameInventorySystem
{
    partial class Form1
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
            this.btnLoadData = new System.Windows.Forms.Button();
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
            this.grpControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstItems
            // 
            this.lstItems.FormattingEnabled = true;
            this.lstItems.Location = new System.Drawing.Point(25, 37);
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(195, 212);
            this.lstItems.TabIndex = 0;
            // 
            // btnShop
            // 
            this.btnShop.Location = new System.Drawing.Point(16, 8);
            this.btnShop.Name = "btnShop";
            this.btnShop.Size = new System.Drawing.Size(169, 45);
            this.btnShop.TabIndex = 1;
            this.btnShop.Text = "&Shop";
            this.btnShop.UseVisualStyleBackColor = true;
            this.btnShop.Click += new System.EventHandler(this.btnShop_Click);
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(16, 204);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(169, 23);
            this.btnLoadData.TabIndex = 2;
            this.btnLoadData.Text = "&Load Data";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(16, 233);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(169, 23);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "&Create Player";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(16, 175);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(169, 23);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "&Remove Item";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnDetails
            // 
            this.btnDetails.Location = new System.Drawing.Point(16, 146);
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
            this.lblPlayer.Location = new System.Drawing.Point(25, 9);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(145, 23);
            this.lblPlayer.TabIndex = 6;
            // 
            // btnUseItem
            // 
            this.btnUseItem.Location = new System.Drawing.Point(16, 117);
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
            this.lblBagAmount.Location = new System.Drawing.Point(176, 252);
            this.lblBagAmount.Name = "lblBagAmount";
            this.lblBagAmount.Size = new System.Drawing.Size(44, 23);
            this.lblBagAmount.TabIndex = 8;
            // 
            // lblMoney
            // 
            this.lblMoney.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMoney.Location = new System.Drawing.Point(50, 252);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(55, 23);
            this.lblMoney.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Money:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Total Items:";
            // 
            // btnPlayerInfo
            // 
            this.btnPlayerInfo.Location = new System.Drawing.Point(16, 59);
            this.btnPlayerInfo.Name = "btnPlayerInfo";
            this.btnPlayerInfo.Size = new System.Drawing.Size(169, 23);
            this.btnPlayerInfo.TabIndex = 12;
            this.btnPlayerInfo.Text = "&View Player Information";
            this.btnPlayerInfo.UseVisualStyleBackColor = true;
            this.btnPlayerInfo.Click += new System.EventHandler(this.btnPlayerInfo_Click);
            // 
            // grpControls
            // 
            this.grpControls.Controls.Add(this.btnCreate);
            this.grpControls.Controls.Add(this.btnLoadData);
            this.grpControls.Controls.Add(this.btnPlayerInfo);
            this.grpControls.Controls.Add(this.btnRemove);
            this.grpControls.Controls.Add(this.btnDetails);
            this.grpControls.Controls.Add(this.btnUseItem);
            this.grpControls.Controls.Add(this.btnShop);
            this.grpControls.Location = new System.Drawing.Point(307, 12);
            this.grpControls.Name = "grpControls";
            this.grpControls.Size = new System.Drawing.Size(200, 260);
            this.grpControls.TabIndex = 15;
            this.grpControls.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 284);
            this.Controls.Add(this.grpControls);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.lblBagAmount);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.lstItems);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpControls.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstItems;
        private System.Windows.Forms.Button btnShop;
        private System.Windows.Forms.Button btnLoadData;
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
    }
}

