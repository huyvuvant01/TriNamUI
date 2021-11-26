// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ChartPaneBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class ChartPaneBuilder<T> where T : class
  {
    public ChartPaneBuilder(ChartPane<T> container) => this.Container = container;

    protected ChartPane<T> Container { get; private set; }

    public ChartPaneBuilder<T> Title(string value)
    {
      this.Container.Title.Text = value;
      this.Container.Title.Chart = this.Container.Chart;
      return this;
    }

    public ChartPaneBuilder<T> Background(string value)
    {
      this.Container.Background = value;
      return this;
    }

    public ChartPaneBuilder<T> Border(
      Action<ChartPaneBorderSettingsBuilder<T>> configurator)
    {
      this.Container.Border.Chart = this.Container.Chart;
      configurator(new ChartPaneBorderSettingsBuilder<T>(this.Container.Border));
      return this;
    }

    public ChartPaneBuilder<T> Clip(bool value)
    {
      this.Container.Clip = new bool?(value);
      return this;
    }

    public ChartPaneBuilder<T> Height(double value)
    {
      this.Container.Height = new double?(value);
      return this;
    }

    public ChartPaneBuilder<T> Margin(
      Action<ChartPaneMarginSettingsBuilder<T>> configurator)
    {
      this.Container.Margin.Chart = this.Container.Chart;
      configurator(new ChartPaneMarginSettingsBuilder<T>(this.Container.Margin));
      return this;
    }

    public ChartPaneBuilder<T> Name(string value)
    {
      this.Container.Name = value;
      return this;
    }

    public ChartPaneBuilder<T> Padding(
      Action<ChartPanePaddingSettingsBuilder<T>> configurator)
    {
      this.Container.Padding.Chart = this.Container.Chart;
      configurator(new ChartPanePaddingSettingsBuilder<T>(this.Container.Padding));
      return this;
    }

    public ChartPaneBuilder<T> Title(
      Action<ChartPaneTitleSettingsBuilder<T>> configurator)
    {
      this.Container.Title.Chart = this.Container.Chart;
      configurator(new ChartPaneTitleSettingsBuilder<T>(this.Container.Title));
      return this;
    }
  }
}
