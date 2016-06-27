using Castle.Windsor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public static class Castle
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
