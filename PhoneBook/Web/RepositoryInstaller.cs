using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Contracts.Repository;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web
{
    public class RepositoryInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<IPhoneBookRepository>().ImplementedBy<PhoneBookRepository>().LifeStyle.Singleton);
        }
    }
}