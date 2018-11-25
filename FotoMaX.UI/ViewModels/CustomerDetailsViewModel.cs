using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FotoMaX.UI.ViewModels
{
    using FotoMaX.Interfaces.Data;
    using FotoMaX.UI.MVVM;

    public class CustomerDetailsViewModel : ViewModelBase
    {
        public CustomerDetailsViewModel(ICustomerRepository customerRepository)
        {
            
        }
    }
}
