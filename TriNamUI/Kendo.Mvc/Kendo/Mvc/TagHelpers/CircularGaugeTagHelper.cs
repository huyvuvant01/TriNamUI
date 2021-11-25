// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.CircularGaugeTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Rendering;
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
  [HtmlTargetElement("kendo-circulargauge")]
  [RestrictChildren("colors", new string[] {"gauge-area", "scale"})]
  public class CircularGaugeTagHelper : TagHelperBase
  {
    public CircularGaugeTagHelper(
    #nullable disable
    IKendoHtmlGenerator generator)
      : base(generator)
    {
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      CircularGaugeTagHelper circularGaugeTagHelper = this;
      context.Items[(object) circularGaugeTagHelper.GetType()] = (object) circularGaugeTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      // ISSUE: reference to a compiler-generated method
      await circularGaugeTagHelper.\u003C\u003En__0(context, output);
    }

    protected override void WriteHtml(TagHelperOutput output)
    {
      this.GenerateId(output);
      TagBuilder tag = this.Generator.GenerateTag("div", this.ViewContext, this.Id, this.Name, (IDictionary<string, object>) new Dictionary<string, object>());
      output.TagName = "div";
      output.MergeAttributes(tag);
    }

    protected override string GetInitializationScript() => this.Initializer.Initialize(this.Selector, "CircularGauge", (IDictionary<string, object>) this.SerializeSettings());

    protected override Dictionary<string, object> SerializeEvents() => new Dictionary<string, object>();

    public string CenterTemplate { get; set; }

    public string CenterTemplateId { get; set; }

    public string Color { get; set; }

    [HtmlAttributeNotBound]
    public CircularGaugeColorsTagHelper Colors { get; set; }

    [HtmlAttributeNotBound]
    public CircularGaugeGaugeAreaSettingsTagHelper GaugeArea { get; set; }

    public double? Opacity { get; set; }

    public string RenderAs { get; set; }

    [HtmlAttributeNotBound]
    public CircularGaugeScaleSettingsTagHelper Scale { get; set; }

    public string Theme { get; set; }

    public bool? Transitions { get; set; }

    public double? Value { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = base.SerializeSettings();
      if (this.CenterTemplateId.HasValue())
        dictionary["centerTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.CenterTemplateId)
        };
      else if (this.CenterTemplate.HasValue())
        dictionary["centerTemplate"] = (object) this.CenterTemplate;
      string color = this.Color;
      if ((color != null ? (color.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["color"] = (object) this.Color;
      if (this.Colors != null)
      {
        IEnumerable<Dictionary<string, object>> source = this.Colors.Select<CircularGaugeColorTagHelper, Dictionary<string, object>>((Func<CircularGaugeColorTagHelper, Dictionary<string, object>>) (i => i.Serialize()));
        if (source.Any<Dictionary<string, object>>())
          dictionary["colors"] = (object) source;
      }
      if (this.GaugeArea != null)
      {
        Dictionary<string, object> source = this.GaugeArea.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["gaugeArea"] = (object) source;
      }
      double? opacity = this.Opacity;
      if (opacity.HasValue)
        dictionary["opacity"] = (object) this.Opacity;
      string renderAs = this.RenderAs;
      if ((renderAs != null ? (renderAs.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["renderAs"] = (object) this.RenderAs;
      if (this.Scale != null)
      {
        Dictionary<string, object> source = this.Scale.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["scale"] = (object) source;
      }
      string theme = this.Theme;
      if ((theme != null ? (theme.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["theme"] = (object) this.Theme;
      if (this.Transitions.HasValue)
        dictionary["transitions"] = (object) this.Transitions;
      opacity = this.Value;
      if (opacity.HasValue)
        dictionary["value"] = (object) this.Value;
      return dictionary;
    }
  }
}
