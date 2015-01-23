using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarketNamespace.Views
{
    //interface for all stock views
    public interface IStockMarketDisplay
    {
        void Update(RealTimeData s); //public interface method for update view
    }
}
