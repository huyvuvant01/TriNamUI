// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.UploadFile
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class UploadFile
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Extension { get; set; }

    public string Name { get; set; }

    public double? Size { get; set; }

    public Upload Upload { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string extension = this.Extension;
      if ((extension != null ? (extension.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["extension"] = (object) this.Extension;
      string name = this.Name;
      if ((name != null ? (name.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["name"] = (object) this.Name;
      if (this.Size.HasValue)
        dictionary["size"] = (object) this.Size;
      return dictionary;
    }
  }
}
