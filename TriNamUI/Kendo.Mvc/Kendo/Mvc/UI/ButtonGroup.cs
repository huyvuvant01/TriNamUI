// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.ButtonGroup
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class ButtonGroup : WidgetBase
  {
    public Action<ButtonGroupItem> ItemAction { get; set; }

    public ButtonGroup(ViewContext viewContext)
      : base(viewContext)
    {
      this.Items = new List<ButtonGroupItem>();
    }

    protected override void WriteHtml(TextWriter writer)
    {
      IHtmlNode htmlNode = new ButtonGroupHtmlBuilder(this).ButtonGroupTag();
      htmlNode.Attributes<string, object>(this.HtmlAttributes).Attribute("id", this.Id);
      htmlNode.WriteTo(writer, this.HtmlEncoder);
      base.WriteHtml(writer);
    }

    public override void WriteInitializationScript(TextWriter writer)
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      writer.Write(this.Initializer.Initialize(this.Selector, nameof (ButtonGroup), (IDictionary<string, object>) dictionary));
    }

    public bool? Enable { get; set; }

    public double? Index { get; set; }

    public string Selection { get; set; }

    public List<ButtonGroupItem> Items { get; set; } = new List<ButtonGroupItem>();

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = base.SerializeSettings();
      if (this.Enable.HasValue)
        dictionary["enable"] = (object) this.Enable;
      if (this.Index.HasValue)
        dictionary["index"] = (object) this.Index;
      string selection = this.Selection;
      if ((selection != null ? (selection.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["selection"] = (object) this.Selection;
      IEnumerable<Dictionary<string, object>> source = this.Items.Select<ButtonGroupItem, Dictionary<string, object>>((Func<ButtonGroupItem, Dictionary<string, object>>) (i => i.Serialize()));
      if (source.Any<Dictionary<string, object>>())
        dictionary["items"] = (object) source;
      return dictionary;
    }
  }
}
