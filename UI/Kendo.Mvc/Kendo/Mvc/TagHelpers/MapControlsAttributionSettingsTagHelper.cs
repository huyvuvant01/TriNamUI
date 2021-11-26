// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.MapControlsAttributionSettingsTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("attribution", ParentTag = "controls", TagStructure = TagStructure.WithoutEndTag)]
  [SuppressTagRendering]
  public class MapControlsAttributionSettingsTagHelper : TagHelperChildBase
  {
    public MapControlPosition? Position { get; set; }

    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (MapControlsSettingsTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as MapControlsSettingsTagHelper).Attribution = this;
    }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary1 = this.SerializeSettings();
      if (this.Position.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        MapControlPosition? position = this.Position;
        ref MapControlPosition? local = ref position;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["position"] = (object) str;
      }
      return dictionary1;
    }

    public bool? Enabled { get; set; }

    internal Dictionary<string, object> SerializeSettings() => new Dictionary<string, object>();
  }
}
