// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.FileManagerUploadAsyncSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class FileManagerUploadAsyncSettings
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public bool? AutoUpload { get; set; }

    public bool? Batch { get; set; }

    public double? ChunkSize { get; set; }

    public bool? Concurrent { get; set; }

    public double? AutoRetryAfter { get; set; }

    public double? MaxAutoRetries { get; set; }

    public string SaveField { get; set; }

    public string SaveUrl { get; set; }

    public bool? UseArrayBuffer { get; set; }

    public bool? WithCredentials { get; set; }

    public FileManager FileManager { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.AutoUpload.HasValue)
        dictionary["autoUpload"] = (object) this.AutoUpload;
      if (this.Batch.HasValue)
        dictionary["batch"] = (object) this.Batch;
      if (this.ChunkSize.HasValue)
        dictionary["chunkSize"] = (object) this.ChunkSize;
      if (this.Concurrent.HasValue)
        dictionary["concurrent"] = (object) this.Concurrent;
      if (this.AutoRetryAfter.HasValue)
        dictionary["autoRetryAfter"] = (object) this.AutoRetryAfter;
      if (this.MaxAutoRetries.HasValue)
        dictionary["maxAutoRetries"] = (object) this.MaxAutoRetries;
      string saveField = this.SaveField;
      if ((saveField != null ? (saveField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["saveField"] = (object) this.SaveField;
      string saveUrl = this.SaveUrl;
      if ((saveUrl != null ? (saveUrl.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["saveUrl"] = (object) this.SaveUrl;
      if (this.UseArrayBuffer.HasValue)
        dictionary["useArrayBuffer"] = (object) this.UseArrayBuffer;
      if (this.WithCredentials.HasValue)
        dictionary["withCredentials"] = (object) this.WithCredentials;
      return dictionary;
    }
  }
}
