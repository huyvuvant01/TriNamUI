// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ChartYAxisCrosshairTooltipSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class ChartYAxisCrosshairTooltipSettingsBuilder<T> where T : class
  {
    public ChartYAxisCrosshairTooltipSettingsBuilder(ChartYAxisCrosshairTooltipSettings<T> container) => this.Container = container;

    protected ChartYAxisCrosshairTooltipSettings<T> Container { get; private set; }

    public ChartYAxisCrosshairTooltipSettingsBuilder<T> Background(
      string value)
    {
      this.Container.Background = value;
      return this;
    }

    public ChartYAxisCrosshairTooltipSettingsBuilder<T> Border(
      Action<ChartYAxisCrosshairTooltipBorderSettingsBuilder<T>> configurator)
    {
      this.Container.Border.Chart = this.Container.Chart;
      configurator(new ChartYAxisCrosshairTooltipBorderSettingsBuilder<T>(this.Container.Border));
      return this;
    }

    public ChartYAxisCrosshairTooltipSettingsBuilder<T> Color(
      string value)
    {
      this.Container.Color = value;
      return this;
    }

    public ChartYAxisCrosshairTooltipSettingsBuilder<T> Font(
      string value)
    {
      this.Container.Font = value;
      return this;
    }

    public ChartYAxisCrosshairTooltipSettingsBuilder<T> Format(
      string value)
    {
      this.Container.Format = value;
      return this;
    }

    public ChartYAxisCrosshairTooltipSettingsBuilder<T> Padding(
      Action<ChartYAxisCrosshairTooltipPaddingSettingsBuilder<T>> configurator)
    {
      this.Container.Padding.Chart = this.Container.Chart;
      configurator(new ChartYAxisCrosshairTooltipPaddingSettingsBuilder<T>(this.Container.Padding));
      return this;
    }

    public ChartYAxisCrosshairTooltipSettingsBuilder<T> Position(
      string value)
    {
      this.Container.Position = value;
      return this;
    }

    public ChartYAxisCrosshairTooltipSettingsBuilder<T> Template(
      string value)
    {
      this.Container.Template = value;
      return this;
    }

    public ChartYAxisCrosshairTooltipSettingsBuilder<T> TemplateId(
      string templateId)
    {
      this.Container.TemplateId = templateId;
      return this;
    }

    public ChartYAxisCrosshairTooltipSettingsBuilder<T> Visible(
      bool value)
    {
      this.Container.Visible = new bool?(value);
      return this;
    }

    public ChartYAxisCrosshairTooltipSettingsBuilder<T> Visible()
    {
      this.Container.Visible = new bool?(true);
      return this;
    }
  }
}
