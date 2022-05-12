using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using WPFGeneral.Helpers;

namespace WPFGeneral.ViewModels
{
    internal class MainWindowVM: ObservableRecipient
    {
        public MainWindowVM()
        {
            SendCommand = new RelayCommand(() =>
            {
                Messenger.Send("data");
            });
            Messenger.Register<MainWindowVM, string>(this, (r, m) =>
            {
                
                LogHelper.WriteLog("xxxx");
            });
        }

        public IRelayCommand SendCommand { get; set; }

        private string _title = "数据";
        [Required]
        [MinLength(5)]
        [MaxLength(100)]
        public string Title
        {
            get { return _title; }
            set =>
                SetProperty(ref _title, value, true);

        }
    }
}
