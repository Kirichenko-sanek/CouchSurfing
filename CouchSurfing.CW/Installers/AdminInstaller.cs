using System.Web.Mvc;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using CouchSurfing.Data;
using Microsoft.Practices.ServiceLocation;

namespace CouchSurfing.CW.Installers
{
    public class AdminInstaller : IWindsorInstaller
    {
        private const string WebAssemblyName = "Geocaching";

        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Classes.FromAssemblyNamed(WebAssemblyName)
                .BasedOn<IController>()
                .LifestyleTransient()
                .Configure(x => x.Named(x.Implementation.Name)));

            container.Register(
                Component.For<IWindsorContainer>().Instance(container),
                Component.For<WindsorControllerFactory>());

            container.Register(Component.For<DataContext>().LifestyleSingleton());
            
            ///////

           
            /////



            
            //////

            var controllerFactory = new WindsorControllerFactory(container.Kernel);
            ControllerBuilder.Current.SetControllerFactory(controllerFactory);
            ServiceLocator.SetLocatorProvider(() => new WindsorServiceLocator(container));
        }
    }
}
