// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.EditorImageBrowserSettingsTagHelper
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
  [HtmlTargetElement("image-browser", ParentTag = "kendo-editor", TagStructure = TagStructure.NormalOrSelfClosing)]
  [HtmlTargetElement("image-browser", ParentTag = "richtexteditor-editor", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("image-browser-transport", new string[] {"schema", "messages"})]
  [SuppressTagRendering]
  public class EditorImageBrowserSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (EditorTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as EditorTagHelper).ImageBrowser = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string FileTypes { get; set; }

    public string Path { get; set; }

    [HtmlAttributeNotBound]
    public EditorImageBrowserTransportSettingsTagHelper Transport { get; set; }

    [HtmlAttributeNotBound]
    public EditorImageBrowserSchemaSettingsTagHelper Schema { get; set; }

    [HtmlAttributeNotBound]
    public EditorImageBrowserMessagesSettingsTagHelper Messages { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string fileTypes = this.FileTypes;
      if ((fileTypes != null ? (fileTypes.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["fileTypes"] = (object) this.FileTypes;
      string path = this.Path;
      if ((path != null ? (path.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["path"] = (object) this.Path;
      if (this.Transport != null)
      {
        Dictionary<string, object> source = this.Transport.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["transport"] = (object) source;
      }
      if (this.Schema != null)
      {
        Dictionary<string, object> source = this.Schema.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["schema"] = (object) source;
      }
      if (this.Messages != null)
      {
        Dictionary<string, object> source = this.Messages.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["messages"] = (object) source;
      }
      return dictionary;
    }
  }
}
