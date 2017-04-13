using UI.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UI.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EntryPage : ContentPage
    {
        public EntryPage()
        {
            InitializeComponent();
            BindingContext = new EntryPageViewModel();
        }
    }
}