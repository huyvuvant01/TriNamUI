// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ChartXAxisCrosshairTooltipSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class ChartXAxisCrosshairTooltipSettingsBuilder<T> where T : class
  {
    public ChartXAxisCrosshairTooltipSettingsBuilder(ChartXAxisCrosshairTooltipSettings<T> container) => this.Container = container;

    protected ChartXAxisCrosshairTooltipSettings<T> Container { get; private set; }

    public ChartXAxisCrosshairTooltipSettingsBuilder<T> Background(
      string value)
    {
      this.Container.Background = value;
      return this;
    }

    public ChartXAxisCrosshairTooltipSettingsBuilder<T> Border(
      Action<ChartXAxisCrosshairTooltipBorderSettingsBuilder<T>> configurator)
    {
      this.Container.Border.Chart = this.Container.Chart;
      configurator(new ChartXAxisCrosshairTooltipBorderSettingsBuilder<T>(this.Container.Border));
      return this;
    }

    public ChartXAxisCrosshairTooltipSettingsBuilder<T> Color(
      string value)
    {
      this.Container.Color = value;
      return this;
    }

    public ChartXAxisCrosshairTooltipSettingsBuilder<T> Font(
      string value)
    {
      this.Container.Font = value;
      return this;
    }

    public ChartXAxisCrosshairTooltipSettingsBuilder<T> Format(
      string value)
    {
      this.Container.Format = value;
      return this;
    }

    public ChartXAxisCrosshairTooltipSettingsBuilder<T> Padding(
      Action<ChartXAxisCrosshairTooltipPaddingSettingsBuilder<T>> configurator)
    {
      this.Container.Padding.Chart = this.Container.Chart;
      configurator(new ChartXAxisCrosshairTooltipPaddingSettingsBuilder<T>(this.Container.Padding));
      return this;
    }

    public ChartXAxisCrosshairTooltipSettingsBuilder<T> Position(
      string value)
    {
      this.Container.Position = value;
      return this;
    }

    public ChartXAxisCrosshairTooltipSettingsBuilder<T> Template(
      string value)
    {
      this.Container.Template = value;
      return this;
    }

    public ChartXAxisCrosshairTooltipSettingsBuilder<T> TemplateId(
      string templateId)
    {
      this.Container.TemplateId = templateId;
      return this;
    }

    public ChartXAxisCrosshairTooltipSettingsBuilder<T> Visible(
      bool value)
    {
      this.Container.Visible = new bool?(value);
      return this;
    }

    public ChartXAxisCrosshairTooltipSettingsBuilder<T> Visible()
    {
      this.Container.Visible = new bool?(true);
      return this;
    }
  }
}
