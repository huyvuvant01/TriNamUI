// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.AppBar
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class AppBar : WidgetBase
  {
    public AppBar(ViewContext viewContext)
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
      writer.Write(this.Initializer.Initialize(this.Selector, nameof (AppBar), (IDictionary<string, object>) dictionary));
    }

    public List<AppBarItem> Items { get; set; } = new List<AppBarItem>();

    public AppBarPosition? Position { get; set; }

    public AppBarPositionMode? PositionMode { get; set; }

    public AppBarThemeColor? ThemeColor { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = base.SerializeSettings();
      IEnumerable<Dictionary<string, object>> source = this.Items.Select<AppBarItem, Dictionary<string, object>>((Func<AppBarItem, Dictionary<string, object>>) (i => i.Serialize()));
      if (source.Any<Dictionary<string, object>>())
        dictionary1["items"] = (object) source;
      AppBarPosition? position = this.Position;
      if (position.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        position = this.Position;
        ref AppBarPosition? local = ref position;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["position"] = (object) str;
      }
      AppBarPositionMode? positionMode = this.PositionMode;
      if (positionMode.HasValue)
      {
        Dictionary<string, object> dictionary3 = dictionary1;
        positionMode = this.PositionMode;
        ref AppBarPositionMode? local = ref positionMode;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary3["positionMode"] = (object) str;
      }
      AppBarThemeColor? themeColor = this.ThemeColor;
      if (themeColor.HasValue)
      {
        Dictionary<string, object> dictionary4 = dictionary1;
        themeColor = this.ThemeColor;
        ref AppBarThemeColor? local = ref themeColor;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary4["themeColor"] = (object) str;
      }
      return dictionary1;
    }
  }
}
