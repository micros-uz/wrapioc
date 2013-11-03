[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(WrapIoC.Ninject.Bootstrapper), "Init")]

namespace WrapIoC.Ninject
{
    public static class Bootstrapper
    {
        public static void Init()
        {
            IoC.Init(new NinjectIoC());
        }
    }
}
