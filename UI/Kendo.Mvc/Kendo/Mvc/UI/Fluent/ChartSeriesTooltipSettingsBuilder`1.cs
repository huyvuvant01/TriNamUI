// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ChartSeriesTooltipSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class ChartSeriesTooltipSettingsBuilder<T> where T : class
  {
    public ChartSeriesTooltipSettingsBuilder(ChartSeriesTooltipSettings<T> container) => this.Container = container;

    protected ChartSeriesTooltipSettings<T> Container { get; private set; }

    public ChartSeriesTooltipSettingsBuilder<T> Background(
      string value)
    {
      this.Container.Background = value;
      return this;
    }

    public ChartSeriesTooltipSettingsBuilder<T> Border(
      Action<ChartSeriesTooltipBorderSettingsBuilder<T>> configurator)
    {
      this.Container.Border.Chart = this.Container.Chart;
      configurator(new ChartSeriesTooltipBorderSettingsBuilder<T>(this.Container.Border));
      return this;
    }

    public ChartSeriesTooltipSettingsBuilder<T> Color(string value)
    {
      this.Container.Color = value;
      return this;
    }

    public ChartSeriesTooltipSettingsBuilder<T> Font(string value)
    {
      this.Container.Font = value;
      return this;
    }

    public ChartSeriesTooltipSettingsBuilder<T> Format(string value)
    {
      this.Container.Format = value;
      return this;
    }

    public ChartSeriesTooltipSettingsBuilder<T> Padding(
      Action<ChartSeriesTooltipPaddingSettingsBuilder<T>> configurator)
    {
      this.Container.Padding.Chart = this.Container.Chart;
      configurator(new ChartSeriesTooltipPaddingSettingsBuilder<T>(this.Container.Padding));
      return this;
    }

    public ChartSeriesTooltipSettingsBuilder<T> Template(
      string value)
    {
      this.Container.Template = value;
      return this;
    }

    public ChartSeriesTooltipSettingsBuilder<T> TemplateId(
      string templateId)
    {
      this.Container.TemplateId = templateId;
      return this;
    }

    public ChartSeriesTooltipSettingsBuilder<T> Visible(bool value)
    {
      this.Container.Visible = new bool?(value);
      return this;
    }

    public ChartSeriesTooltipSettingsBuilder<T> Visible()
    {
      this.Container.Visible = new bool?(true);
      return this;
    }
  }
}
