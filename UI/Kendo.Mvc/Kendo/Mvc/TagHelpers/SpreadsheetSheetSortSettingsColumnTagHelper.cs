// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.SpreadsheetSheetSortSettingsColumnTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("sort-column", ParentTag = "sort-columns", TagStructure = TagStructure.NormalOrSelfClosing)]
  [SuppressTagRendering]
  public class SpreadsheetSheetSortSettingsColumnTagHelper : TagHelperCollectionItemBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (SpreadsheetSheetSortSettingsColumnsTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as SpreadsheetSheetSortSettingsColumnsTagHelper).Add(this);
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public bool? Ascending { get; set; }

    public double? Index { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.Ascending.HasValue)
        dictionary["ascending"] = (object) this.Ascending;
      if (this.Index.HasValue)
        dictionary["index"] = (object) this.Index;
      return dictionary;
    }
  }
}
