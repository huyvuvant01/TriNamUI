// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ChartLegendInactiveItemsSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class ChartLegendInactiveItemsSettingsBuilder<T> where T : class
  {
    public ChartLegendInactiveItemsSettingsBuilder(ChartLegendInactiveItemsSettings<T> container) => this.Container = container;

    protected ChartLegendInactiveItemsSettings<T> Container { get; private set; }

    public ChartLegendInactiveItemsSettingsBuilder<T> Labels(
      Action<ChartLegendInactiveItemsLabelsSettingsBuilder<T>> configurator)
    {
      this.Container.Labels.Chart = this.Container.Chart;
      configurator(new ChartLegendInactiveItemsLabelsSettingsBuilder<T>(this.Container.Labels));
      return this;
    }
  }
}
