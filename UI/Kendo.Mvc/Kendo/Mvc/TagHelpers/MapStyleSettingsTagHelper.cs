// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.MapStyleSettingsTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.TagHelpers.Map;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("map-style", ParentTag = "shape", TagStructure = TagStructure.NormalOrSelfClosing)]
  [HtmlTargetElement("map-style", ParentTag = "layer", TagStructure = TagStructure.NormalOrSelfClosing)]
  [HtmlTargetElement("map-style", ParentTag = "bubble", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("fill", new string[] {"stroke"})]
  [SuppressTagRendering]
  public class MapStyleSettingsTagHelper : TagHelperChildBase
  {
    public 
    #nullable disable
    MapStyleFillSettingsTagHelper Fill { get; set; }

    public MapStyleStrokeSettingsTagHelper Stroke { get; set; }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      foreach (KeyValuePair<object, object> keyValuePair in (IEnumerable<KeyValuePair<object, object>>) context.Items)
        this.SetStyle(keyValuePair.Value);
    }

    private void SetStyle(object item)
    {
      if (!(item is IMapStyleParent<MapStyleSettingsTagHelper>))
        return;
      (item as IMapStyleParent<MapStyleSettingsTagHelper>).Style = this;
    }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.Fill != null)
      {
        Dictionary<string, object> source = this.Fill.SerializeSettings();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["fill"] = (object) source;
      }
      if (this.Stroke != null)
      {
        Dictionary<string, object> source = this.Stroke.SerializeSettings();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["stroke"] = (object) source;
      }
      return dictionary;
    }
  }
}
