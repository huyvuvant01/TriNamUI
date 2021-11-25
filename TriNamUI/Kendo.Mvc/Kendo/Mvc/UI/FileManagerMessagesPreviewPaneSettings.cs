// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.FileManagerMessagesPreviewPaneSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class FileManagerMessagesPreviewPaneSettings
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string NoFileSelected { get; set; }

    public string Extension { get; set; }

    public string Size { get; set; }

    public string Created { get; set; }

    public string Modified { get; set; }

    public string Items { get; set; }

    public FileManager FileManager { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string noFileSelected = this.NoFileSelected;
      if ((noFileSelected != null ? (noFileSelected.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["noFileSelected"] = (object) this.NoFileSelected;
      string extension = this.Extension;
      if ((extension != null ? (extension.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["extension"] = (object) this.Extension;
      string size = this.Size;
      if ((size != null ? (size.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["size"] = (object) this.Size;
      string created = this.Created;
      if ((created != null ? (created.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["created"] = (object) this.Created;
      string modified = this.Modified;
      if ((modified != null ? (modified.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["modified"] = (object) this.Modified;
      string items = this.Items;
      if ((items != null ? (items.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["items"] = (object) this.Items;
      return dictionary;
    }
  }
}
