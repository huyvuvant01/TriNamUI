// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.FloatingActionButton
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
  public class FloatingActionButton : WidgetBase
  {
    public FloatingActionButton(ViewContext viewContext)
      : base(viewContext)
    {
    }

    public FloatingActionButtonAlignOffset AlignOffset { get; set; } = new FloatingActionButtonAlignOffset();

    protected override void WriteHtml(TextWriter writer)
    {
      this.Generator.GenerateTag("button", this.ViewContext, this.Id, this.Name, this.HtmlAttributes).WriteTo(writer, this.HtmlEncoder);
      base.WriteHtml(writer);
    }

    public override void WriteInitializationScript(TextWriter writer)
    {
      Dictionary<string, object> dictionary1 = this.SerializeSettings();
      Dictionary<string, object> dictionary2 = this.AlignOffset.SerializeSettings();
      if (dictionary2.Keys.Any<string>())
        dictionary1["alignOffset"] = (object) dictionary2;
      writer.Write(this.Initializer.Initialize(this.Selector, nameof (FloatingActionButton), (IDictionary<string, object>) dictionary1));
    }

    public bool? Enabled { get; set; }

    public string Icon { get; set; }

    public List<FloatingActionButtonItem> Items { get; set; } = new List<FloatingActionButtonItem>();

    public string Text { get; set; }

    public bool? Visible { get; set; }

    public FloatingActionButtonSize? Size { get; set; }

    public FloatingActionButtonAlign? Align { get; set; }

    public FloatingActionButtonPositionMode? PositionMode { get; set; }

    public FloatingActionButtonShape? Shape { get; set; }

    public FloatingActionButtonThemeColor? ThemeColor { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = base.SerializeSettings();
      if (this.Enabled.HasValue)
        dictionary1["enabled"] = (object) this.Enabled;
      string icon = this.Icon;
      if ((icon != null ? (icon.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["icon"] = (object) this.Icon;
      IEnumerable<Dictionary<string, object>> source = this.Items.Select<FloatingActionButtonItem, Dictionary<string, object>>((Func<FloatingActionButtonItem, Dictionary<string, object>>) (i => i.Serialize()));
      if (source.Any<Dictionary<string, object>>())
        dictionary1["items"] = (object) source;
      string text = this.Text;
      if ((text != null ? (text.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["text"] = (object) this.Text;
      if (this.Visible.HasValue)
        dictionary1["visible"] = (object) this.Visible;
      if (this.Size.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        FloatingActionButtonSize? size = this.Size;
        ref FloatingActionButtonSize? local = ref size;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["size"] = (object) str;
      }
      if (this.Align.HasValue)
      {
        Dictionary<string, object> dictionary3 = dictionary1;
        FloatingActionButtonAlign? align = this.Align;
        ref FloatingActionButtonAlign? local = ref align;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary3["align"] = (object) str;
      }
      if (this.PositionMode.HasValue)
      {
        Dictionary<string, object> dictionary4 = dictionary1;
        FloatingActionButtonPositionMode? positionMode = this.PositionMode;
        ref FloatingActionButtonPositionMode? local = ref positionMode;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary4["positionMode"] = (object) str;
      }
      if (this.Shape.HasValue)
      {
        Dictionary<string, object> dictionary5 = dictionary1;
        FloatingActionButtonShape? shape = this.Shape;
        ref FloatingActionButtonShape? local = ref shape;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary5["shape"] = (object) str;
      }
      if (this.ThemeColor.HasValue)
      {
        Dictionary<string, object> dictionary6 = dictionary1;
        FloatingActionButtonThemeColor? themeColor = this.ThemeColor;
        ref FloatingActionButtonThemeColor? local = ref themeColor;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary6["themeColor"] = (object) str;
      }
      return dictionary1;
    }
  }
}
