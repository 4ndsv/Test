using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Test.Enums;
using Test.Interfaces;

namespace Test.Models
{
    public class FinancialInstrument : IFinancialInstrument 
    {
        private double marketValue;
        private string type;

        public FinancialInstrument(string type, double marketValue)
        {
            this.type = type;
            this.marketValue = marketValue;
        }

        public double MarketValue { get => marketValue; }

        public string Type { get => type;}

       
    }
}
