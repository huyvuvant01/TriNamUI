// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ChartLegendSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class ChartLegendSettingsBuilder<T> where T : class
  {
    public ChartLegendSettingsBuilder(ChartLegendSettings<T> container) => this.Container = container;

    protected ChartLegendSettings<T> Container { get; private set; }

    public ChartLegendSettingsBuilder<T> Background(string value)
    {
      this.Container.Background = value;
      return this;
    }

    public ChartLegendSettingsBuilder<T> Border(
      Action<ChartLegendBorderSettingsBuilder<T>> configurator)
    {
      this.Container.Border.Chart = this.Container.Chart;
      configurator(new ChartLegendBorderSettingsBuilder<T>(this.Container.Border));
      return this;
    }

    public ChartLegendSettingsBuilder<T> Height(double value)
    {
      this.Container.Height = new double?(value);
      return this;
    }

    public ChartLegendSettingsBuilder<T> InactiveItems(
      Action<ChartLegendInactiveItemsSettingsBuilder<T>> configurator)
    {
      this.Container.InactiveItems.Chart = this.Container.Chart;
      configurator(new ChartLegendInactiveItemsSettingsBuilder<T>(this.Container.InactiveItems));
      return this;
    }

    public ChartLegendSettingsBuilder<T> Item(
      Action<ChartLegendItemSettingsBuilder<T>> configurator)
    {
      this.Container.Item.Chart = this.Container.Chart;
      configurator(new ChartLegendItemSettingsBuilder<T>(this.Container.Item));
      return this;
    }

    public ChartLegendSettingsBuilder<T> Labels(
      Action<ChartLegendLabelsSettingsBuilder<T>> configurator)
    {
      this.Container.Labels.Chart = this.Container.Chart;
      configurator(new ChartLegendLabelsSettingsBuilder<T>(this.Container.Labels));
      return this;
    }

    public ChartLegendSettingsBuilder<T> Margin(
      Action<ChartLegendMarginSettingsBuilder<T>> configurator)
    {
      this.Container.Margin.Chart = this.Container.Chart;
      configurator(new ChartLegendMarginSettingsBuilder<T>(this.Container.Margin));
      return this;
    }

    public ChartLegendSettingsBuilder<T> OffsetX(double value)
    {
      this.Container.OffsetX = new double?(value);
      return this;
    }

    public ChartLegendSettingsBuilder<T> OffsetY(double value)
    {
      this.Container.OffsetY = new double?(value);
      return this;
    }

    public ChartLegendSettingsBuilder<T> Padding(
      Action<ChartLegendPaddingSettingsBuilder<T>> configurator)
    {
      this.Container.Padding.Chart = this.Container.Chart;
      configurator(new ChartLegendPaddingSettingsBuilder<T>(this.Container.Padding));
      return this;
    }

    public ChartLegendSettingsBuilder<T> Reverse(bool value)
    {
      this.Container.Reverse = new bool?(value);
      return this;
    }

    public ChartLegendSettingsBuilder<T> Reverse()
    {
      this.Container.Reverse = new bool?(true);
      return this;
    }

    public ChartLegendSettingsBuilder<T> Spacing(double value)
    {
      this.Container.Spacing = new double?(value);
      return this;
    }

    public ChartLegendSettingsBuilder<T> Title(
      Action<ChartLegendTitleSettingsBuilder<T>> configurator)
    {
      this.Container.Title.Chart = this.Container.Chart;
      configurator(new ChartLegendTitleSettingsBuilder<T>(this.Container.Title));
      return this;
    }

    public ChartLegendSettingsBuilder<T> Visible(bool value)
    {
      this.Container.Visible = new bool?(value);
      return this;
    }

    public ChartLegendSettingsBuilder<T> Width(double value)
    {
      this.Container.Width = new double?(value);
      return this;
    }

    public ChartLegendSettingsBuilder<T> Align(ChartLegendAlign value)
    {
      this.Container.Align = new ChartLegendAlign?(value);
      return this;
    }

    public ChartLegendSettingsBuilder<T> Orientation(
      ChartLegendOrientation value)
    {
      this.Container.Orientation = new ChartLegendOrientation?(value);
      return this;
    }

    public ChartLegendSettingsBuilder<T> Position(
      ChartLegendPosition value)
    {
      this.Container.Position = new ChartLegendPosition?(value);
      return this;
    }
  }
}
