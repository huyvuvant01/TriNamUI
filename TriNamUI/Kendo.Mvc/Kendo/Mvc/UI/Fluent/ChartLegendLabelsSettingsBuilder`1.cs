// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ChartLegendLabelsSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class ChartLegendLabelsSettingsBuilder<T> where T : class
  {
    public ChartLegendLabelsSettingsBuilder(ChartLegendLabelsSettings<T> container) => this.Container = container;

    protected ChartLegendLabelsSettings<T> Container { get; private set; }

    public ChartLegendLabelsSettingsBuilder<T> Color(string value)
    {
      this.Container.Color = value;
      return this;
    }

    public ChartLegendLabelsSettingsBuilder<T> Font(string value)
    {
      this.Container.Font = value;
      return this;
    }

    public ChartLegendLabelsSettingsBuilder<T> Margin(
      Action<ChartLegendLabelsMarginSettingsBuilder<T>> configurator)
    {
      this.Container.Margin.Chart = this.Container.Chart;
      configurator(new ChartLegendLabelsMarginSettingsBuilder<T>(this.Container.Margin));
      return this;
    }

    public ChartLegendLabelsSettingsBuilder<T> Padding(
      Action<ChartLegendLabelsPaddingSettingsBuilder<T>> configurator)
    {
      this.Container.Padding.Chart = this.Container.Chart;
      configurator(new ChartLegendLabelsPaddingSettingsBuilder<T>(this.Container.Padding));
      return this;
    }

    public ChartLegendLabelsSettingsBuilder<T> Template(string value)
    {
      this.Container.Template = value;
      return this;
    }

    public ChartLegendLabelsSettingsBuilder<T> TemplateId(
      string templateId)
    {
      this.Container.TemplateId = templateId;
      return this;
    }
  }
}
