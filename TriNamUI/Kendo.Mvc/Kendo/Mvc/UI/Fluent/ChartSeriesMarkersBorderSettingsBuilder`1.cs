// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ChartSeriesMarkersBorderSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class ChartSeriesMarkersBorderSettingsBuilder<T> where T : class
  {
    public ChartSeriesMarkersBorderSettingsBuilder(ChartSeriesMarkersBorderSettings<T> container) => this.Container = container;

    protected ChartSeriesMarkersBorderSettings<T> Container { get; private set; }

    public ChartSeriesMarkersBorderSettingsBuilder<T> Color(
      string value)
    {
      this.Container.ColorHandler = (ClientHandlerDescriptor) null;
      this.Container.Color = value;
      return this;
    }

    public ChartSeriesMarkersBorderSettingsBuilder<T> ColorHandler(
      string handler)
    {
      this.Container.Color = (string) null;
      this.Container.ColorHandler = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public ChartSeriesMarkersBorderSettingsBuilder<T> ColorHandler(
      Func<object, object> handler)
    {
      this.Container.Color = (string) null;
      this.Container.ColorHandler = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public ChartSeriesMarkersBorderSettingsBuilder<T> Width(
      double value)
    {
      this.Container.WidthHandler = (ClientHandlerDescriptor) null;
      this.Container.Width = new double?(value);
      return this;
    }

    public ChartSeriesMarkersBorderSettingsBuilder<T> WidthHandler(
      string handler)
    {
      this.Container.Width = new double?();
      this.Container.WidthHandler = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public ChartSeriesMarkersBorderSettingsBuilder<T> WidthHandler(
      Func<object, object> handler)
    {
      this.Container.Width = new double?();
      this.Container.WidthHandler = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }
  }
}
