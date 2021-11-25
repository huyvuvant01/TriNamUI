// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.ChartSeriesErrorBarsSettingsTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("error-bars", ParentTag = "series-item", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("line", new string[] {})]
  [SuppressTagRendering]
  public class ChartSeriesErrorBarsSettingsTagHelper : TagHelperChildBase
  {
    public 
    #nullable disable
    string Visual { get; set; }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (ChartSeriesTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as ChartSeriesTagHelper).ErrorBars = this;
    }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      string visual = this.Visual;
      if ((visual != null ? (visual.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["visual"] = (object) this.CreateHandler(this.Visual);
      return dictionary;
    }

    public string Value { get; set; }

    public string ValueHandler { get; set; }

    public string XValue { get; set; }

    public string XValueHandler { get; set; }

    public string YValue { get; set; }

    public string YValueHandler { get; set; }

    public bool? EndCaps { get; set; }

    public string Color { get; set; }

    [HtmlAttributeNotBound]
    public ChartSeriesErrorBarsLineSettingsTagHelper Line { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string valueHandler = this.ValueHandler;
      if ((valueHandler != null ? (valueHandler.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary["value"] = (object) this.CreateHandler(this.ValueHandler);
      }
      else
      {
        string str = this.Value;
        if ((str != null ? (str.HasValue() ? 1 : 0) : 0) != 0)
          dictionary["value"] = (object) this.Value;
      }
      string xvalueHandler = this.XValueHandler;
      if ((xvalueHandler != null ? (xvalueHandler.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary["xValue"] = (object) this.CreateHandler(this.XValueHandler);
      }
      else
      {
        string xvalue = this.XValue;
        if ((xvalue != null ? (xvalue.HasValue() ? 1 : 0) : 0) != 0)
          dictionary["xValue"] = (object) this.XValue;
      }
      string yvalueHandler = this.YValueHandler;
      if ((yvalueHandler != null ? (yvalueHandler.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary["yValue"] = (object) this.CreateHandler(this.YValueHandler);
      }
      else
      {
        string yvalue = this.YValue;
        if ((yvalue != null ? (yvalue.HasValue() ? 1 : 0) : 0) != 0)
          dictionary["yValue"] = (object) this.YValue;
      }
      if (this.EndCaps.HasValue)
        dictionary["endCaps"] = (object) this.EndCaps;
      string color = this.Color;
      if ((color != null ? (color.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["color"] = (object) this.Color;
      if (this.Line != null)
      {
        Dictionary<string, object> source = this.Line.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["line"] = (object) source;
      }
      return dictionary;
    }
  }
}
