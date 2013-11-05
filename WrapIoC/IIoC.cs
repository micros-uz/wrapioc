using System;

namespace WrapIoC
{
    public interface IIoC
    {
        void Register<TIntf>(Func<TIntf> func, IoCWorkMode workMode = IoCWorkMode.None);
        void Register<TIntf, TImpl>(IoCWorkMode workMode = IoCWorkMode.None) where TImpl : TIntf;
        void Register<TIntf, TImpl>(string name, IoCWorkMode workMode = IoCWorkMode.None) where TImpl : TIntf;
        T Get<T>();
        T Get<T>(string name);
        T TryGet<T>();
        T TryGet<T>(string name);
        object Get(Type type);
        bool Release(object obj);
    }
}
