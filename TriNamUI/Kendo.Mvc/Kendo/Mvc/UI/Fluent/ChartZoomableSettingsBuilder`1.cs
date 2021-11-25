// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ChartZoomableSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class ChartZoomableSettingsBuilder<T> where T : class
  {
    public ChartZoomableSettingsBuilder(ChartZoomableSettings<T> container) => this.Container = container;

    protected ChartZoomableSettings<T> Container { get; private set; }

    public ChartZoomableSettingsBuilder<T> Mousewheel(
      Action<ChartZoomableMousewheelSettingsBuilder<T>> configurator)
    {
      this.Container.Mousewheel.Enabled = new bool?(true);
      this.Container.Mousewheel.Chart = this.Container.Chart;
      configurator(new ChartZoomableMousewheelSettingsBuilder<T>(this.Container.Mousewheel));
      return this;
    }

    public ChartZoomableSettingsBuilder<T> Mousewheel(bool enabled)
    {
      this.Container.Mousewheel.Enabled = new bool?(enabled);
      return this;
    }

    public ChartZoomableSettingsBuilder<T> Selection(
      Action<ChartZoomableSelectionSettingsBuilder<T>> configurator)
    {
      this.Container.Selection.Enabled = new bool?(true);
      this.Container.Selection.Chart = this.Container.Chart;
      configurator(new ChartZoomableSelectionSettingsBuilder<T>(this.Container.Selection));
      return this;
    }

    public ChartZoomableSettingsBuilder<T> Selection(bool enabled)
    {
      this.Container.Selection.Enabled = new bool?(enabled);
      return this;
    }
  }
}
