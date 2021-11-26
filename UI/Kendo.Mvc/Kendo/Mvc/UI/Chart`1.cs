// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Chart`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class Chart<T> : WidgetBase where T : class
  {
    public ChartSeriesDefaultsSettings<T> SeriesDefaults { get; } = new ChartSeriesDefaultsSettings<T>();

    public Chart(ViewContext viewContext)
      : base(viewContext)
    {
      this.DataSource = new DataSource(this.ModelMetadataProvider);
      this.DataSource.Schema.Data = "";
      this.DataSource.Schema.Total = "";
      this.DataSource.Schema.Errors = "";
      this.DataSource.ModelType(typeof (T));
    }

    public DataSource DataSource { get; private set; }

    public string DataSourceId { get; set; }

    public IEnumerable<T> Data { get; set; }

    protected override void WriteHtml(TextWriter writer)
    {
      this.GenerateTag(writer).WriteTo(writer, this.HtmlEncoder);
      base.WriteHtml(writer);
    }

    protected virtual TagBuilder GenerateTag(TextWriter writer) => this.Generator.GenerateTag("div", this.ViewContext, this.Id, this.Name, this.HtmlAttributes);

    public override void WriteInitializationScript(TextWriter writer)
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      this.SerializeCustomSettings((IDictionary<string, object>) dictionary);
      writer.Write(this.Initializer.Initialize(this.Selector, nameof (Chart<T>), (IDictionary<string, object>) dictionary));
    }

    protected virtual void SerializeCustomSettings(IDictionary<string, object> settings)
    {
      if (this.DataSourceId.HasValue())
        settings["dataSourceId"] = (object) this.DataSourceId;
      else
        this.SerializeDataSource(settings);
      IDictionary<string, object> source = this.SeriesDefaults.Serialize();
      if (!source.Any<KeyValuePair<string, object>>())
        return;
      settings["seriesDefaults"] = (object) source;
    }

    protected virtual void SerializeDataSource(IDictionary<string, object> settings)
    {
      DataSourceType? type = this.DataSource.Type;
      DataSourceType dataSourceType = DataSourceType.Custom;
      if (type.GetValueOrDefault() == dataSourceType & type.HasValue)
        settings["dataSource"] = (object) this.DataSource.ToJson();
      else if (!string.IsNullOrEmpty(this.DataSource.Transport.Read.Url))
      {
        if (!this.DataSource.Transport.Read.Type.HasValue())
          this.DataSource.Transport.Read.Type = "POST";
        if (!this.DataSource.Type.HasValue)
          this.DataSource.Type = new DataSourceType?(DataSourceType.Ajax);
        settings["dataSource"] = (object) this.DataSource.ToJson();
      }
      else
      {
        if (this.Data == null)
          return;
        IDictionary<string, object> json = this.DataSource.ToJson();
        json["data"] = (object) this.Data;
        json.Remove("transport");
        settings["dataSource"] = (object) json;
      }
    }

    public bool? AutoBind { get; set; }

    public ChartAxisDefaultsSettings<T> AxisDefaults { get; } = new ChartAxisDefaultsSettings<T>();

    public List<ChartCategoryAxis<T>> CategoryAxis { get; set; } = new List<ChartCategoryAxis<T>>();

    public ChartChartAreaSettings<T> ChartArea { get; } = new ChartChartAreaSettings<T>();

    public ChartLegendSettings<T> Legend { get; } = new ChartLegendSettings<T>();

    public ChartPaneDefaultsSettings<T> PaneDefaults { get; } = new ChartPaneDefaultsSettings<T>();

    public List<ChartPane<T>> Panes { get; set; } = new List<ChartPane<T>>();

    public ChartPannableSettings<T> Pannable { get; } = new ChartPannableSettings<T>();

    public ChartPdfSettings<T> Pdf { get; } = new ChartPdfSettings<T>();

    public bool? PersistSeriesVisibility { get; set; }

    public ChartPlotAreaSettings<T> PlotArea { get; } = new ChartPlotAreaSettings<T>();

    public List<ChartSeries<T>> Series { get; set; } = new List<ChartSeries<T>>();

    public string[] SeriesColors { get; set; }

    public string Theme { get; set; }

    public ChartTitleSettings<T> Title { get; } = new ChartTitleSettings<T>();

    public ChartTooltipSettings<T> Tooltip { get; } = new ChartTooltipSettings<T>();

    public bool? Transitions { get; set; }

    public List<ChartValueAxis<T>> ValueAxis { get; set; } = new List<ChartValueAxis<T>>();

    public List<ChartXAxis<T>> XAxis { get; set; } = new List<ChartXAxis<T>>();

    public List<ChartYAxis<T>> YAxis { get; set; } = new List<ChartYAxis<T>>();

    public ChartZoomableSettings<T> Zoomable { get; } = new ChartZoomableSettings<T>();

    public RenderingMode? RenderAs { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = base.SerializeSettings();
      if (this.AutoBind.HasValue)
        dictionary1["autoBind"] = (object) this.AutoBind;
      Dictionary<string, object> source1 = this.AxisDefaults.Serialize();
      if (source1.Any<KeyValuePair<string, object>>())
        dictionary1["axisDefaults"] = (object) source1;
      IEnumerable<Dictionary<string, object>> source2 = this.CategoryAxis.Select<ChartCategoryAxis<T>, Dictionary<string, object>>((Func<ChartCategoryAxis<T>, Dictionary<string, object>>) (i => i.Serialize()));
      if (source2.Any<Dictionary<string, object>>())
        dictionary1["categoryAxis"] = (object) source2;
      Dictionary<string, object> source3 = this.ChartArea.Serialize();
      if (source3.Any<KeyValuePair<string, object>>())
        dictionary1["chartArea"] = (object) source3;
      Dictionary<string, object> source4 = this.Legend.Serialize();
      if (source4.Any<KeyValuePair<string, object>>())
        dictionary1["legend"] = (object) source4;
      Dictionary<string, object> source5 = this.PaneDefaults.Serialize();
      if (source5.Any<KeyValuePair<string, object>>())
        dictionary1["paneDefaults"] = (object) source5;
      IEnumerable<Dictionary<string, object>> source6 = this.Panes.Select<ChartPane<T>, Dictionary<string, object>>((Func<ChartPane<T>, Dictionary<string, object>>) (i => i.Serialize()));
      if (source6.Any<Dictionary<string, object>>())
        dictionary1["panes"] = (object) source6;
      Dictionary<string, object> source7 = this.Pannable.Serialize();
      if (source7.Any<KeyValuePair<string, object>>())
        dictionary1["pannable"] = (object) source7;
      else if (this.Pannable.Enabled.HasValue)
        dictionary1["pannable"] = (object) this.Pannable.Enabled;
      Dictionary<string, object> source8 = this.Pdf.Serialize();
      if (source8.Any<KeyValuePair<string, object>>())
        dictionary1["pdf"] = (object) source8;
      if (this.PersistSeriesVisibility.HasValue)
        dictionary1["persistSeriesVisibility"] = (object) this.PersistSeriesVisibility;
      Dictionary<string, object> source9 = this.PlotArea.Serialize();
      if (source9.Any<KeyValuePair<string, object>>())
        dictionary1["plotArea"] = (object) source9;
      IEnumerable<Dictionary<string, object>> source10 = this.Series.Select<ChartSeries<T>, Dictionary<string, object>>((Func<ChartSeries<T>, Dictionary<string, object>>) (i => i.Serialize()));
      if (source10.Any<Dictionary<string, object>>())
        dictionary1["series"] = (object) source10;
      string[] seriesColors = this.SeriesColors;
      if ((seriesColors != null ? (((IEnumerable<string>) seriesColors).Any<string>() ? 1 : 0) : 0) != 0)
        dictionary1["seriesColors"] = (object) this.SeriesColors;
      string theme = this.Theme;
      if ((theme != null ? (theme.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["theme"] = (object) this.Theme;
      Dictionary<string, object> source11 = this.Title.Serialize();
      if (source11.Any<KeyValuePair<string, object>>())
        dictionary1["title"] = (object) source11;
      Dictionary<string, object> source12 = this.Tooltip.Serialize();
      if (source12.Any<KeyValuePair<string, object>>())
        dictionary1["tooltip"] = (object) source12;
      if (this.Transitions.HasValue)
        dictionary1["transitions"] = (object) this.Transitions;
      IEnumerable<Dictionary<string, object>> source13 = this.ValueAxis.Select<ChartValueAxis<T>, Dictionary<string, object>>((Func<ChartValueAxis<T>, Dictionary<string, object>>) (i => i.Serialize()));
      if (source13.Any<Dictionary<string, object>>())
        dictionary1["valueAxis"] = (object) source13;
      IEnumerable<Dictionary<string, object>> source14 = this.XAxis.Select<ChartXAxis<T>, Dictionary<string, object>>((Func<ChartXAxis<T>, Dictionary<string, object>>) (i => i.Serialize()));
      if (source14.Any<Dictionary<string, object>>())
        dictionary1["xAxis"] = (object) source14;
      IEnumerable<Dictionary<string, object>> source15 = this.YAxis.Select<ChartYAxis<T>, Dictionary<string, object>>((Func<ChartYAxis<T>, Dictionary<string, object>>) (i => i.Serialize()));
      if (source15.Any<Dictionary<string, object>>())
        dictionary1["yAxis"] = (object) source15;
      Dictionary<string, object> source16 = this.Zoomable.Serialize();
      if (source16.Any<KeyValuePair<string, object>>())
        dictionary1["zoomable"] = (object) source16;
      else if (this.Zoomable.Enabled.HasValue)
        dictionary1["zoomable"] = (object) this.Zoomable.Enabled;
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
