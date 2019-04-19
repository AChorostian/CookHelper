using System;
namespace CookHelper.Models
{
    public class Product : IComparable<Product>
    {
        public string Name { get; set; }

        public bool Weight { get; set; }
        public bool Volume { get; set; }
        public bool Amount { get; set; }

        public double WeightValue { get; set; }
        public double VolumeValue { get; set; }
        public double AmountValue { get; set; }

        public int CompareTo(Product other) => Name.CompareTo(other.Name);
    }
}
