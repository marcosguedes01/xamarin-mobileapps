using System.Collections.ObjectModel;

namespace AzureExample.Model.Entities
{
    public class ContactDirectory: ObservableBaseObject
    {
        private ObservableCollection<Contact> contacts = new ObservableCollection<Contact>();
        public ObservableCollection<Contact> Contacts
        {
            get { return contacts; }
            set { contacts = value; OnPropertyChanged(); }
        }
    }
}
