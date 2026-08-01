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
        public void OrderTests_GetTotalCose()
        {
            var order = GetOrder();
            var orderCalculator = new OrderCalculator.OrderCalculator();
            var result = orderCalculator.ProcessOrder(order);

            Assert.Equal(3, result.Packages[0].Cost);
            Assert.Equal(8, result.Packages[1].Cost);
            Assert.Equal(11, result.TotalCost);
        }

        private Order GetOrder()
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
                }
            };
        }        
    }
}
