// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.GridGroupableSortSettingsTagHelper
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
  [HtmlTargetElement("sort", ParentTag = "groupable", TagStructure = TagStructure.WithoutEndTag)]
  [SuppressTagRendering]
  public class GridGroupableSortSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (GridGroupableSettingsTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as GridGroupableSettingsTagHelper).Sort = this;
    }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary1 = this.SerializeSettings();
      if (this.Dir.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        ListSortDirection? dir = this.Dir;
        ListSortDirection listSortDirection = ListSortDirection.Ascending;
        string str = dir.GetValueOrDefault() == listSortDirection & dir.HasValue ? "asc" : "desc";
        dictionary2["dir"] = (object) str;
      }
      return dictionary1;
    }

    public string Compare { get; set; }

    public ListSortDirection? Dir { get; set; }

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
