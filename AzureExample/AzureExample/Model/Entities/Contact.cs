using Microsoft.WindowsAzure.MobileServices;

namespace AzureExample.Model.Entities
{
    [DataTable("Contact")]
    public class Contact : ObservableBaseObject
    {
        private string id;
        public string Id
        {
            get { return id; }
            set { id = value; OnPropertyChanged(); }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged(); }
        }

        private string telephone;
        public string Telephone
        {
            get { return telephone; }
            set { telephone = value; OnPropertyChanged(); }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; OnPropertyChanged(); }
        }

        [Version]
        public string AzureVersion { get; set; }
    }
}
