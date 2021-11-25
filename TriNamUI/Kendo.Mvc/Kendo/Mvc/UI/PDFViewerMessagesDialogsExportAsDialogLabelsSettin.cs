// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.PDFViewerMessagesDialogsExportAsDialogLabelsSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class PDFViewerMessagesDialogsExportAsDialogLabelsSettings
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string FileName { get; set; }

    public string SaveAsType { get; set; }

    public string Page { get; set; }

    public PDFViewer PDFViewer { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string fileName = this.FileName;
      if ((fileName != null ? (fileName.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["fileName"] = (object) this.FileName;
      string saveAsType = this.SaveAsType;
      if ((saveAsType != null ? (saveAsType.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["saveAsType"] = (object) this.SaveAsType;
      string page = this.Page;
      if ((page != null ? (page.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["page"] = (object) this.Page;
      return dictionary;
    }
  }
}
