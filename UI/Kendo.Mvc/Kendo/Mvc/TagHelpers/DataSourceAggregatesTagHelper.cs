// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.DataSourceAggregatesTagHelper
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
  [HtmlTargetElement("aggregates", ParentTag = "kendo-datasource", TagStructure = TagStructure.NormalOrSelfClosing)]
  [HtmlTargetElement("aggregates", ParentTag = "datasource", TagStructure = TagStructure.NormalOrSelfClosing)]
  [HtmlTargetElement("aggregates", ParentTag = "kendo-treelistdatasource", TagStructure = TagStructure.NormalOrSelfClosing)]
  [HtmlTargetElement("aggregates", ParentTag = "treelist-datasource", TagStructure = TagStructure.NormalOrSelfClosing)]
  [HtmlTargetElement("aggregates", ParentTag = "gantt-datasource", TagStructure = TagStructure.NormalOrSelfClosing)]
  [HtmlTargetElement("aggregates", ParentTag = "kendo-ganttdatasource", TagStructure = TagStructure.NormalOrSelfClosing)]
  [HtmlTargetElement("aggregates", ParentTag = "dependency-datasource", TagStructure = TagStructure.NormalOrSelfClosing)]
  [HtmlTargetElement("aggregates", ParentTag = "kendo-ganttdependencydatasource", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("aggregate", new string[] {})]
  [SuppressTagRendering]
  public class DataSourceAggregatesTagHelper : TagHelperCollectionBase<
  #nullable disable
  DataSourceAggregateTagHelper>
  {
    public IList<DataSourceAggregateTagHelper> Aggregate => this.InternalRef;

    public DataSourceAggregatesTagHelper()
      : base((IList<DataSourceAggregateTagHelper>) new List<DataSourceAggregateTagHelper>())
    {
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      DataSourceAggregatesTagHelper aggregatesTagHelper = this;
      context.Items[(object) aggregatesTagHelper.GetType()] = (object) aggregatesTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      // ISSUE: reference to a compiler-generated method
      await aggregatesTagHelper.\u003C\u003En__0(context, output);
    }

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (DataSourceTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as DataSourceTagHelper).Aggregate = this;
    }
  }
}
