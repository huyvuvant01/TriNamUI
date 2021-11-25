// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ChartSeriesLineSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.ComponentModel;

namespace Kendo.Mvc.UI.Fluent
{
  public class ChartSeriesLineSettingsBuilder<T> where T : class
  {
    public ChartSeriesLineSettingsBuilder(ChartSeriesLineSettings<T> container) => this.Container = container;

    protected ChartSeriesLineSettings<T> Container { get; private set; }

    [Obsolete("The property is deprecated. Please set the value with a numeric type.")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public ChartSeriesLineSettingsBuilder<T> Width(string value)
    {
      this.Container.StringWidth = value;
      return this;
    }

    [Obsolete("The property is deprecated. Please use the ChartSeriesLineStyle value instead.")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public ChartSeriesLineSettingsBuilder<T> Style(
      ChartAreaStyle value)
    {
      try
      {
        this.Container.Style = (ChartSeriesLineStyle?) Enum.Parse(typeof (ChartSeriesLineStyle), value.ToString());
      }
      catch (Exception ex)
      {
      }
      return this;
    }

    [Obsolete("The property is deprecated. Please use the ChartSeriesLineStyle value instead.")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public ChartSeriesLineSettingsBuilder<T> Style(
      ChartPolarAreaStyle value)
    {
      try
      {
        this.Container.Style = (ChartSeriesLineStyle?) Enum.Parse(typeof (ChartSeriesLineStyle), value.ToString());
      }
      catch (Exception ex)
      {
      }
      return this;
    }

    [Obsolete("The property is deprecated. Please use the ChartSeriesLineStyle value instead.")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public ChartSeriesLineSettingsBuilder<T> Style(
      ChartRadarAreaStyle value)
    {
      try
      {
        this.Container.Style = (ChartSeriesLineStyle?) Enum.Parse(typeof (ChartSeriesLineStyle), value.ToString());
      }
      catch (Exception ex)
      {
      }
      return this;
    }

    public ChartSeriesLineSettingsBuilder<T> Color(string value)
    {
      this.Container.Color = value;
      return this;
    }

    public ChartSeriesLineSettingsBuilder<T> Opacity(double value)
    {
      this.Container.Opacity = new double?(value);
      return this;
    }

    public ChartSeriesLineSettingsBuilder<T> Width(double value)
    {
      this.Container.Width = new double?(value);
      return this;
    }

    public ChartSeriesLineSettingsBuilder<T> Style(
      ChartSeriesLineStyle value)
    {
      this.Container.Style = new ChartSeriesLineStyle?(value);
      return this;
    }
  }
}
