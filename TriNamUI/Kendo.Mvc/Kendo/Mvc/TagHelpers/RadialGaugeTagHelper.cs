// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.RadialGaugeTagHelper
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
  [HtmlTargetElement("kendo-radialgauge")]
  [RestrictChildren("gauge-area", new string[] {"radialgauge-pointers", "scale"})]
  public class RadialGaugeTagHelper : TagHelperBase
  {
    public RadialGaugeTagHelper(
    #nullable disable
    IKendoHtmlGenerator generator)
      : base(generator)
    {
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      RadialGaugeTagHelper radialGaugeTagHelper = this;
      context.Items[(object) radialGaugeTagHelper.GetType()] = (object) radialGaugeTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      // ISSUE: reference to a compiler-generated method
      await radialGaugeTagHelper.\u003C\u003En__0(context, output);
    }

    protected override void WriteHtml(TagHelperOutput output)
    {
      this.GenerateId(output);
      TagBuilder tag = this.Generator.GenerateTag("div", this.ViewContext, this.Id, this.Name, (IDictionary<string, object>) new Dictionary<string, object>());
      output.TagName = "div";
      output.MergeAttributes(tag);
    }

    protected override string GetInitializationScript() => this.Initializer.Initialize(this.Selector, "RadialGauge", (IDictionary<string, object>) this.SerializeSettings());

    protected override Dictionary<string, object> SerializeEvents() => new Dictionary<string, object>();

    [HtmlAttributeNotBound]
    public RadialGaugeGaugeAreaSettingsTagHelper GaugeArea { get; set; }

    [HtmlAttributeNotBound]
    public RadialGaugePointersTagHelper Pointer { get; set; }

    public RenderingMode? RenderAs { get; set; }

    [HtmlAttributeNotBound]
    public RadialGaugeScaleSettingsTagHelper Scale { get; set; }

    public string Theme { get; set; }

    public bool? Transitions { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = base.SerializeSettings();
      if (this.GaugeArea != null)
      {
        Dictionary<string, object> source = this.GaugeArea.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["gaugeArea"] = (object) source;
      }
      if (this.Pointer != null)
      {
        IEnumerable<Dictionary<string, object>> source = this.Pointer.Select<RadialGaugePointerTagHelper, Dictionary<string, object>>((Func<RadialGaugePointerTagHelper, Dictionary<string, object>>) (i => i.Serialize()));
        if (source.Any<Dictionary<string, object>>())
          dictionary1["pointer"] = (object) source;
      }
      if (this.RenderAs.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        RenderingMode? renderAs = this.RenderAs;
        ref RenderingMode? local = ref renderAs;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["renderAs"] = (object) str;
      }
      if (this.Scale != null)
      {
        Dictionary<string, object> source = this.Scale.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["scale"] = (object) source;
      }
      string theme = this.Theme;
      if ((theme != null ? (theme.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["theme"] = (object) this.Theme;
      if (this.Transitions.HasValue)
        dictionary1["transitions"] = (object) this.Transitions;
      return dictionary1;
    }
  }
}
