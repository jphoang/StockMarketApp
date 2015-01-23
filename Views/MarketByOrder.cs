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
    public partial class MarketByOrder : Form, IStockMarketDisplay
    {
        private Company company; //associated company
        private RealTimeData _rdt; //holds real time data

        //constructor
        public MarketByOrder(Company c, RealTimeData rdt)
        {
            _rdt = rdt;
            company = c;
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(formClosed); //add event handler for closing form (unregister)
        }

        //Event handler for closing form
        void formClosed(object sender, FormClosedEventArgs e)
        {
            _rdt.unRegister(this);
        }

        //update view function
        void IStockMarketDisplay.Update(RealTimeData s)
        {

            //Prepare the grid to be populated
            this.dataGridView1.Rows.Clear();
            int buyCount = 0;
            int sellCount = 0;
            int currentBuyCount = 0;
            int currentSellCount = 0;
            int maxRows = 0;

            //Find out the number of rows to add
            if (company.getBuyOrderList().Count > 10 || company.getSellOrderList().Count > 10) 
            {
                maxRows = 10;
            }
            else if (company.getBuyOrderList().Count >= company.getSellOrderList().Count)
            {
                maxRows = company.getBuyOrderList().Count;
            }
            else
            {
                maxRows = company.getSellOrderList().Count;

            }

            //Add the empty rows
            for (int i = 0; i < maxRows; i++) {
                DataGridViewRow row = new DataGridViewRow();
                this.dataGridView1.Rows.Add(row);
            }

            //Populate the Buy order rows
            foreach (BuyOrder o in company.getBuyOrderList().OrderByDescending(x=>x.getPrice()).ThenByDescending(x=>x.getDate()))
            {
                if (currentBuyCount == 10) break;

                this.dataGridView1.Rows[buyCount].Cells[0].Value = o.getSize();
                this.dataGridView1.Rows[buyCount].Cells[1].Value = o.getPrice();
                buyCount++;

                currentBuyCount++;
            }
            //Populate the Sell order rows
            foreach (SellOrder o in company.getSellOrderList().OrderBy(x => x.getPrice()).ThenByDescending(x => x.getDate()))
            {
                if (currentSellCount == 10) break;

                this.dataGridView1.Rows[sellCount].Cells[2].Value = o.getSize();
                this.dataGridView1.Rows[sellCount].Cells[3].Value = o.getPrice();
                sellCount++;

                currentSellCount++;
            }
        }     
    }
}
