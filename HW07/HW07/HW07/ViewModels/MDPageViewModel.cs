using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;

namespace HW07.ViewModels
{
    public class MDPageViewModel : BindableBase
    {
        public DelegateCommand Page1Command { get; private set; }
        public DelegateCommand Page2Command { get; private set; }


        private readonly INavigationService _navigationService;
        public MDPageViewModel(INavigationService navigationService)
        {

            _navigationService = navigationService;
            Page1Command = new DelegateCommand(async () =>
            {
                //用絕對位置切換導航頁面 並清空導航堆疊(UriKind.Absolute)
                await _navigationService.NavigateAsync(new Uri("xf:///MDPage/NaviPage/APage", UriKind.Absolute));
            });
            Page2Command = new DelegateCommand(async () =>
            {
                //用絕對位置切換導航頁面 並清空導航堆疊(UriKind.Absolute)
                await _navigationService.NavigateAsync(new Uri("xf:///MDPage/NaviPage/BPage", UriKind.Absolute));
            });
        }
    }
}
