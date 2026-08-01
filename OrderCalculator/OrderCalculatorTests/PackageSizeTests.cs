using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using OrderCalculator.Helpers;
using OrderCalculator.Models;

namespace OrderCalculatorTests
{   
    public class PackageSizeTests
    {
        [Theory]
        [InlineData(1, 2, 3, PackageSize.Small)]
        [InlineData(10, 20, 30, PackageSize.Medium)]
        [InlineData(70, 80, 90, PackageSize.Large)]
        [InlineData(100, 10, 10, PackageSize.ExtraLarge)]

        public void PackageSizeHelper_Test(int length, int width, int height, PackageSize packageSize)
        {
            var package = new Package
            {
                Length = length,
                Width = width,
                Height = height
            };
 
            var size = PackageSizeHelper.GetPackageSize(package);

            Assert.Equal(packageSize, size);
        }
    }
}
