using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HW05.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {
        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        #region WhoLabel
        private string _WhoLabel;
        /// <summary>
        /// PropertyDescription
        /// </summary>
        public string WhoLabel
        {
            get { return this._WhoLabel; }
            set { this.SetProperty(ref this._WhoLabel, value); }
        }
        #endregion

        public DelegateCommand WhoCommand { get; private set; }
        public IWho _IWho;

        public MainPageViewModel(IWho iWho)
        {
            _IWho = iWho;
            WhoCommand = new DelegateCommand(Who);
        }

        private void Who()
        {
            WhoLabel = _IWho.Hello();
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
