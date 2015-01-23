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
    public partial class PlaceSellOrderForm : Form
    {
        private RealTimeData _rdt;//hold real time data
        
        //constuctors
        public PlaceSellOrderForm(RealTimeData rdt)
        {
            _rdt = rdt;
            InitializeComponent();
            //add event handlers for input validations
            this.numberOfSharesText.KeyPress += new KeyPressEventHandler(numberOfSharesText_KeyPress);
            this.sellPriceText.KeyPress += new KeyPressEventHandler(sellPriceText_KeyPress);

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
        //event handler for number of shares field
        private void numberOfSharesText_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char delete = (char)0x08;
            e.Handled = !char.IsDigit(e.KeyChar) && !(e.KeyChar ==delete);
        }

        //event handler for sell price field
        private void sellPriceText_KeyPress(object sender, KeyPressEventArgs e)
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
            double curPrice = Convert.ToDouble(sellPriceText.Text);

            foreach (Models.Company c in _rdt.CompanyList)
            {
                if (c.CompanyName == this.shareComboBox.Text)
                {
                    restart:
                    SellOrder order = new SellOrder(curSize, curPrice);
                    foreach (BuyOrder o in c.getBuyOrderList().OrderByDescending(x => x.getPrice()).ThenByDescending(x => x.getDate()))
                    {
                        if (curSize > o.getSize() && curPrice <= o.getPrice())
                        {
                            c.getBuyOrderList().Remove(o);
                            c.getTransactionList().Add(o);
    
                            c.ShareVolume = c.ShareVolume + o.getSize();
                            curSize = curSize - o.getSize();
                            o.setSize(curSize);
                            c.ChangeNet = c.OpenPrice - curPrice;
                            c.ChangePercent = (Math.Abs(c.ChangeNet) / c.OpenPrice) * 100;
                            c.LastPrice = curPrice;
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
                        else if (curSize <= o.getSize() && curPrice <= o.getPrice())
                        {
                            c.getTransactionList().Add(order);

                            c.ChangeNet = c.OpenPrice - order.getPrice();
                            c.ChangePercent = (Math.Abs(c.ChangeNet) / c.OpenPrice) * 100;
                            c.LastPrice = curPrice;
                            c.ShareVolume = c.ShareVolume + order.getSize();
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

                            c.getBuyOrderList().Remove(o);
                            if (curSize < o.getSize()) 
                            {
                                o.setSize(o.getSize()-curSize);
                                c.getBuyOrderList().Add(o);
                            }
                            _rdt.Notify();
                            this.Close();
                            return;
                        }
                    }
                    c.addSellOrder(order);
                    _rdt.Notify();
                    this.Close();

                }
            }
        }

    }
}
