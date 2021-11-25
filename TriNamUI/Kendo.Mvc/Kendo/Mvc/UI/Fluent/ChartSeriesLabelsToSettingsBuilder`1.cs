// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ChartSeriesLabelsToSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class ChartSeriesLabelsToSettingsBuilder<T> where T : class
  {
    public ChartSeriesLabelsToSettingsBuilder(ChartSeriesLabelsToSettings<T> container) => this.Container = container;

    protected ChartSeriesLabelsToSettings<T> Container { get; private set; }

    public ChartSeriesLabelsToSettingsBuilder<T> Background(
      string value)
    {
      this.Container.BackgroundHandler = (ClientHandlerDescriptor) null;
      this.Container.Background = value;
      return this;
    }

    public ChartSeriesLabelsToSettingsBuilder<T> BackgroundHandler(
      string handler)
    {
      this.Container.Background = (string) null;
      this.Container.BackgroundHandler = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public ChartSeriesLabelsToSettingsBuilder<T> BackgroundHandler(
      Func<object, object> handler)
    {
      this.Container.Background = (string) null;
      this.Container.BackgroundHandler = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public ChartSeriesLabelsToSettingsBuilder<T> Border(
      Action<ChartSeriesLabelsToBorderSettingsBuilder<T>> configurator)
    {
      this.Container.Border.Chart = this.Container.Chart;
      configurator(new ChartSeriesLabelsToBorderSettingsBuilder<T>(this.Container.Border));
      return this;
    }

    public ChartSeriesLabelsToSettingsBuilder<T> Color(
      string value)
    {
      this.Container.ColorHandler = (ClientHandlerDescriptor) null;
      this.Container.Color = value;
      return this;
    }

    public ChartSeriesLabelsToSettingsBuilder<T> ColorHandler(
      string handler)
    {
      this.Container.Color = (string) null;
      this.Container.ColorHandler = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public ChartSeriesLabelsToSettingsBuilder<T> ColorHandler(
      Func<object, object> handler)
    {
      this.Container.Color = (string) null;
      this.Container.ColorHandler = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public ChartSeriesLabelsToSettingsBuilder<T> Font(string value)
    {
      this.Container.FontHandler = (ClientHandlerDescriptor) null;
      this.Container.Font = value;
      return this;
    }

    public ChartSeriesLabelsToSettingsBuilder<T> FontHandler(
      string handler)
    {
      this.Container.Font = (string) null;
      this.Container.FontHandler = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public ChartSeriesLabelsToSettingsBuilder<T> FontHandler(
      Func<object, object> handler)
    {
      this.Container.Font = (string) null;
      this.Container.FontHandler = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public ChartSeriesLabelsToSettingsBuilder<T> Format(
      string value)
    {
      this.Container.FormatHandler = (ClientHandlerDescriptor) null;
      this.Container.Format = value;
      return this;
    }

    public ChartSeriesLabelsToSettingsBuilder<T> FormatHandler(
      string handler)
    {
      this.Container.Format = (string) null;
      this.Container.FormatHandler = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public ChartSeriesLabelsToSettingsBuilder<T> FormatHandler(
      Func<object, object> handler)
    {
      this.Container.Format = (string) null;
      this.Container.FormatHandler = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public ChartSeriesLabelsToSettingsBuilder<T> Margin(
      Action<ChartSeriesLabelsToMarginSettingsBuilder<T>> configurator)
    {
      this.Container.Margin.Chart = this.Container.Chart;
      configurator(new ChartSeriesLabelsToMarginSettingsBuilder<T>(this.Container.Margin));
      return this;
    }

    public ChartSeriesLabelsToSettingsBuilder<T> Padding(
      Action<ChartSeriesLabelsToPaddingSettingsBuilder<T>> configurator)
    {
      this.Container.Padding.Chart = this.Container.Chart;
      configurator(new ChartSeriesLabelsToPaddingSettingsBuilder<T>(this.Container.Padding));
      return this;
    }

    public ChartSeriesLabelsToSettingsBuilder<T> Template(
      string value)
    {
      this.Container.Template = value;
      return this;
    }

    public ChartSeriesLabelsToSettingsBuilder<T> TemplateId(
      string templateId)
    {
      this.Container.TemplateId = templateId;
      return this;
    }

    public ChartSeriesLabelsToSettingsBuilder<T> Visible(
      bool value)
    {
      this.Container.VisibleHandler = (ClientHandlerDescriptor) null;
      this.Container.Visible = new bool?(value);
      return this;
    }

    public ChartSeriesLabelsToSettingsBuilder<T> VisibleHandler(
      string handler)
    {
      this.Container.Visible = new bool?();
      this.Container.VisibleHandler = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public ChartSeriesLabelsToSettingsBuilder<T> VisibleHandler(
      Func<object, object> handler)
    {
      this.Container.Visible = new bool?();
      this.Container.VisibleHandler = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public ChartSeriesLabelsToSettingsBuilder<T> Position(
      ChartSeriesLabelsPosition value)
    {
      this.Container.Position = new ChartSeriesLabelsPosition?(value);
      return this;
    }
  }
}
