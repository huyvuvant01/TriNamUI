// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ChartPaneDefaultsSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class ChartPaneDefaultsSettingsBuilder<T> where T : class
  {
    public ChartPaneDefaultsSettingsBuilder(ChartPaneDefaultsSettings<T> container) => this.Container = container;

    protected ChartPaneDefaultsSettings<T> Container { get; private set; }

    public ChartPaneDefaultsSettingsBuilder<T> Background(
      string value)
    {
      this.Container.Background = value;
      return this;
    }

    public ChartPaneDefaultsSettingsBuilder<T> Border(
      Action<ChartPaneDefaultsBorderSettingsBuilder<T>> configurator)
    {
      this.Container.Border.Chart = this.Container.Chart;
      configurator(new ChartPaneDefaultsBorderSettingsBuilder<T>(this.Container.Border));
      return this;
    }

    public ChartPaneDefaultsSettingsBuilder<T> Clip(bool value)
    {
      this.Container.Clip = new bool?(value);
      return this;
    }

    public ChartPaneDefaultsSettingsBuilder<T> Height(double value)
    {
      this.Container.Height = new double?(value);
      return this;
    }

    public ChartPaneDefaultsSettingsBuilder<T> Margin(
      Action<ChartPaneDefaultsMarginSettingsBuilder<T>> configurator)
    {
      this.Container.Margin.Chart = this.Container.Chart;
      configurator(new ChartPaneDefaultsMarginSettingsBuilder<T>(this.Container.Margin));
      return this;
    }

    public ChartPaneDefaultsSettingsBuilder<T> Padding(
      Action<ChartPaneDefaultsPaddingSettingsBuilder<T>> configurator)
    {
      this.Container.Padding.Chart = this.Container.Chart;
      configurator(new ChartPaneDefaultsPaddingSettingsBuilder<T>(this.Container.Padding));
      return this;
    }

    public ChartPaneDefaultsSettingsBuilder<T> Title(
      Action<ChartPaneDefaultsTitleSettingsBuilder<T>> configurator)
    {
      this.Container.Title.Chart = this.Container.Chart;
      configurator(new ChartPaneDefaultsTitleSettingsBuilder<T>(this.Container.Title));
      return this;
    }
  }
}
