using UI.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UI.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TaskList : ContentPage
    {
        public TaskList()
        {
            InitializeComponent();
            BindingContext = new TaskListViewModel();
        }
    }
}