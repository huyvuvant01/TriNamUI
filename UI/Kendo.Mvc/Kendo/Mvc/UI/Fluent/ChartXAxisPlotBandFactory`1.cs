// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ChartXAxisPlotBandFactory`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class ChartXAxisPlotBandFactory<T> where T : class
  {
    public ChartXAxisPlotBandFactory(List<ChartXAxisPlotBand<T>> container) => this.Container = container;

    protected List<ChartXAxisPlotBand<T>> Container { get; private set; }

    public virtual ChartXAxisPlotBandBuilder<T> Add(
      double from,
      double to,
      string color)
    {
      ChartXAxisPlotBand<T> container = new ChartXAxisPlotBand<T>()
      {
        Chart = this.Chart,
        From = (object) from,
        To = (object) to,
        Color = color
      };
      this.Container.Add(container);
      return new ChartXAxisPlotBandBuilder<T>(container);
    }

    public Kendo.Mvc.UI.Chart<T> Chart { get; set; }

    public virtual ChartXAxisPlotBandBuilder<T> Add()
    {
      ChartXAxisPlotBand<T> container = new ChartXAxisPlotBand<T>();
      container.Chart = this.Chart;
      this.Container.Add(container);
      return new ChartXAxisPlotBandBuilder<T>(container);
    }
  }
}
