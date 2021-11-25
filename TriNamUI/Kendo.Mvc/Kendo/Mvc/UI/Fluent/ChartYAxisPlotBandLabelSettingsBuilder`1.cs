// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ChartYAxisPlotBandLabelSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class ChartYAxisPlotBandLabelSettingsBuilder<T> where T : class
  {
    public ChartYAxisPlotBandLabelSettingsBuilder(ChartYAxisPlotBandLabelSettings<T> container) => this.Container = container;

    protected ChartYAxisPlotBandLabelSettings<T> Container { get; private set; }

    public ChartYAxisPlotBandLabelSettingsBuilder<T> Align(
      string value)
    {
      this.Container.Align = value;
      return this;
    }

    public ChartYAxisPlotBandLabelSettingsBuilder<T> Background(
      string value)
    {
      this.Container.Background = value;
      return this;
    }

    public ChartYAxisPlotBandLabelSettingsBuilder<T> Border(
      Action<ChartYAxisPlotBandLabelBorderSettingsBuilder<T>> configurator)
    {
      this.Container.Border.Chart = this.Container.Chart;
      configurator(new ChartYAxisPlotBandLabelBorderSettingsBuilder<T>(this.Container.Border));
      return this;
    }

    public ChartYAxisPlotBandLabelSettingsBuilder<T> Color(
      string value)
    {
      this.Container.Color = value;
      return this;
    }

    public ChartYAxisPlotBandLabelSettingsBuilder<T> Font(
      string value)
    {
      this.Container.Font = value;
      return this;
    }

    public ChartYAxisPlotBandLabelSettingsBuilder<T> Margin(
      Action<ChartYAxisPlotBandLabelMarginSettingsBuilder<T>> configurator)
    {
      this.Container.Margin.Chart = this.Container.Chart;
      configurator(new ChartYAxisPlotBandLabelMarginSettingsBuilder<T>(this.Container.Margin));
      return this;
    }

    public ChartYAxisPlotBandLabelSettingsBuilder<T> Padding(
      Action<ChartYAxisPlotBandLabelPaddingSettingsBuilder<T>> configurator)
    {
      this.Container.Padding.Chart = this.Container.Chart;
      configurator(new ChartYAxisPlotBandLabelPaddingSettingsBuilder<T>(this.Container.Padding));
      return this;
    }

    public ChartYAxisPlotBandLabelSettingsBuilder<T> Position(
      string value)
    {
      this.Container.Position = value;
      return this;
    }

    public ChartYAxisPlotBandLabelSettingsBuilder<T> Rotation(
      double value)
    {
      this.Container.Rotation = new double?(value);
      return this;
    }

    public ChartYAxisPlotBandLabelSettingsBuilder<T> Text(
      string value)
    {
      this.Container.Text = value;
      return this;
    }

    public ChartYAxisPlotBandLabelSettingsBuilder<T> Visible(
      bool value)
    {
      this.Container.Visible = new bool?(value);
      return this;
    }

    public ChartYAxisPlotBandLabelSettingsBuilder<T> Visual(
      string handler)
    {
      this.Container.Visual = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public ChartYAxisPlotBandLabelSettingsBuilder<T> Visual(
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
