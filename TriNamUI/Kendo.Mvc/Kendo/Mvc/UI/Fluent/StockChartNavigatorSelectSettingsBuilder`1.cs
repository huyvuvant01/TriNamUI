// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.StockChartNavigatorSelectSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class StockChartNavigatorSelectSettingsBuilder<T> where T : class
  {
    public StockChartNavigatorSelectSettingsBuilder(StockChartNavigatorSelectSettings<T> container) => this.Container = container;

    protected StockChartNavigatorSelectSettings<T> Container { get; private set; }

    public StockChartNavigatorSelectSettingsBuilder<T> From(
      DateTime value)
    {
      this.Container.From = new DateTime?(value);
      return this;
    }

    public StockChartNavigatorSelectSettingsBuilder<T> Mousewheel(
      Action<StockChartNavigatorSelectMousewheelSettingsBuilder<T>> configurator)
    {
      this.Container.Mousewheel.Enabled = new bool?(true);
      this.Container.Mousewheel.StockChart = this.Container.StockChart;
      configurator(new StockChartNavigatorSelectMousewheelSettingsBuilder<T>(this.Container.Mousewheel));
      return this;
    }

    public StockChartNavigatorSelectSettingsBuilder<T> Mousewheel(
      bool enabled)
    {
      this.Container.Mousewheel.Enabled = new bool?(enabled);
      return this;
    }

    public StockChartNavigatorSelectSettingsBuilder<T> To(
      DateTime value)
    {
      this.Container.To = new DateTime?(value);
      return this;
    }
  }
}
