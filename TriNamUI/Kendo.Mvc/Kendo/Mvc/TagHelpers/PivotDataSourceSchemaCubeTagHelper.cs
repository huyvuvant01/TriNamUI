// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.PivotDataSourceSchemaCubeTagHelper
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
  [HtmlTargetElement("cube", ParentTag = "schema", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("dimensions", new string[] {"measures"})]
  [SuppressTagRendering]
  public class PivotDataSourceSchemaCubeTagHelper : TagHelperChildBase
  {
    [HtmlAttributeNotBound]
    public 
    #nullable disable
    Dictionary<string, PivotDataSourceCubeDimensionTagHelper> Dimensions { get; set; }

    [HtmlAttributeNotBound]
    public Dictionary<string, PivotDataSourceCubeMeasureTagHelper> Measures { get; set; }

    public PivotDataSourceSchemaCubeTagHelper()
    {
      this.Dimensions = new Dictionary<string, PivotDataSourceCubeDimensionTagHelper>();
      this.Measures = new Dictionary<string, PivotDataSourceCubeMeasureTagHelper>();
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (PivotDataSourceSchemaSettingsTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as PivotDataSourceSchemaSettingsTagHelper).Cube = this;
    }

    internal Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.Dimensions != null)
      {
        Dictionary<string, object> source = new Dictionary<string, object>();
        foreach (KeyValuePair<string, PivotDataSourceCubeDimensionTagHelper> dimension in this.Dimensions)
          source.Add(dimension.Key, (object) dimension.Value.Serialize());
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["dimensions"] = (object) source;
      }
      if (this.Measures != null)
      {
        Dictionary<string, object> source = new Dictionary<string, object>();
        foreach (KeyValuePair<string, PivotDataSourceCubeMeasureTagHelper> measure in this.Measures)
          source.Add(measure.Key, (object) measure.Value.Serialize());
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["measures"] = (object) source;
      }
      return dictionary;
    }
  }
}
