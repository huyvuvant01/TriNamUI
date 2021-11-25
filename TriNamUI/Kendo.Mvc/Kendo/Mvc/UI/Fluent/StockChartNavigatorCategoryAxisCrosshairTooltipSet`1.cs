// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.StockChartNavigatorCategoryAxisCrosshairTooltipSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class StockChartNavigatorCategoryAxisCrosshairTooltipSettingsBuilder<T> where T : class
  {
    public StockChartNavigatorCategoryAxisCrosshairTooltipSettingsBuilder(
      StockChartNavigatorCategoryAxisCrosshairTooltipSettings<T> container)
    {
      this.Container = container;
    }

    protected StockChartNavigatorCategoryAxisCrosshairTooltipSettings<T> Container { get; private set; }

    public StockChartNavigatorCategoryAxisCrosshairTooltipSettingsBuilder<T> Background(
      string value)
    {
      this.Container.Background = value;
      return this;
    }

    public StockChartNavigatorCategoryAxisCrosshairTooltipSettingsBuilder<T> Border(
      Action<StockChartNavigatorCategoryAxisCrosshairTooltipBorderSettingsBuilder<T>> configurator)
    {
      this.Container.Border.StockChart = this.Container.StockChart;
      configurator(new StockChartNavigatorCategoryAxisCrosshairTooltipBorderSettingsBuilder<T>(this.Container.Border));
      return this;
    }

    public StockChartNavigatorCategoryAxisCrosshairTooltipSettingsBuilder<T> Color(
      string value)
    {
      this.Container.Color = value;
      return this;
    }

    public StockChartNavigatorCategoryAxisCrosshairTooltipSettingsBuilder<T> Font(
      string value)
    {
      this.Container.Font = value;
      return this;
    }

    public StockChartNavigatorCategoryAxisCrosshairTooltipSettingsBuilder<T> Format(
      string value)
    {
      this.Container.Format = value;
      return this;
    }

    public StockChartNavigatorCategoryAxisCrosshairTooltipSettingsBuilder<T> Padding(
      Action<StockChartNavigatorCategoryAxisCrosshairTooltipPaddingSettingsBuilder<T>> configurator)
    {
      this.Container.Padding.StockChart = this.Container.StockChart;
      configurator(new StockChartNavigatorCategoryAxisCrosshairTooltipPaddingSettingsBuilder<T>(this.Container.Padding));
      return this;
    }

    public StockChartNavigatorCategoryAxisCrosshairTooltipSettingsBuilder<T> Template(
      string value)
    {
      this.Container.Template = value;
      return this;
    }

    public StockChartNavigatorCategoryAxisCrosshairTooltipSettingsBuilder<T> TemplateId(
      string templateId)
    {
      this.Container.TemplateId = templateId;
      return this;
    }

    public StockChartNavigatorCategoryAxisCrosshairTooltipSettingsBuilder<T> Visible(
      bool value)
    {
      this.Container.Visible = new bool?(value);
      return this;
    }

    public StockChartNavigatorCategoryAxisCrosshairTooltipSettingsBuilder<T> Visible()
    {
      this.Container.Visible = new bool?(true);
      return this;
    }
  }
}
