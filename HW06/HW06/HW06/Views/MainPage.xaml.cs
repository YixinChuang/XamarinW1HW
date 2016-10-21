using HW06.ViewModels;
using Xamarin.Forms;

namespace HW06.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ToolbarItem_Clicked(object s, System.EventArgs e)
        {
            MainPageViewModel foo = this.BindingContext as MainPageViewModel;
            foo.Title = "OK";
        }
    }
}
