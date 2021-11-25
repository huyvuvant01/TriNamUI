// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Drawer
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
  public class Drawer : WidgetBase
  {
    public HtmlTemplate Content { get; set; }

    public Drawer(ViewContext viewContext)
      : base(viewContext)
    {
      this.Content = new HtmlTemplate();
    }

    protected override void WriteHtml(TextWriter writer)
    {
      IHtmlNode node = new HtmlElement("div").Attribute("id", this.Id).Attribute("name", this.Name).Attributes<string, object>(this.HtmlAttributes);
      this.Content.Apply(node);
      node.WriteTo(writer, this.HtmlEncoder);
      base.WriteHtml(writer);
    }

    public override void WriteInitializationScript(TextWriter writer)
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      writer.Write(this.Initializer.Initialize(this.Selector, nameof (Drawer), (IDictionary<string, object>) dictionary));
    }

    public bool? AutoCollapse { get; set; }

    public string Position { get; set; }

    public string Mode { get; set; }

    public bool? Navigatable { get; set; }

    public string Template { get; set; }

    public string TemplateId { get; set; }

    public double? MinHeight { get; set; }

    public DrawerMiniSettings Mini { get; } = new DrawerMiniSettings();

    public bool? SwipeToOpen { get; set; }

    public double? Width { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = base.SerializeSettings();
      if (this.AutoCollapse.HasValue)
        dictionary["autoCollapse"] = (object) this.AutoCollapse;
      string position = this.Position;
      if ((position != null ? (position.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["position"] = (object) this.Position;
      string mode = this.Mode;
      if ((mode != null ? (mode.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["mode"] = (object) this.Mode;
      if (this.Navigatable.HasValue)
        dictionary["navigatable"] = (object) this.Navigatable;
      if (this.TemplateId.HasValue())
        dictionary["template"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.TemplateId)
        };
      else if (this.Template.HasValue())
        dictionary["template"] = (object) this.Template;
      if (this.MinHeight.HasValue)
        dictionary["minHeight"] = (object) this.MinHeight;
      Dictionary<string, object> source = this.Mini.Serialize();
      if (source.Any<KeyValuePair<string, object>>())
        dictionary["mini"] = (object) source;
      else if (this.Mini.Enabled.HasValue)
        dictionary["mini"] = (object) this.Mini.Enabled;
      if (this.SwipeToOpen.HasValue)
        dictionary["swipeToOpen"] = (object) this.SwipeToOpen;
      if (this.Width.HasValue)
        dictionary["width"] = (object) this.Width;
      return dictionary;
    }
  }
}
