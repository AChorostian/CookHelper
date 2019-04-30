using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using CookHelper.Controls;
using CookHelper.iOS.CustomRenderers;


[assembly: ExportRenderer(typeof(CustomSearchBar), typeof(CustomSearchBarRenderer))]
namespace CookHelper.iOS.CustomRenderers
{
    public class CustomSearchBarRenderer : SearchBarRenderer
    {
        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == SearchBar.TextProperty.PropertyName)
            {
                Control.Text = Element.Text;
            }
            else
            {
                if (e.PropertyName != SearchBar.CancelButtonColorProperty.PropertyName)
                    base.OnElementPropertyChanged(sender, e);
            }
        }
    }
}
