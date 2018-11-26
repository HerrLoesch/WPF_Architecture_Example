
namespace FotoMaX.CustomerManagement.Module
{
    using FotoMaX.CustomerManagement.Data;
    using FotoMaX.CustomerManagement.Interfaces;
    using FotoMaX.Interfaces.Infrastructure;

    public class CustomerManagementModule : IModule
    {
        public void Initialize(ITypeContainer container)
        {
            container.Register<ICustomerRepository, CustomerRepository>();
        }
    }
}
