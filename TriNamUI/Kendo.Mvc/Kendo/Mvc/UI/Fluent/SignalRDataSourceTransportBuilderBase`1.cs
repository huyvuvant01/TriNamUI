// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.SignalRDataSourceTransportBuilderBase`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public abstract class SignalRDataSourceTransportBuilderBase<TTransportBuilder> : IHideObjectMembers
    where TTransportBuilder : SignalRDataSourceTransportBuilderBase<TTransportBuilder>
  {
    protected readonly Transport transport;

    public SignalRDataSourceTransportBuilderBase(Transport transport) => this.transport = transport;

    public TTransportBuilder ParameterMap(Func<object, object> handler)
    {
      this.transport.ParameterMap.TemplateDelegate = handler;
      return (TTransportBuilder) this;
    }

    public TTransportBuilder ParameterMap(string handler)
    {
      this.transport.ParameterMap.HandlerName = handler;
      return (TTransportBuilder) this;
    }

    public TTransportBuilder Hub(Func<object, object> handler)
    {
      this.transport.SignalR.Hub.TemplateDelegate = handler;
      return (TTransportBuilder) this;
    }

    public TTransportBuilder Hub(string handler)
    {
      this.transport.SignalR.Hub.HandlerName = handler;
      return (TTransportBuilder) this;
    }

    public TTransportBuilder Promise(Func<object, object> handler)
    {
      this.transport.SignalR.Promise.TemplateDelegate = handler;
      return (TTransportBuilder) this;
    }

    public TTransportBuilder Promise(string handler)
    {
      this.transport.SignalR.Promise.HandlerName = handler;
      return (TTransportBuilder) this;
    }

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
