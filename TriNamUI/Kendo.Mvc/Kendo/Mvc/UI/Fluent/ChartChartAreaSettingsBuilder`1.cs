// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ChartChartAreaSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class ChartChartAreaSettingsBuilder<T> where T : class
  {
    public ChartChartAreaSettingsBuilder(ChartChartAreaSettings<T> container) => this.Container = container;

    protected ChartChartAreaSettings<T> Container { get; private set; }

    public ChartChartAreaSettingsBuilder<T> Margin(int value)
    {
      this.Container.Margin.Top = new double?((double) value);
      this.Container.Margin.Right = new double?((double) value);
      this.Container.Margin.Bottom = new double?((double) value);
      this.Container.Margin.Left = new double?((double) value);
      return this;
    }

    public ChartChartAreaSettingsBuilder<T> Background(string value)
    {
      this.Container.Background = value;
      return this;
    }

    public ChartChartAreaSettingsBuilder<T> Border(
      Action<ChartChartAreaBorderSettingsBuilder<T>> configurator)
    {
      this.Container.Border.Chart = this.Container.Chart;
      configurator(new ChartChartAreaBorderSettingsBuilder<T>(this.Container.Border));
      return this;
    }

    public ChartChartAreaSettingsBuilder<T> Height(double value)
    {
      this.Container.Height = new double?(value);
      return this;
    }

    public ChartChartAreaSettingsBuilder<T> Margin(
      Action<ChartChartAreaMarginSettingsBuilder<T>> configurator)
    {
      this.Container.Margin.Chart = this.Container.Chart;
      configurator(new ChartChartAreaMarginSettingsBuilder<T>(this.Container.Margin));
      return this;
    }

    public ChartChartAreaSettingsBuilder<T> Opacity(double value)
    {
      this.Container.Opacity = new double?(value);
      return this;
    }

    public ChartChartAreaSettingsBuilder<T> Width(double value)
    {
      this.Container.Width = new double?(value);
      return this;
    }
  }
}
