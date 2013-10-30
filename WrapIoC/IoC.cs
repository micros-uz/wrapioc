namespace WrapIoC
{
    public class IoC 
    {
        public static void Init(IIoC impl)
        {
            Current = impl;
        }
        
        public static IIoC Current
        {
            get;
            private set;
        }
    }
}
