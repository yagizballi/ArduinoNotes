using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ArduinoNotes
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AddNote : ContentPage
	{
        public string noteHeader;
        public string noteBody;
		public AddNote ()
		{
			InitializeComponent ();
		}
        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
        private void Entry_Focused(object sender, FocusEventArgs e)
        {
			if(NoteName.Text == "Enter Your Code Name Here")
			{
                NoteName.Text = string.Empty;
            }
			NoteName.MaxLength = 12;
        }
        private void NoteName_Unfocused(object sender, FocusEventArgs e)
        {
			if (NoteName.Text == string.Empty)
			{
                NoteName.MaxLength = 99;
                NoteName.Text = "Enter Your Code Name Here";	
            }
        }
        private void NoteName_Completed(object sender, EventArgs e)
        {
            noteHeader = NoteName.Text;
        }
        private void Code_Focused(object sender, FocusEventArgs e)
        {
            Code.HorizontalOptions = LayoutOptions.FillAndExpand;
            if(Code.Text == "Enter Your Code Here")
            {
                Code.Text = string.Empty;
            }
        }

        private void Code_Unfocused(object sender, FocusEventArgs e)
        {
            if(Code.Text == string.Empty)
            {
                Code.Text = "Enter Your Code Here";
                Code.HorizontalOptions = LayoutOptions.CenterAndExpand;
            }
        }
        private void Code_TextChanged(object sender, TextChangedEventArgs e)
        {
            Code.Text = RemoveEmojis(Code.Text);
        }
        private string RemoveEmojis(string input)
        {
            string emojiPattern = @"[\uD83C-\uDBFF\uDC00-\uDFFF]+";
            return Regex.Replace(input, emojiPattern, "");
        }
        private void Code_Completed(object sender, EventArgs e)
        {
            noteBody = Code.Text;
        }
        private void TakeNoteBtn_Clicked(object sender, EventArgs e)
        {
            AddNoteStackLayout.Children.Add(CreateGrid(noteHeader, noteBody));
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
            return noteGrid;
        }
    }
}