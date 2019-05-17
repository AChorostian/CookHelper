using System;
using Android.Views;
using Android.Content;
using Android.Runtime;
using CookHelper;
using CookHelper.Droid;

[assembly: Xamarin.Forms.Dependency(typeof(DeviceOrientation))]
namespace CookHelper.Droid
{
    public class DeviceOrientation : IDeviceOrientation
    {
        public DeviceOrientation() { }

        public static void Init() { }

        public DeviceOrientations GetOrientation()
        {
            IWindowManager windowManager = Android.App.Application.Context.GetSystemService(Context.WindowService).JavaCast<IWindowManager>();

            var rotation = windowManager.DefaultDisplay.Rotation;
            bool isLandscape = rotation == SurfaceOrientation.Rotation90 || rotation == SurfaceOrientation.Rotation270;
            return isLandscape ? DeviceOrientations.Landscape : DeviceOrientations.Portrait;
        }
    }
}