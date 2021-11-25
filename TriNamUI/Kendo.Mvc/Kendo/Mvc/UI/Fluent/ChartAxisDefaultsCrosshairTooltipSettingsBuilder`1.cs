// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ChartAxisDefaultsCrosshairTooltipSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class ChartAxisDefaultsCrosshairTooltipSettingsBuilder<T> where T : class
  {
    public ChartAxisDefaultsCrosshairTooltipSettingsBuilder(
      ChartAxisDefaultsCrosshairTooltipSettings<T> container)
    {
      this.Container = container;
    }

    protected ChartAxisDefaultsCrosshairTooltipSettings<T> Container { get; private set; }

    public ChartAxisDefaultsCrosshairTooltipSettingsBuilder<T> Background(
      string value)
    {
      this.Container.Background = value;
      return this;
    }

    public ChartAxisDefaultsCrosshairTooltipSettingsBuilder<T> Border(
      Action<ChartAxisDefaultsCrosshairTooltipBorderSettingsBuilder<T>> configurator)
    {
      this.Container.Border.Chart = this.Container.Chart;
      configurator(new ChartAxisDefaultsCrosshairTooltipBorderSettingsBuilder<T>(this.Container.Border));
      return this;
    }

    public ChartAxisDefaultsCrosshairTooltipSettingsBuilder<T> Color(
      string value)
    {
      this.Container.Color = value;
      return this;
    }

    public ChartAxisDefaultsCrosshairTooltipSettingsBuilder<T> Font(
      string value)
    {
      this.Container.Font = value;
      return this;
    }

    public ChartAxisDefaultsCrosshairTooltipSettingsBuilder<T> Format(
      string value)
    {
      this.Container.Format = value;
      return this;
    }

    public ChartAxisDefaultsCrosshairTooltipSettingsBuilder<T> Padding(
      Action<ChartAxisDefaultsCrosshairTooltipPaddingSettingsBuilder<T>> configurator)
    {
      this.Container.Padding.Chart = this.Container.Chart;
      configurator(new ChartAxisDefaultsCrosshairTooltipPaddingSettingsBuilder<T>(this.Container.Padding));
      return this;
    }

    public ChartAxisDefaultsCrosshairTooltipSettingsBuilder<T> Template(
      string value)
    {
      this.Container.Template = value;
      return this;
    }

    public ChartAxisDefaultsCrosshairTooltipSettingsBuilder<T> TemplateId(
      string templateId)
    {
      this.Container.TemplateId = templateId;
      return this;
    }

    public ChartAxisDefaultsCrosshairTooltipSettingsBuilder<T> Visible(
      bool value)
    {
      this.Container.Visible = new bool?(value);
      return this;
    }

    public ChartAxisDefaultsCrosshairTooltipSettingsBuilder<T> Visible()
    {
      this.Container.Visible = new bool?(true);
      return this;
    }
  }
}
