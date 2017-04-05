using AzureExample.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AzureExample.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactView : ContentPage
    {
        public ContactView()
        {
            InitializeComponent();
            this.BindingContext = new ContactDirectoryViewModel();
        }
    }
}
