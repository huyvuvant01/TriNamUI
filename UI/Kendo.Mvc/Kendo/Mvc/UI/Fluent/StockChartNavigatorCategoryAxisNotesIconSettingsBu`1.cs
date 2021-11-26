// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.StockChartNavigatorCategoryAxisNotesIconSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class StockChartNavigatorCategoryAxisNotesIconSettingsBuilder<T> where T : class
  {
    public StockChartNavigatorCategoryAxisNotesIconSettingsBuilder(
      StockChartNavigatorCategoryAxisNotesIconSettings<T> container)
    {
      this.Container = container;
    }

    protected StockChartNavigatorCategoryAxisNotesIconSettings<T> Container { get; private set; }

    public StockChartNavigatorCategoryAxisNotesIconSettingsBuilder<T> Background(
      string value)
    {
      this.Container.Background = value;
      return this;
    }

    public StockChartNavigatorCategoryAxisNotesIconSettingsBuilder<T> Border(
      Action<StockChartNavigatorCategoryAxisNotesIconBorderSettingsBuilder<T>> configurator)
    {
      this.Container.Border.StockChart = this.Container.StockChart;
      configurator(new StockChartNavigatorCategoryAxisNotesIconBorderSettingsBuilder<T>(this.Container.Border));
      return this;
    }

    public StockChartNavigatorCategoryAxisNotesIconSettingsBuilder<T> Size(
      double value)
    {
      this.Container.Size = new double?(value);
      return this;
    }

    public StockChartNavigatorCategoryAxisNotesIconSettingsBuilder<T> Type(
      string value)
    {
      this.Container.Type = value;
      return this;
    }

    public StockChartNavigatorCategoryAxisNotesIconSettingsBuilder<T> Visible(
      bool value)
    {
      this.Container.Visible = new bool?(value);
      return this;
    }
  }
}
