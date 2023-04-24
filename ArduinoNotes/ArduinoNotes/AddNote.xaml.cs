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
    public struct Note
    {
        public string noteHead;
        public string noteCode;
    }
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AddNote : ContentPage
	{
        string codeTextFinal;
        string noteNameTextFinal;
        private static List<Note> _notes;
        public static List<Note> Note
        {
            get
            {
                if (_notes == null)
                    _notes = new List<Note>();
                return _notes;
            }
        }
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
            if(NoteName.Text == "Enter Your Code Name Here")
            {
                noteNameTextFinal = "";
            }
            noteNameTextFinal = NoteName.Text;
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
            if(Code.Text == "Enter Your Code Here")
            {
                codeTextFinal = "";
            }
            codeTextFinal = Code.Text;
        }
        private void TakeNoteBtn_Clicked(object sender, EventArgs e)
        {
            if(noteNameTextFinal != null && codeTextFinal != null) 
            {
                Note.Add(new Note() { noteHead = noteNameTextFinal, noteCode = codeTextFinal });
                DisplayAlert(noteNameTextFinal, "Code Taken!", "OK");
            }
            else if(noteNameTextFinal == null) 
            {
                DisplayAlert("Error!", "You can't take unnamed codes.", "OK");
            }
            else if(codeTextFinal == null)
            {
                DisplayAlert("Error!", "You can't take empty codes.", "OK");
            }
        }
    }
}