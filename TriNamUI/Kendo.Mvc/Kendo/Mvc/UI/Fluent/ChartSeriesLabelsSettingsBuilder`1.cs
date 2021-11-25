// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ChartSeriesLabelsSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.ComponentModel;

namespace Kendo.Mvc.UI.Fluent
{
  public class ChartSeriesLabelsSettingsBuilder<T> where T : class
  {
    public ChartSeriesLabelsSettingsBuilder(ChartSeriesLabelsSettings<T> container) => this.Container = container;

    protected ChartSeriesLabelsSettings<T> Container { get; private set; }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public ChartSeriesLabelsSettingsBuilder<T> Align(
      ChartFunnelLabelsAlign value)
    {
      try
      {
        this.Container.Align = (ChartSeriesLabelsAlign?) Enum.Parse(typeof (ChartSeriesLabelsAlign), value.ToString());
      }
      catch (Exception ex)
      {
      }
      return this;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public ChartSeriesLabelsSettingsBuilder<T> Align(
      ChartPieLabelsAlign value)
    {
      try
      {
        this.Container.Align = (ChartSeriesLabelsAlign?) Enum.Parse(typeof (ChartSeriesLabelsAlign), value.ToString());
      }
      catch (Exception ex)
      {
      }
      return this;
    }

    public ChartSeriesLabelsSettingsBuilder<T> Margin(int value)
    {
      this.Container.Margin.Top = new double?((double) value);
      this.Container.Margin.Right = new double?((double) value);
      this.Container.Margin.Bottom = new double?((double) value);
      this.Container.Margin.Left = new double?((double) value);
      return this;
    }

    public ChartSeriesLabelsSettingsBuilder<T> Padding(int value)
    {
      this.Container.Padding.Top = new double?((double) value);
      this.Container.Padding.Right = new double?((double) value);
      this.Container.Padding.Bottom = new double?((double) value);
      this.Container.Padding.Left = new double?((double) value);
      return this;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public ChartSeriesLabelsSettingsBuilder<T> Position(
      ChartBarLabelsPosition value)
    {
      try
      {
        this.Container.Position = (ChartSeriesLabelsPosition?) Enum.Parse(typeof (ChartSeriesLabelsPosition), value.ToString());
      }
      catch (Exception ex)
      {
      }
      return this;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public ChartSeriesLabelsSettingsBuilder<T> Position(
      ChartFunnelLabelsPosition value)
    {
      try
      {
        this.Container.Position = (ChartSeriesLabelsPosition?) Enum.Parse(typeof (ChartSeriesLabelsPosition), value.ToString());
      }
      catch (Exception ex)
      {
      }
      return this;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public ChartSeriesLabelsSettingsBuilder<T> Position(
      ChartPieLabelsPosition value)
    {
      try
      {
        this.Container.Position = (ChartSeriesLabelsPosition?) Enum.Parse(typeof (ChartSeriesLabelsPosition), value.ToString());
      }
      catch (Exception ex)
      {
      }
      return this;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public ChartSeriesLabelsSettingsBuilder<T> Position(
      ChartPointLabelsPosition value)
    {
      try
      {
        this.Container.Position = (ChartSeriesLabelsPosition?) Enum.Parse(typeof (ChartSeriesLabelsPosition), value.ToString());
      }
      catch (Exception ex)
      {
      }
      return this;
    }

    public ChartSeriesLabelsSettingsBuilder<T> Background(
      string value)
    {
      this.Container.BackgroundHandler = (ClientHandlerDescriptor) null;
      this.Container.Background = value;
      return this;
    }

    public ChartSeriesLabelsSettingsBuilder<T> BackgroundHandler(
      string handler)
    {
      this.Container.Background = (string) null;
      this.Container.BackgroundHandler = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public ChartSeriesLabelsSettingsBuilder<T> BackgroundHandler(
      Func<object, object> handler)
    {
      this.Container.Background = (string) null;
      this.Container.BackgroundHandler = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public ChartSeriesLabelsSettingsBuilder<T> Border(
      Action<ChartSeriesLabelsBorderSettingsBuilder<T>> configurator)
    {
      this.Container.Border.Chart = this.Container.Chart;
      configurator(new ChartSeriesLabelsBorderSettingsBuilder<T>(this.Container.Border));
      return this;
    }

    public ChartSeriesLabelsSettingsBuilder<T> Color(string value)
    {
      this.Container.ColorHandler = (ClientHandlerDescriptor) null;
      this.Container.Color = value;
      return this;
    }

    public ChartSeriesLabelsSettingsBuilder<T> ColorHandler(
      string handler)
    {
      this.Container.Color = (string) null;
      this.Container.ColorHandler = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public ChartSeriesLabelsSettingsBuilder<T> ColorHandler(
      Func<object, object> handler)
    {
      this.Container.Color = (string) null;
      this.Container.ColorHandler = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public ChartSeriesLabelsSettingsBuilder<T> Distance(double value)
    {
      this.Container.Distance = new double?(value);
      return this;
    }

    public ChartSeriesLabelsSettingsBuilder<T> Font(string value)
    {
      this.Container.FontHandler = (ClientHandlerDescriptor) null;
      this.Container.Font = value;
      return this;
    }

    public ChartSeriesLabelsSettingsBuilder<T> FontHandler(
      string handler)
    {
      this.Container.Font = (string) null;
      this.Container.FontHandler = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public ChartSeriesLabelsSettingsBuilder<T> FontHandler(
      Func<object, object> handler)
    {
      this.Container.Font = (string) null;
      this.Container.FontHandler = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public ChartSeriesLabelsSettingsBuilder<T> Format(string value)
    {
      this.Container.FormatHandler = (ClientHandlerDescriptor) null;
      this.Container.Format = value;
      return this;
    }

    public ChartSeriesLabelsSettingsBuilder<T> FormatHandler(
      string handler)
    {
      this.Container.Format = (string) null;
      this.Container.FormatHandler = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public ChartSeriesLabelsSettingsBuilder<T> FormatHandler(
      Func<object, object> handler)
    {
      this.Container.Format = (string) null;
      this.Container.FormatHandler = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public ChartSeriesLabelsSettingsBuilder<T> Margin(
      Action<ChartSeriesLabelsMarginSettingsBuilder<T>> configurator)
    {
      this.Container.Margin.Chart = this.Container.Chart;
      configurator(new ChartSeriesLabelsMarginSettingsBuilder<T>(this.Container.Margin));
      return this;
    }

    public ChartSeriesLabelsSettingsBuilder<T> Padding(
      Action<ChartSeriesLabelsPaddingSettingsBuilder<T>> configurator)
    {
      this.Container.Padding.Chart = this.Container.Chart;
      configurator(new ChartSeriesLabelsPaddingSettingsBuilder<T>(this.Container.Padding));
      return this;
    }

    public ChartSeriesLabelsSettingsBuilder<T> Rotation(string value)
    {
      this.Container.Rotation = value;
      return this;
    }

    public ChartSeriesLabelsSettingsBuilder<T> Template(string value)
    {
      this.Container.Template = value;
      return this;
    }

    public ChartSeriesLabelsSettingsBuilder<T> TemplateId(
      string templateId)
    {
      this.Container.TemplateId = templateId;
      return this;
    }

    public ChartSeriesLabelsSettingsBuilder<T> Visible(bool value)
    {
      this.Container.VisibleHandler = (ClientHandlerDescriptor) null;
      this.Container.Visible = new bool?(value);
      return this;
    }

    public ChartSeriesLabelsSettingsBuilder<T> VisibleHandler(
      string handler)
    {
      this.Container.Visible = new bool?();
      this.Container.VisibleHandler = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public ChartSeriesLabelsSettingsBuilder<T> VisibleHandler(
      Func<object, object> handler)
    {
      this.Container.Visible = new bool?();
      this.Container.VisibleHandler = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public ChartSeriesLabelsSettingsBuilder<T> Visual(string handler)
    {
      this.Container.Visual = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public ChartSeriesLabelsSettingsBuilder<T> Visual(
      Func<object, object> handler)
    {
      this.Container.Visual = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public ChartSeriesLabelsSettingsBuilder<T> From(
      Action<ChartSeriesLabelsFromSettingsBuilder<T>> configurator)
    {
      this.Container.From.Chart = this.Container.Chart;
      configurator(new ChartSeriesLabelsFromSettingsBuilder<T>(this.Container.From));
      return this;
    }

    public ChartSeriesLabelsSettingsBuilder<T> To(
      Action<ChartSeriesLabelsToSettingsBuilder<T>> configurator)
    {
      this.Container.To.Chart = this.Container.Chart;
      configurator(new ChartSeriesLabelsToSettingsBuilder<T>(this.Container.To));
      return this;
    }

    public ChartSeriesLabelsSettingsBuilder<T> Align(
      ChartSeriesLabelsAlign value)
    {
      this.Container.Align = new ChartSeriesLabelsAlign?(value);
      return this;
    }

    public ChartSeriesLabelsSettingsBuilder<T> Position(
      ChartSeriesLabelsPosition value)
    {
      this.Container.PositionHandler = (ClientHandlerDescriptor) null;
      this.Container.Position = new ChartSeriesLabelsPosition?(value);
      return this;
    }

    public ChartSeriesLabelsSettingsBuilder<T> PositionHandler(
      string handler)
    {
      this.Container.Position = new ChartSeriesLabelsPosition?();
      this.Container.PositionHandler = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public ChartSeriesLabelsSettingsBuilder<T> PositionHandler(
      Func<object, object> handler)
    {
      this.Container.Position = new ChartSeriesLabelsPosition?();
      this.Container.PositionHandler = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }
  }
}
