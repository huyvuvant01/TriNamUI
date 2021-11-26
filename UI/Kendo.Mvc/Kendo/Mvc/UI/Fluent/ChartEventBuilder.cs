// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ChartEventBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class ChartEventBuilder : EventBuilder
  {
    public ChartEventBuilder(IDictionary<string, object> events)
      : base(events)
    {
    }

    public ChartEventBuilder AxisLabelClick(string handler)
    {
      this.Handler("axisLabelClick", handler);
      return this;
    }

    public ChartEventBuilder AxisLabelClick(Func<object, object> handler)
    {
      this.Handler("axisLabelClick", handler);
      return this;
    }

    public ChartEventBuilder DataBound(string handler)
    {
      this.Handler("dataBound", handler);
      return this;
    }

    public ChartEventBuilder DataBound(Func<object, object> handler)
    {
      this.Handler("dataBound", handler);
      return this;
    }

    public ChartEventBuilder Drag(string handler)
    {
      this.Handler("drag", handler);
      return this;
    }

    public ChartEventBuilder Drag(Func<object, object> handler)
    {
      this.Handler("drag", handler);
      return this;
    }

    public ChartEventBuilder DragEnd(string handler)
    {
      this.Handler("dragEnd", handler);
      return this;
    }

    public ChartEventBuilder DragEnd(Func<object, object> handler)
    {
      this.Handler("dragEnd", handler);
      return this;
    }

    public ChartEventBuilder DragStart(string handler)
    {
      this.Handler("dragStart", handler);
      return this;
    }

    public ChartEventBuilder DragStart(Func<object, object> handler)
    {
      this.Handler("dragStart", handler);
      return this;
    }

    public ChartEventBuilder LegendItemClick(string handler)
    {
      this.Handler("legendItemClick", handler);
      return this;
    }

    public ChartEventBuilder LegendItemClick(Func<object, object> handler)
    {
      this.Handler("legendItemClick", handler);
      return this;
    }

    public ChartEventBuilder LegendItemHover(string handler)
    {
      this.Handler("legendItemHover", handler);
      return this;
    }

    public ChartEventBuilder LegendItemHover(Func<object, object> handler)
    {
      this.Handler("legendItemHover", handler);
      return this;
    }

    public ChartEventBuilder LegendItemLeave(string handler)
    {
      this.Handler("legendItemLeave", handler);
      return this;
    }

    public ChartEventBuilder LegendItemLeave(Func<object, object> handler)
    {
      this.Handler("legendItemLeave", handler);
      return this;
    }

    public ChartEventBuilder NoteClick(string handler)
    {
      this.Handler("noteClick", handler);
      return this;
    }

    public ChartEventBuilder NoteClick(Func<object, object> handler)
    {
      this.Handler("noteClick", handler);
      return this;
    }

    public ChartEventBuilder NoteHover(string handler)
    {
      this.Handler("noteHover", handler);
      return this;
    }

    public ChartEventBuilder NoteHover(Func<object, object> handler)
    {
      this.Handler("noteHover", handler);
      return this;
    }

    public ChartEventBuilder NoteLeave(string handler)
    {
      this.Handler("noteLeave", handler);
      return this;
    }

    public ChartEventBuilder NoteLeave(Func<object, object> handler)
    {
      this.Handler("noteLeave", handler);
      return this;
    }

    public ChartEventBuilder PaneRender(string handler)
    {
      this.Handler("paneRender", handler);
      return this;
    }

    public ChartEventBuilder PaneRender(Func<object, object> handler)
    {
      this.Handler("paneRender", handler);
      return this;
    }

    public ChartEventBuilder PlotAreaClick(string handler)
    {
      this.Handler("plotAreaClick", handler);
      return this;
    }

    public ChartEventBuilder PlotAreaClick(Func<object, object> handler)
    {
      this.Handler("plotAreaClick", handler);
      return this;
    }

    public ChartEventBuilder PlotAreaHover(string handler)
    {
      this.Handler("plotAreaHover", handler);
      return this;
    }

    public ChartEventBuilder PlotAreaHover(Func<object, object> handler)
    {
      this.Handler("plotAreaHover", handler);
      return this;
    }

    public ChartEventBuilder PlotAreaLeave(string handler)
    {
      this.Handler("plotAreaLeave", handler);
      return this;
    }

    public ChartEventBuilder PlotAreaLeave(Func<object, object> handler)
    {
      this.Handler("plotAreaLeave", handler);
      return this;
    }

    public ChartEventBuilder Render(string handler)
    {
      this.Handler("render", handler);
      return this;
    }

    public ChartEventBuilder Render(Func<object, object> handler)
    {
      this.Handler("render", handler);
      return this;
    }

    public ChartEventBuilder Select(string handler)
    {
      this.Handler("select", handler);
      return this;
    }

    public ChartEventBuilder Select(Func<object, object> handler)
    {
      this.Handler("select", handler);
      return this;
    }

    public ChartEventBuilder SelectEnd(string handler)
    {
      this.Handler("selectEnd", handler);
      return this;
    }

    public ChartEventBuilder SelectEnd(Func<object, object> handler)
    {
      this.Handler("selectEnd", handler);
      return this;
    }

    public ChartEventBuilder SelectStart(string handler)
    {
      this.Handler("selectStart", handler);
      return this;
    }

    public ChartEventBuilder SelectStart(Func<object, object> handler)
    {
      this.Handler("selectStart", handler);
      return this;
    }

    public ChartEventBuilder SeriesClick(string handler)
    {
      this.Handler("seriesClick", handler);
      return this;
    }

    public ChartEventBuilder SeriesClick(Func<object, object> handler)
    {
      this.Handler("seriesClick", handler);
      return this;
    }

    public ChartEventBuilder SeriesHover(string handler)
    {
      this.Handler("seriesHover", handler);
      return this;
    }

    public ChartEventBuilder SeriesHover(Func<object, object> handler)
    {
      this.Handler("seriesHover", handler);
      return this;
    }

    public ChartEventBuilder SeriesOver(string handler)
    {
      this.Handler("seriesOver", handler);
      return this;
    }

    public ChartEventBuilder SeriesOver(Func<object, object> handler)
    {
      this.Handler("seriesOver", handler);
      return this;
    }

    public ChartEventBuilder SeriesLeave(string handler)
    {
      this.Handler("seriesLeave", handler);
      return this;
    }

    public ChartEventBuilder SeriesLeave(Func<object, object> handler)
    {
      this.Handler("seriesLeave", handler);
      return this;
    }

    public ChartEventBuilder Zoom(string handler)
    {
      this.Handler("zoom", handler);
      return this;
    }

    public ChartEventBuilder Zoom(Func<object, object> handler)
    {
      this.Handler("zoom", handler);
      return this;
    }

    public ChartEventBuilder ZoomEnd(string handler)
    {
      this.Handler("zoomEnd", handler);
      return this;
    }

    public ChartEventBuilder ZoomEnd(Func<object, object> handler)
    {
      this.Handler("zoomEnd", handler);
      return this;
    }

    public ChartEventBuilder ZoomStart(string handler)
    {
      this.Handler("zoomStart", handler);
      return this;
    }

    public ChartEventBuilder ZoomStart(Func<object, object> handler)
    {
      this.Handler("zoomStart", handler);
      return this;
    }
  }
}
