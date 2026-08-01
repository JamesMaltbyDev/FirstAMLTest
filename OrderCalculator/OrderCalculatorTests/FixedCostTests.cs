using OrderCalculator;
using OrderCalculator.Models;
using System;
using System.Collections.Generic;
using System.Text;
using OrderCalculator.Helpers;

namespace OrderCalculatorTests
{
    public class Package_Size_Fixed_Cost_Tests
    {
        [Theory]
        [InlineData(1, 2, 3, 3)]         //Small
        [InlineData(10, 20, 30, 8)]      //Medium
        [InlineData(70, 80, 90, 15)]     //Large
        [InlineData(100, 10, 10, 25)]    //Extra Large
        public void FixedCost_Test(int length, int width, int height, int cost)
        {
            var package = new Package                            
            {
                Length = length,
                Width = width,
                Height = height
            };
            
            var calculatedCost = FixedCostCalculator.GetPackageCost(package);

            Assert.Equal(cost, calculatedCost);
        }
    }
}
