using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarketNamespace
{
    public class RealTimeData : StockMarket
    {
        private DateTime _tradingDate; //date stock market opened
        private List<Models.Company> _company; //holds companies

        //Real Time Data constructor
        public RealTimeData() 
        {
            _tradingDate = DateTime.Now;
            _stocks = new List<Views.IStockMarketDisplay>();
            _company = new List<Models.Company>();
            
            //Hardcoded in 3 companies with default values (Mock Data)
            Models.Company microsoft = new Models.Company
            {
                CompanyName = "Microsoft Corporation",
                Symbol = "MSFT",
                OpenPrice =46.13,
                LastPrice =0,
                ChangeNet = 0,
                ChangeIcon = @"C:\Users\Justin\Documents\Visual Studio 2013\Projects\assignment2_jhoang27\assignment2_jhoang27\Resources\noChange.bmp",
                ChangePercent = 0,
                ShareVolume = 0
            };
            Models.Company apple = new Models.Company
            {
                CompanyName = "Apple Inc.",
                Symbol = "AAPL",
                OpenPrice = 105.22,
                LastPrice = 0,
                ChangeNet = 0,
                ChangeIcon = @"C:\Users\Justin\Documents\Visual Studio 2013\Projects\assignment2_jhoang27\assignment2_jhoang27\Resources\noChange.bmp",
                ChangePercent = 0,
                ShareVolume = 0
            };
            Models.Company facebook = new Models.Company
            {
                CompanyName = "Facebook, Inc.",
                Symbol = "FB",
                OpenPrice = 80.67,
                LastPrice = 0,
                ChangeNet = 0,
                ChangeIcon = @"C:\Users\Justin\Documents\Visual Studio 2013\Projects\assignment2_jhoang27\assignment2_jhoang27\Resources\noChange.bmp",
                ChangePercent = 0,
                ShareVolume = 0

            };
            _company.Add(microsoft);
            _company.Add(apple);
            _company.Add(facebook);
        }

        public List<Models.Company> CompanyList //company list getter
        {
            get
            {
                return _company;
            }
        }

        //Notify method to update all views
        public override void Notify() 
        {
            foreach (Views.IStockMarketDisplay o in _stocks)
            {
                o.Update(this);
            }
        }
    }
}
