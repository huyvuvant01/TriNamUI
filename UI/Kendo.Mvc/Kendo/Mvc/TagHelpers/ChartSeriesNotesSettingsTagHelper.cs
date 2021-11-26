// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.ChartSeriesNotesSettingsTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("notes", ParentTag = "series-item", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("chart-series-notes-icon", new string[] {"chart-series-notes-label", "chart-series-notes-line"})]
  [SuppressTagRendering]
  public class ChartSeriesNotesSettingsTagHelper : TagHelperChildBase
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
      (context.Items[(object) type] as ChartSeriesTagHelper).Notes = this;
    }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      string visual = this.Visual;
      if ((visual != null ? (visual.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["visual"] = (object) this.CreateHandler(this.Visual);
      return dictionary;
    }

    [HtmlAttributeNotBound]
    public ChartSeriesNotesIconSettingsTagHelper Icon { get; set; }

    [HtmlAttributeNotBound]
    public ChartSeriesNotesLabelSettingsTagHelper Label { get; set; }

    [HtmlAttributeNotBound]
    public ChartSeriesNotesLineSettingsTagHelper Line { get; set; }

    public ChartNotePosition? Position { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = new Dictionary<string, object>();
      if (this.Icon != null)
      {
        Dictionary<string, object> source = this.Icon.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["icon"] = (object) source;
      }
      if (this.Label != null)
      {
        Dictionary<string, object> source = this.Label.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["label"] = (object) source;
      }
      if (this.Line != null)
      {
        Dictionary<string, object> source = this.Line.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["line"] = (object) source;
      }
      if (this.Position.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        ChartNotePosition? position = this.Position;
        ref ChartNotePosition? local = ref position;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["position"] = (object) str;
      }
      return dictionary1;
    }
  }
}
