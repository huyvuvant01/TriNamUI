// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.DataSourceSchemaModelFieldsTagHelper
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
  [HtmlTargetElement("fields", ParentTag = "model", TagStructure = TagStructure.NormalOrSelfClosing)]
  [HtmlTargetElement("fields", ParentTag = "treelist-model", TagStructure = TagStructure.NormalOrSelfClosing)]
  [HtmlTargetElement("fields", ParentTag = "scheduler-model", TagStructure = TagStructure.NormalOrSelfClosing)]
  [HtmlTargetElement("fields", ParentTag = "filemanager-model", TagStructure = TagStructure.NormalOrSelfClosing)]
  [HtmlTargetElement("fields", ParentTag = "orgchart-model", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("field", new string[] {})]
  [SuppressTagRendering]
  public class DataSourceSchemaModelFieldsTagHelper : 
    TagHelperCollectionBase<
    #nullable disable
    DataSourceSchemaModelFieldTaghelper>
  {
    [HtmlAttributeNotBound]
    public Dictionary<string, DataSourceSchemaModelFieldTaghelper> Fields { get; set; }

    public DataSourceSchemaModelFieldsTagHelper()
      : base((IList<DataSourceSchemaModelFieldTaghelper>) new List<DataSourceSchemaModelFieldTaghelper>())
    {
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      DataSourceSchemaModelFieldsTagHelper modelFieldsTagHelper = this;
      context.Items[(object) modelFieldsTagHelper.GetType()] = (object) modelFieldsTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      // ISSUE: reference to a compiler-generated method
      await modelFieldsTagHelper.\u003C\u003En__0(context, output);
      context.Items[(object) modelFieldsTagHelper.GetType()] = (object) null;
    }

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (DataSourceSchemaModelSettingsTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      DataSourceSchemaModelSettingsTagHelper settingsTagHelper = context.Items[(object) type] as DataSourceSchemaModelSettingsTagHelper;
      foreach (DataSourceSchemaModelFieldTaghelper modelFieldTaghelper in (TagHelperCollectionBase<DataSourceSchemaModelFieldTaghelper>) this)
        settingsTagHelper.Fields.Add(modelFieldTaghelper.Name, modelFieldTaghelper);
    }
  }
}
