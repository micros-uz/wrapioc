[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(WrapIoC.Ninject.Bootstraper), "Init")]

namespace WrapIoC.Ninject
{
    public static class Bootstraper
    {
        public static void Init()
        {
            IoC.Init(new NinjectIoC());
        }
    }
}
