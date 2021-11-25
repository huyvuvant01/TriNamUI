﻿// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.LinearGaugeScaleSettingsTagHelper
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
  [HtmlTargetElement("scale", ParentTag = "kendo-lineargauge", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("lineargauge-scale-line", new string[] {"lineargauge-scale-labels", "lineargauge-scale-major-ticks", "lineargauge-scale-minor-ticks", "lineargauge-scale-ranges"})]
  [SuppressTagRendering]
  public class LinearGaugeScaleSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (LinearGaugeTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as LinearGaugeTagHelper).Scale = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    [HtmlAttributeNotBound]
    public LinearGaugeScaleLineSettingsTagHelper Line { get; set; }

    [HtmlAttributeNotBound]
    public LinearGaugeScaleLabelsSettingsTagHelper Labels { get; set; }

    [HtmlAttributeNotBound]
    public LinearGaugeScaleMajorTicksSettingsTagHelper MajorTicks { get; set; }

    public double? MajorUnit { get; set; }

    public double? Max { get; set; }

    public double? Min { get; set; }

    [HtmlAttributeNotBound]
    public LinearGaugeScaleMinorTicksSettingsTagHelper MinorTicks { get; set; }

    public double? MinorUnit { get; set; }

    public bool? Mirror { get; set; }

    [HtmlAttributeNotBound]
    public LinearGaugeScaleSettingsRangesTagHelper Ranges { get; set; }

    public string RangePlaceholderColor { get; set; }

    public double? RangeSize { get; set; }

    public bool? Reverse { get; set; }

    public bool? Vertical { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.Line != null)
      {
        Dictionary<string, object> source = this.Line.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["line"] = (object) source;
      }
      if (this.Labels != null)
      {
        Dictionary<string, object> source = this.Labels.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["labels"] = (object) source;
      }
      if (this.MajorTicks != null)
      {
        Dictionary<string, object> source = this.MajorTicks.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["majorTicks"] = (object) source;
      }
      if (this.MajorUnit.HasValue)
        dictionary["majorUnit"] = (object) this.MajorUnit;
      if (this.Max.HasValue)
        dictionary["max"] = (object) this.Max;
      if (this.Min.HasValue)
        dictionary["min"] = (object) this.Min;
      if (this.MinorTicks != null)
      {
        Dictionary<string, object> source = this.MinorTicks.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["minorTicks"] = (object) source;
      }
      if (this.MinorUnit.HasValue)
        dictionary["minorUnit"] = (object) this.MinorUnit;
      if (this.Mirror.HasValue)
        dictionary["mirror"] = (object) this.Mirror;
      if (this.Ranges != null)
      {
        IEnumerable<Dictionary<string, object>> source = this.Ranges.Select<LinearGaugeScaleSettingsRangeTagHelper, Dictionary<string, object>>((Func<LinearGaugeScaleSettingsRangeTagHelper, Dictionary<string, object>>) (i => i.Serialize()));
        if (source.Any<Dictionary<string, object>>())
          dictionary["ranges"] = (object) source;
      }
      string placeholderColor = this.RangePlaceholderColor;
      if ((placeholderColor != null ? (placeholderColor.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["rangePlaceholderColor"] = (object) this.RangePlaceholderColor;
      if (this.RangeSize.HasValue)
        dictionary["rangeSize"] = (object) this.RangeSize;
      if (this.Reverse.HasValue)
        dictionary["reverse"] = (object) this.Reverse;
      if (this.Vertical.HasValue)
        dictionary["vertical"] = (object) this.Vertical;
      return dictionary;
    }
  }
}
