// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.ChartTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Rendering;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("kendo-chart")]
  [RestrictChildren("axis-defaults", new string[] {"category-axis", "chart-area", "chart-legend", "panes", "pannable", "pdf", "plot-area", "series", "series-defaults", "chart-title", "tooltip", "value-axis", "x-axis", "y-axis", "zoomable", "datasource"})]
  public class ChartTagHelper : TagHelperBase, IDataBoundWidget<
  #nullable disable
  DataSourceTagHelper>
  {
    [HtmlAttributeNotBound]
    public DataSourceTagHelper Datasource { get; set; }

    public string DatasourceId { get; set; }

    public ChartTagHelper(IKendoHtmlGenerator generator)
      : base(generator)
    {
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      ChartTagHelper chartTagHelper = this;
      context.Items[(object) chartTagHelper.GetType()] = (object) chartTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      // ISSUE: reference to a compiler-generated method
      await chartTagHelper.\u003C\u003En__0(context, output);
    }

    protected override void WriteHtml(TagHelperOutput output)
    {
      this.GenerateId(output);
      TagBuilder tag = this.Generator.GenerateTag("div", this.ViewContext, this.Id, this.Name, (IDictionary<string, object>) new Dictionary<string, object>());
      output.TagName = "div";
      output.MergeAttributes(tag);
    }

    protected override string GetInitializationScript()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      if (this.DatasourceId.HasValue())
        dictionary["dataSourceId"] = (object) this.DatasourceId;
      else if (this.Datasource != null)
        dictionary["dataSource"] = (object) this.Datasource.Serialize();
      return this.Initializer.Initialize(this.Selector, "Chart", (IDictionary<string, object>) dictionary);
    }

    public string OnAxisLabelClick { get; set; }

    public string OnDataBound { get; set; }

    public string OnDrag { get; set; }

    public string OnDragEnd { get; set; }

    public string OnDragStart { get; set; }

    public string OnLegendItemClick { get; set; }

    public string OnLegendItemHover { get; set; }

    public string OnLegendItemLeave { get; set; }

    public string OnNoteClick { get; set; }

    public string OnNoteHover { get; set; }

    public string OnNoteLeave { get; set; }

    public string OnPaneRender { get; set; }

    public string OnPlotAreaClick { get; set; }

    public string OnPlotAreaHover { get; set; }

    public string OnPlotAreaLeave { get; set; }

    public string OnRender { get; set; }

    public string OnSelect { get; set; }

    public string OnSelectEnd { get; set; }

    public string OnSelectStart { get; set; }

    public string OnSeriesClick { get; set; }

    public string OnSeriesHover { get; set; }

    public string OnSeriesOver { get; set; }

    public string OnSeriesLeave { get; set; }

    public string OnZoom { get; set; }

    public string OnZoomEnd { get; set; }

    public string OnZoomStart { get; set; }

    protected override Dictionary<string, object> SerializeEvents()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string onAxisLabelClick = this.OnAxisLabelClick;
      if ((onAxisLabelClick != null ? (onAxisLabelClick.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["axisLabelClick"] = (object) this.CreateHandler(this.OnAxisLabelClick);
      string onDataBound = this.OnDataBound;
      if ((onDataBound != null ? (onDataBound.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataBound"] = (object) this.CreateHandler(this.OnDataBound);
      string onDrag = this.OnDrag;
      if ((onDrag != null ? (onDrag.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["drag"] = (object) this.CreateHandler(this.OnDrag);
      string onDragEnd = this.OnDragEnd;
      if ((onDragEnd != null ? (onDragEnd.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dragEnd"] = (object) this.CreateHandler(this.OnDragEnd);
      string onDragStart = this.OnDragStart;
      if ((onDragStart != null ? (onDragStart.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dragStart"] = (object) this.CreateHandler(this.OnDragStart);
      string onLegendItemClick = this.OnLegendItemClick;
      if ((onLegendItemClick != null ? (onLegendItemClick.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["legendItemClick"] = (object) this.CreateHandler(this.OnLegendItemClick);
      string onLegendItemHover = this.OnLegendItemHover;
      if ((onLegendItemHover != null ? (onLegendItemHover.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["legendItemHover"] = (object) this.CreateHandler(this.OnLegendItemHover);
      string onLegendItemLeave = this.OnLegendItemLeave;
      if ((onLegendItemLeave != null ? (onLegendItemLeave.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["legendItemLeave"] = (object) this.CreateHandler(this.OnLegendItemLeave);
      string onNoteClick = this.OnNoteClick;
      if ((onNoteClick != null ? (onNoteClick.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["noteClick"] = (object) this.CreateHandler(this.OnNoteClick);
      string onNoteHover = this.OnNoteHover;
      if ((onNoteHover != null ? (onNoteHover.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["noteHover"] = (object) this.CreateHandler(this.OnNoteHover);
      string onNoteLeave = this.OnNoteLeave;
      if ((onNoteLeave != null ? (onNoteLeave.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["noteLeave"] = (object) this.CreateHandler(this.OnNoteLeave);
      string onPaneRender = this.OnPaneRender;
      if ((onPaneRender != null ? (onPaneRender.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["paneRender"] = (object) this.CreateHandler(this.OnPaneRender);
      string onPlotAreaClick = this.OnPlotAreaClick;
      if ((onPlotAreaClick != null ? (onPlotAreaClick.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["plotAreaClick"] = (object) this.CreateHandler(this.OnPlotAreaClick);
      string onPlotAreaHover = this.OnPlotAreaHover;
      if ((onPlotAreaHover != null ? (onPlotAreaHover.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["plotAreaHover"] = (object) this.CreateHandler(this.OnPlotAreaHover);
      string onPlotAreaLeave = this.OnPlotAreaLeave;
      if ((onPlotAreaLeave != null ? (onPlotAreaLeave.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["plotAreaLeave"] = (object) this.CreateHandler(this.OnPlotAreaLeave);
      string onRender = this.OnRender;
      if ((onRender != null ? (onRender.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["render"] = (object) this.CreateHandler(this.OnRender);
      string onSelect = this.OnSelect;
      if ((onSelect != null ? (onSelect.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["select"] = (object) this.CreateHandler(this.OnSelect);
      string onSelectEnd = this.OnSelectEnd;
      if ((onSelectEnd != null ? (onSelectEnd.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["selectEnd"] = (object) this.CreateHandler(this.OnSelectEnd);
      string onSelectStart = this.OnSelectStart;
      if ((onSelectStart != null ? (onSelectStart.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["selectStart"] = (object) this.CreateHandler(this.OnSelectStart);
      string onSeriesClick = this.OnSeriesClick;
      if ((onSeriesClick != null ? (onSeriesClick.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["seriesClick"] = (object) this.CreateHandler(this.OnSeriesClick);
      string onSeriesHover = this.OnSeriesHover;
      if ((onSeriesHover != null ? (onSeriesHover.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["seriesHover"] = (object) this.CreateHandler(this.OnSeriesHover);
      string onSeriesOver = this.OnSeriesOver;
      if ((onSeriesOver != null ? (onSeriesOver.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["seriesOver"] = (object) this.CreateHandler(this.OnSeriesOver);
      string onSeriesLeave = this.OnSeriesLeave;
      if ((onSeriesLeave != null ? (onSeriesLeave.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["seriesLeave"] = (object) this.CreateHandler(this.OnSeriesLeave);
      string onZoom = this.OnZoom;
      if ((onZoom != null ? (onZoom.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["zoom"] = (object) this.CreateHandler(this.OnZoom);
      string onZoomEnd = this.OnZoomEnd;
      if ((onZoomEnd != null ? (onZoomEnd.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["zoomEnd"] = (object) this.CreateHandler(this.OnZoomEnd);
      string onZoomStart = this.OnZoomStart;
      if ((onZoomStart != null ? (onZoomStart.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["zoomStart"] = (object) this.CreateHandler(this.OnZoomStart);
      return dictionary;
    }

    public bool? AutoBind { get; set; }

    [HtmlAttributeNotBound]
    public ChartAxisDefaultsSettingsTagHelper AxisDefaults { get; set; }

    [HtmlAttributeNotBound]
    public ChartCategoryAxisTagHelperCollection CategoryAxis { get; set; }

    [HtmlAttributeNotBound]
    public ChartChartAreaSettingsTagHelper ChartArea { get; set; }

    [HtmlAttributeNotBound]
    public ChartLegendSettingsTagHelper Legend { get; set; }

    [HtmlAttributeNotBound]
    public ChartPaneDefaultsSettingsTagHelper PaneDefaults { get; set; }

    [HtmlAttributeNotBound]
    public ChartPanesTagHelper Panes { get; set; }

    [HtmlAttributeNotBound]
    public ChartPannableSettingsTagHelper Pannable { get; set; }

    [HtmlAttributeNotBound]
    public ChartPdfSettingsTagHelper Pdf { get; set; }

    public bool? PersistSeriesVisibility { get; set; }

    [HtmlAttributeNotBound]
    public ChartPlotAreaSettingsTagHelper PlotArea { get; set; }

    [HtmlAttributeNotBound]
    public ChartSeriesTagHelperCollection Series { get; set; }

    public string[] SeriesColors { get; set; }

    [HtmlAttributeNotBound]
    public ChartSeriesDefaultsSettingsTagHelper SeriesDefaults { get; set; }

    public string Theme { get; set; }

    [HtmlAttributeNotBound]
    public ChartTitleSettingsTagHelper Title { get; set; }

    [HtmlAttributeNotBound]
    public ChartTooltipSettingsTagHelper Tooltip { get; set; }

    public bool? Transitions { get; set; }

    [HtmlAttributeNotBound]
    public ChartValueAxisTagHelperCollection ValueAxis { get; set; }

    [HtmlAttributeNotBound]
    public ChartXAxisTagHelperCollection XAxis { get; set; }

    [HtmlAttributeNotBound]
    public ChartYAxisTagHelperCollection YAxis { get; set; }

    [HtmlAttributeNotBound]
    public ChartZoomableSettingsTagHelper Zoomable { get; set; }

    public RenderingMode? RenderAs { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = base.SerializeSettings();
      if (this.AutoBind.HasValue)
        dictionary1["autoBind"] = (object) this.AutoBind;
      if (this.AxisDefaults != null)
      {
        Dictionary<string, object> source = this.AxisDefaults.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["axisDefaults"] = (object) source;
      }
      if (this.CategoryAxis != null)
      {
        IEnumerable<Dictionary<string, object>> source = this.CategoryAxis.Select<ChartCategoryAxisTagHelper, Dictionary<string, object>>((Func<ChartCategoryAxisTagHelper, Dictionary<string, object>>) (i => i.Serialize()));
        if (source.Any<Dictionary<string, object>>())
          dictionary1["categoryAxis"] = (object) source;
      }
      if (this.ChartArea != null)
      {
        Dictionary<string, object> source = this.ChartArea.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["chartArea"] = (object) source;
      }
      if (this.Legend != null)
      {
        Dictionary<string, object> source = this.Legend.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["legend"] = (object) source;
      }
      if (this.PaneDefaults != null)
      {
        Dictionary<string, object> source = this.PaneDefaults.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["paneDefaults"] = (object) source;
      }
      if (this.Panes != null)
      {
        IEnumerable<Dictionary<string, object>> source = this.Panes.Select<ChartPaneTagHelper, Dictionary<string, object>>((Func<ChartPaneTagHelper, Dictionary<string, object>>) (i => i.Serialize()));
        if (source.Any<Dictionary<string, object>>())
          dictionary1["panes"] = (object) source;
      }
      if (this.Pannable != null)
      {
        Dictionary<string, object> source = this.Pannable.Serialize();
        if (source.Any<KeyValuePair<string, object>>() && (!this.Pannable.Enabled.HasValue || this.Pannable.Enabled.Value))
          dictionary1["pannable"] = (object) source;
        else if (this.Pannable.Enabled.HasValue && this.Pannable.Enabled.Value)
          dictionary1["pannable"] = (object) this.Pannable.Enabled;
      }
      if (this.Pdf != null)
      {
        Dictionary<string, object> source = this.Pdf.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["pdf"] = (object) source;
      }
      if (this.PersistSeriesVisibility.HasValue)
        dictionary1["persistSeriesVisibility"] = (object) this.PersistSeriesVisibility;
      if (this.PlotArea != null)
      {
        Dictionary<string, object> source = this.PlotArea.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["plotArea"] = (object) source;
      }
      if (this.Series != null)
      {
        IEnumerable<Dictionary<string, object>> source = this.Series.Select<ChartSeriesTagHelper, Dictionary<string, object>>((Func<ChartSeriesTagHelper, Dictionary<string, object>>) (i => i.Serialize()));
        if (source.Any<Dictionary<string, object>>())
          dictionary1["series"] = (object) source;
      }
      string[] seriesColors = this.SeriesColors;
      if ((seriesColors != null ? (((IEnumerable<string>) seriesColors).Any<string>() ? 1 : 0) : 0) != 0)
        dictionary1["seriesColors"] = (object) this.SeriesColors;
      if (this.SeriesDefaults != null)
      {
        Dictionary<string, object> source = this.SeriesDefaults.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["seriesDefaults"] = (object) source;
      }
      string theme = this.Theme;
      if ((theme != null ? (theme.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["theme"] = (object) this.Theme;
      if (this.Title != null)
      {
        Dictionary<string, object> source = this.Title.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["title"] = (object) source;
      }
      if (this.Tooltip != null)
      {
        Dictionary<string, object> source = this.Tooltip.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["tooltip"] = (object) source;
      }
      if (this.Transitions.HasValue)
        dictionary1["transitions"] = (object) this.Transitions;
      if (this.ValueAxis != null)
      {
        IEnumerable<Dictionary<string, object>> source = this.ValueAxis.Select<ChartValueAxisTagHelper, Dictionary<string, object>>((Func<ChartValueAxisTagHelper, Dictionary<string, object>>) (i => i.Serialize()));
        if (source.Any<Dictionary<string, object>>())
          dictionary1["valueAxis"] = (object) source;
      }
      if (this.XAxis != null)
      {
        IEnumerable<Dictionary<string, object>> source = this.XAxis.Select<ChartXAxisTagHelper, Dictionary<string, object>>((Func<ChartXAxisTagHelper, Dictionary<string, object>>) (i => i.Serialize()));
        if (source.Any<Dictionary<string, object>>())
          dictionary1["xAxis"] = (object) source;
      }
      if (this.YAxis != null)
      {
        IEnumerable<Dictionary<string, object>> source = this.YAxis.Select<ChartYAxisTagHelper, Dictionary<string, object>>((Func<ChartYAxisTagHelper, Dictionary<string, object>>) (i => i.Serialize()));
        if (source.Any<Dictionary<string, object>>())
          dictionary1["yAxis"] = (object) source;
      }
      if (this.Zoomable != null)
      {
        Dictionary<string, object> source = this.Zoomable.Serialize();
        if (source.Any<KeyValuePair<string, object>>() && (!this.Zoomable.Enabled.HasValue || this.Zoomable.Enabled.Value))
          dictionary1["zoomable"] = (object) source;
        else if (this.Zoomable.Enabled.HasValue && this.Zoomable.Enabled.Value)
          dictionary1["zoomable"] = (object) this.Zoomable.Enabled;
      }
      if (this.RenderAs.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        RenderingMode? renderAs = this.RenderAs;
        ref RenderingMode? local = ref renderAs;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["renderAs"] = (object) str;
      }
      return dictionary1;
    }
  }
}
