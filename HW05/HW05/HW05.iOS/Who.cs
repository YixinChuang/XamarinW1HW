using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HW05.iOS;

//using MonoTouch.Foundation;
//using MonoTouch.UIKit;


[assembly: Xamarin.Forms.Dependency(typeof(Who))]
namespace HW05.iOS
{
    public class Who : IWho
    {
        public string Hello()
        {
            return "iOSiOSiOS";
        }
    }
}