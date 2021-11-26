// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.EditorFileBrowserSchemaModelFieldsSettingsTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("fields", ParentTag = "file-browser-model", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("name", new string[] {"type", "size"})]
  [SuppressTagRendering]
  public class EditorFileBrowserSchemaModelFieldsSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      System.Type type = typeof (EditorFileBrowserSchemaModelSettingsTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as EditorFileBrowserSchemaModelSettingsTagHelper).Fields = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    [HtmlAttributeNotBound]
    public EditorFileBrowserSchemaModelFieldsNameSettingsTagHelper Name { get; set; }

    [HtmlAttributeNotBound]
    public EditorFileBrowserSchemaModelFieldsTypeSettingsTagHelper Type { get; set; }

    [HtmlAttributeNotBound]
    public EditorFileBrowserSchemaModelFieldsSizeSettingsTagHelper Size { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.Name != null)
      {
        Dictionary<string, object> source = this.Name.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["name"] = (object) source;
      }
      if (this.Type != null)
      {
        Dictionary<string, object> source = this.Type.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["type"] = (object) source;
      }
      if (this.Size != null)
      {
        Dictionary<string, object> source = this.Size.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["size"] = (object) source;
      }
      return dictionary;
    }
  }
}
