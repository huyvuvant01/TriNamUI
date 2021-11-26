// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ChartSeriesTargetSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class ChartSeriesTargetSettingsBuilder<T> where T : class
  {
    public ChartSeriesTargetSettingsBuilder(ChartSeriesTargetSettings<T> container) => this.Container = container;

    protected ChartSeriesTargetSettings<T> Container { get; private set; }

    public ChartSeriesTargetSettingsBuilder<T> Border(
      Action<ChartSeriesTargetBorderSettingsBuilder<T>> configurator)
    {
      this.Container.Border.Chart = this.Container.Chart;
      configurator(new ChartSeriesTargetBorderSettingsBuilder<T>(this.Container.Border));
      return this;
    }

    public ChartSeriesTargetSettingsBuilder<T> Color(string value)
    {
      this.Container.ColorHandler = (ClientHandlerDescriptor) null;
      this.Container.Color = value;
      return this;
    }

    public ChartSeriesTargetSettingsBuilder<T> ColorHandler(
      string handler)
    {
      this.Container.Color = (string) null;
      this.Container.ColorHandler = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public ChartSeriesTargetSettingsBuilder<T> ColorHandler(
      Func<object, object> handler)
    {
      this.Container.Color = (string) null;
      this.Container.ColorHandler = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public ChartSeriesTargetSettingsBuilder<T> Line(
      Action<ChartSeriesTargetLineSettingsBuilder<T>> configurator)
    {
      this.Container.Line.Chart = this.Container.Chart;
      configurator(new ChartSeriesTargetLineSettingsBuilder<T>(this.Container.Line));
      return this;
    }
  }
}
