using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarketNamespace.Models
{
    //Class that represents a bid order
    public class BuyOrder : Order
    {
        //Constructor which calls base class constructor
        public BuyOrder(int orderSize, double orderPrice) : base(orderSize, orderPrice) { }
    }
}
