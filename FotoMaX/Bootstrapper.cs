using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FotoMaX
{
    using System.Windows;

    using FotoMaX.Data;
    using FotoMaX.Infrastructure;
    using FotoMaX.Interfaces;
    using FotoMaX.Interfaces.Data;
    using FotoMaX.Interfaces.Infrastructure;
    using FotoMaX.Interfaces.Logic;

    using FotoMaXLogic;

    public class Bootstrapper
    {
        public void Run()
        {
            var logger = InitLogger();

            var typeContainer = CreateContainer();
            
            RegisterTypes(typeContainer, logger);
            
            var shell = CreateShell(typeContainer);
            
            Show(shell);
        }
        
        private static ILogger InitLogger()
        {
            return null;
        }
        
        private static ITypeContainer CreateContainer()
        {
            return null;
        }

        private static void RegisterTypes(ITypeContainer typeContainer, ILogger logger)
        {
            // Infrastructure
            typeContainer.Register<ILogger, Logger>();
            typeContainer.Register<ISettingsManagement, SettingsManagement>();

            // Logic
            typeContainer.Register<IOrderService, OrderService>();

            // Data
            typeContainer.Register<IPictureRepository, PictureRepository>();
            typeContainer.Register<ICustomerRepository, CustomerRepository>();
        }
        
        private static Window CreateShell(ITypeContainer container)
        {
            return null;
        }

        private static void Show(Window shell)
        {
        }
    }

    internal interface ITypeContainer
    {
        void Register<TFrom, TTo>();
    }
}


