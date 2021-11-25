// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ChartSeriesDefaultsSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class ChartSeriesDefaultsSettingsBuilder<T> where T : class
  {
    public ChartSeriesDefaultsSettingsBuilder(ChartSeriesDefaultsSettings<T> container) => this.Container = container;

    protected ChartSeriesDefaultsSettings<T> Container { get; private set; }

    public ChartSeriesBuilder<T> Area() => new ChartSeriesBuilder<T>(this.Container.Area);

    public ChartSeriesBuilder<T> Bar() => new ChartSeriesBuilder<T>(this.Container.Bar);

    public ChartSeriesBuilder<T> BoxPlot() => new ChartSeriesBuilder<T>(this.Container.BoxPlot);

    public ChartSeriesBuilder<T> Bubble() => new ChartSeriesBuilder<T>(this.Container.Bubble);

    public ChartSeriesBuilder<T> Bullet() => new ChartSeriesBuilder<T>(this.Container.Bullet);

    public ChartSeriesBuilder<T> Candlestick() => new ChartSeriesBuilder<T>(this.Container.Candlestick);

    public ChartSeriesBuilder<T> Column() => new ChartSeriesBuilder<T>(this.Container.Column);

    public ChartSeriesBuilder<T> Donut() => new ChartSeriesBuilder<T>(this.Container.Donut);

    public ChartSeriesBuilder<T> Funnel() => new ChartSeriesBuilder<T>(this.Container.Funnel);

    public ChartSeriesBuilder<T> HorizontalWaterfall() => new ChartSeriesBuilder<T>(this.Container.HorizontalWaterfall);

    public ChartSeriesBuilder<T> Line() => new ChartSeriesBuilder<T>(this.Container.Line);

    public ChartSeriesBuilder<T> OHLC() => new ChartSeriesBuilder<T>(this.Container.OHLC);

    public ChartSeriesBuilder<T> Pie() => new ChartSeriesBuilder<T>(this.Container.Pie);

    public ChartSeriesBuilder<T> PolarArea() => new ChartSeriesBuilder<T>(this.Container.PolarArea);

    public ChartSeriesBuilder<T> PolarLine() => new ChartSeriesBuilder<T>(this.Container.PolarLine);

    public ChartSeriesBuilder<T> PolarScatter() => new ChartSeriesBuilder<T>(this.Container.PolarScatter);

    public ChartSeriesBuilder<T> RadarArea() => new ChartSeriesBuilder<T>(this.Container.RadarArea);

    public ChartSeriesBuilder<T> RadarColumn() => new ChartSeriesBuilder<T>(this.Container.RadarColumn);

    public ChartSeriesBuilder<T> RadarLine() => new ChartSeriesBuilder<T>(this.Container.RadarLine);

    public ChartSeriesBuilder<T> RangeArea() => new ChartSeriesBuilder<T>(this.Container.RangeArea);

    public ChartSeriesBuilder<T> RangeBar() => new ChartSeriesBuilder<T>(this.Container.RangeBar);

    public ChartSeriesBuilder<T> RangeColumn() => new ChartSeriesBuilder<T>(this.Container.RangeColumn);

    public ChartSeriesBuilder<T> Scatter() => new ChartSeriesBuilder<T>(this.Container.Scatter);

    public ChartSeriesBuilder<T> ScatterLine() => new ChartSeriesBuilder<T>(this.Container.ScatterLine);

    public ChartSeriesBuilder<T> VerticalArea() => new ChartSeriesBuilder<T>(this.Container.VerticalArea);

    public ChartSeriesBuilder<T> VerticalBoxPlot() => new ChartSeriesBuilder<T>(this.Container.VerticalBoxPlot);

    public ChartSeriesBuilder<T> VerticalBullet() => new ChartSeriesBuilder<T>(this.Container.VerticalBullet);

    public ChartSeriesBuilder<T> VerticalLine() => new ChartSeriesBuilder<T>(this.Container.VerticalLine);

    public ChartSeriesBuilder<T> VerticalRangeArea() => new ChartSeriesBuilder<T>(this.Container.VerticalRangeArea);

    public ChartSeriesBuilder<T> Waterfall() => new ChartSeriesBuilder<T>(this.Container.Waterfall);

    public ChartSeriesBuilder<T> HeatMap() => new ChartSeriesBuilder<T>(this.Container.HeatMap);
  }
}
