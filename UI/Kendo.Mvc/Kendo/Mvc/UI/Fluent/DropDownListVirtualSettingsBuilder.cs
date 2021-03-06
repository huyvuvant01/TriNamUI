// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.DropDownListVirtualSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class DropDownListVirtualSettingsBuilder
  {
    public DropDownListVirtualSettingsBuilder(DropDownListVirtualSettings container) => this.Container = container;

    protected DropDownListVirtualSettings Container { get; private set; }

    public DropDownListVirtualSettingsBuilder ItemHeight(
      double value)
    {
      this.Container.ItemHeight = new double?(value);
      return this;
    }

    public DropDownListVirtualSettingsBuilder MapValueTo(
      string value)
    {
      this.Container.MapValueTo = value;
      return this;
    }

    public DropDownListVirtualSettingsBuilder ValueMapper(
      string handler)
    {
      this.Container.ValueMapper = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public DropDownListVirtualSettingsBuilder ValueMapper(
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
