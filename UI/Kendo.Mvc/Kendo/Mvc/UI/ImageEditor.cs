// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.ImageEditor
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class ImageEditor : WidgetBase
  {
    public ImageEditor(ViewContext viewContext)
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
      writer.Write(this.Initializer.Initialize(this.Selector, nameof (ImageEditor), (IDictionary<string, object>) dictionary));
    }

    public double? Width { get; set; }

    public double? Height { get; set; }

    public string ImageUrl { get; set; }

    public ImageEditorSaveAsSettings SaveAs { get; } = new ImageEditorSaveAsSettings();

    public ImageEditorToolbarSettings Toolbar { get; } = new ImageEditorToolbarSettings();

    public ImageEditorMessagesSettings Messages { get; } = new ImageEditorMessagesSettings();

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = base.SerializeSettings();
      if (this.Width.HasValue)
        dictionary["width"] = (object) this.Width;
      if (this.Height.HasValue)
        dictionary["height"] = (object) this.Height;
      string imageUrl = this.ImageUrl;
      if ((imageUrl != null ? (imageUrl.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["imageUrl"] = (object) this.ImageUrl;
      Dictionary<string, object> source1 = this.SaveAs.Serialize();
      if (source1.Any<KeyValuePair<string, object>>())
        dictionary["saveAs"] = (object) source1;
      Dictionary<string, object> source2 = this.Toolbar.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
        dictionary["toolbar"] = (object) source2;
      else if (this.Toolbar.Enabled.HasValue)
        dictionary["toolbar"] = (object) this.Toolbar.Enabled;
      Dictionary<string, object> source3 = this.Messages.Serialize();
      if (source3.Any<KeyValuePair<string, object>>())
        dictionary["messages"] = (object) source3;
      return dictionary;
    }
  }
}
