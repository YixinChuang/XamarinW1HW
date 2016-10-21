using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using HW05.Droid;

[assembly: Xamarin.Forms.Dependency(typeof(Who))]
namespace HW05.Droid
{
    public class Who : IWho
    {
        public string Hello()
        {
            return "Android";
        }
    }
}