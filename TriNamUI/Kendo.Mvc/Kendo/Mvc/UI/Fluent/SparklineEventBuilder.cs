// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.SparklineEventBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class SparklineEventBuilder : EventBuilder
  {
    public SparklineEventBuilder(IDictionary<string, object> events)
      : base(events)
    {
    }

    public SparklineEventBuilder AxisLabelClick(string handler)
    {
      this.Handler("axisLabelClick", handler);
      return this;
    }

    public SparklineEventBuilder AxisLabelClick(Func<object, object> handler)
    {
      this.Handler("axisLabelClick", handler);
      return this;
    }

    public SparklineEventBuilder DataBound(string handler)
    {
      this.Handler("dataBound", handler);
      return this;
    }

    public SparklineEventBuilder DataBound(Func<object, object> handler)
    {
      this.Handler("dataBound", handler);
      return this;
    }

    public SparklineEventBuilder DragStart(string handler)
    {
      this.Handler("dragStart", handler);
      return this;
    }

    public SparklineEventBuilder DragStart(Func<object, object> handler)
    {
      this.Handler("dragStart", handler);
      return this;
    }

    public SparklineEventBuilder Drag(string handler)
    {
      this.Handler("drag", handler);
      return this;
    }

    public SparklineEventBuilder Drag(Func<object, object> handler)
    {
      this.Handler("drag", handler);
      return this;
    }

    public SparklineEventBuilder DragEnd(string handler)
    {
      this.Handler("dragEnd", handler);
      return this;
    }

    public SparklineEventBuilder DragEnd(Func<object, object> handler)
    {
      this.Handler("dragEnd", handler);
      return this;
    }

    public SparklineEventBuilder PaneRender(string handler)
    {
      this.Handler("paneRender", handler);
      return this;
    }

    public SparklineEventBuilder PaneRender(Func<object, object> handler)
    {
      this.Handler("paneRender", handler);
      return this;
    }

    public SparklineEventBuilder PlotAreaClick(string handler)
    {
      this.Handler("plotAreaClick", handler);
      return this;
    }

    public SparklineEventBuilder PlotAreaClick(Func<object, object> handler)
    {
      this.Handler("plotAreaClick", handler);
      return this;
    }

    public SparklineEventBuilder PlotAreaHover(string handler)
    {
      this.Handler("plotAreaHover", handler);
      return this;
    }

    public SparklineEventBuilder PlotAreaHover(Func<object, object> handler)
    {
      this.Handler("plotAreaHover", handler);
      return this;
    }

    public SparklineEventBuilder PlotAreaLeave(string handler)
    {
      this.Handler("plotAreaLeave", handler);
      return this;
    }

    public SparklineEventBuilder PlotAreaLeave(Func<object, object> handler)
    {
      this.Handler("plotAreaLeave", handler);
      return this;
    }

    public SparklineEventBuilder SeriesClick(string handler)
    {
      this.Handler("seriesClick", handler);
      return this;
    }

    public SparklineEventBuilder SeriesClick(Func<object, object> handler)
    {
      this.Handler("seriesClick", handler);
      return this;
    }

    public SparklineEventBuilder SeriesHover(string handler)
    {
      this.Handler("seriesHover", handler);
      return this;
    }

    public SparklineEventBuilder SeriesHover(Func<object, object> handler)
    {
      this.Handler("seriesHover", handler);
      return this;
    }

    public SparklineEventBuilder SeriesOver(string handler)
    {
      this.Handler("seriesOver", handler);
      return this;
    }

    public SparklineEventBuilder SeriesOver(Func<object, object> handler)
    {
      this.Handler("seriesOver", handler);
      return this;
    }

    public SparklineEventBuilder SeriesLeave(string handler)
    {
      this.Handler("seriesLeave", handler);
      return this;
    }

    public SparklineEventBuilder SeriesLeave(Func<object, object> handler)
    {
      this.Handler("seriesLeave", handler);
      return this;
    }

    public SparklineEventBuilder ZoomStart(string handler)
    {
      this.Handler("zoomStart", handler);
      return this;
    }

    public SparklineEventBuilder ZoomStart(Func<object, object> handler)
    {
      this.Handler("zoomStart", handler);
      return this;
    }

    public SparklineEventBuilder Zoom(string handler)
    {
      this.Handler("zoom", handler);
      return this;
    }

    public SparklineEventBuilder Zoom(Func<object, object> handler)
    {
      this.Handler("zoom", handler);
      return this;
    }

    public SparklineEventBuilder ZoomEnd(string handler)
    {
      this.Handler("zoomEnd", handler);
      return this;
    }

    public SparklineEventBuilder ZoomEnd(Func<object, object> handler)
    {
      this.Handler("zoomEnd", handler);
      return this;
    }
  }
}
