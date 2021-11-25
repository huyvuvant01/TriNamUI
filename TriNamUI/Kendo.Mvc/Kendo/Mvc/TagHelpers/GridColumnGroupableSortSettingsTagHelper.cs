// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.GridColumnGroupableSortSettingsTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("grid-column-groupable-sort", ParentTag = "groupable", TagStructure = TagStructure.WithoutEndTag)]
  [SuppressTagRendering]
  public class GridColumnGroupableSortSettingsTagHelper : TagHelperChildBase
  {
    public 
    #nullable disable
    string Compare { get; set; }

    public ListSortDirection Dir { get; set; }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (GridColumnGroupableSettingsTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as GridColumnGroupableSettingsTagHelper).Sort = this;
    }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      int dir = (int) this.Dir;
      dictionary["dir"] = this.Dir == ListSortDirection.Ascending ? (object) "asc" : (object) "desc";
      return dictionary;
    }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string compare = this.Compare;
      if ((compare != null ? (compare.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["compare"] = (object) this.CreateHandler(this.Compare);
      return dictionary;
    }
  }
}
