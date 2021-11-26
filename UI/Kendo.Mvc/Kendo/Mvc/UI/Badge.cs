// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Badge
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.IO;

namespace Kendo.Mvc.UI
{
  public class Badge : WidgetBase
  {
    public float? FloatText { get; set; }

    public Badge(ViewContext viewContext)
      : base(viewContext)
    {
    }

    protected override void WriteHtml(TextWriter writer)
    {
      this.Generator.GenerateTag("span", this.ViewContext, this.Id, this.Name, this.HtmlAttributes).WriteTo(writer, this.HtmlEncoder);
      base.WriteHtml(writer);
    }

    public override void WriteInitializationScript(TextWriter writer)
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      if (this.FloatText.HasValue)
        dictionary["text"] = (object) this.FloatText;
      writer.Write(this.Initializer.Initialize(this.Selector, nameof (Badge), (IDictionary<string, object>) dictionary));
    }

    public bool? CutoutBorder { get; set; }

    public string Icon { get; set; }

    public double? Max { get; set; }

    public string Template { get; set; }

    public string TemplateId { get; set; }

    public string Text { get; set; }

    public bool? Visible { get; set; }

    public BadgeSize? Size { get; set; }

    public BadgeAlign? Align { get; set; }

    public BadgePosition? Position { get; set; }

    public BadgeShape? Shape { get; set; }

    public BadgeColor? ThemeColor { get; set; }

    public BadgeFill? Fill { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = base.SerializeSettings();
      if (this.CutoutBorder.HasValue)
        dictionary1["cutoutBorder"] = (object) this.CutoutBorder;
      string icon = this.Icon;
      if ((icon != null ? (icon.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["icon"] = (object) this.Icon;
      if (this.Max.HasValue)
        dictionary1["max"] = (object) this.Max;
      if (this.TemplateId.HasValue())
        dictionary1["template"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.TemplateId)
        };
      else if (this.Template.HasValue())
        dictionary1["template"] = (object) this.Template;
      string text = this.Text;
      if ((text != null ? (text.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["text"] = (object) this.Text;
      if (this.Visible.HasValue)
        dictionary1["visible"] = (object) this.Visible;
      if (this.Size.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        BadgeSize? size = this.Size;
        ref BadgeSize? local = ref size;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["size"] = (object) str;
      }
      if (this.Align.HasValue)
      {
        Dictionary<string, object> dictionary3 = dictionary1;
        BadgeAlign? align = this.Align;
        ref BadgeAlign? local = ref align;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary3["align"] = (object) str;
      }
      if (this.Position.HasValue)
      {
        Dictionary<string, object> dictionary4 = dictionary1;
        BadgePosition? position = this.Position;
        ref BadgePosition? local = ref position;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary4["position"] = (object) str;
      }
      if (this.Shape.HasValue)
      {
        Dictionary<string, object> dictionary5 = dictionary1;
        BadgeShape? shape = this.Shape;
        ref BadgeShape? local = ref shape;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary5["shape"] = (object) str;
      }
      if (this.ThemeColor.HasValue)
      {
        Dictionary<string, object> dictionary6 = dictionary1;
        BadgeColor? themeColor = this.ThemeColor;
        ref BadgeColor? local = ref themeColor;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary6["themeColor"] = (object) str;
      }
      if (this.Fill.HasValue)
      {
        Dictionary<string, object> dictionary7 = dictionary1;
        BadgeFill? fill = this.Fill;
        ref BadgeFill? local = ref fill;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary7["fill"] = (object) str;
      }
      return dictionary1;
    }
  }
}
