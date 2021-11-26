// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ChartLegendTitleSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class ChartLegendTitleSettingsBuilder<T> where T : class
  {
    public ChartLegendTitleSettingsBuilder(ChartLegendTitleSettings<T> container) => this.Container = container;

    protected ChartLegendTitleSettings<T> Container { get; private set; }

    public ChartLegendTitleSettingsBuilder<T> Align(string value)
    {
      this.Container.Align = value;
      return this;
    }

    public ChartLegendTitleSettingsBuilder<T> Background(string value)
    {
      this.Container.Background = value;
      return this;
    }

    public ChartLegendTitleSettingsBuilder<T> Border(
      Action<ChartLegendTitleBorderSettingsBuilder<T>> configurator)
    {
      this.Container.Border.Chart = this.Container.Chart;
      configurator(new ChartLegendTitleBorderSettingsBuilder<T>(this.Container.Border));
      return this;
    }

    public ChartLegendTitleSettingsBuilder<T> Color(string value)
    {
      this.Container.Color = value;
      return this;
    }

    public ChartLegendTitleSettingsBuilder<T> Font(string value)
    {
      this.Container.Font = value;
      return this;
    }

    public ChartLegendTitleSettingsBuilder<T> Margin(
      Action<ChartLegendTitleMarginSettingsBuilder<T>> configurator)
    {
      this.Container.Margin.Chart = this.Container.Chart;
      configurator(new ChartLegendTitleMarginSettingsBuilder<T>(this.Container.Margin));
      return this;
    }

    public ChartLegendTitleSettingsBuilder<T> Padding(
      Action<ChartLegendTitlePaddingSettingsBuilder<T>> configurator)
    {
      this.Container.Padding.Chart = this.Container.Chart;
      configurator(new ChartLegendTitlePaddingSettingsBuilder<T>(this.Container.Padding));
      return this;
    }

    public ChartLegendTitleSettingsBuilder<T> Position(string value)
    {
      this.Container.Position = value;
      return this;
    }

    public ChartLegendTitleSettingsBuilder<T> Text(string value)
    {
      this.Container.Text = value;
      return this;
    }

    public ChartLegendTitleSettingsBuilder<T> Visible(bool value)
    {
      this.Container.Visible = new bool?(value);
      return this;
    }
  }
}
