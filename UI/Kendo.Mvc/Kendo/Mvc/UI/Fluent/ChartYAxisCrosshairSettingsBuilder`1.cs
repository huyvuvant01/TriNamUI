// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ChartYAxisCrosshairSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class ChartYAxisCrosshairSettingsBuilder<T> where T : class
  {
    public ChartYAxisCrosshairSettingsBuilder(ChartYAxisCrosshairSettings<T> container) => this.Container = container;

    protected ChartYAxisCrosshairSettings<T> Container { get; private set; }

    public ChartYAxisCrosshairSettingsBuilder<T> Color(
      string value)
    {
      this.Container.Color = value;
      return this;
    }

    public ChartYAxisCrosshairSettingsBuilder<T> DashType(
      ChartDashType value)
    {
      this.Container.DashType = new ChartDashType?(value);
      return this;
    }

    public ChartYAxisCrosshairSettingsBuilder<T> Opacity(
      double value)
    {
      this.Container.Opacity = new double?(value);
      return this;
    }

    public ChartYAxisCrosshairSettingsBuilder<T> Tooltip(
      Action<ChartYAxisCrosshairTooltipSettingsBuilder<T>> configurator)
    {
      this.Container.Tooltip.Chart = this.Container.Chart;
      configurator(new ChartYAxisCrosshairTooltipSettingsBuilder<T>(this.Container.Tooltip));
      return this;
    }

    public ChartYAxisCrosshairSettingsBuilder<T> Visible(
      bool value)
    {
      this.Container.Visible = new bool?(value);
      return this;
    }

    public ChartYAxisCrosshairSettingsBuilder<T> Visible()
    {
      this.Container.Visible = new bool?(true);
      return this;
    }

    public ChartYAxisCrosshairSettingsBuilder<T> Width(
      double value)
    {
      this.Container.Width = new double?(value);
      return this;
    }
  }
}
