using System;
using System.Collections.Generic;
using System.Text;

namespace OrderCalculator.Models
{
    public enum PackageSize
    {
        Small,
        Medium,
        Large,
        ExtraLarge
    }

    internal class Package
    {
        /// <summary>
        /// Length in cm
        /// </summary>        
        public int Length { get; set; }

        /// <summary>
        /// Width in cm
        /// </summary>        
        public int Width { get; set; }

        /// <summary>
        /// Height in cm
        /// </summary>
        public int Height { get; set; }

        /// <summary>
        /// Cost of the package
        /// </summary>
        public int Cost { get; set; }
    }


    internal class Order
    {
        public List<Package> Packages { get; set; } = new List<Package>();

    }    
}
