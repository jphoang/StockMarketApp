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
    public partial class StockSecuritiesExchange_Client : Form
    {
        private RealTimeData _rdt; // hold real time data

        //constructor for client
        public StockSecuritiesExchange_Client()
        {
            _rdt = new RealTimeData();
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade); 
        }

        private void horizontalTileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal); 
        }

        private void verticalTileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void stockStateSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockStateSummary summaryForm = new StockStateSummary(_rdt);
            _rdt.Register(summaryForm);
            // Set the parent form of the child window.
            summaryForm.MdiParent = this;
            // Display the new form.
            summaryForm.Show();
            _rdt.Notify();
            
        }

        private void bidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlaceBidOrderForm bidForm = new PlaceBidOrderForm(_rdt);
            // Set the parent form of the child window.
            bidForm.MdiParent = this;
            //Populate combo box
            foreach (Company c in _rdt.CompanyList)
            {
                bidForm.getShareComboBox().Items.Add(c.CompanyName);
            }
            // Display the new form.
            bidForm.Show();
        }

        private void sellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlaceSellOrderForm sellForm = new PlaceSellOrderForm(_rdt);
            // Set the parent form of the child window.
            sellForm.MdiParent = this;
            //Populate combo box
            foreach (Company c in _rdt.CompanyList)
            {
                sellForm.getShareComboBox().Items.Add(c.CompanyName);
            }
            // Display the new form.
            sellForm.Show(); 
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Stop the trading and close the application
            this.Close();
        }

        private void stopTradingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Exit the application
            this.Close();
        }

        private void beginTradingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Configure the view
            mToolStripMenuItem.Text = "Market <<Open>>";
            beginTradingToolStripMenuItem.Enabled = false;
            stopTradingToolStripMenuItem.Enabled = true;
            watchToolStripMenuItem.Visible = true;
            ordersToolStripMenuItem.Visible = true;
            
            foreach(Company c in _rdt.CompanyList)
            {
                ToolStripMenuItem item = new ToolStripMenuItem();
                item.Text = c.CompanyName;
                item.Name = c.CompanyName+"MarketByOrderTab";
                item.Click += new EventHandler(OnClickOrderTab);
                marketByOrderToolStripMenuItem.DropDownItems.Add(item);
            }

            foreach (Company c in _rdt.CompanyList)
            {
                ToolStripMenuItem item = new ToolStripMenuItem();
                item.Text = c.CompanyName;
                item.Name = c.CompanyName + "MarketByPriceTab";
                item.Click += new EventHandler(OnClickPriceTab);
                marketByPriceToolStripMenuItem.DropDownItems.Add(item);
            }
        }
        public void OnClickPriceTab(object sender, EventArgs ee)
        {
            Company company = new Company();
            foreach (Company c in _rdt.CompanyList) 
            {
                if (c.CompanyName == sender.ToString()) 
                {
                    company = c;
                }
            }
            MarketByPrice priceForm = new MarketByPrice(_rdt,company);
            _rdt.Register(priceForm);
            // Set the parent form of the child window.
            priceForm.MdiParent = this;
            // Display the new form.
            priceForm.Show();
            priceForm.Text = priceForm.Text.ToString() + " (" + sender.ToString() + ")";
            _rdt.Notify();

        }
        public void OnClickOrderTab(object sender, EventArgs ee)
        {
            Company company = new Company();
            foreach(Company c in _rdt.CompanyList)
            {
                if (c.CompanyName == sender.ToString()) 
                {
                    company = c;
                }
            }
            MarketByOrder orderForm = new MarketByOrder(company, _rdt);
            _rdt.Register(orderForm);
            // Set the parent form of the child window.
            orderForm.MdiParent = this;
            // Display the new form.
            orderForm.Show();
            orderForm.Text = orderForm.Text.ToString() + " (" + sender.ToString() + ")";
            _rdt.Notify();

        }

        private void marketByOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
