using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarketNamespace.Models
{
    //Order base class for sell orders and buy orders
    public abstract class Order
    {
        private int _orderSize; //order size
        private double _orderPrice; //order price
        private DateTime _orderDateTime; //time of order

        public Order() { }
        
        public Order(int orderSize, double orderPrice)  //constructor
        {
            this._orderSize = orderSize;
            this._orderPrice = orderPrice;
            this._orderDateTime = DateTime.Now;
        }

        public void setPrice(double p)//set price of order
        {
            _orderPrice = p;
        }
        public double getPrice()  //get price of order
        {
            return _orderPrice;
        }
        public DateTime getDate() //get date of order
        {
            return _orderDateTime;
        }
        public int getSize() //get size of order
        {
            return _orderSize;
        }
        public void setSize(int size) //set size of order
        {
            _orderSize = size;
        }
    }
}
