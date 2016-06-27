using System;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Data.Model;
using Contracts.Repository;
using Repository;

namespace Presentation
{
    internal class RepositoryInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<IVehicleRepository<Vehicle>>().ImplementedBy<VehicleRepository>().LifeStyle.Singleton);
        }
    }
}