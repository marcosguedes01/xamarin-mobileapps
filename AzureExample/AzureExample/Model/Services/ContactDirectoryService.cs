using AzureExample.Model.Entities;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace AzureExample.Model.Services
{
    public class ContactDirectoryService
    {
        public static async Task<ContactDirectory> LoadContactDirectory()
        {
            ContactDirectory contactDirectory = new ContactDirectory();
            ObservableCollection<Contact> contacts = new ObservableCollection<Contact>();

            var Service = new AzureService<Contact>();
            var Items = await Service.GetTable();

            var result = Items.ToList();

            foreach (var contact in result)
            {
                contacts.Add(contact);
            }

            contactDirectory.Contacts = contacts;
            return contactDirectory;
        }
    }
}
