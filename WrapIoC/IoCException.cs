using System;

namespace WrapIoC
{
    public class IoCException : Exception
    {
        public IoCException(string message)
            :base(message)
        {

        }
    }
}
