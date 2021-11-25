// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.EditorImageBrowserTransportDestroySettingsTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections.Generic;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("destroy", ParentTag = "image-browser-transport", TagStructure = TagStructure.WithoutEndTag)]
  [SuppressTagRendering]
  public class EditorImageBrowserTransportDestroySettingsTagHelper : TagHelperChildBase
  {
    [HtmlAttributeName("datatype")]
    public 
    #nullable disable
    string DataType { get; set; }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      System.Type type = typeof (EditorImageBrowserTransportSettingsTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as EditorImageBrowserTransportSettingsTagHelper).Destroy = this;
    }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      string dataType = this.DataType;
      if ((dataType != null ? (dataType.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataType"] = (object) this.DataType;
      return dictionary;
    }

    public string ContentType { get; set; }

    public string Type { get; set; }

    public string Url { get; set; }

    public string UrlHandler { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string contentType = this.ContentType;
      if ((contentType != null ? (contentType.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["contentType"] = (object) this.ContentType;
      string type = this.Type;
      if ((type != null ? (type.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["type"] = (object) this.Type;
      string urlHandler = this.UrlHandler;
      if ((urlHandler != null ? (urlHandler.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary["url"] = (object) this.CreateHandler(this.UrlHandler);
      }
      else
      {
        string url = this.Url;
        if ((url != null ? (url.HasValue() ? 1 : 0) : 0) != 0)
          dictionary["url"] = (object) this.Url;
      }
      return dictionary;
    }
  }
}
