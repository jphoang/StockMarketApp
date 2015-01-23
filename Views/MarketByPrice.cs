using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
    //Market by price form
    public partial class MarketByPrice : Form, IStockMarketDisplay
    {
        private RealTimeData _rdt; //holds real time data
        private Company _company; //associated company


        //update view function
        void IStockMarketDisplay.Update(RealTimeData s)
        {
            this.dataGridView1.Rows.Clear();
            int maxRows = 0;

            HashSet<Double> buySet = new HashSet<Double>(); 
            HashSet<Double> sellSet = new HashSet<Double>();

            foreach(BuyOrder o in _company.getBuyOrderList())
            {
                buySet.Add(o.getPrice());
            }
            foreach (SellOrder o in _company.getSellOrderList())
            {
                sellSet.Add(o.getPrice());
            }
            //finds amount of rows to make
            if (buySet.Count > 10 && sellSet.Count > 10) maxRows = 10;
            else if (buySet.Count >= sellSet.Count) maxRows = buySet.Count;
            else maxRows = sellSet.Count;

            //adds rows to view
            for (int i = 0; i < maxRows; i++) 
            {
                dataGridView1.Rows.Add(new DataGridViewRow());
            }

            int currentVolume = 0;
            int currentCount = 0;
            int currentBuyCount = 0;
            int currentSellCount = 0;
            int buyCount = 0;
            int sellCount =0;

            List<BuyOrder> buyList = _company.getBuyOrderList().OrderByDescending(x=>x.getPrice()).ToList(); //sort lists
            List<SellOrder> sellList = _company.getSellOrderList().OrderBy(x => x.getPrice()).ToList();//sort lists 

            //Logic for populating views
            if (buyList.Count != 0)
            {
                currentVolume = buyList[0].getSize();
                currentCount = 1;
            }
            for (int i = 0; i < buyList.Count; i++ )
            {
                if (i == 10) break;
                if(i ==0 && buyList.Count == 1)
                {
                    this.dataGridView1.Rows[buyCount].Cells[0].Value = currentCount;
                    this.dataGridView1.Rows[buyCount].Cells[1].Value = currentVolume;
                    this.dataGridView1.Rows[buyCount].Cells[2].Value = buyList[i].getPrice();
                    buyCount++;
                    currentBuyCount++;
                    currentVolume = 0;
                    currentCount = 0;
                    break;
                }
                else if (i == 0)
                {
                    continue;
                }

                if (buyList[i].getPrice() != buyList[i - 1].getPrice())
                {
                    this.dataGridView1.Rows[buyCount].Cells[0].Value = currentCount;
                    this.dataGridView1.Rows[buyCount].Cells[1].Value = currentVolume;
                    this.dataGridView1.Rows[buyCount].Cells[2].Value = buyList[i - 1].getPrice();
                    buyCount++;
                    currentVolume = buyList[i].getSize();
                    currentCount = 1;
                    currentBuyCount++;
                }
                else 
                {
                    currentCount++;
                    currentVolume = currentVolume + buyList[i].getSize();
                }
                if (i == buyList.Count - 1)
                {
                    this.dataGridView1.Rows[buyCount].Cells[0].Value = currentCount;
                    this.dataGridView1.Rows[buyCount].Cells[1].Value = currentVolume;
                    this.dataGridView1.Rows[buyCount].Cells[2].Value = buyList[i].getPrice();
                    buyCount++;
                    currentBuyCount++;
                    currentVolume = 0;
                    currentCount = 0;
                }
            }
            if (sellList.Count != 0)
            {
                currentVolume = sellList[0].getSize();
                currentCount = 1;
            }
            for (int i = 0; i < sellList.Count; i++)
            {
                if (i == 10) break;
                if (i == 0 && sellList.Count == 1)
                {
                    this.dataGridView1.Rows[sellCount].Cells[5].Value = currentCount;
                    this.dataGridView1.Rows[sellCount].Cells[4].Value = currentVolume;
                    this.dataGridView1.Rows[sellCount].Cells[3].Value = sellList[i].getPrice();
                    sellCount++;
                    currentSellCount++;
                    currentVolume = 0;
                    currentCount = 0;
                    break;
                }
                else if(i == 0)
                {
                    continue;
                }

                if (sellList[i].getPrice() != sellList[i - 1].getPrice())
                {
                    this.dataGridView1.Rows[sellCount].Cells[5].Value = currentCount;
                    this.dataGridView1.Rows[sellCount].Cells[4].Value = currentVolume;
                    this.dataGridView1.Rows[sellCount].Cells[3].Value = sellList[i - 1].getPrice();
                    sellCount++;
                    currentVolume = sellList[i].getSize();
                    currentCount = 1;
                    currentSellCount++;
                }
                else
                {
                    currentCount++;
                    currentVolume = currentVolume + sellList[i].getSize();
                }
                if (i == sellList.Count - 1)
                {
                    this.dataGridView1.Rows[sellCount].Cells[5].Value = currentCount;
                    this.dataGridView1.Rows[sellCount].Cells[4].Value = currentVolume;
                    this.dataGridView1.Rows[sellCount].Cells[3].Value = sellList[i].getPrice();
                    sellCount++;
                    currentSellCount++;
                    currentVolume = 0;
                    currentCount = 0;
                }

            }

        }

        //constructor
        public MarketByPrice(RealTimeData rdt, Company company)
        {
            _rdt = rdt;
            _company = company;
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(formClosed); //add close form event handler
        }

        //unregister when form is closed event handler
        void formClosed(object sender, FormClosedEventArgs e)
        {
            _rdt.unRegister(this);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buyLabel_Click(object sender, EventArgs e)
        {

        }

        private void sellLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
