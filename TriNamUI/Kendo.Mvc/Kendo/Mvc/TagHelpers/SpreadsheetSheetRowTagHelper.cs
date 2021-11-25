// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.SpreadsheetSheetRowTagHelper
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
  [HtmlTargetElement("sheet-row", ParentTag = "rows", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("cells", new string[] {})]
  [SuppressTagRendering]
  public class SpreadsheetSheetRowTagHelper : TagHelperCollectionItemBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      System.Type type = typeof (SpreadsheetSheetRowsTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as SpreadsheetSheetRowsTagHelper).Add(this);
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    [HtmlAttributeNotBound]
    public SpreadsheetSheetRowCellsTagHelper Cells { get; set; }

    public double? Height { get; set; }

    public double? Index { get; set; }

    public string Type { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.Cells != null)
      {
        IEnumerable<Dictionary<string, object>> source = this.Cells.Select<SpreadsheetSheetRowCellTagHelper, Dictionary<string, object>>((Func<SpreadsheetSheetRowCellTagHelper, Dictionary<string, object>>) (i => i.Serialize()));
        if (source.Any<Dictionary<string, object>>())
          dictionary["cells"] = (object) source;
      }
      if (this.Height.HasValue)
        dictionary["height"] = (object) this.Height;
      if (this.Index.HasValue)
        dictionary["index"] = (object) this.Index;
      string type = this.Type;
      if ((type != null ? (type.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["type"] = (object) this.Type;
      return dictionary;
    }
  }
}
