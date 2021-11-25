// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.SpreadsheetSheetFilterSettingsColumnTagHelper
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
  [HtmlTargetElement("filter-column", ParentTag = "filter-columns", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("criterias", new string[] {})]
  [SuppressTagRendering]
  public class SpreadsheetSheetFilterSettingsColumnTagHelper : TagHelperCollectionItemBase
  {
    public 
    #nullable disable
    double?[] Values { get; set; }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      System.Type type = typeof (SpreadsheetSheetFilterSettingsColumnsTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as SpreadsheetSheetFilterSettingsColumnsTagHelper).Add(this);
    }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      if (this.Values != null && this.Values.Length != 0)
        dictionary["values"] = (object) this.Values;
      return dictionary;
    }

    [HtmlAttributeNotBound]
    public SpreadsheetSheetFilterSettingsColumnCriteriasTagHelper Criteria { get; set; }

    public string Filter { get; set; }

    public double? Index { get; set; }

    public string Logic { get; set; }

    public string Type { get; set; }

    public double? Value { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.Criteria != null)
      {
        IEnumerable<Dictionary<string, object>> source = this.Criteria.Select<SpreadsheetSheetFilterSettingsColumnCriteriaTagHelper, Dictionary<string, object>>((Func<SpreadsheetSheetFilterSettingsColumnCriteriaTagHelper, Dictionary<string, object>>) (i => i.Serialize()));
        if (source.Any<Dictionary<string, object>>())
          dictionary["criteria"] = (object) source;
      }
      string filter = this.Filter;
      if ((filter != null ? (filter.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["filter"] = (object) this.Filter;
      if (this.Index.HasValue)
        dictionary["index"] = (object) this.Index;
      string logic = this.Logic;
      if ((logic != null ? (logic.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["logic"] = (object) this.Logic;
      string type = this.Type;
      if ((type != null ? (type.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["type"] = (object) this.Type;
      if (this.Value.HasValue)
        dictionary["value"] = (object) this.Value;
      return dictionary;
    }
  }
}
