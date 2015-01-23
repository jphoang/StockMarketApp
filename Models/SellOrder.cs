using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarketNamespace.Models
{
    //class for sell orders
    public class SellOrder : Order
    {
        public SellOrder(int orderSize, double orderPrice) : base(orderSize, orderPrice) { }
    }
}
