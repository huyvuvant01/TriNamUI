// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.PDFViewerMessagesToolbarSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class PDFViewerMessagesToolbarSettings
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Open { get; set; }

    public string ExportAs { get; set; }

    public string Download { get; set; }

    public PDFViewerMessagesToolbarPagerSettings Pager { get; } = new PDFViewerMessagesToolbarPagerSettings();

    public PDFViewer PDFViewer { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string open = this.Open;
      if ((open != null ? (open.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["open"] = (object) this.Open;
      string exportAs = this.ExportAs;
      if ((exportAs != null ? (exportAs.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["exportAs"] = (object) this.ExportAs;
      string download = this.Download;
      if ((download != null ? (download.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["download"] = (object) this.Download;
      Dictionary<string, object> source = this.Pager.Serialize();
      if (source.Any<KeyValuePair<string, object>>())
        dictionary["pager"] = (object) source;
      return dictionary;
    }
  }
}
