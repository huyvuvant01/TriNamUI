// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ChartSeriesHighlightSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class ChartSeriesHighlightSettingsBuilder<T> where T : class
  {
    public ChartSeriesHighlightSettingsBuilder(ChartSeriesHighlightSettings<T> container) => this.Container = container;

    protected ChartSeriesHighlightSettings<T> Container { get; private set; }

    public ChartSeriesHighlightSettingsBuilder<T> Border(
      Action<ChartSeriesHighlightBorderSettingsBuilder<T>> configurator)
    {
      this.Container.Border.Chart = this.Container.Chart;
      configurator(new ChartSeriesHighlightBorderSettingsBuilder<T>(this.Container.Border));
      return this;
    }

    public ChartSeriesHighlightSettingsBuilder<T> Color(
      string value)
    {
      this.Container.Color = value;
      return this;
    }

    public ChartSeriesHighlightSettingsBuilder<T> InactiveOpacity(
      double value)
    {
      this.Container.InactiveOpacity = new double?(value);
      return this;
    }

    public ChartSeriesHighlightSettingsBuilder<T> Line(
      Action<ChartSeriesHighlightLineSettingsBuilder<T>> configurator)
    {
      this.Container.Line.Chart = this.Container.Chart;
      configurator(new ChartSeriesHighlightLineSettingsBuilder<T>(this.Container.Line));
      return this;
    }

    public ChartSeriesHighlightSettingsBuilder<T> Opacity(
      double value)
    {
      this.Container.Opacity = new double?(value);
      return this;
    }

    public ChartSeriesHighlightSettingsBuilder<T> Toggle(
      string handler)
    {
      this.Container.Toggle = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public ChartSeriesHighlightSettingsBuilder<T> Toggle(
      Func<object, object> handler)
    {
      this.Container.Toggle = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public ChartSeriesHighlightSettingsBuilder<T> Visible(
      bool value)
    {
      this.Container.Visible = new bool?(value);
      return this;
    }

    public ChartSeriesHighlightSettingsBuilder<T> Visual(
      string handler)
    {
      this.Container.Visual = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public ChartSeriesHighlightSettingsBuilder<T> Visual(
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
