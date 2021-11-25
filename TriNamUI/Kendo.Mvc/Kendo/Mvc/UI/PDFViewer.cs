// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.PDFViewer
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class PDFViewer : WidgetBase
  {
    public PDFViewer(ViewContext viewContext)
      : base(viewContext)
    {
    }

    protected override void WriteHtml(TextWriter writer)
    {
      this.Generator.GenerateTag("div", this.ViewContext, this.Id, this.Name, this.HtmlAttributes).WriteTo(writer, this.HtmlEncoder);
      base.WriteHtml(writer);
    }

    public override void WriteInitializationScript(TextWriter writer)
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      writer.Write(this.Initializer.Initialize(this.Selector, nameof (PDFViewer), (IDictionary<string, object>) dictionary));
    }

    public PDFViewerPdfjsProcessingSettings PdfjsProcessing { get; } = new PDFViewerPdfjsProcessingSettings();

    public PDFViewerDplProcessingSettings DplProcessing { get; } = new PDFViewerDplProcessingSettings();

    public double? Width { get; set; }

    public double? Height { get; set; }

    public PDFViewerDefaultPageSizeSettings DefaultPageSize { get; } = new PDFViewerDefaultPageSizeSettings();

    public double? Page { get; set; }

    public double? Scale { get; set; }

    public double? ZoomMin { get; set; }

    public double? ZoomMax { get; set; }

    public double? ZoomRate { get; set; }

    public PDFViewerViewSettings View { get; } = new PDFViewerViewSettings();

    public PDFViewerToolbarSettings Toolbar { get; } = new PDFViewerToolbarSettings();

    public PDFViewerMessagesSettings Messages { get; } = new PDFViewerMessagesSettings();

    public ClientHandlerDescriptor Document { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = base.SerializeSettings();
      Dictionary<string, object> source1 = this.PdfjsProcessing.Serialize();
      if (source1.Any<KeyValuePair<string, object>>())
        dictionary["pdfjsProcessing"] = (object) source1;
      Dictionary<string, object> source2 = this.DplProcessing.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
        dictionary["dplProcessing"] = (object) source2;
      double? nullable = this.Width;
      if (nullable.HasValue)
        dictionary["width"] = (object) this.Width;
      nullable = this.Height;
      if (nullable.HasValue)
        dictionary["height"] = (object) this.Height;
      Dictionary<string, object> source3 = this.DefaultPageSize.Serialize();
      if (source3.Any<KeyValuePair<string, object>>())
        dictionary["defaultPageSize"] = (object) source3;
      nullable = this.Page;
      if (nullable.HasValue)
        dictionary["page"] = (object) this.Page;
      nullable = this.Scale;
      if (nullable.HasValue)
        dictionary["scale"] = (object) this.Scale;
      nullable = this.ZoomMin;
      if (nullable.HasValue)
        dictionary["zoomMin"] = (object) this.ZoomMin;
      nullable = this.ZoomMax;
      if (nullable.HasValue)
        dictionary["zoomMax"] = (object) this.ZoomMax;
      nullable = this.ZoomRate;
      if (nullable.HasValue)
        dictionary["zoomRate"] = (object) this.ZoomRate;
      Dictionary<string, object> source4 = this.View.Serialize();
      if (source4.Any<KeyValuePair<string, object>>())
        dictionary["view"] = (object) source4;
      Dictionary<string, object> source5 = this.Toolbar.Serialize();
      if (source5.Any<KeyValuePair<string, object>>())
        dictionary["toolbar"] = (object) source5;
      else if (this.Toolbar.Enabled.HasValue)
        dictionary["toolbar"] = (object) this.Toolbar.Enabled;
      Dictionary<string, object> source6 = this.Messages.Serialize();
      if (source6.Any<KeyValuePair<string, object>>())
        dictionary["messages"] = (object) source6;
      ClientHandlerDescriptor document = this.Document;
      if ((document != null ? (document.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["document"] = (object) this.Document;
      return dictionary;
    }
  }
}
