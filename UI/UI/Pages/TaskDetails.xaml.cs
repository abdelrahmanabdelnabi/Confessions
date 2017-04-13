using UI.Models;
using UI.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UI.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TaskDetail : ContentPage
    {
        public TaskDetail(TodoItem item = null)
        {
            InitializeComponent();
            BindingContext = new TaskDetailViewModel(item);
        }
    }
}
