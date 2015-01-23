namespace StockMarketNamespace
{
    partial class PlaceBidOrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlaceBidOrderForm));
            this.submitButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.numberOfSharesText = new System.Windows.Forms.TextBox();
            this.purchasePriceText = new System.Windows.Forms.TextBox();
            this.selectShareLabel = new System.Windows.Forms.Label();
            this.numberOfSharesLabel = new System.Windows.Forms.Label();
            this.purchasePriceLabel = new System.Windows.Forms.Label();
            this.shareComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(103, 223);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 0;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(230, 223);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // numberOfSharesText
            // 
            this.numberOfSharesText.Location = new System.Drawing.Point(187, 136);
            this.numberOfSharesText.Name = "numberOfSharesText";
            this.numberOfSharesText.Size = new System.Drawing.Size(169, 20);
            this.numberOfSharesText.TabIndex = 2;
            // 
            // purchasePriceText
            // 
            this.purchasePriceText.Location = new System.Drawing.Point(187, 169);
            this.purchasePriceText.Name = "purchasePriceText";
            this.purchasePriceText.Size = new System.Drawing.Size(169, 20);
            this.purchasePriceText.TabIndex = 3;
            // 
            // selectShareLabel
            // 
            this.selectShareLabel.AutoSize = true;
            this.selectShareLabel.Location = new System.Drawing.Point(65, 61);
            this.selectShareLabel.Name = "selectShareLabel";
            this.selectShareLabel.Size = new System.Drawing.Size(101, 13);
            this.selectShareLabel.TabIndex = 4;
            this.selectShareLabel.Text = "Select Share to Buy";
            // 
            // numberOfSharesLabel
            // 
            this.numberOfSharesLabel.AutoSize = true;
            this.numberOfSharesLabel.Location = new System.Drawing.Point(65, 139);
            this.numberOfSharesLabel.Name = "numberOfSharesLabel";
            this.numberOfSharesLabel.Size = new System.Drawing.Size(95, 13);
            this.numberOfSharesLabel.TabIndex = 5;
            this.numberOfSharesLabel.Text = "Number of Shares:";
            // 
            // purchasePriceLabel
            // 
            this.purchasePriceLabel.AutoSize = true;
            this.purchasePriceLabel.Location = new System.Drawing.Point(65, 169);
            this.purchasePriceLabel.Name = "purchasePriceLabel";
            this.purchasePriceLabel.Size = new System.Drawing.Size(82, 13);
            this.purchasePriceLabel.TabIndex = 6;
            this.purchasePriceLabel.Text = "Purchase Price:";
            // 
            // shareComboBox
            // 
            this.shareComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.shareComboBox.FormattingEnabled = true;
            this.shareComboBox.Location = new System.Drawing.Point(187, 61);
            this.shareComboBox.Name = "shareComboBox";
            this.shareComboBox.Size = new System.Drawing.Size(169, 21);
            this.shareComboBox.TabIndex = 7;
            // 
            // PlaceBidOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 310);
            this.Controls.Add(this.shareComboBox);
            this.Controls.Add(this.purchasePriceLabel);
            this.Controls.Add(this.numberOfSharesLabel);
            this.Controls.Add(this.selectShareLabel);
            this.Controls.Add(this.purchasePriceText);
            this.Controls.Add(this.numberOfSharesText);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.submitButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PlaceBidOrderForm";
            this.Text = "Place Bid Order Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox numberOfSharesText;
        private System.Windows.Forms.TextBox purchasePriceText;
        private System.Windows.Forms.Label selectShareLabel;
        private System.Windows.Forms.Label numberOfSharesLabel;
        private System.Windows.Forms.Label purchasePriceLabel;
        private System.Windows.Forms.ComboBox shareComboBox;
    }
}

