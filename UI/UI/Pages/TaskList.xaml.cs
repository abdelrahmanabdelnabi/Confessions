using UI.Models;
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
            ConfessionList1.ItemsSource = ConfessionNote.ConfessionsList;
            BindingContext = new TaskListViewModel();
        }

        private async void NewConfession_Clicked(object sender, System.EventArgs e)
        {
           await Navigation.PushAsync(new UI.Pages.TaskDetail());
        }
    }
}