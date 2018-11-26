using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FotoMaX
{
    using System.Windows;

    using FotoMaX.Data;
    using FotoMaX.Interfaces;
    using FotoMaX.Interfaces.Infrastructure;


    public class Bootstrapper
    {
        public void Run()
        {
            var logger = InitLogger();

            var typeContainer = CreateContainer();
            
            RegisterTypes(typeContainer, logger);
            
            var shell = CreateShell(typeContainer);

            InitializeModules();

            
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
        }
        
        private static Window CreateShell(ITypeContainer container)
        {
            return null;
        }

        private static void Show(Window shell)
        {
        }

        private static void InitializeModules()
        {
            
        }
    }
}


