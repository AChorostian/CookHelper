using System;

namespace CookHelper.Models
{
    public enum UnitBase { Weight , Volume , Amount };

    public class Unit : IComparable<Unit>
    {
        public int Id;
        public string Name { get; set; }
        public UnitBase Base { get; set; }
        public double Value { get; set; }

        public int CompareTo(Unit other) => Name.CompareTo(other.Name);

        public Unit()
        {
            
        }
    }
}

