// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.PDFViewerPdfjsProcessingFileSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class PDFViewerPdfjsProcessingFileSettings
  {
    public string Url { get; set; }

    public object Data { get; set; }

    public string CMapUrl { get; set; }

    public bool? CMapPacked { get; set; }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.Url.HasValue())
        dictionary["url"] = (object) this.Url;
      else if (this.Data != null)
        dictionary["data"] = this.Data;
      if (this.CMapUrl.HasValue())
        dictionary["cMapUrl"] = (object) this.CMapUrl;
      if (this.CMapPacked.HasValue)
        dictionary["cMapPacked"] = (object) this.CMapPacked;
      return dictionary;
    }
  }
}
