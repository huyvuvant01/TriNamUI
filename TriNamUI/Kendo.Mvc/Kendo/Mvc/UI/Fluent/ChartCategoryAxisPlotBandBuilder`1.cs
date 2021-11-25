// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ChartCategoryAxisPlotBandBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class ChartCategoryAxisPlotBandBuilder<T> where T : class
  {
    public ChartCategoryAxisPlotBandBuilder(ChartCategoryAxisPlotBand<T> container) => this.Container = container;

    protected ChartCategoryAxisPlotBand<T> Container { get; private set; }

    public ChartCategoryAxisPlotBandBuilder<T> Color(string value)
    {
      this.Container.Color = value;
      return this;
    }

    public ChartCategoryAxisPlotBandBuilder<T> From(object value)
    {
      this.Container.From = value;
      return this;
    }

    public ChartCategoryAxisPlotBandBuilder<T> Label(
      Action<ChartCategoryAxisPlotBandLabelSettingsBuilder<T>> configurator)
    {
      this.Container.Label.Chart = this.Container.Chart;
      configurator(new ChartCategoryAxisPlotBandLabelSettingsBuilder<T>(this.Container.Label));
      return this;
    }

    public ChartCategoryAxisPlotBandBuilder<T> Opacity(double value)
    {
      this.Container.Opacity = new double?(value);
      return this;
    }

    public ChartCategoryAxisPlotBandBuilder<T> To(object value)
    {
      this.Container.To = value;
      return this;
    }
  }
}
