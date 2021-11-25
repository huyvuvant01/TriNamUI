// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.StockChartNavigatorSettings`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class StockChartNavigatorSettings<T> where T : class
  {
    public List<ChartSeries<T>> Series { get; set; } = new List<ChartSeries<T>>();

    public DataSource DataSource { get; private set; }

    public ViewContext ViewContext { get; private set; }

    public IUrlGenerator UrlGenerator { get; private set; }

    public StockChartNavigatorSettings()
    {
    }

    public StockChartNavigatorSettings(Kendo.Mvc.UI.StockChart<T> chart, ViewContext viewContext)
    {
      this.ViewContext = viewContext;
      this.UrlGenerator = chart.UrlGenerator;
      this.DataSource = new DataSource(chart.ModelMetadataProvider);
      this.DataSource.Schema.Data = "";
      this.DataSource.Schema.Total = "";
      this.DataSource.Schema.Errors = "";
      this.DataSource.ModelType(typeof (T));
      this.StockChart = chart;
    }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      if (!string.IsNullOrEmpty(this.DataSource.Transport.Read.Url))
      {
        if (!this.DataSource.Transport.Read.Type.HasValue())
          this.DataSource.Transport.Read.Type = "POST";
        dictionary["dataSource"] = (object) this.DataSource.ToJson();
      }
      IEnumerable<Dictionary<string, object>> source = this.Series.Select<ChartSeries<T>, Dictionary<string, object>>((Func<ChartSeries<T>, Dictionary<string, object>>) (i => i.Serialize()));
      if (source.Any<Dictionary<string, object>>())
        dictionary["series"] = (object) source;
      return dictionary;
    }

    public StockChartNavigatorCategoryAxisSettings<T> CategoryAxis { get; } = new StockChartNavigatorCategoryAxisSettings<T>();

    public bool? AutoBind { get; set; }

    public string DateField { get; set; }

    public StockChartNavigatorPaneSettings<T> Pane { get; } = new StockChartNavigatorPaneSettings<T>();

    public StockChartNavigatorSelectSettings<T> Select { get; } = new StockChartNavigatorSelectSettings<T>();

    public StockChartNavigatorHintSettings<T> Hint { get; } = new StockChartNavigatorHintSettings<T>();

    public bool? Visible { get; set; }

    public Kendo.Mvc.UI.StockChart<T> StockChart { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      Dictionary<string, object> source1 = this.CategoryAxis.Serialize();
      if (source1.Any<KeyValuePair<string, object>>())
        dictionary["categoryAxis"] = (object) source1;
      if (this.AutoBind.HasValue)
        dictionary["autoBind"] = (object) this.AutoBind;
      string dateField = this.DateField;
      if ((dateField != null ? (dateField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dateField"] = (object) this.DateField;
      Dictionary<string, object> source2 = this.Pane.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
        dictionary["pane"] = (object) source2;
      Dictionary<string, object> source3 = this.Select.Serialize();
      if (source3.Any<KeyValuePair<string, object>>())
        dictionary["select"] = (object) source3;
      Dictionary<string, object> source4 = this.Hint.Serialize();
      if (source4.Any<KeyValuePair<string, object>>())
        dictionary["hint"] = (object) source4;
      if (this.Visible.HasValue)
        dictionary["visible"] = (object) this.Visible;
      return dictionary;
    }
  }
}
