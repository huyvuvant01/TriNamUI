// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.DataSourceAggregateTagHelper
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
  [HtmlTargetElement("aggregate", ParentTag = "aggregates", TagStructure = TagStructure.WithoutEndTag)]
  [SuppressTagRendering]
  public class DataSourceAggregateTagHelper : TagHelperCollectionItemBase
  {
    public 
    #nullable disable
    string Aggregate { get; set; }

    public string Field { get; set; }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type1 = typeof (DataSourceGroupAggregatesTagHelper);
      if (context.Items.ContainsKey((object) type1))
      {
        (context.Items[(object) type1] as DataSourceGroupAggregatesTagHelper).Add(this);
      }
      else
      {
        Type type2 = typeof (DataSourceAggregatesTagHelper);
        (context.Items[(object) type2] as DataSourceAggregatesTagHelper).Add(this);
      }
    }

    internal Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string aggregate = this.Aggregate;
      if ((aggregate != null ? (aggregate.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["aggregate"] = (object) this.Aggregate;
      string field = this.Field;
      if ((field != null ? (field.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["field"] = (object) this.Field;
      return dictionary;
    }
  }
}
