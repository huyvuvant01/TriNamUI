// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.ChartZoomableSettingsTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("zoomable", ParentTag = "kendo-chart", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("mousewheel", new string[] {"selection"})]
  [SuppressTagRendering]
  public class ChartZoomableSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (ChartTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as ChartTagHelper).Zoomable = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public bool? Enabled { get; set; }

    [HtmlAttributeNotBound]
    public ChartZoomableMousewheelSettingsTagHelper Mousewheel { get; set; }

    [HtmlAttributeNotBound]
    public ChartZoomableSelectionSettingsTagHelper Selection { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      bool? enabled;
      if (this.Mousewheel != null)
      {
        Dictionary<string, object> source = this.Mousewheel.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
        {
          enabled = this.Mousewheel.Enabled;
          if (enabled.HasValue)
          {
            enabled = this.Mousewheel.Enabled;
            if (!enabled.Value)
              goto label_5;
          }
          dictionary["mousewheel"] = (object) source;
          goto label_8;
        }
label_5:
        enabled = this.Mousewheel.Enabled;
        if (enabled.HasValue)
        {
          enabled = this.Mousewheel.Enabled;
          if (!enabled.Value)
            dictionary["mousewheel"] = (object) this.Mousewheel.Enabled;
        }
      }
label_8:
      if (this.Selection != null)
      {
        Dictionary<string, object> source = this.Selection.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
        {
          enabled = this.Selection.Enabled;
          if (enabled.HasValue)
          {
            enabled = this.Selection.Enabled;
            if (!enabled.Value)
              goto label_13;
          }
          dictionary["selection"] = (object) source;
          goto label_16;
        }
label_13:
        enabled = this.Selection.Enabled;
        if (enabled.HasValue)
        {
          enabled = this.Selection.Enabled;
          if (!enabled.Value)
            dictionary["selection"] = (object) this.Selection.Enabled;
        }
      }
label_16:
      return dictionary;
    }
  }
}
