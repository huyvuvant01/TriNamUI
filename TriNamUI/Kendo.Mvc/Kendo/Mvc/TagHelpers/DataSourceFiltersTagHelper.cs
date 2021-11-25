// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.DataSourceFiltersTagHelper
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
  [HtmlTargetElement("filters", ParentTag = "kendo-datasource", TagStructure = TagStructure.NormalOrSelfClosing)]
  [HtmlTargetElement("filters", ParentTag = "datasource", TagStructure = TagStructure.NormalOrSelfClosing)]
  [HtmlTargetElement("filters", ParentTag = "kendo-treelistdatasource", TagStructure = TagStructure.NormalOrSelfClosing)]
  [HtmlTargetElement("filters", ParentTag = "treelist-datasource", TagStructure = TagStructure.NormalOrSelfClosing)]
  [HtmlTargetElement("filters", ParentTag = "kendo-hierarchicaldatasource", TagStructure = TagStructure.NormalOrSelfClosing)]
  [HtmlTargetElement("filters", ParentTag = "hierarchical-datasource", TagStructure = TagStructure.NormalOrSelfClosing)]
  [HtmlTargetElement("filters", ParentTag = "kendo-schedulerdatasource", TagStructure = TagStructure.NormalOrSelfClosing)]
  [HtmlTargetElement("filters", ParentTag = "scheduler-datasource", TagStructure = TagStructure.NormalOrSelfClosing)]
  [HtmlTargetElement("filters", ParentTag = "gantt-datasource", TagStructure = TagStructure.NormalOrSelfClosing)]
  [HtmlTargetElement("filters", ParentTag = "kendo-ganttdatasource", TagStructure = TagStructure.NormalOrSelfClosing)]
  [HtmlTargetElement("filters", ParentTag = "dependency-datasource", TagStructure = TagStructure.NormalOrSelfClosing)]
  [HtmlTargetElement("filters", ParentTag = "kendo-ganttdependencydatasource", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("datasource-filter", new string[] {})]
  [SuppressTagRendering]
  public class DataSourceFiltersTagHelper : TagHelperCollectionBase<
  #nullable disable
  DataSourceFilterTagHelper>
  {
    public IList<DataSourceFilterTagHelper> Filter => this.InternalRef;

    public DataSourceFiltersTagHelper()
      : base((IList<DataSourceFilterTagHelper>) new List<DataSourceFilterTagHelper>())
    {
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      DataSourceFiltersTagHelper filtersTagHelper = this;
      context.Items[(object) filtersTagHelper.GetType()] = (object) filtersTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      filtersTagHelper.AddSelfToParent(context);
    }

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (DataSourceTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as DataSourceTagHelper).Filter = this;
    }
  }
}
