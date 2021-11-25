// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.PDFViewerPdfjsProcessingSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class PDFViewerPdfjsProcessingSettings
  {
    public PDFViewerPdfjsProcessingFileSettings File { get; set; } = new PDFViewerPdfjsProcessingFileSettings();

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      Dictionary<string, object> source = this.File.Serialize();
      if (source.Any<KeyValuePair<string, object>>())
        dictionary["file"] = (object) source;
      return dictionary;
    }

    public PDFViewer PDFViewer { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings() => new Dictionary<string, object>();
  }
}
