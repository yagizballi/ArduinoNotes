using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ArduinoNotes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();

            foreach(var x in AddNote.Note)
            {
                HomePageGridZone.Children.Add(CreateGrid(x.noteHead, x.noteCode));
            }
        }
        public Grid CreateGrid(string header, string note)
        {
            Label headerLabel = new Label();
            Label noteLabel = new Label();
            headerLabel.Text = header;
            noteLabel.Text = note;
            Grid noteGrid = new Grid();
            noteGrid.Children.Add(headerLabel);
            noteGrid.Children.Add(noteLabel);
            noteGrid.WidthRequest = 50;
            noteGrid.HeightRequest = 50;
            noteGrid.BackgroundColor = Color.Red;
            noteGrid.HorizontalOptions = LayoutOptions.FillAndExpand;
            return noteGrid;
        }
    }
}