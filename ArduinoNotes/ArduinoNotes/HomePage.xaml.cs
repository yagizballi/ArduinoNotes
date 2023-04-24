using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
using TextCopy;

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

                    ScrollView noteCurrentPageView = new ScrollView();
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

                    Button copyButton = new Button();
                    copyButton.Text = "Copy";
                    copyButton.TextColor = Color.WhiteSmoke;
                    copyButton.BackgroundColor = Color.Gray;
                    copyButton.HorizontalOptions = LayoutOptions.Start;
                    copyButton.WidthRequest = 100;
                    copyButton.HeightRequest = 50;

                    copyButton.Clicked += (sender, e) =>
                    {
                        TextCopy.ClipboardService.SetText(note);
                        if(ClipboardService.GetText() == note)
                        {
                            DisplayAlert("Success!", "Copied!", "OK");
                        };
                    };

                    Button deleteButton = new Button();
                    deleteButton.Text = "Delete";
                    deleteButton.TextColor = Color.WhiteSmoke;
                    deleteButton.BackgroundColor = Color.Gray;
                    deleteButton.HorizontalOptions = LayoutOptions.End;
                    deleteButton.WidthRequest = 100;
                    deleteButton.HeightRequest = 50;

                    noteCurrentPageLayout.Children.Add(headerLabelForCurrentPage);
                    noteCurrentPageLayout.Children.Add(copyButton);
                    noteCurrentPageLayout.Children.Add(deleteButton);
                    noteCurrentPageLayout.Children.Add(noteLabelForCurrentPage);

                    noteCurrentPageView.Content = noteCurrentPageLayout;
                    noteCurrentPage.Content = noteCurrentPageView;
                    noteCurrentPage.Title = headerLabelForCurrentPage.Text;


                    await Navigation.PushAsync(noteCurrentPage);
                })
            });

            return noteFrame;
        }
    }
}