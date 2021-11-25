// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ChartSeriesMarkersSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class ChartSeriesMarkersSettingsBuilder<T> where T : class
  {
    public ChartSeriesMarkersSettingsBuilder(ChartSeriesMarkersSettings<T> container) => this.Container = container;

    protected ChartSeriesMarkersSettings<T> Container { get; private set; }

    public ChartSeriesMarkersSettingsBuilder<T> Background(
      string value)
    {
      this.Container.BackgroundHandler = (ClientHandlerDescriptor) null;
      this.Container.Background = value;
      return this;
    }

    public ChartSeriesMarkersSettingsBuilder<T> BackgroundHandler(
      string handler)
    {
      this.Container.Background = (string) null;
      this.Container.BackgroundHandler = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public ChartSeriesMarkersSettingsBuilder<T> BackgroundHandler(
      Func<object, object> handler)
    {
      this.Container.Background = (string) null;
      this.Container.BackgroundHandler = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public ChartSeriesMarkersSettingsBuilder<T> Border(
      Action<ChartSeriesMarkersBorderSettingsBuilder<T>> configurator)
    {
      this.Container.Border.Chart = this.Container.Chart;
      configurator(new ChartSeriesMarkersBorderSettingsBuilder<T>(this.Container.Border));
      return this;
    }

    public ChartSeriesMarkersSettingsBuilder<T> BorderRadius(
      double value)
    {
      this.Container.BorderRadius = new double?(value);
      return this;
    }

    public ChartSeriesMarkersSettingsBuilder<T> From(
      Action<ChartSeriesMarkersFromSettingsBuilder<T>> configurator)
    {
      this.Container.From.Chart = this.Container.Chart;
      configurator(new ChartSeriesMarkersFromSettingsBuilder<T>(this.Container.From));
      return this;
    }

    public ChartSeriesMarkersSettingsBuilder<T> Size(double value)
    {
      this.Container.SizeHandler = (ClientHandlerDescriptor) null;
      this.Container.Size = new double?(value);
      return this;
    }

    public ChartSeriesMarkersSettingsBuilder<T> SizeHandler(
      string handler)
    {
      this.Container.Size = new double?();
      this.Container.SizeHandler = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public ChartSeriesMarkersSettingsBuilder<T> SizeHandler(
      Func<object, object> handler)
    {
      this.Container.Size = new double?();
      this.Container.SizeHandler = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public ChartSeriesMarkersSettingsBuilder<T> To(
      Action<ChartSeriesMarkersToSettingsBuilder<T>> configurator)
    {
      this.Container.To.Chart = this.Container.Chart;
      configurator(new ChartSeriesMarkersToSettingsBuilder<T>(this.Container.To));
      return this;
    }

    public ChartSeriesMarkersSettingsBuilder<T> Visible(bool value)
    {
      this.Container.VisibleHandler = (ClientHandlerDescriptor) null;
      this.Container.Visible = new bool?(value);
      return this;
    }

    public ChartSeriesMarkersSettingsBuilder<T> VisibleHandler(
      string handler)
    {
      this.Container.Visible = new bool?();
      this.Container.VisibleHandler = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public ChartSeriesMarkersSettingsBuilder<T> VisibleHandler(
      Func<object, object> handler)
    {
      this.Container.Visible = new bool?();
      this.Container.VisibleHandler = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public ChartSeriesMarkersSettingsBuilder<T> Visual(
      string handler)
    {
      this.Container.Visual = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public ChartSeriesMarkersSettingsBuilder<T> Visual(
      Func<object, object> handler)
    {
      this.Container.Visual = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public ChartSeriesMarkersSettingsBuilder<T> Rotation(
      double value)
    {
      this.Container.RotationHandler = (ClientHandlerDescriptor) null;
      this.Container.Rotation = new double?(value);
      return this;
    }

    public ChartSeriesMarkersSettingsBuilder<T> RotationHandler(
      string handler)
    {
      this.Container.Rotation = new double?();
      this.Container.RotationHandler = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public ChartSeriesMarkersSettingsBuilder<T> RotationHandler(
      Func<object, object> handler)
    {
      this.Container.Rotation = new double?();
      this.Container.RotationHandler = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public ChartSeriesMarkersSettingsBuilder<T> ZIndex(double value)
    {
      this.Container.ZIndexHandler = (ClientHandlerDescriptor) null;
      this.Container.ZIndex = new double?(value);
      return this;
    }

    public ChartSeriesMarkersSettingsBuilder<T> ZIndexHandler(
      string handler)
    {
      this.Container.ZIndex = new double?();
      this.Container.ZIndexHandler = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public ChartSeriesMarkersSettingsBuilder<T> ZIndexHandler(
      Func<object, object> handler)
    {
      this.Container.ZIndex = new double?();
      this.Container.ZIndexHandler = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public ChartSeriesMarkersSettingsBuilder<T> Type(
      ChartMarkerShape value)
    {
      this.Container.TypeHandler = (ClientHandlerDescriptor) null;
      this.Container.Type = new ChartMarkerShape?(value);
      return this;
    }

    public ChartSeriesMarkersSettingsBuilder<T> TypeHandler(
      string handler)
    {
      this.Container.Type = new ChartMarkerShape?();
      this.Container.TypeHandler = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public ChartSeriesMarkersSettingsBuilder<T> TypeHandler(
      Func<object, object> handler)
    {
      this.Container.Type = new ChartMarkerShape?();
      this.Container.TypeHandler = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }
  }
}
