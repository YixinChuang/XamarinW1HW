using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HW04.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {
        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }


        public DelegateCommand 顯示NewPageCommand { get; private set; }


        private readonly INavigationService _navigationService;

        public MainPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            顯示NewPageCommand = new DelegateCommand(顯示NewPage);
        }

        private async void 顯示NewPage()
        {
            //傳遞參數
            NavigationParameters parm = new NavigationParameters();
            //parm.Add("Now", DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
            parm.Add("Now", DateTime.Now);
            await _navigationService.NavigateAsync("NewPage", parm);
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            if (parameters.ContainsKey("title"))
                Title = (string)parameters["title"] + " and Prism";
        }
    }
}
