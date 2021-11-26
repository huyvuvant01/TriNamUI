// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.PDFViewerMessagesDialogsExportAsDialogSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class PDFViewerMessagesDialogsExportAsDialogSettings
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Title { get; set; }

    public string DefaultFileName { get; set; }

    public string Pdf { get; set; }

    public string Png { get; set; }

    public string Svg { get; set; }

    public PDFViewerMessagesDialogsExportAsDialogLabelsSettings Labels { get; } = new PDFViewerMessagesDialogsExportAsDialogLabelsSettings();

    public PDFViewer PDFViewer { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string title = this.Title;
      if ((title != null ? (title.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["title"] = (object) this.Title;
      string defaultFileName = this.DefaultFileName;
      if ((defaultFileName != null ? (defaultFileName.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["defaultFileName"] = (object) this.DefaultFileName;
      string pdf = this.Pdf;
      if ((pdf != null ? (pdf.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["pdf"] = (object) this.Pdf;
      string png = this.Png;
      if ((png != null ? (png.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["png"] = (object) this.Png;
      string svg = this.Svg;
      if ((svg != null ? (svg.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["svg"] = (object) this.Svg;
      Dictionary<string, object> source = this.Labels.Serialize();
      if (source.Any<KeyValuePair<string, object>>())
        dictionary["labels"] = (object) source;
      return dictionary;
    }
  }
}
