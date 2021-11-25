// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.EditorImageBrowserTransportSettingsTagHelper
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
  [HtmlTargetElement("image-browser-transport", ParentTag = "image-browser", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("read", new string[] {"destroy", "create"})]
  [SuppressTagRendering]
  public class EditorImageBrowserTransportSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (EditorImageBrowserSettingsTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as EditorImageBrowserSettingsTagHelper).Transport = this;
    }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      if (this.Read != null)
        dictionary["type"] = (object) "filebrowser-aspnetmvc";
      return dictionary;
    }

    [HtmlAttributeNotBound]
    public EditorImageBrowserTransportReadSettingsTagHelper Read { get; set; }

    public string ThumbnailUrl { get; set; }

    public string ThumbnailUrlHandler { get; set; }

    public string UploadUrl { get; set; }

    public string ImageUrl { get; set; }

    public string ImageUrlHandler { get; set; }

    [HtmlAttributeNotBound]
    public EditorImageBrowserTransportDestroySettingsTagHelper Destroy { get; set; }

    [HtmlAttributeNotBound]
    public EditorImageBrowserTransportCreateSettingsTagHelper Create { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.Read != null)
      {
        Dictionary<string, object> source = this.Read.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["read"] = (object) source;
      }
      string thumbnailUrlHandler = this.ThumbnailUrlHandler;
      if ((thumbnailUrlHandler != null ? (thumbnailUrlHandler.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary["thumbnailUrl"] = (object) this.CreateHandler(this.ThumbnailUrlHandler);
      }
      else
      {
        string thumbnailUrl = this.ThumbnailUrl;
        if ((thumbnailUrl != null ? (thumbnailUrl.HasValue() ? 1 : 0) : 0) != 0)
          dictionary["thumbnailUrl"] = (object) this.ThumbnailUrl;
      }
      string uploadUrl = this.UploadUrl;
      if ((uploadUrl != null ? (uploadUrl.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["uploadUrl"] = (object) this.UploadUrl;
      string imageUrlHandler = this.ImageUrlHandler;
      if ((imageUrlHandler != null ? (imageUrlHandler.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary["imageUrl"] = (object) this.CreateHandler(this.ImageUrlHandler);
      }
      else
      {
        string imageUrl = this.ImageUrl;
        if ((imageUrl != null ? (imageUrl.HasValue() ? 1 : 0) : 0) != 0)
          dictionary["imageUrl"] = (object) this.ImageUrl;
      }
      if (this.Destroy != null)
      {
        Dictionary<string, object> source = this.Destroy.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["destroy"] = (object) source;
      }
      if (this.Create != null)
      {
        Dictionary<string, object> source = this.Create.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["create"] = (object) source;
      }
      return dictionary;
    }
  }
}
