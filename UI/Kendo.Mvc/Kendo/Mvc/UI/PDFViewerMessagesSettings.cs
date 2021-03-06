// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.PDFViewerMessagesSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class PDFViewerMessagesSettings
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string DefaultFileName { get; set; }

    public PDFViewerMessagesToolbarSettings Toolbar { get; } = new PDFViewerMessagesToolbarSettings();

    public PDFViewerMessagesErrorMessagesSettings ErrorMessages { get; } = new PDFViewerMessagesErrorMessagesSettings();

    public PDFViewerMessagesDialogsSettings Dialogs { get; } = new PDFViewerMessagesDialogsSettings();

    public PDFViewer PDFViewer { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string defaultFileName = this.DefaultFileName;
      if ((defaultFileName != null ? (defaultFileName.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["defaultFileName"] = (object) this.DefaultFileName;
      Dictionary<string, object> source1 = this.Toolbar.Serialize();
      if (source1.Any<KeyValuePair<string, object>>())
        dictionary["toolbar"] = (object) source1;
      Dictionary<string, object> source2 = this.ErrorMessages.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
        dictionary["errorMessages"] = (object) source2;
      Dictionary<string, object> source3 = this.Dialogs.Serialize();
      if (source3.Any<KeyValuePair<string, object>>())
        dictionary["dialogs"] = (object) source3;
      return dictionary;
    }
  }
}
