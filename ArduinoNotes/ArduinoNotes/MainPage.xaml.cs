using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;

namespace ArduinoNotes
{
    public partial class MainPage : ContentPage
    {
        public string SolutionName { get; set; } = "AndroidArduinoNotes";
        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;

        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            NavigationPage.SetHasNavigationBar(this, true);
        }
        private void openRightMenu(object sender, EventArgs e)
        {

        }
    }
}
