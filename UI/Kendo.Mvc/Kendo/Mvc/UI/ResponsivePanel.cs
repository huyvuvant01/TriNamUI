// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.ResponsivePanel
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.IO;

namespace Kendo.Mvc.UI
{
  public class ResponsivePanel : WidgetBase
  {
    public ResponsivePanel(ViewContext viewContext)
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
      writer.Write(this.Initializer.Initialize(this.Selector, nameof (ResponsivePanel), (IDictionary<string, object>) dictionary));
    }

    public bool? AutoClose { get; set; }

    public double? Breakpoint { get; set; }

    public string ToggleButton { get; set; }

    public string Content { get; set; }

    public ResponsivePanelOrientation? Orientation { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = base.SerializeSettings();
      if (this.AutoClose.HasValue)
        dictionary1["autoClose"] = (object) this.AutoClose;
      if (this.Breakpoint.HasValue)
        dictionary1["breakpoint"] = (object) this.Breakpoint;
      string toggleButton = this.ToggleButton;
      if ((toggleButton != null ? (toggleButton.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["toggleButton"] = (object) this.ToggleButton;
      string content = this.Content;
      if ((content != null ? (content.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["content"] = (object) this.Content;
      if (this.Orientation.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        ResponsivePanelOrientation? orientation = this.Orientation;
        ref ResponsivePanelOrientation? local = ref orientation;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["orientation"] = (object) str;
      }
      return dictionary1;
    }
  }
}
