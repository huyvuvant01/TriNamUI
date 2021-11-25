// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.AutoCompleteVirtualSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class AutoCompleteVirtualSettingsBuilder
  {
    public AutoCompleteVirtualSettingsBuilder(AutoCompleteVirtualSettings container) => this.Container = container;

    protected AutoCompleteVirtualSettings Container { get; private set; }

    public AutoCompleteVirtualSettingsBuilder ItemHeight(
      double value)
    {
      this.Container.ItemHeight = new double?(value);
      return this;
    }

    public AutoCompleteVirtualSettingsBuilder MapValueTo(
      string value)
    {
      this.Container.MapValueTo = value;
      return this;
    }

    public AutoCompleteVirtualSettingsBuilder ValueMapper(
      string handler)
    {
      this.Container.ValueMapper = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public AutoCompleteVirtualSettingsBuilder ValueMapper(
      Func<object, object> handler)
    {
      this.Container.ValueMapper = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }
  }
}
