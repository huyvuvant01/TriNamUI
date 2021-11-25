﻿// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.StockChartNavigatorCategoryAxisLabelsDateFormatsSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class StockChartNavigatorCategoryAxisLabelsDateFormatsSettingsBuilder<T> where T : class
  {
    public StockChartNavigatorCategoryAxisLabelsDateFormatsSettingsBuilder(
      StockChartNavigatorCategoryAxisLabelsDateFormatsSettings<T> container)
    {
      this.Container = container;
    }

    protected StockChartNavigatorCategoryAxisLabelsDateFormatsSettings<T> Container { get; private set; }

    public StockChartNavigatorCategoryAxisLabelsDateFormatsSettingsBuilder<T> Days(
      string value)
    {
      this.Container.Days = value;
      return this;
    }

    public StockChartNavigatorCategoryAxisLabelsDateFormatsSettingsBuilder<T> Hours(
      string value)
    {
      this.Container.Hours = value;
      return this;
    }

    public StockChartNavigatorCategoryAxisLabelsDateFormatsSettingsBuilder<T> Months(
      string value)
    {
      this.Container.Months = value;
      return this;
    }

    public StockChartNavigatorCategoryAxisLabelsDateFormatsSettingsBuilder<T> Weeks(
      string value)
    {
      this.Container.Weeks = value;
      return this;
    }

    public StockChartNavigatorCategoryAxisLabelsDateFormatsSettingsBuilder<T> Years(
      string value)
    {
      this.Container.Years = value;
      return this;
    }
  }
}