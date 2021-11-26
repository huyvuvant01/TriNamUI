// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.ChartSeriesAggregateSettingsTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("aggregate", ParentTag = "series-item", TagStructure = TagStructure.NormalOrSelfClosing)]
  [SuppressTagRendering]
  public class ChartSeriesAggregateSettingsTagHelper : TagHelperChildBase
  {
    public ChartSeriesAggregate? Close { get; set; }

    public 
    #nullable disable
    string CloseHandler { get; set; }

    public ChartSeriesAggregate? High { get; set; }

    public string HighHandler { get; set; }

    public ChartSeriesAggregate? Low { get; set; }

    public string LowHandler { get; set; }

    public ChartSeriesAggregate? Open { get; set; }

    public string OpenHandler { get; set; }

    public ChartSeriesAggregate? Lower { get; set; }

    public string LowerHandler { get; set; }

    public ChartSeriesAggregate? Mean { get; set; }

    public string MeanHandler { get; set; }

    public ChartSeriesAggregate? Median { get; set; }

    public string MedianHandler { get; set; }

    public ChartSeriesAggregate? Outliers { get; set; }

    public string OutliersHandler { get; set; }

    public ChartSeriesAggregate? Q1 { get; set; }

    public string Q1Handler { get; set; }

    public ChartSeriesAggregate? Q3 { get; set; }

    public string Q3Handler { get; set; }

    public ChartSeriesAggregate? Upper { get; set; }

    public string UpperHandler { get; set; }

    protected Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = new Dictionary<string, object>();
      string closeHandler = this.CloseHandler;
      ChartSeriesAggregate? nullable;
      if ((closeHandler != null ? (closeHandler.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary1["close"] = (object) this.CreateHandler(this.CloseHandler);
      }
      else
      {
        nullable = this.Close;
        if (nullable.HasValue)
        {
          Dictionary<string, object> dictionary2 = dictionary1;
          nullable = this.Close;
          ref ChartSeriesAggregate? local = ref nullable;
          string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
          dictionary2["close"] = (object) str;
        }
      }
      string highHandler = this.HighHandler;
      if ((highHandler != null ? (highHandler.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary1["high"] = (object) this.CreateHandler(this.HighHandler);
      }
      else
      {
        nullable = this.High;
        if (nullable.HasValue)
        {
          Dictionary<string, object> dictionary3 = dictionary1;
          nullable = this.High;
          ref ChartSeriesAggregate? local = ref nullable;
          string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
          dictionary3["high"] = (object) str;
        }
      }
      string lowHandler = this.LowHandler;
      if ((lowHandler != null ? (lowHandler.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary1["low"] = (object) this.CreateHandler(this.LowHandler);
      }
      else
      {
        nullable = this.Low;
        if (nullable.HasValue)
        {
          Dictionary<string, object> dictionary4 = dictionary1;
          nullable = this.Low;
          ref ChartSeriesAggregate? local = ref nullable;
          string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
          dictionary4["low"] = (object) str;
        }
      }
      string openHandler = this.OpenHandler;
      if ((openHandler != null ? (openHandler.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary1["open"] = (object) this.CreateHandler(this.OpenHandler);
      }
      else
      {
        nullable = this.Open;
        if (nullable.HasValue)
        {
          Dictionary<string, object> dictionary5 = dictionary1;
          nullable = this.Open;
          ref ChartSeriesAggregate? local = ref nullable;
          string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
          dictionary5["open"] = (object) str;
        }
      }
      string lowerHandler = this.LowerHandler;
      if ((lowerHandler != null ? (lowerHandler.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary1["lower"] = (object) this.CreateHandler(this.LowerHandler);
      }
      else
      {
        nullable = this.Lower;
        if (nullable.HasValue)
        {
          Dictionary<string, object> dictionary6 = dictionary1;
          nullable = this.Lower;
          ref ChartSeriesAggregate? local = ref nullable;
          string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
          dictionary6["lower"] = (object) str;
        }
      }
      string meanHandler = this.MeanHandler;
      if ((meanHandler != null ? (meanHandler.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary1["mean"] = (object) this.CreateHandler(this.MeanHandler);
      }
      else
      {
        nullable = this.Mean;
        if (nullable.HasValue)
        {
          Dictionary<string, object> dictionary7 = dictionary1;
          nullable = this.Mean;
          ref ChartSeriesAggregate? local = ref nullable;
          string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
          dictionary7["mean"] = (object) str;
        }
      }
      string medianHandler = this.MedianHandler;
      if ((medianHandler != null ? (medianHandler.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary1["median"] = (object) this.CreateHandler(this.MedianHandler);
      }
      else
      {
        nullable = this.Median;
        if (nullable.HasValue)
        {
          Dictionary<string, object> dictionary8 = dictionary1;
          nullable = this.Median;
          ref ChartSeriesAggregate? local = ref nullable;
          string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
          dictionary8["median"] = (object) str;
        }
      }
      string outliersHandler = this.OutliersHandler;
      if ((outliersHandler != null ? (outliersHandler.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary1["outliers"] = (object) this.CreateHandler(this.OutliersHandler);
      }
      else
      {
        nullable = this.Outliers;
        if (nullable.HasValue)
        {
          Dictionary<string, object> dictionary9 = dictionary1;
          nullable = this.Outliers;
          ref ChartSeriesAggregate? local = ref nullable;
          string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
          dictionary9["outliers"] = (object) str;
        }
      }
      string q1Handler = this.Q1Handler;
      if ((q1Handler != null ? (q1Handler.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary1["q1"] = (object) this.CreateHandler(this.Q1Handler);
      }
      else
      {
        nullable = this.Q1;
        if (nullable.HasValue)
        {
          Dictionary<string, object> dictionary10 = dictionary1;
          nullable = this.Q1;
          ref ChartSeriesAggregate? local = ref nullable;
          string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
          dictionary10["q1"] = (object) str;
        }
      }
      string q3Handler = this.Q3Handler;
      if ((q3Handler != null ? (q3Handler.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary1["q3"] = (object) this.CreateHandler(this.Q3Handler);
      }
      else
      {
        nullable = this.Q3;
        if (nullable.HasValue)
        {
          Dictionary<string, object> dictionary11 = dictionary1;
          nullable = this.Q3;
          ref ChartSeriesAggregate? local = ref nullable;
          string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
          dictionary11["q3"] = (object) str;
        }
      }
      string upperHandler = this.UpperHandler;
      if ((upperHandler != null ? (upperHandler.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary1["upper"] = (object) this.CreateHandler(this.UpperHandler);
      }
      else
      {
        nullable = this.Upper;
        if (nullable.HasValue)
        {
          Dictionary<string, object> dictionary12 = dictionary1;
          nullable = this.Upper;
          ref ChartSeriesAggregate? local = ref nullable;
          string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
          dictionary12["upper"] = (object) str;
        }
      }
      return dictionary1;
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (ChartSeriesTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as ChartSeriesTagHelper).Aggregates = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();
  }
}
