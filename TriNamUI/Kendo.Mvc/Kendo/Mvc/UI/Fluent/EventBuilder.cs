// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.EventBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class EventBuilder : IHideObjectMembers
  {
    protected IDictionary<string, object> Events { get; private set; }

    public EventBuilder(IDictionary<string, object> events) => this.Events = events;

    protected void Handler(string name, string handler) => this.Events[name] = (object) new ClientHandlerDescriptor()
    {
      HandlerName = handler
    };

    protected void Handler(string name, Func<object, object> handler) => this.Events[name] = (object) new ClientHandlerDescriptor()
    {
      TemplateDelegate = handler
    };

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
