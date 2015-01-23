using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarketNamespace
{
    //base class for real time data
    public abstract class StockMarket
    {
        protected List<Views.IStockMarketDisplay> _stocks; //holds stock views

        //register new view
        public void Register(Views.IStockMarketDisplay o)
        {
            _stocks.Add(o);
        }

        //unregister view
        public void unRegister(Views.IStockMarketDisplay o)
        {
            _stocks.Remove(o);
        }

        //abstract function for notify
        public abstract void Notify(); 
        
    }
}
