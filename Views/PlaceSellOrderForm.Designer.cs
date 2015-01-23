namespace StockMarketNamespace
{
    partial class PlaceSellOrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlaceSellOrderForm));
            this.shareComboBox = new System.Windows.Forms.ComboBox();
            this.sellPriceLabel = new System.Windows.Forms.Label();
            this.numberOfSharesLabel = new System.Windows.Forms.Label();
            this.selectShareLabel = new System.Windows.Forms.Label();
            this.sellPriceText = new System.Windows.Forms.TextBox();
            this.numberOfSharesText = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // shareComboBox
            // 
            this.shareComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.shareComboBox.FormattingEnabled = true;
            this.shareComboBox.Location = new System.Drawing.Point(188, 57);
            this.shareComboBox.Name = "shareComboBox";
            this.shareComboBox.Size = new System.Drawing.Size(169, 21);
            this.shareComboBox.TabIndex = 15;
            // 
            // sellPriceLabel
            // 
            this.sellPriceLabel.AutoSize = true;
            this.sellPriceLabel.Location = new System.Drawing.Point(66, 165);
            this.sellPriceLabel.Name = "sellPriceLabel";
            this.sellPriceLabel.Size = new System.Drawing.Size(54, 13);
            this.sellPriceLabel.TabIndex = 14;
            this.sellPriceLabel.Text = "Sell Price:";
            // 
            // numberOfSharesLabel
            // 
            this.numberOfSharesLabel.AutoSize = true;
            this.numberOfSharesLabel.Location = new System.Drawing.Point(66, 135);
            this.numberOfSharesLabel.Name = "numberOfSharesLabel";
            this.numberOfSharesLabel.Size = new System.Drawing.Size(95, 13);
            this.numberOfSharesLabel.TabIndex = 13;
            this.numberOfSharesLabel.Text = "Number of Shares:";
            // 
            // selectShareLabel
            // 
            this.selectShareLabel.AutoSize = true;
            this.selectShareLabel.Location = new System.Drawing.Point(66, 57);
            this.selectShareLabel.Name = "selectShareLabel";
            this.selectShareLabel.Size = new System.Drawing.Size(100, 13);
            this.selectShareLabel.TabIndex = 12;
            this.selectShareLabel.Text = "Select Share to Sell";
            // 
            // sellPriceText
            // 
            this.sellPriceText.Location = new System.Drawing.Point(188, 165);
            this.sellPriceText.Name = "sellPriceText";
            this.sellPriceText.Size = new System.Drawing.Size(169, 20);
            this.sellPriceText.TabIndex = 11;
            // 
            // numberOfSharesText
            // 
            this.numberOfSharesText.Location = new System.Drawing.Point(188, 132);
            this.numberOfSharesText.Name = "numberOfSharesText";
            this.numberOfSharesText.Size = new System.Drawing.Size(169, 20);
            this.numberOfSharesText.TabIndex = 10;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(231, 219);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(104, 219);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 8;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // PlaceSellOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 306);
            this.Controls.Add(this.shareComboBox);
            this.Controls.Add(this.sellPriceLabel);
            this.Controls.Add(this.numberOfSharesLabel);
            this.Controls.Add(this.selectShareLabel);
            this.Controls.Add(this.sellPriceText);
            this.Controls.Add(this.numberOfSharesText);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.submitButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PlaceSellOrderForm";
            this.Text = "Place Sell Order Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox shareComboBox;
        private System.Windows.Forms.Label sellPriceLabel;
        private System.Windows.Forms.Label numberOfSharesLabel;
        private System.Windows.Forms.Label selectShareLabel;
        private System.Windows.Forms.TextBox sellPriceText;
        private System.Windows.Forms.TextBox numberOfSharesText;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button submitButton;

    }
}