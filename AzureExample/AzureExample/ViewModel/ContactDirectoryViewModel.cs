using AzureExample.Helper;
using AzureExample.Model.Entities;
using AzureExample.Model.Services;
using Xamarin.Forms;

namespace AzureExample.ViewModel
{
    public class ContactDirectoryViewModel : ObservableBaseObject
    {
        public ObservableRangeCollection<Contact> Contacts { get; set; }

        private bool isBusy;
        public bool IsBusy
        {
            get { return isBusy; }
            set { isBusy = value; OnPropertyChanged(); }
        }

        public Command LoadDirectoryCommand { get; set; }

        public ContactDirectoryViewModel()
        {
            Contacts = new ObservableRangeCollection<Contact>();
            IsBusy = false;
            LoadDirectoryCommand = new Command((obj) => LoadDirectory());
        }

        private async void LoadDirectory()
        {
            if (!IsBusy)
            {
                IsBusy = true;

                var Service = new AzureService<Contact>();
                var Items = await Service.GetTable();
                
                Contacts.Clear();
                Contacts.ReplaceRange(Items);

                IsBusy = false;
            }
        }
    }
}
