// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ChartValueAxisCrosshairTooltipSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class ChartValueAxisCrosshairTooltipSettingsBuilder<T> where T : class
  {
    public ChartValueAxisCrosshairTooltipSettingsBuilder(
      ChartValueAxisCrosshairTooltipSettings<T> container)
    {
      this.Container = container;
    }

    protected ChartValueAxisCrosshairTooltipSettings<T> Container { get; private set; }

    public ChartValueAxisCrosshairTooltipSettingsBuilder<T> Background(
      string value)
    {
      this.Container.Background = value;
      return this;
    }

    public ChartValueAxisCrosshairTooltipSettingsBuilder<T> Border(
      Action<ChartValueAxisCrosshairTooltipBorderSettingsBuilder<T>> configurator)
    {
      this.Container.Border.Chart = this.Container.Chart;
      configurator(new ChartValueAxisCrosshairTooltipBorderSettingsBuilder<T>(this.Container.Border));
      return this;
    }

    public ChartValueAxisCrosshairTooltipSettingsBuilder<T> Color(
      string value)
    {
      this.Container.Color = value;
      return this;
    }

    public ChartValueAxisCrosshairTooltipSettingsBuilder<T> Font(
      string value)
    {
      this.Container.Font = value;
      return this;
    }

    public ChartValueAxisCrosshairTooltipSettingsBuilder<T> Format(
      string value)
    {
      this.Container.Format = value;
      return this;
    }

    public ChartValueAxisCrosshairTooltipSettingsBuilder<T> Padding(
      Action<ChartValueAxisCrosshairTooltipPaddingSettingsBuilder<T>> configurator)
    {
      this.Container.Padding.Chart = this.Container.Chart;
      configurator(new ChartValueAxisCrosshairTooltipPaddingSettingsBuilder<T>(this.Container.Padding));
      return this;
    }

    public ChartValueAxisCrosshairTooltipSettingsBuilder<T> Position(
      string value)
    {
      this.Container.Position = value;
      return this;
    }

    public ChartValueAxisCrosshairTooltipSettingsBuilder<T> Template(
      string value)
    {
      this.Container.Template = value;
      return this;
    }

    public ChartValueAxisCrosshairTooltipSettingsBuilder<T> TemplateId(
      string templateId)
    {
      this.Container.TemplateId = templateId;
      return this;
    }

    public ChartValueAxisCrosshairTooltipSettingsBuilder<T> Visible(
      bool value)
    {
      this.Container.Visible = new bool?(value);
      return this;
    }

    public ChartValueAxisCrosshairTooltipSettingsBuilder<T> Visible()
    {
      this.Container.Visible = new bool?(true);
      return this;
    }
  }
}
