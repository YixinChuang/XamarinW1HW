using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW05.UWP;

[assembly: Xamarin.Forms.Dependency(typeof(WhoUWP))]
namespace HW05.UWP
{
    public class WhoUWP : IWho
    {
        public string Hello()
        {
            return "Windows UWP";
        }
    }
}
