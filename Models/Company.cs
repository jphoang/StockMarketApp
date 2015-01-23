using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarketNamespace.Models
{
    //Class that represents a company which contains its associated data
    public class Company
    {
        private String _companyName; //contains the name of the company
        private String _symbol; //Company symbol
        private double _openPrice; //company open price
        private double _lastPrice; //company last price
        private double _changeNet; //company change net
        private String _changeIcon; //company change icon
        private double _changePercent; // company change percentage
        private long _shareVolume; //company share volume
        private List<BuyOrder> _buyOrder; //holds all buy orders
        private List<SellOrder> _sellOrder; //holds all sell orders
        public List<Order> _transactions; //Holds a list of successful transactions

        public Company() {  //company constructor
            _sellOrder = new List<SellOrder>();
            _buyOrder = new List<BuyOrder>();
            _transactions = new List<Order>();
        }

        public String CompanyName //company name getter/setter
        {
            get
            {
                return _companyName;
            }
            set
            { 
                _companyName = value;
            }
        }

        public String Symbol //Company symbol getter/setter
        {
            get
            {
                return _symbol;
            }
            set
            {
                _symbol = value;
            }
        }
        
        public double OpenPrice //company open price getter/setter
        {
            get
            {
                return _openPrice;
            }
            set
            {
                _openPrice = value;
            }
        }

        public double LastPrice //company last price getter/setter
        {
            get
            {
                return _lastPrice;
            }
            set
            {
                _lastPrice = value;
            }
        }

        public double ChangeNet //company change net getter/setter
        {
            get
            {
                return _changeNet;
            }
            set
            {
                _changeNet = value;
            }
        }
       
        public String ChangeIcon //company chage icon getter/setter
        {
            get
            {
                return _changeIcon;
            }
            set
            {
                _changeIcon = value;
            }
        }

        public double ChangePercent
        {
            get
            {
                return _changePercent; //company change percent getter/setter
            }
            set
            {
                _changePercent = value;
            }
        }

        public long ShareVolume //company share volume getter/setter
        {
            get
            {
                return _shareVolume;
            }
            set
            {
                _shareVolume = value;
            }
        }
       
        public void addBuyOrder(BuyOrder order)  //add to buy order list
        {
            _buyOrder.Add(order);
        }
       
        public void addSellOrder(SellOrder order) //add to sell order list
        {
            _sellOrder.Add(order);
        }
        
        public List<BuyOrder> getBuyOrderList() //buy order list getter
        {
            return _buyOrder;
        }
        public List<SellOrder> getSellOrderList() //sell order list getter
        {
            return _sellOrder;
        }
        public List<Order> getTransactionList() //get transaction list
        {
            return _transactions;
        }
    }
}
