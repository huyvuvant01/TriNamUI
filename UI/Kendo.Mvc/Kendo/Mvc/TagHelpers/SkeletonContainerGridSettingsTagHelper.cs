// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.SkeletonContainerGridSettingsTagHelper
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
  [HtmlTargetElement("grid", ParentTag = "kendo-skeletoncontainer", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("gap", new string[] {"items"})]
  [SuppressTagRendering]
  public class SkeletonContainerGridSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (SkeletonContainerTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as SkeletonContainerTagHelper).Grid = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public double? Columns { get; set; }

    [HtmlAttributeNotBound]
    public SkeletonContainerGridGapSettingsTagHelper Gap { get; set; }

    [HtmlAttributeNotBound]
    public SkeletonContainerGridSettingsItemsTagHelper Items { get; set; }

    public double? Rows { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.Columns.HasValue)
        dictionary["columns"] = (object) this.Columns;
      if (this.Gap != null)
      {
        Dictionary<string, object> source = this.Gap.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["gap"] = (object) source;
      }
      if (this.Items != null)
      {
        IEnumerable<Dictionary<string, object>> source = this.Items.Select<SkeletonContainerGridSettingsItemTagHelper, Dictionary<string, object>>((Func<SkeletonContainerGridSettingsItemTagHelper, Dictionary<string, object>>) (i => i.Serialize()));
        if (source.Any<Dictionary<string, object>>())
          dictionary["items"] = (object) source;
      }
      if (this.Rows.HasValue)
        dictionary["rows"] = (object) this.Rows;
      return dictionary;
    }
  }
}
