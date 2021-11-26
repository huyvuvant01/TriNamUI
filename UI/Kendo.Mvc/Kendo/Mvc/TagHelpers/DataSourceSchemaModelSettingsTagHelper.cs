// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.DataSourceSchemaModelSettingsTagHelper
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
  [HtmlTargetElement("model", ParentTag = "schema", TagStructure = TagStructure.NormalOrSelfClosing)]
  [HtmlTargetElement("filemanager-model", ParentTag = "schema", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("fields", new string[] {})]
  [SuppressTagRendering]
  public class DataSourceSchemaModelSettingsTagHelper : TagHelperChildBase
  {
    [HtmlAttributeNotBound]
    public 
    #nullable disable
    Dictionary<string, DataSourceSchemaModelFieldTaghelper> Fields { get; set; }

    public string Id { get; set; }

    public DataSourceSchemaModelSettingsTagHelper() => this.Fields = new Dictionary<string, DataSourceSchemaModelFieldTaghelper>();

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (DataSourceSchemaSettingsTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as DataSourceSchemaSettingsTagHelper).Model = this;
    }

    internal virtual Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string id = this.Id;
      if ((id != null ? (id.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["id"] = (object) this.Id;
      if (this.Fields != null)
      {
        Dictionary<string, object> source = new Dictionary<string, object>();
        foreach (KeyValuePair<string, DataSourceSchemaModelFieldTaghelper> field in this.Fields)
          source.Add(field.Key, (object) field.Value.Serialize());
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["fields"] = (object) source;
      }
      return dictionary;
    }
  }
}
