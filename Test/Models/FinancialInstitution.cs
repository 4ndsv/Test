using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Models
{
    public class FinancialInstitution
    {
        public int Id { get; set; }
        string Name { get; }
        public List<Portfolio>? Portfolios { get; set; }

        public FinancialInstitution(string name)
        {
            Name = name;
        }
    }
}
