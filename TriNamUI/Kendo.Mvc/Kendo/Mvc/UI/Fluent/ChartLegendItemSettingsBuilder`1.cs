// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ChartLegendItemSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class ChartLegendItemSettingsBuilder<T> where T : class
  {
    public ChartLegendItemSettingsBuilder(ChartLegendItemSettings<T> container) => this.Container = container;

    protected ChartLegendItemSettings<T> Container { get; private set; }

    public ChartLegendItemSettingsBuilder<T> Cursor(string value)
    {
      this.Container.Cursor = value;
      return this;
    }

    public ChartLegendItemSettingsBuilder<T> Visual(string handler)
    {
      this.Container.Visual = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public ChartLegendItemSettingsBuilder<T> Visual(
      Func<object, object> handler)
    {
      this.Container.Visual = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }
  }
}
