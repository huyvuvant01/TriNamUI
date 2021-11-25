// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.DataSourceGroupsTagHelper
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
  [HtmlTargetElement("groups", ParentTag = "kendo-datasource", TagStructure = TagStructure.NormalOrSelfClosing)]
  [HtmlTargetElement("groups", ParentTag = "datasource", TagStructure = TagStructure.NormalOrSelfClosing)]
  [HtmlTargetElement("groups", ParentTag = "kendo-treelistdatasource", TagStructure = TagStructure.NormalOrSelfClosing)]
  [HtmlTargetElement("groups", ParentTag = "treelist-datasource", TagStructure = TagStructure.NormalOrSelfClosing)]
  [HtmlTargetElement("groups", ParentTag = "gantt-datasource", TagStructure = TagStructure.NormalOrSelfClosing)]
  [HtmlTargetElement("groups", ParentTag = "kendo-ganttdatasource", TagStructure = TagStructure.NormalOrSelfClosing)]
  [HtmlTargetElement("groups", ParentTag = "dependency-datasource", TagStructure = TagStructure.NormalOrSelfClosing)]
  [HtmlTargetElement("groups", ParentTag = "kendo-ganttdependencydatasource", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("group", new string[] {})]
  [SuppressTagRendering]
  public class DataSourceGroupsTagHelper : TagHelperCollectionBase<
  #nullable disable
  DataSourceGroupTagHelper>
  {
    public IList<DataSourceGroupTagHelper> Group => this.InternalRef;

    public DataSourceGroupsTagHelper()
      : base((IList<DataSourceGroupTagHelper>) new List<DataSourceGroupTagHelper>())
    {
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      DataSourceGroupsTagHelper sourceGroupsTagHelper = this;
      context.Items[(object) sourceGroupsTagHelper.GetType()] = (object) sourceGroupsTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      // ISSUE: reference to a compiler-generated method
      await sourceGroupsTagHelper.\u003C\u003En__0(context, output);
    }

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (DataSourceTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as DataSourceTagHelper).Group = this;
    }
  }
}
