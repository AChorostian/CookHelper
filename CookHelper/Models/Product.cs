using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace CookHelper.Models
{
    public class Product : IComparable<Product> , INotifyPropertyChanged
    {
        public int Id;
        public string name;

        public string Name
        {
            get { return name; }
            set 
            { 
                name = value;
                OnPropertyChanged("Name");
            }
        }
        //    {
        //        //Name = value;
        //        //OnPropertyChanged("Name");
        //    }
        //}

        //public string Image
        //{ 
        //    get { return Image; } 
        //    set
        //    { 
        //        Image = value; 
        //        OnPropertyChanged("Image");
        //    } 
        //}

        public bool Weight { get; set; }
        public bool Volume { get; set; }
        public bool Amount { get; set; }

        public double WeightValue { get; set; }
        public double VolumeValue { get; set; }
        public double AmountValue { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;


        public int CompareTo(Product other) => Name.CompareTo(other.Name);

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged == null)
                return;
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
