// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.SpreadsheetSheetSortSettingsTagHelper
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
  [HtmlTargetElement("sort", ParentTag = "sheet", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("sort-columns", new string[] {})]
  [SuppressTagRendering]
  public class SpreadsheetSheetSortSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (SpreadsheetSheetTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as SpreadsheetSheetTagHelper).Sort = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    [HtmlAttributeNotBound]
    public SpreadsheetSheetSortSettingsColumnsTagHelper Columns { get; set; }

    public string Ref { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.Columns != null)
      {
        IEnumerable<Dictionary<string, object>> source = this.Columns.Select<SpreadsheetSheetSortSettingsColumnTagHelper, Dictionary<string, object>>((Func<SpreadsheetSheetSortSettingsColumnTagHelper, Dictionary<string, object>>) (i => i.Serialize()));
        if (source.Any<Dictionary<string, object>>())
          dictionary["columns"] = (object) source;
      }
      string str = this.Ref;
      if ((str != null ? (str.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["ref"] = (object) this.Ref;
      return dictionary;
    }
  }
}
