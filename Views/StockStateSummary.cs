using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockMarketNamespace.Models;

namespace StockMarketNamespace.Views
{
    public partial class StockStateSummary : Form, IStockMarketDisplay
    {
        private RealTimeData _rdt;//hold real time data
     
        //constructor for stock state summary view
        public StockStateSummary(RealTimeData rdt)
        {
            _rdt = rdt;
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(formClosed);
            DataGridViewRow row1 = new DataGridViewRow();
            DataGridViewRow row2 = new DataGridViewRow();
            DataGridViewRow row3 = new DataGridViewRow();
            this.StockStateSummaryGrid.Rows.Add(row1);
            this.StockStateSummaryGrid.Rows.Add(row2);
            this.StockStateSummaryGrid.Rows.Add(row3);
        }
        //unregister form when its closed (event handler
        void formClosed(object sender, FormClosedEventArgs e)
        {
            _rdt.unRegister(this);
        }
        private void StockStateSummaryGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //update view with the companies in rdt
        void IStockMarketDisplay.Update(RealTimeData s)
        {
            int rowCount = 0;
            foreach(Models.Company company in s.CompanyList)
            {
                this.StockStateSummaryGrid.Rows[rowCount].Cells[0].Value = company.CompanyName;
                this.StockStateSummaryGrid.Rows[rowCount].Cells[1].Value = company.Symbol;
                this.StockStateSummaryGrid.Rows[rowCount].Cells[2].Value = company.OpenPrice;
                this.StockStateSummaryGrid.Rows[rowCount].Cells[3].Value = company.LastPrice;
                this.StockStateSummaryGrid.Rows[rowCount].Cells[4].Value = company.ChangeNet;
                this.StockStateSummaryGrid.Rows[rowCount].Cells[5].Value = new Bitmap(company.ChangeIcon);
                this.StockStateSummaryGrid.Rows[rowCount].Cells[6].Value = company.ChangePercent;
                this.StockStateSummaryGrid.Rows[rowCount].Cells[7].Value = company.ShareVolume;
                rowCount++;
            }
        }    
    }
}
