using System;
using Xamarin.Forms;
using System.Globalization;
using CookHelper.Models;

namespace CookHelper.Controls
{
    public class UnitBaseConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo cultureInfo)
        {
            UnitBase unitBase = (UnitBase)value;
            string unitBaseShort;
            switch (unitBase)
            {
                case UnitBase.Weight:
                    unitBaseShort = "g";
                    break;
                case UnitBase.Volume:
                    unitBaseShort = "ml";
                    break;
                case UnitBase.Amount:
                    unitBaseShort = "szt";
                    break;
                default:
                    unitBaseShort = "";
                    break;
            }
            return unitBaseShort;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo cultureInfo)
        {
            throw new NotImplementedException();
        }
    }
}

