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

namespace StockMarketNamespace
{
    public partial class PlaceBidOrderForm : Form
    {
        private RealTimeData _rdt;// hold real time data
        
        //constructor for bid form
        public PlaceBidOrderForm(RealTimeData rdt)
        {
            _rdt = rdt;
            InitializeComponent();
            this.numberOfSharesText.KeyPress += new KeyPressEventHandler(numberOfSharesText_KeyPress);
            this.purchasePriceText.KeyPress += new KeyPressEventHandler(purchasePriceText_KeyPress);
        }

        //Close form when cancel is clicked
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public ComboBox getShareComboBox() 
        {
            return this.shareComboBox;
        }
        //Handles input validation
        private void numberOfSharesText_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char delete = (char)0x08;
            e.Handled = !char.IsDigit(e.KeyChar) && !(e.KeyChar==delete);
        }

        //Handles input validation
        private void purchasePriceText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        //On submit make comparisons to form values, buy orders and sell orders to check for transactions
        private void submitButton_Click(object sender, EventArgs e)
        {
            int curSize = Convert.ToInt32(numberOfSharesText.Text);
            double curPrice = Convert.ToDouble(purchasePriceText.Text);
            foreach (Models.Company c in _rdt.CompanyList) 
            {
                if (c.CompanyName == this.shareComboBox.Text) 
                {
                    restart:
                    foreach(SellOrder o in c.getSellOrderList().OrderBy(x=>x.getPrice()).ThenByDescending(x=>x.getDate()))
                    {
                        if (curSize > o.getSize() && curPrice >= o.getPrice())
                        {
                            c.getSellOrderList().Remove(o);
                            c.getTransactionList().Add(o);

                            c.ShareVolume = c.ShareVolume + o.getSize();
                            curSize = curSize - o.getSize();
                            o.setSize(curSize);
                            c.ChangeNet = c.OpenPrice - o.getPrice();
                            c.ChangePercent = (Math.Abs(c.ChangeNet) / c.OpenPrice) * 100;
                            c.LastPrice = o.getPrice();
                            if (c.ChangeNet < 0)
                            {
                                c.ChangeIcon = @"C:\Users\Justin\Documents\Visual Studio 2013\Projects\assignment2_jhoang27\assignment2_jhoang27\Resources\up.bmp";
                            }
                            else if (c.ChangeNet > 0)
                            {
                                c.ChangeIcon = @"C:\Users\Justin\Documents\Visual Studio 2013\Projects\assignment2_jhoang27\assignment2_jhoang27\Resources\down.bmp";
                            }
                            else
                            {
                                c.ChangeIcon = @"C:\Users\Justin\Documents\Visual Studio 2013\Projects\assignment2_jhoang27\assignment2_jhoang27\Resources\noChange.bmp";
                            }
                            c.ChangeNet = Math.Abs(c.ChangeNet);
                            _rdt.Notify();
                            this.Close();
                            goto restart;
                        }
                        else if (curSize < o.getSize() && curPrice >= o.getPrice()) 
                        {
                            o.setSize(o.getSize() - curSize);
                            c.getTransactionList().Add(new BuyOrder(curSize, o.getPrice()));
                            c.ChangeNet = c.OpenPrice - o.getPrice();
                            c.ChangePercent = (Math.Abs(c.ChangeNet) / c.OpenPrice) * 100;
                            c.LastPrice = o.getPrice();
                            c.ShareVolume = c.ShareVolume + o.getSize();
                            if (c.ChangeNet < 0)
                            {
                                c.ChangeIcon = @"C:\Users\Justin\Documents\Visual Studio 2013\Projects\assignment2_jhoang27\assignment2_jhoang27\Resources\up.bmp";
                            }
                            else if (c.ChangeNet > 0)
                            {
                                c.ChangeIcon = @"C:\Users\Justin\Documents\Visual Studio 2013\Projects\assignment2_jhoang27\assignment2_jhoang27\Resources\down.bmp";
                            }
                            else
                            {
                                c.ChangeIcon = @"C:\Users\Justin\Documents\Visual Studio 2013\Projects\assignment2_jhoang27\assignment2_jhoang27\Resources\noChange.bmp";
                            }
                            c.ChangeNet = Math.Abs(c.ChangeNet);
                            _rdt.Notify();
                            this.Close();
                            return;
                        }
                        else if(curSize >= o.getSize() && curPrice >= o.getPrice())
                        {
                            c.getTransactionList().Add(o);
                            c.ChangeNet = c.OpenPrice - o.getPrice();
                            c.ChangePercent = (Math.Abs(c.ChangeNet) / c.OpenPrice) * 100;
                            c.LastPrice = o.getPrice();
                            c.ShareVolume = c.ShareVolume + o.getSize();
                            if (c.ChangeNet < 0) 
                            {
                                c.ChangeIcon = @"C:\Users\Justin\Documents\Visual Studio 2013\Projects\assignment2_jhoang27\assignment2_jhoang27\Resources\up.bmp";
                            }
                            else if (c.ChangeNet > 0)
                            {
                                c.ChangeIcon = @"C:\Users\Justin\Documents\Visual Studio 2013\Projects\assignment2_jhoang27\assignment2_jhoang27\Resources\down.bmp";
                            }
                            else 
                            {
                                c.ChangeIcon = @"C:\Users\Justin\Documents\Visual Studio 2013\Projects\assignment2_jhoang27\assignment2_jhoang27\Resources\noChange.bmp";
                            }
                            c.ChangeNet = Math.Abs(c.ChangeNet);

                            c.getSellOrderList().Remove(o);
                            if (curSize > o.getSize())
                            {
                                c.getBuyOrderList().Add(new BuyOrder(curSize - o.getSize(), curPrice));
                            }
                            _rdt.Notify();
                            this.Close();
                            return;
                        }
                    }

                    BuyOrder order = new BuyOrder(curSize, curPrice);
                    c.addBuyOrder(order);
                    _rdt.Notify();
                    this.Close();
                    
                }
            }
        }
    }
}
