using Castle.MicroKernel.Registration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Contracts.Repository;
using Repository;
using Data.Model;

namespace Business
{
    public class RepositoryInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<IVehicleRepository<Vehicle>>().ImplementedBy<VehicleRepository>().LifeStyle.Singleton);
        }
    }
}
