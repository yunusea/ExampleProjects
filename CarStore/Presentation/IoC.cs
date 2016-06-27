using Castle.Windsor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Presentation
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