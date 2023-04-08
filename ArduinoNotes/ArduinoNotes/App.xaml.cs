using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ArduinoNotes
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var flyoutPage = new FlyoutPage
            {
                Title = "ArduinoNotes",
                Flyout = new NavigationPage(new FlyoutMenuPage())
                {
                    Title = "Menu"
                },
                Detail = new NavigationPage(new HomePage())
                {
                    Title = "Home"
                }
            };

            MainPage = flyoutPage;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
