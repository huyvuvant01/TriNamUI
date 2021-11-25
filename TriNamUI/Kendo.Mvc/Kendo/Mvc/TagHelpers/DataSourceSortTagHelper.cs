// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.DataSourceSortTagHelper
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
  [HtmlTargetElement("sort", ParentTag = "sorts", TagStructure = TagStructure.WithoutEndTag)]
  [SuppressTagRendering]
  public class DataSourceSortTagHelper : TagHelperCollectionItemBase
  {
    public 
    #nullable disable
    string Direction { get; set; }

    public string Field { get; set; }

    public string Compare { get; set; }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (DataSourceSortsTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as DataSourceSortsTagHelper).Add(this);
    }

    internal Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string direction = this.Direction;
      if ((direction != null ? (direction.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dir"] = (object) this.Direction;
      string field = this.Field;
      if ((field != null ? (field.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["field"] = (object) this.Field;
      string compare = this.Compare;
      if ((compare != null ? (compare.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["compare"] = (object) this.CreateHandler(this.Compare);
      return dictionary;
    }
  }
}
