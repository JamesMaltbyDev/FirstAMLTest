using OrderCalculator.Helpers;
using System;
using System.Collections.Generic;
using System.Text;
using OrderCalculator.Models;

namespace OrderCalculator
{
    internal class OrderCalculator
    {
        public ResultCosts ProcessOrder(Order order)
        {
            var result = new ResultCosts
            {
                Packages = new List<Package>()
            };


            int totalCose = 0;

            foreach (var package in order.Packages)
            {                
                var cost = FixedCostCalculator.GetPackageCost(package);
                package.Cost = cost;

                result.Packages.Add(package);
                result.TotalCost += cost;
            }

            return result;
        }
    }
}
