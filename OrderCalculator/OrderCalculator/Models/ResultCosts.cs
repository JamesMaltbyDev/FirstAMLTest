using System;
using System.Collections.Generic;
using System.Text;

namespace OrderCalculator.Models
{
    internal class ResultCosts
    {
        public List<Package> Packages { get; set; }        
        public int TotalCost { get; set; }
    }
}
