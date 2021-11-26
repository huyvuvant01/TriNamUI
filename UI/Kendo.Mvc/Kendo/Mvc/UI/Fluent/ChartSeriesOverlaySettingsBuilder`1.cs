// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ChartSeriesOverlaySettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.ComponentModel;

namespace Kendo.Mvc.UI.Fluent
{
  public class ChartSeriesOverlaySettingsBuilder<T> where T : class
  {
    public ChartSeriesOverlaySettingsBuilder(ChartSeriesOverlaySettings<T> container) => this.Container = container;

    protected ChartSeriesOverlaySettings<T> Container { get; private set; }

    [Obsolete("The property is deprecated. Please use the ChartSeriesGradient value instead.")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public ChartSeriesOverlaySettingsBuilder<T> Gradient(
      ChartBarGradient value)
    {
      try
      {
        this.Container.Gradient = (ChartSeriesGradient?) Enum.Parse(typeof (ChartSeriesGradient), value.ToString());
      }
      catch (Exception ex)
      {
      }
      return this;
    }

    public ChartSeriesOverlaySettingsBuilder<T> Gradient(
      ChartSeriesGradient value)
    {
      this.Container.Gradient = new ChartSeriesGradient?(value);
      return this;
    }
  }
}
