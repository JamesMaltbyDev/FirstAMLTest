using System;
using System.Collections.Generic;
using System.Text;
using OrderCalculator.Models;
using OrderCalculator;

namespace OrderCalculatorTests
{
    public class OrderTests
    {
        [Fact]
        public void OrderTests_GetTotalCost()
        {
            var order = GetOrder(false);
            var orderCalculator = new OrderCalculator.OrderCalculator();
            var result = orderCalculator.ProcessOrder(order);

            Assert.Equal(3, result.Packages[0].Cost);
            Assert.Equal(8, result.Packages[1].Cost);
            Assert.Equal(11, result.TotalCost);
        }

        [Fact]
        public void OrderTests_GetTotalCost_SpeedyShipping()
        {
            var order = GetOrder(true);
            var orderCalculator = new OrderCalculator.OrderCalculator();
            var result = orderCalculator.ProcessOrder(order);

            Assert.Equal(6, result.Packages[0].Cost);
            Assert.Equal(16, result.Packages[1].Cost);
            Assert.Equal(21, result.TotalCost);
        }

        private Order GetOrder(bool speedyShipping)
        {
            return new Order
            {
                Packages = new List<Package>
                {
                    new Package
                    {
                        Length = 10,
                        Width = 10,
                        Height = 10
                    },
                    new Package
                    {
                        Length = 20,
                        Width = 30,
                        Height = 40
                    }
                },
                UseSpeedyShipping = speedyShipping
            };
        }        
    }
}
