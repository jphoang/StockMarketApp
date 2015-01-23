namespace StockMarketNamespace.Views
{
    partial class StockStateSummary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockStateSummary));
            this.StockStateSummaryGrid = new System.Windows.Forms.DataGridView();
            this.CompanyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SymbolColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpenPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastSaleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChangeNetColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChangeSymbolColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.ChangePercentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShareVolumeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.StockStateSummaryGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // StockStateSummaryGrid
            // 
            this.StockStateSummaryGrid.AllowUserToAddRows = false;
            this.StockStateSummaryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StockStateSummaryGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CompanyColumn,
            this.SymbolColumn,
            this.OpenPriceColumn,
            this.LastSaleColumn,
            this.ChangeNetColumn,
            this.ChangeSymbolColumn,
            this.ChangePercentColumn,
            this.ShareVolumeColumn});
            this.StockStateSummaryGrid.Location = new System.Drawing.Point(12, 12);
            this.StockStateSummaryGrid.Name = "StockStateSummaryGrid";
            this.StockStateSummaryGrid.Size = new System.Drawing.Size(784, 288);
            this.StockStateSummaryGrid.TabIndex = 0;
            this.StockStateSummaryGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StockStateSummaryGrid_CellContentClick);
            // 
            // CompanyColumn
            // 
            this.CompanyColumn.HeaderText = "Company";
            this.CompanyColumn.Name = "CompanyColumn";
            // 
            // SymbolColumn
            // 
            this.SymbolColumn.HeaderText = "Symbol";
            this.SymbolColumn.Name = "SymbolColumn";
            // 
            // OpenPriceColumn
            // 
            this.OpenPriceColumn.HeaderText = "Open Price";
            this.OpenPriceColumn.Name = "OpenPriceColumn";
            // 
            // LastSaleColumn
            // 
            this.LastSaleColumn.HeaderText = "Last Sale";
            this.LastSaleColumn.Name = "LastSaleColumn";
            // 
            // ChangeNetColumn
            // 
            this.ChangeNetColumn.HeaderText = "Change Net";
            this.ChangeNetColumn.Name = "ChangeNetColumn";
            // 
            // ChangeSymbolColumn
            // 
            this.ChangeSymbolColumn.HeaderText = "";
            this.ChangeSymbolColumn.Name = "ChangeSymbolColumn";
            this.ChangeSymbolColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ChangeSymbolColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ChangeSymbolColumn.Width = 40;
            // 
            // ChangePercentColumn
            // 
            this.ChangePercentColumn.HeaderText = "Change %";
            this.ChangePercentColumn.Name = "ChangePercentColumn";
            // 
            // ShareVolumeColumn
            // 
            this.ShareVolumeColumn.HeaderText = "Share Volume";
            this.ShareVolumeColumn.Name = "ShareVolumeColumn";
            // 
            // StockStateSummary
            // 
            this.ClientSize = new System.Drawing.Size(808, 305);
            this.Controls.Add(this.StockStateSummaryGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StockStateSummary";
            this.Text = "Stock State Summary";
            ((System.ComponentModel.ISupportInitialize)(this.StockStateSummaryGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company;
        private System.Windows.Forms.DataGridViewTextBoxColumn Symbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn OpenPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastSale;
        private System.Windows.Forms.DataGridView StockStateSummaryGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SymbolColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OpenPriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastSaleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChangeNetColumn;
        private System.Windows.Forms.DataGridViewImageColumn ChangeSymbolColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChangePercentColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShareVolumeColumn;
    }
}