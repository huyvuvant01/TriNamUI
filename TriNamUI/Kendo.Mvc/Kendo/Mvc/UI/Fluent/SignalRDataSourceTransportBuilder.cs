// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.SignalRDataSourceTransportBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class SignalRDataSourceTransportBuilder : 
    SignalRDataSourceTransportBuilderBase<SignalRDataSourceTransportBuilder>,
    IHideObjectMembers
  {
    public SignalRDataSourceTransportBuilder(Transport transport)
      : base(transport)
    {
    }

    public SignalRDataSourceTransportBuilder Client(
      Action<SignalRCrudOperationsBuilder> configurator)
    {
      configurator(new SignalRCrudOperationsBuilder((IDictionary<string, object>) this.transport.SignalR.Client));
      return this;
    }

    public SignalRDataSourceTransportBuilder Client(object settings)
    {
      this.transport.SignalR.Client.Merge(settings);
      return this;
    }

    public SignalRDataSourceTransportBuilder Server(
      Action<SignalRCrudOperationsBuilder> configurator)
    {
      configurator(new SignalRCrudOperationsBuilder((IDictionary<string, object>) this.transport.SignalR.Server));
      return this;
    }

    public SignalRDataSourceTransportBuilder Server(object settings)
    {
      this.transport.SignalR.Server.Merge(settings);
      return this;
    }

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
