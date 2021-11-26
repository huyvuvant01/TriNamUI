// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ChartSeriesOutliersSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class ChartSeriesOutliersSettingsBuilder<T> where T : class
  {
    public ChartSeriesOutliersSettingsBuilder(ChartSeriesOutliersSettings<T> container) => this.Container = container;

    protected ChartSeriesOutliersSettings<T> Container { get; private set; }

    public ChartSeriesOutliersSettingsBuilder<T> Background(
      string value)
    {
      this.Container.BackgroundHandler = (ClientHandlerDescriptor) null;
      this.Container.Background = value;
      return this;
    }

    public ChartSeriesOutliersSettingsBuilder<T> BackgroundHandler(
      string handler)
    {
      this.Container.Background = (string) null;
      this.Container.BackgroundHandler = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public ChartSeriesOutliersSettingsBuilder<T> BackgroundHandler(
      Func<object, object> handler)
    {
      this.Container.Background = (string) null;
      this.Container.BackgroundHandler = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public ChartSeriesOutliersSettingsBuilder<T> Border(
      Action<ChartSeriesOutliersBorderSettingsBuilder<T>> configurator)
    {
      this.Container.Border.Chart = this.Container.Chart;
      configurator(new ChartSeriesOutliersBorderSettingsBuilder<T>(this.Container.Border));
      return this;
    }

    public ChartSeriesOutliersSettingsBuilder<T> Size(double value)
    {
      this.Container.SizeHandler = (ClientHandlerDescriptor) null;
      this.Container.Size = new double?(value);
      return this;
    }

    public ChartSeriesOutliersSettingsBuilder<T> SizeHandler(
      string handler)
    {
      this.Container.Size = new double?();
      this.Container.SizeHandler = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public ChartSeriesOutliersSettingsBuilder<T> SizeHandler(
      Func<object, object> handler)
    {
      this.Container.Size = new double?();
      this.Container.SizeHandler = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public ChartSeriesOutliersSettingsBuilder<T> Type(string value)
    {
      this.Container.TypeHandler = (ClientHandlerDescriptor) null;
      this.Container.Type = value;
      return this;
    }

    public ChartSeriesOutliersSettingsBuilder<T> TypeHandler(
      string handler)
    {
      this.Container.Type = (string) null;
      this.Container.TypeHandler = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public ChartSeriesOutliersSettingsBuilder<T> TypeHandler(
      Func<object, object> handler)
    {
      this.Container.Type = (string) null;
      this.Container.TypeHandler = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public ChartSeriesOutliersSettingsBuilder<T> Rotation(
      double value)
    {
      this.Container.RotationHandler = (ClientHandlerDescriptor) null;
      this.Container.Rotation = new double?(value);
      return this;
    }

    public ChartSeriesOutliersSettingsBuilder<T> RotationHandler(
      string handler)
    {
      this.Container.Rotation = new double?();
      this.Container.RotationHandler = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public ChartSeriesOutliersSettingsBuilder<T> RotationHandler(
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
