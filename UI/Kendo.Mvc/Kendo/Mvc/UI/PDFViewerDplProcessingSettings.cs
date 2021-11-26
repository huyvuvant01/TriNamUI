// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.PDFViewerDplProcessingSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class PDFViewerDplProcessingSettings
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public PDFViewerDplProcessingReadSettings Read { get; } = new PDFViewerDplProcessingReadSettings();

    public PDFViewerDplProcessingUploadSettings Upload { get; } = new PDFViewerDplProcessingUploadSettings();

    public PDFViewerDplProcessingDownloadSettings Download { get; } = new PDFViewerDplProcessingDownloadSettings();

    public bool? LoadOnDemand { get; set; }

    public PDFViewer PDFViewer { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      Dictionary<string, object> source1 = this.Read.Serialize();
      if (source1.Any<KeyValuePair<string, object>>())
        dictionary["read"] = (object) source1;
      Dictionary<string, object> source2 = this.Upload.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
        dictionary["upload"] = (object) source2;
      Dictionary<string, object> source3 = this.Download.Serialize();
      if (source3.Any<KeyValuePair<string, object>>())
        dictionary["download"] = (object) source3;
      if (this.LoadOnDemand.HasValue)
        dictionary["loadOnDemand"] = (object) this.LoadOnDemand;
      return dictionary;
    }
  }
}
