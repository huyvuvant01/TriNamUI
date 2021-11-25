// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ChartSeriesErrorBarsSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class ChartSeriesErrorBarsSettingsBuilder<T> where T : class
  {
    public ChartSeriesErrorBarsSettingsBuilder(ChartSeriesErrorBarsSettings<T> container) => this.Container = container;

    protected ChartSeriesErrorBarsSettings<T> Container { get; private set; }

    public ChartSeriesErrorBarsSettingsBuilder<T> Value(
      string value)
    {
      this.Container.ValueHandler = (ClientHandlerDescriptor) null;
      this.Container.Value = value;
      return this;
    }

    public ChartSeriesErrorBarsSettingsBuilder<T> ValueHandler(
      string handler)
    {
      this.Container.Value = (string) null;
      this.Container.ValueHandler = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public ChartSeriesErrorBarsSettingsBuilder<T> ValueHandler(
      Func<object, object> handler)
    {
      this.Container.Value = (string) null;
      this.Container.ValueHandler = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public ChartSeriesErrorBarsSettingsBuilder<T> Visual(
      string handler)
    {
      this.Container.Visual = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public ChartSeriesErrorBarsSettingsBuilder<T> Visual(
      Func<object, object> handler)
    {
      this.Container.Visual = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public ChartSeriesErrorBarsSettingsBuilder<T> XValue(
      string value)
    {
      this.Container.XValueHandler = (ClientHandlerDescriptor) null;
      this.Container.XValue = value;
      return this;
    }

    public ChartSeriesErrorBarsSettingsBuilder<T> XValueHandler(
      string handler)
    {
      this.Container.XValue = (string) null;
      this.Container.XValueHandler = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public ChartSeriesErrorBarsSettingsBuilder<T> XValueHandler(
      Func<object, object> handler)
    {
      this.Container.XValue = (string) null;
      this.Container.XValueHandler = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public ChartSeriesErrorBarsSettingsBuilder<T> YValue(
      string value)
    {
      this.Container.YValueHandler = (ClientHandlerDescriptor) null;
      this.Container.YValue = value;
      return this;
    }

    public ChartSeriesErrorBarsSettingsBuilder<T> YValueHandler(
      string handler)
    {
      this.Container.YValue = (string) null;
      this.Container.YValueHandler = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public ChartSeriesErrorBarsSettingsBuilder<T> YValueHandler(
      Func<object, object> handler)
    {
      this.Container.YValue = (string) null;
      this.Container.YValueHandler = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public ChartSeriesErrorBarsSettingsBuilder<T> EndCaps(
      bool value)
    {
      this.Container.EndCaps = new bool?(value);
      return this;
    }

    public ChartSeriesErrorBarsSettingsBuilder<T> Color(
      string value)
    {
      this.Container.Color = value;
      return this;
    }

    public ChartSeriesErrorBarsSettingsBuilder<T> Line(
      Action<ChartSeriesErrorBarsLineSettingsBuilder<T>> configurator)
    {
      this.Container.Line.Chart = this.Container.Chart;
      configurator(new ChartSeriesErrorBarsLineSettingsBuilder<T>(this.Container.Line));
      return this;
    }
  }
}
