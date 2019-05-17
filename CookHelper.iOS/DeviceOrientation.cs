using System;
using UIKit;
using Foundation;
using CookHelper;
using CookHelper.iOS;

[assembly: Xamarin.Forms.Dependency(typeof(DeviceOrientation))]
namespace CookHelper.iOS
{
    public class DeviceOrientation : IDeviceOrientation
    {
        public DeviceOrientation() {}

        public DeviceOrientations GetOrientation()
        {
            var currentOrientation = UIApplication.SharedApplication.StatusBarOrientation;
            bool isPortrait = currentOrientation == UIInterfaceOrientation.Portrait
                || currentOrientation == UIInterfaceOrientation.PortraitUpsideDown;

            return isPortrait ? DeviceOrientations.Portrait : DeviceOrientations.Landscape;
        }
    }
}
