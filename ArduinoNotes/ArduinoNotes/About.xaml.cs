using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static System.Net.WebRequestMethods;

namespace ArduinoNotes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class About : ContentPage
    {
        public About()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
        private async void githubOpenBrowser_Clicked(object sender, EventArgs e)
        {
            await Browser.OpenAsync(uri: @"https://github.com/yagizballi/ArduinoNotes");
        }
    }
}