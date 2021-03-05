using Ninject;
using Ninject.Modules;

namespace IndeterminateProgressBarWithNinjectDI.Container.Ninject
{
    public static class DependencyInjector
    {
        private static readonly IKernel Kernel = new StandardKernel();
        
        public static void LoadModules(params INinjectModule[] modules)
        {
            Kernel.Load(modules);
        }

        public static void RegisterSingleton<TInterface, TClass>() where TClass : TInterface
        {
            Kernel.Bind<TInterface>().To<TClass>().InSingletonScope();
        }

        public static void RegisterTransient<TInterface, TClass>() where TClass : TInterface
        {
            Kernel.Bind<TInterface>().To<TClass>().InTransientScope();
        }

        public static TClass Retrieve<TClass>()
        {
            return Kernel.Get<TClass>();
        }
    }
}
