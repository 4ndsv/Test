using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Enums;
using Test.Interfaces;

namespace Test.Models
{
    public class Portfolio : ICategorizationRules
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<FinancialInstrument>? FinancialInstruments { get; set; }
        public List<string> InstrumentCategories
        {
            get
            {
                return ByMarketValue(this.FinancialInstruments);
            }
        }

        public Portfolio(string name)
        {
            Name = name;
        }

        public List<string> ByMarketValue(List<FinancialInstrument> list)
        {
            List<string> result = new List<string>();
            if (list == null) { return result; }

            foreach (var item in list)
            {
                switch (item.MarketValue)
                {
                    case < 1000000:
                        result.Add(MarketValueCategory.LowValue.ToString());
                        break;
                    case < 5000000:
                        result.Add(MarketValueCategory.MediumValue.ToString());
                        break;
                    default:
                        result.Add(MarketValueCategory.HighValue.ToString());
                        break;
                }
            }
            return result;
        }
    }
}
