using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Contracts.Repository;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web
{
    public static class IoC
    {
        private static IWindsorContainer _container;

        public static void Initialize()
        {
            _container = new WindsorContainer().Install(new RepositoryInstaller());
        }

        public static T Resolve<T>()
        {
            return _container.Resolve<T>();
        }
    }
}