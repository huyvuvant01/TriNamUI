// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ChartCategoryAxisCrosshairTooltipSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class ChartCategoryAxisCrosshairTooltipSettingsBuilder<T> where T : class
  {
    public ChartCategoryAxisCrosshairTooltipSettingsBuilder(
      ChartCategoryAxisCrosshairTooltipSettings<T> container)
    {
      this.Container = container;
    }

    protected ChartCategoryAxisCrosshairTooltipSettings<T> Container { get; private set; }

    public ChartCategoryAxisCrosshairTooltipSettingsBuilder<T> Background(
      string value)
    {
      this.Container.Background = value;
      return this;
    }

    public ChartCategoryAxisCrosshairTooltipSettingsBuilder<T> Border(
      Action<ChartCategoryAxisCrosshairTooltipBorderSettingsBuilder<T>> configurator)
    {
      this.Container.Border.Chart = this.Container.Chart;
      configurator(new ChartCategoryAxisCrosshairTooltipBorderSettingsBuilder<T>(this.Container.Border));
      return this;
    }

    public ChartCategoryAxisCrosshairTooltipSettingsBuilder<T> Color(
      string value)
    {
      this.Container.Color = value;
      return this;
    }

    public ChartCategoryAxisCrosshairTooltipSettingsBuilder<T> Font(
      string value)
    {
      this.Container.Font = value;
      return this;
    }

    public ChartCategoryAxisCrosshairTooltipSettingsBuilder<T> Format(
      string value)
    {
      this.Container.Format = value;
      return this;
    }

    public ChartCategoryAxisCrosshairTooltipSettingsBuilder<T> Padding(
      Action<ChartCategoryAxisCrosshairTooltipPaddingSettingsBuilder<T>> configurator)
    {
      this.Container.Padding.Chart = this.Container.Chart;
      configurator(new ChartCategoryAxisCrosshairTooltipPaddingSettingsBuilder<T>(this.Container.Padding));
      return this;
    }

    public ChartCategoryAxisCrosshairTooltipSettingsBuilder<T> Position(
      string value)
    {
      this.Container.Position = value;
      return this;
    }

    public ChartCategoryAxisCrosshairTooltipSettingsBuilder<T> Template(
      string value)
    {
      this.Container.Template = value;
      return this;
    }

    public ChartCategoryAxisCrosshairTooltipSettingsBuilder<T> TemplateId(
      string templateId)
    {
      this.Container.TemplateId = templateId;
      return this;
    }

    public ChartCategoryAxisCrosshairTooltipSettingsBuilder<T> Visible(
      bool value)
    {
      this.Container.Visible = new bool?(value);
      return this;
    }

    public ChartCategoryAxisCrosshairTooltipSettingsBuilder<T> Visible()
    {
      this.Container.Visible = new bool?(true);
      return this;
    }
  }
}
