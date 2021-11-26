// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.HierarchicalDataSourceSchemaModelSettingsTagHelper
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
  [HtmlTargetElement("hierarchical-model", ParentTag = "schema", TagStructure = TagStructure.NormalOrSelfClosing)]
  [SuppressTagRendering]
  public class HierarchicalDataSourceSchemaModelSettingsTagHelper : 
    DataSourceSchemaModelSettingsTagHelper
  {
    [HtmlAttributeName("has-children")]
    public 
    #nullable disable
    string HasChildren { get; set; }

    [HtmlAttributeName("children")]
    public string Children { get; set; }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToContext(TagHelperContext context) => context.Items[(object) typeof (DataSourceSchemaModelSettingsTagHelper)] = (object) this;

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (DataSourceSchemaSettingsTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as DataSourceSchemaSettingsTagHelper).Model = (DataSourceSchemaModelSettingsTagHelper) this;
    }

    internal override Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = base.Serialize();
      if (this.HasChildren.HasValue())
        dictionary["hasChildren"] = (object) this.HasChildren;
      if (this.Children.HasValue())
        dictionary["children"] = (object) this.Children;
      return dictionary;
    }
  }
}
