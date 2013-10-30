﻿using System;

namespace WrapIoC
{
    public interface IIoC
    {
        void Register<TIntf, TImpl>(IoCWorkMode workMode = IoCWorkMode.None) where TImpl : TIntf;
        void Register<TIntf, TImpl>(string name, IoCWorkMode workMode = IoCWorkMode.None) where TImpl : TIntf;
        T Get<T>();
        T Get<T>(string name);
        object Get(Type type);
        bool Release(object obj);
    }
}