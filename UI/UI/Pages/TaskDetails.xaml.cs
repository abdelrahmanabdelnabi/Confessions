using UI.Models;
using UI.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UI.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TaskDetail : ContentPage
    {

        public TaskDetail()
        {
            InitializeComponent();
           


    }
        private void PickerCtl_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (PickerCtl != null && PickerCtl.SelectedIndex <= PickerCtl.Items.Count)
     {
                var selecteditem = PickerCtl.Items[PickerCtl.SelectedIndex];
                DisplayAlert("Picker Control", selecteditem, "OK");
            }
        }

        private void SaveButton_Clicked(object sender, System.EventArgs e)
        {
            ConfessionNote note = new ConfessionNote(editor1.Text, SignatureName.Text, selecteditem);

        }
    }
}
