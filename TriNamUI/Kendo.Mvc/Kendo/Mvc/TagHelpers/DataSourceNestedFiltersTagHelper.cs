// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.DataSourceNestedFiltersTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("filters", ParentTag = "datasource-filter")]
  [RestrictChildren("datasource-filter", new string[] {})]
  [SuppressTagRendering]
  public class DataSourceNestedFiltersTagHelper : DataSourceFiltersTagHelper
  {
    private 
    #nullable disable
    DataSourceNestedFiltersTagHelper PreviousInstance { get; set; }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      DataSourceNestedFiltersTagHelper filtersTagHelper = this;
      filtersTagHelper.AddSelfToParent(context);
      Type type = filtersTagHelper.GetType();
      if (context.Items.ContainsKey((object) type))
        filtersTagHelper.PreviousInstance = context.Items[(object) type] as DataSourceNestedFiltersTagHelper;
      context.Items[(object) type] = (object) filtersTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      context.Items[(object) type] = (object) filtersTagHelper.PreviousInstance;
      type = (Type) null;
    }

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (DataSourceFilterTagHelper);
      (context.Items[(object) type] as DataSourceFilterTagHelper).Filter = (DataSourceFiltersTagHelper) this;
    }
  }
}
