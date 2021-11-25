// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.Infrastructure.IDependencyInjectionContainer
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.Infrastructure
{
  public interface IDependencyInjectionContainer
  {
    void Register<TService, TArg>(Func<TArg, TService> factory);

    void Register<TService, TArg1, TArg2, TArg3, TArg4>(
      Func<TArg1, TArg2, TArg3, TArg4, TService> factory);

    void Register<TService, TArg1, TArg2, TArg3>(Func<TArg1, TArg2, TArg3, TService> factory);

    void Register<TService, TArg1, TArg2>(Func<TArg1, TArg2, TService> factory);

    void Register<TService>(Func<TService> factory);

    void Register<TService>(
      Func<IDependencyInjectionContainer, TService> factory);

    TService Resolve<TService>();
  }
}
