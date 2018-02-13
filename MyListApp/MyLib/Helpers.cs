using System;
using Xamarin.Forms;
namespace MyListApp
{
    public static class Helpers
    {
        // Page padding
        // iOS Devices need more padding at the top. 
        public static Thickness GetPagePadding()
        {
            double top = 0;
            if (Device.RuntimePlatform == Device.iOS)
                top = 20;

            return (new Thickness(10, top, 10, 5));
        }
    }
}
