using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Interfaces
{
    interface IFinancialInstrument
    {
        double MarketValue { get; }
        string Type { get; }
    }
}
