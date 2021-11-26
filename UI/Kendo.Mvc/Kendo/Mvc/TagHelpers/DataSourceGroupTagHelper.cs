// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.DataSourceGroupTagHelper
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
  [HtmlTargetElement("group", ParentTag = "groups", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("aggregates", new string[] {})]
  [SuppressTagRendering]
  public class DataSourceGroupTagHelper : TagHelperCollectionItemBase
  {
    [HtmlAttributeNotBound]
    public 
    #nullable disable
    DataSourceGroupAggregatesTagHelper Aggregates { get; set; }

    public string Compare { get; set; }

    public string Direction { get; set; }

    public string Field { get; set; }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      DataSourceGroupTagHelper sourceGroupTagHelper = this;
      context.Items[(object) sourceGroupTagHelper.GetType()] = (object) sourceGroupTagHelper;
      // ISSUE: reference to a compiler-generated method
      await sourceGroupTagHelper.\u003C\u003En__0(context, output);
    }

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (DataSourceGroupsTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as DataSourceGroupsTagHelper).Add(this);
    }

    internal Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.Aggregates != null)
      {
        IEnumerable<Dictionary<string, object>> source = this.Aggregates.Select<DataSourceAggregateTagHelper, Dictionary<string, object>>((Func<DataSourceAggregateTagHelper, Dictionary<string, object>>) (i => i.Serialize()));
        if (source.Any<Dictionary<string, object>>())
          dictionary["aggregates"] = (object) source;
      }
      string compare = this.Compare;
      if ((compare != null ? (compare.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["compare"] = (object) this.CreateHandler(this.Compare);
      string direction = this.Direction;
      if ((direction != null ? (direction.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dir"] = (object) this.Direction;
      string field = this.Field;
      if ((field != null ? (field.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["field"] = (object) this.Field;
      return dictionary;
    }
  }
}
