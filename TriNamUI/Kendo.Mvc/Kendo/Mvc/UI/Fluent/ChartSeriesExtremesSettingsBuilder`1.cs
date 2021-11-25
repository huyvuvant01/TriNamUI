// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ChartSeriesExtremesSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class ChartSeriesExtremesSettingsBuilder<T> where T : class
  {
    public ChartSeriesExtremesSettingsBuilder(ChartSeriesExtremesSettings<T> container) => this.Container = container;

    protected ChartSeriesExtremesSettings<T> Container { get; private set; }

    public ChartSeriesExtremesSettingsBuilder<T> Background(
      string value)
    {
      this.Container.BackgroundHandler = (ClientHandlerDescriptor) null;
      this.Container.Background = value;
      return this;
    }

    public ChartSeriesExtremesSettingsBuilder<T> BackgroundHandler(
      string handler)
    {
      this.Container.Background = (string) null;
      this.Container.BackgroundHandler = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public ChartSeriesExtremesSettingsBuilder<T> BackgroundHandler(
      Func<object, object> handler)
    {
      this.Container.Background = (string) null;
      this.Container.BackgroundHandler = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public ChartSeriesExtremesSettingsBuilder<T> Border(
      Action<ChartSeriesExtremesBorderSettingsBuilder<T>> configurator)
    {
      this.Container.Border.Chart = this.Container.Chart;
      configurator(new ChartSeriesExtremesBorderSettingsBuilder<T>(this.Container.Border));
      return this;
    }

    public ChartSeriesExtremesSettingsBuilder<T> Size(double value)
    {
      this.Container.SizeHandler = (ClientHandlerDescriptor) null;
      this.Container.Size = new double?(value);
      return this;
    }

    public ChartSeriesExtremesSettingsBuilder<T> SizeHandler(
      string handler)
    {
      this.Container.Size = new double?();
      this.Container.SizeHandler = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public ChartSeriesExtremesSettingsBuilder<T> SizeHandler(
      Func<object, object> handler)
    {
      this.Container.Size = new double?();
      this.Container.SizeHandler = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public ChartSeriesExtremesSettingsBuilder<T> Type(string value)
    {
      this.Container.TypeHandler = (ClientHandlerDescriptor) null;
      this.Container.Type = value;
      return this;
    }

    public ChartSeriesExtremesSettingsBuilder<T> TypeHandler(
      string handler)
    {
      this.Container.Type = (string) null;
      this.Container.TypeHandler = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public ChartSeriesExtremesSettingsBuilder<T> TypeHandler(
      Func<object, object> handler)
    {
      this.Container.Type = (string) null;
      this.Container.TypeHandler = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public ChartSeriesExtremesSettingsBuilder<T> Rotation(
      double value)
    {
      this.Container.RotationHandler = (ClientHandlerDescriptor) null;
      this.Container.Rotation = new double?(value);
      return this;
    }

    public ChartSeriesExtremesSettingsBuilder<T> RotationHandler(
      string handler)
    {
      this.Container.Rotation = new double?();
      this.Container.RotationHandler = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public ChartSeriesExtremesSettingsBuilder<T> RotationHandler(
      Func<object, object> handler)
    {
      this.Container.Rotation = new double?();
      this.Container.RotationHandler = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }
  }
}
