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
		public AddNote ()
		{
			InitializeComponent ();
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

        private void TakeNoteBtn_Clicked(object sender, EventArgs e)
        {

        }
    }
}