// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.MapControlsSettingsTagHelper
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
  [HtmlTargetElement("controls", ParentTag = "kendo-map", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("attribution", new string[] {"navigator", "zoom"})]
  [SuppressTagRendering]
  public class MapControlsSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (MapTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as MapTagHelper).Controls = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    [HtmlAttributeNotBound]
    public MapControlsAttributionSettingsTagHelper Attribution { get; set; }

    [HtmlAttributeNotBound]
    public MapControlsNavigatorSettingsTagHelper Navigator { get; set; }

    [HtmlAttributeNotBound]
    public MapControlsZoomSettingsTagHelper Zoom { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      bool? enabled;
      if (this.Attribution != null)
      {
        Dictionary<string, object> source = this.Attribution.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
        {
          enabled = this.Attribution.Enabled;
          if (enabled.HasValue)
          {
            enabled = this.Attribution.Enabled;
            if (!enabled.Value)
              goto label_5;
          }
          dictionary["attribution"] = (object) source;
          goto label_8;
        }
label_5:
        enabled = this.Attribution.Enabled;
        if (enabled.HasValue)
        {
          enabled = this.Attribution.Enabled;
          if (!enabled.Value)
            dictionary["attribution"] = (object) this.Attribution.Enabled;
        }
      }
label_8:
      if (this.Navigator != null)
      {
        Dictionary<string, object> source = this.Navigator.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
        {
          enabled = this.Navigator.Enabled;
          if (enabled.HasValue)
          {
            enabled = this.Navigator.Enabled;
            if (!enabled.Value)
              goto label_13;
          }
          dictionary["navigator"] = (object) source;
          goto label_16;
        }
label_13:
        enabled = this.Navigator.Enabled;
        if (enabled.HasValue)
        {
          enabled = this.Navigator.Enabled;
          if (!enabled.Value)
            dictionary["navigator"] = (object) this.Navigator.Enabled;
        }
      }
label_16:
      if (this.Zoom != null)
      {
        Dictionary<string, object> source = this.Zoom.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
        {
          enabled = this.Zoom.Enabled;
          if (enabled.HasValue)
          {
            enabled = this.Zoom.Enabled;
            if (!enabled.Value)
              goto label_21;
          }
          dictionary["zoom"] = (object) source;
          goto label_24;
        }
label_21:
        enabled = this.Zoom.Enabled;
        if (enabled.HasValue)
        {
          enabled = this.Zoom.Enabled;
          if (!enabled.Value)
            dictionary["zoom"] = (object) this.Zoom.Enabled;
        }
      }
label_24:
      return dictionary;
    }
  }
}
