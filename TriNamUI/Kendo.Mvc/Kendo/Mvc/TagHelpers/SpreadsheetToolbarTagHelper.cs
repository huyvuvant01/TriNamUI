// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.SpreadsheetToolbarTagHelper
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
  [RestrictChildren("home", new string[] {"insert", "data"})]
  [SuppressTagRendering]
  [HtmlTargetElement("toolbar", ParentTag = "kendo-spreadsheet", TagStructure = TagStructure.NormalOrSelfClosing)]
  public class SpreadsheetToolbarTagHelper : TagHelperChildBase
  {
    public bool? Enabled { get; set; }

    [HtmlAttributeNotBound]
    public 
    #nullable disable
    SpreadsheetHomeToolTabTagHelper Home { get; set; }

    [HtmlAttributeNotBound]
    public SpreadsheetInsertToolTabTagHelper Insert { get; set; }

    [HtmlAttributeNotBound]
    public SpreadsheetDataToolTabTagHelper Data { get; set; }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (SpreadsheetTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as SpreadsheetTagHelper).Toolbar = this;
    }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.Home != null)
      {
        dictionary["home"] = (object) this.Home.Enabled;
        if (this.Home.Enabled && this.Home.Tools.Any<SpreadsheetToolTagHelper>())
          dictionary["home"] = (object) this.Home.Tools.Select<SpreadsheetToolTagHelper, object>((Func<SpreadsheetToolTagHelper, object>) (tool => tool.Serialize()[nameof (tool)]));
      }
      if (this.Insert != null)
      {
        dictionary["insert"] = (object) this.Insert.Enabled;
        if (this.Insert.Enabled && this.Insert.Tools.Any<SpreadsheetToolTagHelper>())
          dictionary["insert"] = (object) this.Insert.Tools.Select<SpreadsheetToolTagHelper, object>((Func<SpreadsheetToolTagHelper, object>) (tool => tool.Serialize()[nameof (tool)]));
      }
      if (this.Data != null)
      {
        dictionary["data"] = (object) this.Data.Enabled;
        if (this.Data.Enabled && this.Data.Tools.Any<SpreadsheetToolTagHelper>())
          dictionary["data"] = (object) this.Data.Tools.Select<SpreadsheetToolTagHelper, object>((Func<SpreadsheetToolTagHelper, object>) (tool => tool.Serialize()[nameof (tool)]));
      }
      return dictionary;
    }
  }
}
