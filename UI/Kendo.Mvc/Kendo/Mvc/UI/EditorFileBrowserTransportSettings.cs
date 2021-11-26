// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.EditorFileBrowserTransportSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class EditorFileBrowserTransportSettings
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public EditorFileBrowserTransportReadSettings Read { get; } = new EditorFileBrowserTransportReadSettings();

    public string UploadUrl { get; set; }

    public string FileUrl { get; set; }

    public ClientHandlerDescriptor FileUrlHandler { get; set; }

    public EditorFileBrowserTransportDestroySettings Destroy { get; } = new EditorFileBrowserTransportDestroySettings();

    public EditorFileBrowserTransportCreateSettings Create { get; } = new EditorFileBrowserTransportCreateSettings();

    public Editor Editor { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      Dictionary<string, object> source1 = this.Read.Serialize();
      if (source1.Any<KeyValuePair<string, object>>())
        dictionary["read"] = (object) source1;
      string uploadUrl = this.UploadUrl;
      if ((uploadUrl != null ? (uploadUrl.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["uploadUrl"] = (object) this.UploadUrl;
      ClientHandlerDescriptor fileUrlHandler = this.FileUrlHandler;
      if ((fileUrlHandler != null ? (fileUrlHandler.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary["fileUrl"] = (object) this.FileUrlHandler;
      }
      else
      {
        string fileUrl = this.FileUrl;
        if ((fileUrl != null ? (fileUrl.HasValue() ? 1 : 0) : 0) != 0)
          dictionary["fileUrl"] = (object) this.FileUrl;
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
