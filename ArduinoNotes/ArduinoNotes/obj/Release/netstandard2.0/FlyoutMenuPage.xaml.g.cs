//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::Xamarin.Forms.Xaml.XamlResourceIdAttribute("ArduinoNotes.FlyoutMenuPage.xaml", "FlyoutMenuPage.xaml", typeof(global::ArduinoNotes.FlyoutMenuPage))]

namespace ArduinoNotes {
    
    
    [global::Xamarin.Forms.Xaml.XamlFilePathAttribute("FlyoutMenuPage.xaml")]
    public partial class FlyoutMenuPage : global::Xamarin.Forms.ContentPage {
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        public global::Xamarin.Forms.ListView listview;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::ArduinoNotes.FlyoutItemPage NotesArea;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::ArduinoNotes.FlyoutItemPage AddNoteArea;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::ArduinoNotes.FlyoutItemPage AboutArea;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent() {
            global::Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(FlyoutMenuPage));
            listview = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.ListView>(this, "listview");
            NotesArea = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::ArduinoNotes.FlyoutItemPage>(this, "NotesArea");
            AddNoteArea = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::ArduinoNotes.FlyoutItemPage>(this, "AddNoteArea");
            AboutArea = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::ArduinoNotes.FlyoutItemPage>(this, "AboutArea");
        }
    }
}
