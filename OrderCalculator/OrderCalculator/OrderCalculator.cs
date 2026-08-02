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
                var cost = FixedCostCalculator.GetPackageCost(package, order.UseSpeedyShipping);
                package.Cost = cost;                

                var clonedPackage = new Package
                {
                    Length = package.Length,
                    Width = package.Width,
                    Height = package.Height
                };

                result.Packages.Add(clonedPackage);

                result.TotalCost += cost;
            }

            return result;
        }
    }
}
