// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.DataSourceSortsTagHelper
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
  [HtmlTargetElement("sorts", ParentTag = "kendo-datasource", TagStructure = TagStructure.NormalOrSelfClosing)]
  [HtmlTargetElement("sorts", ParentTag = "datasource", TagStructure = TagStructure.NormalOrSelfClosing)]
  [HtmlTargetElement("sorts", ParentTag = "kendo-treelistdatasource", TagStructure = TagStructure.NormalOrSelfClosing)]
  [HtmlTargetElement("sorts", ParentTag = "treelist-datasource", TagStructure = TagStructure.NormalOrSelfClosing)]
  [HtmlTargetElement("sorts", ParentTag = "kendo-schedulerdatasource", TagStructure = TagStructure.NormalOrSelfClosing)]
  [HtmlTargetElement("sorts", ParentTag = "scheduler-datasource", TagStructure = TagStructure.NormalOrSelfClosing)]
  [HtmlTargetElement("sorts", ParentTag = "gantt-datasource", TagStructure = TagStructure.NormalOrSelfClosing)]
  [HtmlTargetElement("sorts", ParentTag = "kendo-ganttdatasource", TagStructure = TagStructure.NormalOrSelfClosing)]
  [HtmlTargetElement("sorts", ParentTag = "dependency-datasource", TagStructure = TagStructure.NormalOrSelfClosing)]
  [HtmlTargetElement("sorts", ParentTag = "kendo-ganttdependencydatasource", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("sort", new string[] {})]
  [SuppressTagRendering]
  public class DataSourceSortsTagHelper : TagHelperCollectionBase<
  #nullable disable
  DataSourceSortTagHelper>
  {
    public IList<DataSourceSortTagHelper> Sort => this.InternalRef;

    public DataSourceSortsTagHelper()
      : base((IList<DataSourceSortTagHelper>) new List<DataSourceSortTagHelper>())
    {
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      DataSourceSortsTagHelper sourceSortsTagHelper = this;
      context.Items[(object) sourceSortsTagHelper.GetType()] = (object) sourceSortsTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      // ISSUE: reference to a compiler-generated method
      await sourceSortsTagHelper.\u003C\u003En__0(context, output);
    }

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (DataSourceTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as DataSourceTagHelper).Sort = this;
    }
  }
}
