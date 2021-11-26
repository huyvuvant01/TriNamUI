// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.StockChartEventBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class StockChartEventBuilder : EventBuilder
  {
    public StockChartEventBuilder(IDictionary<string, object> events)
      : base(events)
    {
    }

    public StockChartEventBuilder AxisLabelClick(string handler)
    {
      this.Handler("axisLabelClick", handler);
      return this;
    }

    public StockChartEventBuilder AxisLabelClick(Func<object, object> handler)
    {
      this.Handler("axisLabelClick", handler);
      return this;
    }

    public StockChartEventBuilder DataBound(string handler)
    {
      this.Handler("dataBound", handler);
      return this;
    }

    public StockChartEventBuilder DataBound(Func<object, object> handler)
    {
      this.Handler("dataBound", handler);
      return this;
    }

    public StockChartEventBuilder DragStart(string handler)
    {
      this.Handler("dragStart", handler);
      return this;
    }

    public StockChartEventBuilder DragStart(Func<object, object> handler)
    {
      this.Handler("dragStart", handler);
      return this;
    }

    public StockChartEventBuilder Drag(string handler)
    {
      this.Handler("drag", handler);
      return this;
    }

    public StockChartEventBuilder Drag(Func<object, object> handler)
    {
      this.Handler("drag", handler);
      return this;
    }

    public StockChartEventBuilder DragEnd(string handler)
    {
      this.Handler("dragEnd", handler);
      return this;
    }

    public StockChartEventBuilder DragEnd(Func<object, object> handler)
    {
      this.Handler("dragEnd", handler);
      return this;
    }

    public StockChartEventBuilder LegendItemClick(string handler)
    {
      this.Handler("legendItemClick", handler);
      return this;
    }

    public StockChartEventBuilder LegendItemClick(Func<object, object> handler)
    {
      this.Handler("legendItemClick", handler);
      return this;
    }

    public StockChartEventBuilder LegendItemHover(string handler)
    {
      this.Handler("legendItemHover", handler);
      return this;
    }

    public StockChartEventBuilder LegendItemHover(Func<object, object> handler)
    {
      this.Handler("legendItemHover", handler);
      return this;
    }

    public StockChartEventBuilder LegendItemLeave(string handler)
    {
      this.Handler("legendItemLeave", handler);
      return this;
    }

    public StockChartEventBuilder LegendItemLeave(Func<object, object> handler)
    {
      this.Handler("legendItemLeave", handler);
      return this;
    }

    public StockChartEventBuilder NoteClick(string handler)
    {
      this.Handler("noteClick", handler);
      return this;
    }

    public StockChartEventBuilder NoteClick(Func<object, object> handler)
    {
      this.Handler("noteClick", handler);
      return this;
    }

    public StockChartEventBuilder NoteHover(string handler)
    {
      this.Handler("noteHover", handler);
      return this;
    }

    public StockChartEventBuilder NoteHover(Func<object, object> handler)
    {
      this.Handler("noteHover", handler);
      return this;
    }

    public StockChartEventBuilder NoteLeave(string handler)
    {
      this.Handler("noteLeave", handler);
      return this;
    }

    public StockChartEventBuilder NoteLeave(Func<object, object> handler)
    {
      this.Handler("noteLeave", handler);
      return this;
    }

    public StockChartEventBuilder PaneRender(string handler)
    {
      this.Handler("paneRender", handler);
      return this;
    }

    public StockChartEventBuilder PaneRender(Func<object, object> handler)
    {
      this.Handler("paneRender", handler);
      return this;
    }

    public StockChartEventBuilder PlotAreaClick(string handler)
    {
      this.Handler("plotAreaClick", handler);
      return this;
    }

    public StockChartEventBuilder PlotAreaClick(Func<object, object> handler)
    {
      this.Handler("plotAreaClick", handler);
      return this;
    }

    public StockChartEventBuilder PlotAreaHover(string handler)
    {
      this.Handler("plotAreaHover", handler);
      return this;
    }

    public StockChartEventBuilder PlotAreaHover(Func<object, object> handler)
    {
      this.Handler("plotAreaHover", handler);
      return this;
    }

    public StockChartEventBuilder PlotAreaLeave(string handler)
    {
      this.Handler("plotAreaLeave", handler);
      return this;
    }

    public StockChartEventBuilder PlotAreaLeave(Func<object, object> handler)
    {
      this.Handler("plotAreaLeave", handler);
      return this;
    }

    public StockChartEventBuilder Render(string handler)
    {
      this.Handler("render", handler);
      return this;
    }

    public StockChartEventBuilder Render(Func<object, object> handler)
    {
      this.Handler("render", handler);
      return this;
    }

    public StockChartEventBuilder Select(string handler)
    {
      this.Handler("select", handler);
      return this;
    }

    public StockChartEventBuilder Select(Func<object, object> handler)
    {
      this.Handler("select", handler);
      return this;
    }

    public StockChartEventBuilder SelectEnd(string handler)
    {
      this.Handler("selectEnd", handler);
      return this;
    }

    public StockChartEventBuilder SelectEnd(Func<object, object> handler)
    {
      this.Handler("selectEnd", handler);
      return this;
    }

    public StockChartEventBuilder SelectStart(string handler)
    {
      this.Handler("selectStart", handler);
      return this;
    }

    public StockChartEventBuilder SelectStart(Func<object, object> handler)
    {
      this.Handler("selectStart", handler);
      return this;
    }

    public StockChartEventBuilder SeriesClick(string handler)
    {
      this.Handler("seriesClick", handler);
      return this;
    }

    public StockChartEventBuilder SeriesClick(Func<object, object> handler)
    {
      this.Handler("seriesClick", handler);
      return this;
    }

    public StockChartEventBuilder SeriesHover(string handler)
    {
      this.Handler("seriesHover", handler);
      return this;
    }

    public StockChartEventBuilder SeriesHover(Func<object, object> handler)
    {
      this.Handler("seriesHover", handler);
      return this;
    }

    public StockChartEventBuilder SeriesOver(string handler)
    {
      this.Handler("seriesOver", handler);
      return this;
    }

    public StockChartEventBuilder SeriesOver(Func<object, object> handler)
    {
      this.Handler("seriesOver", handler);
      return this;
    }

    public StockChartEventBuilder SeriesLeave(string handler)
    {
      this.Handler("seriesLeave", handler);
      return this;
    }

    public StockChartEventBuilder SeriesLeave(Func<object, object> handler)
    {
      this.Handler("seriesLeave", handler);
      return this;
    }

    public StockChartEventBuilder ZoomStart(string handler)
    {
      this.Handler("zoomStart", handler);
      return this;
    }

    public StockChartEventBuilder ZoomStart(Func<object, object> handler)
    {
      this.Handler("zoomStart", handler);
      return this;
    }

    public StockChartEventBuilder Zoom(string handler)
    {
      this.Handler("zoom", handler);
      return this;
    }

    public StockChartEventBuilder Zoom(Func<object, object> handler)
    {
      this.Handler("zoom", handler);
      return this;
    }

    public StockChartEventBuilder ZoomEnd(string handler)
    {
      this.Handler("zoomEnd", handler);
      return this;
    }

    public StockChartEventBuilder ZoomEnd(Func<object, object> handler)
    {
      this.Handler("zoomEnd", handler);
      return this;
    }
  }
}
