// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.StockChartNavigatorSeriesLabelsSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class StockChartNavigatorSeriesLabelsSettingsBuilder<T> where T : class
  {
    public StockChartNavigatorSeriesLabelsSettingsBuilder(
      StockChartNavigatorSeriesLabelsSettings<T> container)
    {
      this.Container = container;
    }

    protected StockChartNavigatorSeriesLabelsSettings<T> Container { get; private set; }

    public StockChartNavigatorSeriesLabelsSettingsBuilder<T> Background(
      string value)
    {
      this.Container.Background = value;
      return this;
    }

    public StockChartNavigatorSeriesLabelsSettingsBuilder<T> Border(
      Action<StockChartNavigatorSeriesLabelsBorderSettingsBuilder<T>> configurator)
    {
      this.Container.Border.StockChart = this.Container.StockChart;
      configurator(new StockChartNavigatorSeriesLabelsBorderSettingsBuilder<T>(this.Container.Border));
      return this;
    }

    public StockChartNavigatorSeriesLabelsSettingsBuilder<T> Color(
      string value)
    {
      this.Container.Color = value;
      return this;
    }

    public StockChartNavigatorSeriesLabelsSettingsBuilder<T> Font(
      string value)
    {
      this.Container.Font = value;
      return this;
    }

    public StockChartNavigatorSeriesLabelsSettingsBuilder<T> Format(
      string value)
    {
      this.Container.Format = value;
      return this;
    }

    public StockChartNavigatorSeriesLabelsSettingsBuilder<T> Margin(
      double value)
    {
      this.Container.Margin = new double?(value);
      return this;
    }

    public StockChartNavigatorSeriesLabelsSettingsBuilder<T> Padding(
      double value)
    {
      this.Container.Padding = new double?(value);
      return this;
    }

    public StockChartNavigatorSeriesLabelsSettingsBuilder<T> Position(
      string value)
    {
      this.Container.Position = value;
      return this;
    }

    public StockChartNavigatorSeriesLabelsSettingsBuilder<T> Template(
      string value)
    {
      this.Container.Template = value;
      return this;
    }

    public StockChartNavigatorSeriesLabelsSettingsBuilder<T> TemplateId(
      string templateId)
    {
      this.Container.TemplateId = templateId;
      return this;
    }

    public StockChartNavigatorSeriesLabelsSettingsBuilder<T> Visible(
      bool value)
    {
      this.Container.Visible = new bool?(value);
      return this;
    }

    public StockChartNavigatorSeriesLabelsSettingsBuilder<T> Visible()
    {
      this.Container.Visible = new bool?(true);
      return this;
    }
  }
}
