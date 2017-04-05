using Microsoft.WindowsAzure.MobileServices;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AzureExample.Model.Services
{
    public class AzureService<T>
    {
        IMobileServiceClient Client;
        IMobileServiceTable<T> Table;

        public AzureService()
        {
            string MyAppServiceURL = "http://maratonaxamarinexample.azurewebsites.net";
            Client = new MobileServiceClient(MyAppServiceURL); Table = Client.GetTable<T>();
        }

        public async Task<IEnumerable<T>> GetTable()
        {
            return await Table.ToEnumerableAsync();
        }
    }
}
