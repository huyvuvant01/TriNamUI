// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.StockChartNavigatorCategoryAxisSettingsPlotBandFactory`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class StockChartNavigatorCategoryAxisSettingsPlotBandFactory<T> where T : class
  {
    public StockChartNavigatorCategoryAxisSettingsPlotBandFactory(
      List<StockChartNavigatorCategoryAxisSettingsPlotBand<T>> container)
    {
      this.Container = container;
    }

    protected List<StockChartNavigatorCategoryAxisSettingsPlotBand<T>> Container { get; private set; }

    public Kendo.Mvc.UI.StockChart<T> StockChart { get; set; }

    public virtual StockChartNavigatorCategoryAxisSettingsPlotBandBuilder<T> Add()
    {
      StockChartNavigatorCategoryAxisSettingsPlotBand<T> container = new StockChartNavigatorCategoryAxisSettingsPlotBand<T>();
      container.StockChart = this.StockChart;
      this.Container.Add(container);
      return new StockChartNavigatorCategoryAxisSettingsPlotBandBuilder<T>(container);
    }
  }
}
