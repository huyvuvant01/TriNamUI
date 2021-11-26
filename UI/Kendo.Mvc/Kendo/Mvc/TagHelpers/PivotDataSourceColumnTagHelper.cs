// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.PivotDataSourceColumnTagHelper
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
  [HtmlTargetElement("pivot-datasource-column", ParentTag = "columns", TagStructure = TagStructure.NormalOrSelfClosing)]
  public class PivotDataSourceColumnTagHelper : TagHelperCollectionItemBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (PivotDataSourceColumnsTagHelperCollection);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as PivotDataSourceColumnsTagHelperCollection).Add(this);
    }

    public string Name { get; set; }

    public bool? Expand { get; set; }

    internal Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.Name.HasValue())
        dictionary["name"] = (object) this.Name;
      if (this.Expand.HasValue)
        dictionary["expand"] = (object) this.Expand;
      return dictionary;
    }
  }
}
