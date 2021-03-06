// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ChartValueAxisPlotBandLabelSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class ChartValueAxisPlotBandLabelSettingsBuilder<T> where T : class
  {
    public ChartValueAxisPlotBandLabelSettingsBuilder(
      ChartValueAxisPlotBandLabelSettings<T> container)
    {
      this.Container = container;
    }

    protected ChartValueAxisPlotBandLabelSettings<T> Container { get; private set; }

    public ChartValueAxisPlotBandLabelSettingsBuilder<T> Align(
      string value)
    {
      this.Container.Align = value;
      return this;
    }

    public ChartValueAxisPlotBandLabelSettingsBuilder<T> Background(
      string value)
    {
      this.Container.Background = value;
      return this;
    }

    public ChartValueAxisPlotBandLabelSettingsBuilder<T> Border(
      Action<ChartValueAxisPlotBandLabelBorderSettingsBuilder<T>> configurator)
    {
      this.Container.Border.Chart = this.Container.Chart;
      configurator(new ChartValueAxisPlotBandLabelBorderSettingsBuilder<T>(this.Container.Border));
      return this;
    }

    public ChartValueAxisPlotBandLabelSettingsBuilder<T> Color(
      string value)
    {
      this.Container.Color = value;
      return this;
    }

    public ChartValueAxisPlotBandLabelSettingsBuilder<T> Font(
      string value)
    {
      this.Container.Font = value;
      return this;
    }

    public ChartValueAxisPlotBandLabelSettingsBuilder<T> Margin(
      Action<ChartValueAxisPlotBandLabelMarginSettingsBuilder<T>> configurator)
    {
      this.Container.Margin.Chart = this.Container.Chart;
      configurator(new ChartValueAxisPlotBandLabelMarginSettingsBuilder<T>(this.Container.Margin));
      return this;
    }

    public ChartValueAxisPlotBandLabelSettingsBuilder<T> Padding(
      Action<ChartValueAxisPlotBandLabelPaddingSettingsBuilder<T>> configurator)
    {
      this.Container.Padding.Chart = this.Container.Chart;
      configurator(new ChartValueAxisPlotBandLabelPaddingSettingsBuilder<T>(this.Container.Padding));
      return this;
    }

    public ChartValueAxisPlotBandLabelSettingsBuilder<T> Position(
      string value)
    {
      this.Container.Position = value;
      return this;
    }

    public ChartValueAxisPlotBandLabelSettingsBuilder<T> Rotation(
      double value)
    {
      this.Container.Rotation = new double?(value);
      return this;
    }

    public ChartValueAxisPlotBandLabelSettingsBuilder<T> Text(
      string value)
    {
      this.Container.Text = value;
      return this;
    }

    public ChartValueAxisPlotBandLabelSettingsBuilder<T> Visible(
      bool value)
    {
      this.Container.Visible = new bool?(value);
      return this;
    }

    public ChartValueAxisPlotBandLabelSettingsBuilder<T> Visual(
      string handler)
    {
      this.Container.Visual = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public ChartValueAxisPlotBandLabelSettingsBuilder<T> Visual(
      Func<object, object> handler)
    {
      this.Container.Visual = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }
  }
}
