// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ChartXAxisPlotBandBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class ChartXAxisPlotBandBuilder<T> where T : class
  {
    public ChartXAxisPlotBandBuilder(ChartXAxisPlotBand<T> container) => this.Container = container;

    protected ChartXAxisPlotBand<T> Container { get; private set; }

    public ChartXAxisPlotBandBuilder<T> Color(string value)
    {
      this.Container.Color = value;
      return this;
    }

    public ChartXAxisPlotBandBuilder<T> From(object value)
    {
      this.Container.From = value;
      return this;
    }

    public ChartXAxisPlotBandBuilder<T> Label(
      Action<ChartXAxisPlotBandLabelSettingsBuilder<T>> configurator)
    {
      this.Container.Label.Chart = this.Container.Chart;
      configurator(new ChartXAxisPlotBandLabelSettingsBuilder<T>(this.Container.Label));
      return this;
    }

    public ChartXAxisPlotBandBuilder<T> Opacity(double value)
    {
      this.Container.Opacity = new double?(value);
      return this;
    }

    public ChartXAxisPlotBandBuilder<T> To(object value)
    {
      this.Container.To = value;
      return this;
    }
  }
}
