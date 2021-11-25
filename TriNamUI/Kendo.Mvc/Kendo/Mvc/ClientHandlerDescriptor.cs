// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.ClientHandlerDescriptor
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System;

namespace Kendo.Mvc
{
  public class ClientHandlerDescriptor
  {
    public Func<object, object> TemplateDelegate { get; set; }

    public string HandlerName { get; set; }

    public bool HasValue() => this.HandlerName.HasValue() || this.TemplateDelegate != null;
  }
}
