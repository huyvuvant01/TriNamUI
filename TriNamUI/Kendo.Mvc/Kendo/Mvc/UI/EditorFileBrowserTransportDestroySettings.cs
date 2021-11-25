// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.EditorFileBrowserTransportDestroySettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class EditorFileBrowserTransportDestroySettings
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string ContentType { get; set; }

    public string DataType { get; set; }

    public string Type { get; set; }

    public string Url { get; set; }

    public ClientHandlerDescriptor UrlHandler { get; set; }

    public Editor Editor { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string contentType = this.ContentType;
      if ((contentType != null ? (contentType.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["contentType"] = (object) this.ContentType;
      string dataType = this.DataType;
      if ((dataType != null ? (dataType.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataType"] = (object) this.DataType;
      string type = this.Type;
      if ((type != null ? (type.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["type"] = (object) this.Type;
      ClientHandlerDescriptor urlHandler = this.UrlHandler;
      if ((urlHandler != null ? (urlHandler.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary["url"] = (object) this.UrlHandler;
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
