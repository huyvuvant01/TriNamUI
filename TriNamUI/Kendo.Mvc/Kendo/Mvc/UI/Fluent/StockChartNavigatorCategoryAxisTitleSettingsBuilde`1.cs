// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.StockChartNavigatorCategoryAxisTitleSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class StockChartNavigatorCategoryAxisTitleSettingsBuilder<T> where T : class
  {
    public StockChartNavigatorCategoryAxisTitleSettingsBuilder(
      StockChartNavigatorCategoryAxisTitleSettings<T> container)
    {
      this.Container = container;
    }

    protected StockChartNavigatorCategoryAxisTitleSettings<T> Container { get; private set; }

    public StockChartNavigatorCategoryAxisTitleSettingsBuilder<T> Background(
      string value)
    {
      this.Container.Background = value;
      return this;
    }

    public StockChartNavigatorCategoryAxisTitleSettingsBuilder<T> Border(
      Action<StockChartNavigatorCategoryAxisTitleBorderSettingsBuilder<T>> configurator)
    {
      this.Container.Border.StockChart = this.Container.StockChart;
      configurator(new StockChartNavigatorCategoryAxisTitleBorderSettingsBuilder<T>(this.Container.Border));
      return this;
    }

    public StockChartNavigatorCategoryAxisTitleSettingsBuilder<T> Color(
      string value)
    {
      this.Container.Color = value;
      return this;
    }

    public StockChartNavigatorCategoryAxisTitleSettingsBuilder<T> Font(
      string value)
    {
      this.Container.Font = value;
      return this;
    }

    public StockChartNavigatorCategoryAxisTitleSettingsBuilder<T> Margin(
      Action<StockChartNavigatorCategoryAxisTitleMarginSettingsBuilder<T>> configurator)
    {
      this.Container.Margin.StockChart = this.Container.StockChart;
      configurator(new StockChartNavigatorCategoryAxisTitleMarginSettingsBuilder<T>(this.Container.Margin));
      return this;
    }

    public StockChartNavigatorCategoryAxisTitleSettingsBuilder<T> Padding(
      Action<StockChartNavigatorCategoryAxisTitlePaddingSettingsBuilder<T>> configurator)
    {
      this.Container.Padding.StockChart = this.Container.StockChart;
      configurator(new StockChartNavigatorCategoryAxisTitlePaddingSettingsBuilder<T>(this.Container.Padding));
      return this;
    }

    public StockChartNavigatorCategoryAxisTitleSettingsBuilder<T> Position(
      string value)
    {
      this.Container.Position = value;
      return this;
    }

    public StockChartNavigatorCategoryAxisTitleSettingsBuilder<T> Rotation(
      double value)
    {
      this.Container.Rotation = new double?(value);
      return this;
    }

    public StockChartNavigatorCategoryAxisTitleSettingsBuilder<T> Text(
      string value)
    {
      this.Container.Text = value;
      return this;
    }

    public StockChartNavigatorCategoryAxisTitleSettingsBuilder<T> Visible(
      bool value)
    {
      this.Container.Visible = new bool?(value);
      return this;
    }
  }
}
