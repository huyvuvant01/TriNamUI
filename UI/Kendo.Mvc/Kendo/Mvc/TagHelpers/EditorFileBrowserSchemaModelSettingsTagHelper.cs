// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.EditorFileBrowserSchemaModelSettingsTagHelper
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
  [HtmlTargetElement("file-browser-model", ParentTag = "schema", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("fields", new string[] {})]
  [SuppressTagRendering]
  public class EditorFileBrowserSchemaModelSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (EditorFileBrowserSchemaSettingsTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as EditorFileBrowserSchemaSettingsTagHelper).Model = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Id { get; set; }

    [HtmlAttributeNotBound]
    public EditorFileBrowserSchemaModelFieldsSettingsTagHelper Fields { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string id = this.Id;
      if ((id != null ? (id.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["id"] = (object) this.Id;
      if (this.Fields != null)
      {
        Dictionary<string, object> source = this.Fields.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["fields"] = (object) source;
      }
      return dictionary;
    }
  }
}
