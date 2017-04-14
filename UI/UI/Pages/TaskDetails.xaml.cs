using System.Threading.Tasks;
using UI.Models;
using UI.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UI.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TaskDetail : ContentPage
    {
        string selecteditem;
        public TaskDetail()
        {
            InitializeComponent();



        }
        private void PickerCtl_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (PickerCtl != null && PickerCtl.SelectedIndex <= PickerCtl.Items.Count)
            {
                selecteditem = PickerCtl.Items[PickerCtl.SelectedIndex];
                DisplayAlert("Picker Control", selecteditem, "OK");

            }
        }

        private void SaveButton_Clicked(object sender, System.EventArgs e)
        {
            ConfessionNote note = new ConfessionNote(editor1.Text, SignatureName.Text, selecteditem);

            Command cmdSave;

        public Command SaveCommand => cmdSave ?? (cmdSave = new Command(async () => await ExecuteSaveCommand()));

        async Task ExecuteSaveCommand()
        {
            if (IsBusy)
                return;
            IsBusy = true;

            try
            {
                if (Item.Id == null)
                {
                    await table.CreateItemAsync(Item);
                }
                else
                {
                    await table.UpdateItemAsync(Item);
                }
                MessagingCenter.Send<TaskDetailViewModel>(this, "ItemsChanged");
                await Application.Current.MainPage.Navigation.PopAsync();
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"[TaskDetail] Save error: {ex.Message}");
                Debug.WriteLine(ex.StackTrace);
            }
            finally
            {
                IsBusy = false;
            }
        } }
    }
        

  

