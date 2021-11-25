// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.StockChartNavigatorCategoryAxisLabelsSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class StockChartNavigatorCategoryAxisLabelsSettingsBuilder<T> where T : class
  {
    public StockChartNavigatorCategoryAxisLabelsSettingsBuilder(
      StockChartNavigatorCategoryAxisLabelsSettings<T> container)
    {
      this.Container = container;
    }

    protected StockChartNavigatorCategoryAxisLabelsSettings<T> Container { get; private set; }

    public StockChartNavigatorCategoryAxisLabelsSettingsBuilder<T> Background(
      string value)
    {
      this.Container.Background = value;
      return this;
    }

    public StockChartNavigatorCategoryAxisLabelsSettingsBuilder<T> Border(
      Action<StockChartNavigatorCategoryAxisLabelsBorderSettingsBuilder<T>> configurator)
    {
      this.Container.Border.StockChart = this.Container.StockChart;
      configurator(new StockChartNavigatorCategoryAxisLabelsBorderSettingsBuilder<T>(this.Container.Border));
      return this;
    }

    public StockChartNavigatorCategoryAxisLabelsSettingsBuilder<T> Color(
      string value)
    {
      this.Container.Color = value;
      return this;
    }

    public StockChartNavigatorCategoryAxisLabelsSettingsBuilder<T> Culture(
      string value)
    {
      this.Container.Culture = value;
      return this;
    }

    public StockChartNavigatorCategoryAxisLabelsSettingsBuilder<T> DateFormats(
      Action<StockChartNavigatorCategoryAxisLabelsDateFormatsSettingsBuilder<T>> configurator)
    {
      this.Container.DateFormats.StockChart = this.Container.StockChart;
      configurator(new StockChartNavigatorCategoryAxisLabelsDateFormatsSettingsBuilder<T>(this.Container.DateFormats));
      return this;
    }

    public StockChartNavigatorCategoryAxisLabelsSettingsBuilder<T> Font(
      string value)
    {
      this.Container.Font = value;
      return this;
    }

    public StockChartNavigatorCategoryAxisLabelsSettingsBuilder<T> Format(
      string value)
    {
      this.Container.Format = value;
      return this;
    }

    public StockChartNavigatorCategoryAxisLabelsSettingsBuilder<T> Margin(
      Action<StockChartNavigatorCategoryAxisLabelsMarginSettingsBuilder<T>> configurator)
    {
      this.Container.Margin.StockChart = this.Container.StockChart;
      configurator(new StockChartNavigatorCategoryAxisLabelsMarginSettingsBuilder<T>(this.Container.Margin));
      return this;
    }

    public StockChartNavigatorCategoryAxisLabelsSettingsBuilder<T> Mirror(
      bool value)
    {
      this.Container.Mirror = new bool?(value);
      return this;
    }

    public StockChartNavigatorCategoryAxisLabelsSettingsBuilder<T> Mirror()
    {
      this.Container.Mirror = new bool?(true);
      return this;
    }

    public StockChartNavigatorCategoryAxisLabelsSettingsBuilder<T> Padding(
      Action<StockChartNavigatorCategoryAxisLabelsPaddingSettingsBuilder<T>> configurator)
    {
      this.Container.Padding.StockChart = this.Container.StockChart;
      configurator(new StockChartNavigatorCategoryAxisLabelsPaddingSettingsBuilder<T>(this.Container.Padding));
      return this;
    }

    public StockChartNavigatorCategoryAxisLabelsSettingsBuilder<T> Rotation(
      double value)
    {
      this.Container.Rotation = new double?(value);
      return this;
    }

    public StockChartNavigatorCategoryAxisLabelsSettingsBuilder<T> Skip(
      double value)
    {
      this.Container.Skip = new double?(value);
      return this;
    }

    public StockChartNavigatorCategoryAxisLabelsSettingsBuilder<T> Step(
      double value)
    {
      this.Container.Step = new double?(value);
      return this;
    }

    public StockChartNavigatorCategoryAxisLabelsSettingsBuilder<T> Template(
      string value)
    {
      this.Container.Template = value;
      return this;
    }

    public StockChartNavigatorCategoryAxisLabelsSettingsBuilder<T> TemplateId(
      string templateId)
    {
      this.Container.TemplateId = templateId;
      return this;
    }

    public StockChartNavigatorCategoryAxisLabelsSettingsBuilder<T> Visible(
      bool value)
    {
      this.Container.Visible = new bool?(value);
      return this;
    }
  }
}
