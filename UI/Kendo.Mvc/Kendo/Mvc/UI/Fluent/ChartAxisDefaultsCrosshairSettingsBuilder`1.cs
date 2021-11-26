// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ChartAxisDefaultsCrosshairSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class ChartAxisDefaultsCrosshairSettingsBuilder<T> where T : class
  {
    public ChartAxisDefaultsCrosshairSettingsBuilder(ChartAxisDefaultsCrosshairSettings<T> container) => this.Container = container;

    protected ChartAxisDefaultsCrosshairSettings<T> Container { get; private set; }

    public ChartAxisDefaultsCrosshairSettingsBuilder<T> Color(
      string value)
    {
      this.Container.Color = value;
      return this;
    }

    public ChartAxisDefaultsCrosshairSettingsBuilder<T> DashType(
      ChartDashType value)
    {
      this.Container.DashType = new ChartDashType?(value);
      return this;
    }

    public ChartAxisDefaultsCrosshairSettingsBuilder<T> Opacity(
      double value)
    {
      this.Container.Opacity = new double?(value);
      return this;
    }

    public ChartAxisDefaultsCrosshairSettingsBuilder<T> Tooltip(
      Action<ChartAxisDefaultsCrosshairTooltipSettingsBuilder<T>> configurator)
    {
      this.Container.Tooltip.Chart = this.Container.Chart;
      configurator(new ChartAxisDefaultsCrosshairTooltipSettingsBuilder<T>(this.Container.Tooltip));
      return this;
    }

    public ChartAxisDefaultsCrosshairSettingsBuilder<T> Visible(
      bool value)
    {
      this.Container.Visible = new bool?(value);
      return this;
    }

    public ChartAxisDefaultsCrosshairSettingsBuilder<T> Visible()
    {
      this.Container.Visible = new bool?(true);
      return this;
    }

    public ChartAxisDefaultsCrosshairSettingsBuilder<T> Width(
      double value)
    {
      this.Container.Width = new double?(value);
      return this;
    }
  }
}
