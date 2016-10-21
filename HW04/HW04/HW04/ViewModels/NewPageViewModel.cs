using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;

namespace HW04.ViewModels
{
    public class NewPageViewModel : BindableBase, INavigationAware
    {

        #region DateTimeNow
        private string _DateTimeNow;
        /// <summary>
        /// DateTimeNow
        /// </summary>
        public string DateTimeNow
        {
            get { return this._DateTimeNow; }
            set { this.SetProperty(ref this._DateTimeNow, value); }
        }
        #endregion


        public NewPageViewModel()
        {

        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
            throw new NotImplementedException();
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            if (parameters.ContainsKey("Now"))
            {
                var t = parameters["Now"] as DateTime?;
                DateTimeNow = $"現在時間 {t}";
            }
            else
            {
                DateTimeNow = "沒參數";
            }
        }
    }
}
