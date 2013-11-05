using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WrapIoC.Ninject;

namespace WrapIoC.Test
{
    [TestClass]
    public class NinjectTest
    {
        [TestMethod]
        public void FuncTest()
        {
            Bootstrapper.Init();

            IoC.Current.Register<ITestInterface>(() => new TestIntfImpl());

            Assert.IsNotNull(IoC.Current.Get<ITestInterface>());
        }

        [TestMethod]
        public void TryGetTest()
        {
            Bootstrapper.Init();

            var intf = IoC.Current.TryGet<ITestInterface>();
            var intf2 = IoC.Current.TryGet(typeof(ITestInterface));

            Assert.AreEqual(intf, default(ITestInterface));
            Assert.AreEqual(intf2, default(ITestInterface));
        }
    }
}
