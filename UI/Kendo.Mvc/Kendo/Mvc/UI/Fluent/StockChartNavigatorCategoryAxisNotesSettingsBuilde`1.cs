// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.StockChartNavigatorCategoryAxisNotesSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class StockChartNavigatorCategoryAxisNotesSettingsBuilder<T> where T : class
  {
    public StockChartNavigatorCategoryAxisNotesSettingsBuilder(
      StockChartNavigatorCategoryAxisNotesSettings<T> container)
    {
      this.Container = container;
    }

    protected StockChartNavigatorCategoryAxisNotesSettings<T> Container { get; private set; }

    public StockChartNavigatorCategoryAxisNotesSettingsBuilder<T> Position(
      string value)
    {
      this.Container.Position = value;
      return this;
    }

    public StockChartNavigatorCategoryAxisNotesSettingsBuilder<T> Icon(
      Action<StockChartNavigatorCategoryAxisNotesIconSettingsBuilder<T>> configurator)
    {
      this.Container.Icon.StockChart = this.Container.StockChart;
      configurator(new StockChartNavigatorCategoryAxisNotesIconSettingsBuilder<T>(this.Container.Icon));
      return this;
    }

    public StockChartNavigatorCategoryAxisNotesSettingsBuilder<T> Label(
      Action<StockChartNavigatorCategoryAxisNotesLabelSettingsBuilder<T>> configurator)
    {
      this.Container.Label.StockChart = this.Container.StockChart;
      configurator(new StockChartNavigatorCategoryAxisNotesLabelSettingsBuilder<T>(this.Container.Label));
      return this;
    }

    public StockChartNavigatorCategoryAxisNotesSettingsBuilder<T> Line(
      Action<StockChartNavigatorCategoryAxisNotesLineSettingsBuilder<T>> configurator)
    {
      this.Container.Line.StockChart = this.Container.StockChart;
      configurator(new StockChartNavigatorCategoryAxisNotesLineSettingsBuilder<T>(this.Container.Line));
      return this;
    }
  }
}
