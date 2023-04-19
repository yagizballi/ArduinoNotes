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
            foreach (var x in AddNote.Note)
            {
                HomePageGridZone.Children.Add(CreateFrame(x.noteHead, x.noteCode));
            }
        }
        public Frame CreateFrame(string header, string note)
        {
            Grid noteGrid = new Grid();
            noteGrid.BackgroundColor = Color.Black;
            noteGrid.WidthRequest = 400;
            noteGrid.HeightRequest = 400;

            Label headerLabel = new Label();
            headerLabel.Text = header;
            headerLabel.TextColor = Color.White;
            headerLabel.HorizontalTextAlignment = TextAlignment.Center;
            headerLabel.FontSize = 26;
            headerLabel.WidthRequest = 400;
            headerLabel.HeightRequest = 100;
            noteGrid.Children.Add(headerLabel);

            Label noteLabel = new Label();
            noteLabel.Text = note;
            noteLabel.TextColor = Color.White;
            noteLabel.FontSize = 14;
            noteLabel.Margin = new Thickness(5, 25, 0, 0);
            noteGrid.Children.Add(noteLabel);

            Frame noteFrame = new Frame();
            noteFrame.CornerRadius =20;
            noteFrame.BackgroundColor = Color.White;
            noteFrame.Padding = new Thickness(3);
            noteFrame.HasShadow = true;
            noteFrame.Content = noteGrid;

            noteFrame.GestureRecognizers.Add(new TapGestureRecognizer
            {
                Command = new Command(async () =>
                {
                    ContentPage noteCurrentPage = new ContentPage();

                    StackLayout noteCurrentPageLayout = new StackLayout();
                    noteCurrentPageLayout.BackgroundColor = Color.Black;

                    Label headerLabelForCurrentPage = new Label();
                    headerLabelForCurrentPage.Text = header;
                    headerLabelForCurrentPage.TextColor = Color.White;
                    headerLabelForCurrentPage.HorizontalTextAlignment = TextAlignment.Center;
                    headerLabelForCurrentPage.FontSize = 26;
                    headerLabelForCurrentPage.WidthRequest = 400;
                    headerLabelForCurrentPage.HeightRequest = 100;

                    Label noteLabelForCurrentPage = new Label();
                    noteLabelForCurrentPage.Text = note;
                    noteLabelForCurrentPage.TextColor = Color.White;
                    noteLabelForCurrentPage.FontSize = 14;
                    noteLabelForCurrentPage.Margin = new Thickness(5, 0, 0, 0);

                    noteCurrentPageLayout.Children.Add(headerLabelForCurrentPage);
                    noteCurrentPageLayout.Children.Add(noteLabelForCurrentPage);

                    noteCurrentPage.Content = noteCurrentPageLayout;
                    noteCurrentPage.Title = headerLabelForCurrentPage.Text;

                    await Navigation.PushAsync(noteCurrentPage);
                })
            });

            return noteFrame;
        }
    }
}