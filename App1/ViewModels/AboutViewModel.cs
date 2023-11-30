using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace App1.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "Morcegos";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://media.tenor.com/ccQPQ5QiTjAAAAAC/kubby.gif"));
        }

        public ICommand OpenWebCommand { get; }
    }
}