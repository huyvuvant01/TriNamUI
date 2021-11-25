// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ChartSeriesBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.ComponentModel;

namespace Kendo.Mvc.UI.Fluent
{
  public class ChartSeriesBuilder<T> where T : class
  {
    public ChartSeriesBuilder(ChartSeries<T> container) => this.Container = container;

    protected ChartSeries<T> Container { get; private set; }

    public ChartSeriesBuilder<T> Aggregate(
      Action<ChartSeriesAggregateSettingsBuilder<T>> configurator)
    {
      this.Container.Aggregates.Chart = this.Container.Chart;
      configurator(new ChartSeriesAggregateSettingsBuilder<T>(this.Container.Aggregates));
      return this;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public ChartSeriesBuilder<T> MissingValues(ChartAreaMissingValues value)
    {
      try
      {
        this.Container.MissingValues = (ChartSeriesMissingValues?) Enum.Parse(typeof (ChartSeriesMissingValues), value.ToString());
      }
      catch (Exception ex)
      {
      }
      return this;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public ChartSeriesBuilder<T> MissingValues(ChartLineMissingValues value)
    {
      try
      {
        this.Container.MissingValues = (ChartSeriesMissingValues?) Enum.Parse(typeof (ChartSeriesMissingValues), value.ToString());
      }
      catch (Exception ex)
      {
      }
      return this;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public ChartSeriesBuilder<T> MissingValues(ChartScatterLineMissingValues value)
    {
      try
      {
        this.Container.MissingValues = (ChartSeriesMissingValues?) Enum.Parse(typeof (ChartSeriesMissingValues), value.ToString());
      }
      catch (Exception ex)
      {
      }
      return this;
    }

    public virtual ChartSeriesBuilder<T> Stack(
      ChartStackType stackType,
      string stackGroup = null)
    {
      this.Container.Stack.Type = new ChartStackType?(stackType);
      if (stackGroup != null)
        this.Container.Stack.Group = stackGroup;
      return this;
    }

    public virtual ChartSeriesBuilder<T> Stack(string stackGroup)
    {
      this.Container.Stack.Group = stackGroup;
      return this;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public ChartSeriesBuilder<T> Style(ChartLineStyle value)
    {
      try
      {
        this.Container.Style = (ChartSeriesStyle?) Enum.Parse(typeof (ChartSeriesStyle), value.ToString());
      }
      catch (Exception ex)
      {
      }
      return this;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public ChartSeriesBuilder<T> Style(ChartPolarLineStyle value)
    {
      try
      {
        this.Container.Style = (ChartSeriesStyle?) Enum.Parse(typeof (ChartSeriesStyle), value.ToString());
      }
      catch (Exception ex)
      {
      }
      return this;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public ChartSeriesBuilder<T> Style(ChartRadarLineStyle value)
    {
      try
      {
        this.Container.Style = (ChartSeriesStyle?) Enum.Parse(typeof (ChartSeriesStyle), value.ToString());
      }
      catch (Exception ex)
      {
      }
      return this;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public ChartSeriesBuilder<T> Style(ChartScatterLineStyle value)
    {
      try
      {
        this.Container.Style = (ChartSeriesStyle?) Enum.Parse(typeof (ChartSeriesStyle), value.ToString());
      }
      catch (Exception ex)
      {
      }
      return this;
    }

    [Obsolete("This property is obsolete. The series type is determined by the specific fluent builder.")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public ChartSeriesBuilder<T> Type(string value)
    {
      this.Container.Type = value;
      return this;
    }

    public ChartSeriesBuilder<T> AutoFit(bool value)
    {
      this.Container.AutoFit = new bool?(value);
      return this;
    }

    public ChartSeriesBuilder<T> AutoFit()
    {
      this.Container.AutoFit = new bool?(true);
      return this;
    }

    public ChartSeriesBuilder<T> Axis(string value)
    {
      this.Container.Axis = value;
      return this;
    }

    public ChartSeriesBuilder<T> Border(
      Action<ChartSeriesBorderSettingsBuilder<T>> configurator)
    {
      this.Container.Border.Chart = this.Container.Chart;
      configurator(new ChartSeriesBorderSettingsBuilder<T>(this.Container.Border));
      return this;
    }

    public ChartSeriesBuilder<T> CategoryAxis(string value)
    {
      this.Container.CategoryAxis = value;
      return this;
    }

    public ChartSeriesBuilder<T> CategoryField(string value)
    {
      this.Container.CategoryField = value;
      return this;
    }

    public ChartSeriesBuilder<T> CloseField(string value)
    {
      this.Container.CloseField = value;
      return this;
    }

    public ChartSeriesBuilder<T> Color(string value)
    {
      this.Container.ColorHandler = (ClientHandlerDescriptor) null;
      this.Container.Color = value;
      return this;
    }

    public ChartSeriesBuilder<T> ColorHandler(string handler)
    {
      this.Container.Color = (string) null;
      this.Container.ColorHandler = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public ChartSeriesBuilder<T> ColorHandler(Func<object, object> handler)
    {
      this.Container.Color = (string) null;
      this.Container.ColorHandler = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public ChartSeriesBuilder<T> ColorField(string value)
    {
      this.Container.ColorField = value;
      return this;
    }

    public ChartSeriesBuilder<T> Connectors(
      Action<ChartSeriesConnectorsSettingsBuilder<T>> configurator)
    {
      this.Container.Connectors.Chart = this.Container.Chart;
      configurator(new ChartSeriesConnectorsSettingsBuilder<T>(this.Container.Connectors));
      return this;
    }

    public ChartSeriesBuilder<T> CurrentField(string value)
    {
      this.Container.CurrentField = value;
      return this;
    }

    public ChartSeriesBuilder<T> DashType(ChartDashType value)
    {
      this.Container.DashType = new ChartDashType?(value);
      return this;
    }

    public ChartSeriesBuilder<T> DownColor(string value)
    {
      this.Container.DownColorHandler = (ClientHandlerDescriptor) null;
      this.Container.DownColor = value;
      return this;
    }

    public ChartSeriesBuilder<T> DownColorHandler(string handler)
    {
      this.Container.DownColor = (string) null;
      this.Container.DownColorHandler = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public ChartSeriesBuilder<T> DownColorHandler(Func<object, object> handler)
    {
      this.Container.DownColor = (string) null;
      this.Container.DownColorHandler = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public ChartSeriesBuilder<T> DownColorField(string value)
    {
      this.Container.DownColorField = value;
      return this;
    }

    public ChartSeriesBuilder<T> SegmentSpacing(double value)
    {
      this.Container.SegmentSpacing = new double?(value);
      return this;
    }

    public ChartSeriesBuilder<T> SummaryField(string value)
    {
      this.Container.SummaryField = value;
      return this;
    }

    public ChartSeriesBuilder<T> NeckRatio(double value)
    {
      this.Container.NeckRatio = new double?(value);
      return this;
    }

    public ChartSeriesBuilder<T> DynamicSlope(bool value)
    {
      this.Container.DynamicSlope = new bool?(value);
      return this;
    }

    public ChartSeriesBuilder<T> DynamicSlope()
    {
      this.Container.DynamicSlope = new bool?(true);
      return this;
    }

    public ChartSeriesBuilder<T> DynamicHeight(bool value)
    {
      this.Container.DynamicHeight = new bool?(value);
      return this;
    }

    public ChartSeriesBuilder<T> ErrorBars(
      Action<ChartSeriesErrorBarsSettingsBuilder<T>> configurator)
    {
      this.Container.ErrorBars.Chart = this.Container.Chart;
      configurator(new ChartSeriesErrorBarsSettingsBuilder<T>(this.Container.ErrorBars));
      return this;
    }

    public ChartSeriesBuilder<T> ErrorLowField(string value)
    {
      this.Container.ErrorLowField = value;
      return this;
    }

    public ChartSeriesBuilder<T> ErrorHighField(string value)
    {
      this.Container.ErrorHighField = value;
      return this;
    }

    public ChartSeriesBuilder<T> XErrorLowField(string value)
    {
      this.Container.XErrorLowField = value;
      return this;
    }

    public ChartSeriesBuilder<T> XErrorHighField(string value)
    {
      this.Container.XErrorHighField = value;
      return this;
    }

    public ChartSeriesBuilder<T> YErrorLowField(string value)
    {
      this.Container.YErrorLowField = value;
      return this;
    }

    public ChartSeriesBuilder<T> YErrorHighField(string value)
    {
      this.Container.YErrorHighField = value;
      return this;
    }

    public ChartSeriesBuilder<T> ExplodeField(string value)
    {
      this.Container.ExplodeField = value;
      return this;
    }

    public ChartSeriesBuilder<T> Field(string value)
    {
      this.Container.Field = value;
      return this;
    }

    public ChartSeriesBuilder<T> FromField(string value)
    {
      this.Container.FromField = value;
      return this;
    }

    public ChartSeriesBuilder<T> ToField(string value)
    {
      this.Container.ToField = value;
      return this;
    }

    public ChartSeriesBuilder<T> NoteTextField(string value)
    {
      this.Container.NoteTextField = value;
      return this;
    }

    public ChartSeriesBuilder<T> LowerField(string value)
    {
      this.Container.LowerField = value;
      return this;
    }

    public ChartSeriesBuilder<T> Q1Field(string value)
    {
      this.Container.Q1Field = value;
      return this;
    }

    public ChartSeriesBuilder<T> Median(
      Action<ChartSeriesMedianSettingsBuilder<T>> configurator)
    {
      this.Container.Median.Chart = this.Container.Chart;
      configurator(new ChartSeriesMedianSettingsBuilder<T>(this.Container.Median));
      return this;
    }

    public ChartSeriesBuilder<T> MedianField(string value)
    {
      this.Container.MedianField = value;
      return this;
    }

    public ChartSeriesBuilder<T> Q3Field(string value)
    {
      this.Container.Q3Field = value;
      return this;
    }

    public ChartSeriesBuilder<T> UpperField(string value)
    {
      this.Container.UpperField = value;
      return this;
    }

    public ChartSeriesBuilder<T> Mean(
      Action<ChartSeriesMeanSettingsBuilder<T>> configurator)
    {
      this.Container.Mean.Chart = this.Container.Chart;
      configurator(new ChartSeriesMeanSettingsBuilder<T>(this.Container.Mean));
      return this;
    }

    public ChartSeriesBuilder<T> MeanField(string value)
    {
      this.Container.MeanField = value;
      return this;
    }

    public ChartSeriesBuilder<T> OutliersField(string value)
    {
      this.Container.OutliersField = value;
      return this;
    }

    public ChartSeriesBuilder<T> Gap(double value)
    {
      this.Container.Gap = new double?(value);
      return this;
    }

    public ChartSeriesBuilder<T> HighField(string value)
    {
      this.Container.HighField = value;
      return this;
    }

    public ChartSeriesBuilder<T> Highlight(
      Action<ChartSeriesHighlightSettingsBuilder<T>> configurator)
    {
      this.Container.Highlight.Chart = this.Container.Chart;
      configurator(new ChartSeriesHighlightSettingsBuilder<T>(this.Container.Highlight));
      return this;
    }

    public ChartSeriesBuilder<T> HoleSize(double value)
    {
      this.Container.HoleSize = new double?(value);
      return this;
    }

    public ChartSeriesBuilder<T> Labels(
      Action<ChartSeriesLabelsSettingsBuilder<T>> configurator)
    {
      this.Container.Labels.Chart = this.Container.Chart;
      configurator(new ChartSeriesLabelsSettingsBuilder<T>(this.Container.Labels));
      return this;
    }

    public ChartSeriesBuilder<T> Line(
      Action<ChartSeriesLineSettingsBuilder<T>> configurator)
    {
      this.Container.Line.Chart = this.Container.Chart;
      configurator(new ChartSeriesLineSettingsBuilder<T>(this.Container.Line));
      return this;
    }

    public ChartSeriesBuilder<T> LowField(string value)
    {
      this.Container.LowField = value;
      return this;
    }

    public ChartSeriesBuilder<T> Margin(double value)
    {
      this.Container.Margin = new double?(value);
      return this;
    }

    public ChartSeriesBuilder<T> Markers(
      Action<ChartSeriesMarkersSettingsBuilder<T>> configurator)
    {
      this.Container.Markers.Chart = this.Container.Chart;
      configurator(new ChartSeriesMarkersSettingsBuilder<T>(this.Container.Markers));
      return this;
    }

    public ChartSeriesBuilder<T> Outliers(
      Action<ChartSeriesOutliersSettingsBuilder<T>> configurator)
    {
      this.Container.Outliers.Chart = this.Container.Chart;
      configurator(new ChartSeriesOutliersSettingsBuilder<T>(this.Container.Outliers));
      return this;
    }

    public ChartSeriesBuilder<T> Extremes(
      Action<ChartSeriesExtremesSettingsBuilder<T>> configurator)
    {
      this.Container.Extremes.Chart = this.Container.Chart;
      configurator(new ChartSeriesExtremesSettingsBuilder<T>(this.Container.Extremes));
      return this;
    }

    public ChartSeriesBuilder<T> MaxSize(double value)
    {
      this.Container.MaxSize = new double?(value);
      return this;
    }

    public ChartSeriesBuilder<T> MinSize(double value)
    {
      this.Container.MinSize = new double?(value);
      return this;
    }

    public ChartSeriesBuilder<T> Name(string value)
    {
      this.Container.Name = value;
      return this;
    }

    public ChartSeriesBuilder<T> NegativeColor(string value)
    {
      this.Container.NegativeColor = value;
      return this;
    }

    public ChartSeriesBuilder<T> NegativeValues(
      Action<ChartSeriesNegativeValuesSettingsBuilder<T>> configurator)
    {
      this.Container.NegativeValues.Chart = this.Container.Chart;
      configurator(new ChartSeriesNegativeValuesSettingsBuilder<T>(this.Container.NegativeValues));
      return this;
    }

    public ChartSeriesBuilder<T> Opacity(double value)
    {
      this.Container.Opacity = new double?(value);
      return this;
    }

    public ChartSeriesBuilder<T> OpenField(string value)
    {
      this.Container.OpenField = value;
      return this;
    }

    public ChartSeriesBuilder<T> Overlay(
      Action<ChartSeriesOverlaySettingsBuilder<T>> configurator)
    {
      this.Container.Overlay.Chart = this.Container.Chart;
      configurator(new ChartSeriesOverlaySettingsBuilder<T>(this.Container.Overlay));
      return this;
    }

    public ChartSeriesBuilder<T> Padding(double value)
    {
      this.Container.Padding = new double?(value);
      return this;
    }

    public ChartSeriesBuilder<T> Size(double value)
    {
      this.Container.Size = new double?(value);
      return this;
    }

    public ChartSeriesBuilder<T> SizeField(string value)
    {
      this.Container.SizeField = value;
      return this;
    }

    public ChartSeriesBuilder<T> Spacing(double value)
    {
      this.Container.Spacing = new double?(value);
      return this;
    }

    public ChartSeriesBuilder<T> Stack(
      Action<ChartSeriesStackSettingsBuilder<T>> configurator)
    {
      this.Container.Stack.Enabled = new bool?(true);
      this.Container.Stack.Chart = this.Container.Chart;
      configurator(new ChartSeriesStackSettingsBuilder<T>(this.Container.Stack));
      return this;
    }

    public ChartSeriesBuilder<T> Stack()
    {
      this.Container.Stack.Enabled = new bool?(true);
      return this;
    }

    public ChartSeriesBuilder<T> Stack(bool enabled)
    {
      this.Container.Stack.Enabled = new bool?(enabled);
      return this;
    }

    public ChartSeriesBuilder<T> StartAngle(double value)
    {
      this.Container.StartAngle = new double?(value);
      return this;
    }

    public ChartSeriesBuilder<T> TargetField(string value)
    {
      this.Container.TargetField = value;
      return this;
    }

    public ChartSeriesBuilder<T> Target(
      Action<ChartSeriesTargetSettingsBuilder<T>> configurator)
    {
      this.Container.Target.Chart = this.Container.Chart;
      configurator(new ChartSeriesTargetSettingsBuilder<T>(this.Container.Target));
      return this;
    }

    public ChartSeriesBuilder<T> Tooltip(
      Action<ChartSeriesTooltipSettingsBuilder<T>> configurator)
    {
      this.Container.Tooltip.Chart = this.Container.Chart;
      configurator(new ChartSeriesTooltipSettingsBuilder<T>(this.Container.Tooltip));
      return this;
    }

    public ChartSeriesBuilder<T> Visible(bool value)
    {
      this.Container.Visible = new bool?(value);
      return this;
    }

    public ChartSeriesBuilder<T> VisibleInLegend(bool value)
    {
      this.Container.VisibleInLegend = new bool?(value);
      return this;
    }

    public ChartSeriesBuilder<T> VisibleInLegendField(string value)
    {
      this.Container.VisibleInLegendField = value;
      return this;
    }

    public ChartSeriesBuilder<T> Visual(string handler)
    {
      this.Container.Visual = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public ChartSeriesBuilder<T> Visual(Func<object, object> handler)
    {
      this.Container.Visual = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public ChartSeriesBuilder<T> Whiskers(
      Action<ChartSeriesWhiskersSettingsBuilder<T>> configurator)
    {
      this.Container.Whiskers.Chart = this.Container.Chart;
      configurator(new ChartSeriesWhiskersSettingsBuilder<T>(this.Container.Whiskers));
      return this;
    }

    public ChartSeriesBuilder<T> Width(double value)
    {
      this.Container.Width = new double?(value);
      return this;
    }

    public ChartSeriesBuilder<T> XAxis(string value)
    {
      this.Container.XAxis = value;
      return this;
    }

    public ChartSeriesBuilder<T> XField(string value)
    {
      this.Container.XField = value;
      return this;
    }

    public ChartSeriesBuilder<T> YAxis(string value)
    {
      this.Container.YAxis = value;
      return this;
    }

    public ChartSeriesBuilder<T> YField(string value)
    {
      this.Container.YField = value;
      return this;
    }

    public ChartSeriesBuilder<T> Notes(
      Action<ChartSeriesNotesSettingsBuilder<T>> configurator)
    {
      this.Container.Notes.Chart = this.Container.Chart;
      configurator(new ChartSeriesNotesSettingsBuilder<T>(this.Container.Notes));
      return this;
    }

    public ChartSeriesBuilder<T> ZIndex(double value)
    {
      this.Container.ZIndex = new double?(value);
      return this;
    }

    public ChartSeriesBuilder<T> Aggregate(ChartSeriesAggregate value)
    {
      this.Container.AggregateHandler = (ClientHandlerDescriptor) null;
      this.Container.Aggregate = new ChartSeriesAggregate?(value);
      return this;
    }

    public ChartSeriesBuilder<T> AggregateHandler(string handler)
    {
      this.Container.Aggregate = new ChartSeriesAggregate?();
      this.Container.AggregateHandler = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public ChartSeriesBuilder<T> AggregateHandler(Func<object, object> handler)
    {
      this.Container.Aggregate = new ChartSeriesAggregate?();
      this.Container.AggregateHandler = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public ChartSeriesBuilder<T> MissingValues(ChartSeriesMissingValues value)
    {
      this.Container.MissingValues = new ChartSeriesMissingValues?(value);
      return this;
    }

    public ChartSeriesBuilder<T> Style(ChartSeriesStyle value)
    {
      this.Container.Style = new ChartSeriesStyle?(value);
      return this;
    }
  }
}
