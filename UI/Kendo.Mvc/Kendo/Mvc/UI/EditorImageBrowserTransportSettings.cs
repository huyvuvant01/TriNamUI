// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.EditorImageBrowserTransportSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class EditorImageBrowserTransportSettings
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public EditorImageBrowserTransportReadSettings Read { get; } = new EditorImageBrowserTransportReadSettings();

    public string ThumbnailUrl { get; set; }

    public ClientHandlerDescriptor ThumbnailUrlHandler { get; set; }

    public string UploadUrl { get; set; }

    public string ImageUrl { get; set; }

    public ClientHandlerDescriptor ImageUrlHandler { get; set; }

    public EditorImageBrowserTransportDestroySettings Destroy { get; } = new EditorImageBrowserTransportDestroySettings();

    public EditorImageBrowserTransportCreateSettings Create { get; } = new EditorImageBrowserTransportCreateSettings();

    public Editor Editor { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      Dictionary<string, object> source1 = this.Read.Serialize();
      if (source1.Any<KeyValuePair<string, object>>())
        dictionary["read"] = (object) source1;
      ClientHandlerDescriptor thumbnailUrlHandler = this.ThumbnailUrlHandler;
      if ((thumbnailUrlHandler != null ? (thumbnailUrlHandler.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary["thumbnailUrl"] = (object) this.ThumbnailUrlHandler;
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
      ClientHandlerDescriptor imageUrlHandler = this.ImageUrlHandler;
      if ((imageUrlHandler != null ? (imageUrlHandler.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary["imageUrl"] = (object) this.ImageUrlHandler;
      }
      else
      {
        string imageUrl = this.ImageUrl;
        if ((imageUrl != null ? (imageUrl.HasValue() ? 1 : 0) : 0) != 0)
          dictionary["imageUrl"] = (object) this.ImageUrl;
      }
      Dictionary<string, object> source2 = this.Destroy.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
        dictionary["destroy"] = (object) source2;
      Dictionary<string, object> source3 = this.Create.Serialize();
      if (source3.Any<KeyValuePair<string, object>>())
        dictionary["create"] = (object) source3;
      return dictionary;
    }
  }
}
