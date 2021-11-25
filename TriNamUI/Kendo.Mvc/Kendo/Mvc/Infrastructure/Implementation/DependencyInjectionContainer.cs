// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.Infrastructure.Implementation.DependencyInjectionContainer
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;

namespace Kendo.Mvc.Infrastructure.Implementation
{
  internal class DependencyInjectionContainer : IDependencyInjectionContainer
  {
    private readonly IDictionary<Type, object> factories;

    public DependencyInjectionContainer() => this.factories = (IDictionary<Type, object>) new Dictionary<Type, object>();

    public TService Resolve<TService>()
    {
      object obj;
      return this.factories.TryGetValue(typeof (TService), out obj) ? ((Func<TService>) obj)() : default (TService);
    }

    public void Register<TService>(Func<TService> factory) => this.factories[typeof (TService)] = (object) factory;

    public void Register<TService>(
      Func<IDependencyInjectionContainer, TService> factory)
    {
      this.factories[typeof (TService)] = (object) (Func<TService>) (() => factory((IDependencyInjectionContainer) this));
    }

    public void Register<TService, TArg>(Func<TArg, TService> factory) => this.factories[typeof (TService)] = (object) (Func<TService>) (() => factory(this.Resolve<TArg>()));

    public void Register<TService, TArg1, TArg2>(Func<TArg1, TArg2, TService> factory) => this.factories[typeof (TService)] = (object) (Func<TService>) (() => factory(this.Resolve<TArg1>(), this.Resolve<TArg2>()));

    public void Register<TService, TArg1, TArg2, TArg3>(Func<TArg1, TArg2, TArg3, TService> factory) => this.factories[typeof (TService)] = (object) (Func<TService>) (() => factory(this.Resolve<TArg1>(), this.Resolve<TArg2>(), this.Resolve<TArg3>()));

    public void Register<TService, TArg1, TArg2, TArg3, TArg4>(
      Func<TArg1, TArg2, TArg3, TArg4, TService> factory)
    {
      this.factories[typeof (TService)] = (object) (Func<TService>) (() => factory(this.Resolve<TArg1>(), this.Resolve<TArg2>(), this.Resolve<TArg3>(), this.Resolve<TArg4>()));
    }
  }
}
