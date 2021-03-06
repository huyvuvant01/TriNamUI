// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.EditorFileBrowserSchemaModelFieldsTypeSettingsTagHelper
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
  [HtmlTargetElement("type", ParentTag = "fields", TagStructure = TagStructure.WithoutEndTag)]
  [SuppressTagRendering]
  public class EditorFileBrowserSchemaModelFieldsTypeSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (EditorFileBrowserSchemaModelFieldsSettingsTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as EditorFileBrowserSchemaModelFieldsSettingsTagHelper).Type = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Parse { get; set; }

    public string Field { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string parse = this.Parse;
      if ((parse != null ? (parse.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["parse"] = (object) this.CreateHandler(this.Parse);
      string field = this.Field;
      if ((field != null ? (field.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["field"] = (object) this.Field;
      return dictionary;
    }
  }
}
