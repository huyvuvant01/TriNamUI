// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.StockChartNavigatorSeriesLineSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class StockChartNavigatorSeriesLineSettingsBuilder<T> where T : class
  {
    public StockChartNavigatorSeriesLineSettingsBuilder(
      StockChartNavigatorSeriesLineSettings<T> container)
    {
      this.Container = container;
    }

    protected StockChartNavigatorSeriesLineSettings<T> Container { get; private set; }

    public StockChartNavigatorSeriesLineSettingsBuilder<T> Color(
      string value)
    {
      this.Container.Color = value;
      return this;
    }

    public StockChartNavigatorSeriesLineSettingsBuilder<T> Opacity(
      double value)
    {
      this.Container.Opacity = new double?(value);
      return this;
    }

    public StockChartNavigatorSeriesLineSettingsBuilder<T> Width(
      string value)
    {
      this.Container.Width = value;
      return this;
    }
  }
}
