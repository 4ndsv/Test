using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Enums;
using Test.Models;

namespace Test.Interfaces
{
    interface ICategorizationRules
    {
       public List<string> ByMarketValue(List<FinancialInstrument> list);
    }
}
