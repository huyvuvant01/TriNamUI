// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.StockChartNavigatorSeriesTooltipSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class StockChartNavigatorSeriesTooltipSettingsBuilder<T> where T : class
  {
    public StockChartNavigatorSeriesTooltipSettingsBuilder(
      StockChartNavigatorSeriesTooltipSettings<T> container)
    {
      this.Container = container;
    }

    protected StockChartNavigatorSeriesTooltipSettings<T> Container { get; private set; }

    public StockChartNavigatorSeriesTooltipSettingsBuilder<T> Background(
      string value)
    {
      this.Container.Background = value;
      return this;
    }

    public StockChartNavigatorSeriesTooltipSettingsBuilder<T> Border(
      Action<StockChartNavigatorSeriesTooltipBorderSettingsBuilder<T>> configurator)
    {
      this.Container.Border.StockChart = this.Container.StockChart;
      configurator(new StockChartNavigatorSeriesTooltipBorderSettingsBuilder<T>(this.Container.Border));
      return this;
    }

    public StockChartNavigatorSeriesTooltipSettingsBuilder<T> Color(
      string value)
    {
      this.Container.Color = value;
      return this;
    }

    public StockChartNavigatorSeriesTooltipSettingsBuilder<T> Font(
      string value)
    {
      this.Container.Font = value;
      return this;
    }

    public StockChartNavigatorSeriesTooltipSettingsBuilder<T> Format(
      string value)
    {
      this.Container.Format = value;
      return this;
    }

    public StockChartNavigatorSeriesTooltipSettingsBuilder<T> Padding(
      double value)
    {
      this.Container.Padding = new double?(value);
      return this;
    }

    public StockChartNavigatorSeriesTooltipSettingsBuilder<T> Template(
      string value)
    {
      this.Container.Template = value;
      return this;
    }

    public StockChartNavigatorSeriesTooltipSettingsBuilder<T> TemplateId(
      string templateId)
    {
      this.Container.TemplateId = templateId;
      return this;
    }

    public StockChartNavigatorSeriesTooltipSettingsBuilder<T> Visible(
      bool value)
    {
      this.Container.Visible = new bool?(value);
      return this;
    }

    public StockChartNavigatorSeriesTooltipSettingsBuilder<T> Visible()
    {
      this.Container.Visible = new bool?(true);
      return this;
    }
  }
}
