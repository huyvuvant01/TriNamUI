// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.QRCodeOverlaySettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class QRCodeOverlaySettings
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public double? Height { get; set; }

    public string Type { get; set; }

    public string ImageUrl { get; set; }

    public double? Width { get; set; }

    public QRCode QRCode { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.Height.HasValue)
        dictionary["height"] = (object) this.Height;
      string type = this.Type;
      if ((type != null ? (type.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["type"] = (object) this.Type;
      string imageUrl = this.ImageUrl;
      if ((imageUrl != null ? (imageUrl.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["imageUrl"] = (object) this.ImageUrl;
      if (this.Width.HasValue)
        dictionary["width"] = (object) this.Width;
      return dictionary;
    }
  }
}
