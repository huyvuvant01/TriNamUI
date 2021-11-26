// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.PDFViewerMessagesDialogsSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class PDFViewerMessagesDialogsSettings
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public PDFViewerMessagesDialogsExportAsDialogSettings ExportAsDialog { get; } = new PDFViewerMessagesDialogsExportAsDialogSettings();

    public string OkText { get; set; }

    public string Save { get; set; }

    public string Cancel { get; set; }

    public PDFViewer PDFViewer { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      Dictionary<string, object> source = this.ExportAsDialog.Serialize();
      if (source.Any<KeyValuePair<string, object>>())
        dictionary["exportAsDialog"] = (object) source;
      string okText = this.OkText;
      if ((okText != null ? (okText.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["okText"] = (object) this.OkText;
      string save = this.Save;
      if ((save != null ? (save.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["save"] = (object) this.Save;
      string cancel = this.Cancel;
      if ((cancel != null ? (cancel.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["cancel"] = (object) this.Cancel;
      return dictionary;
    }
  }
}
