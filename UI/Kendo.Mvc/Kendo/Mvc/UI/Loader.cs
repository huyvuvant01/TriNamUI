// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Loader
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class Loader : WidgetBase
  {
    public Loader(ViewContext viewContext)
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
      writer.Write(this.Initializer.Initialize(this.Selector, nameof (Loader), (IDictionary<string, object>) dictionary));
    }

    public LoaderMessagesSettings Messages { get; } = new LoaderMessagesSettings();

    public bool? Visible { get; set; }

    public LoaderSize? Size { get; set; }

    public LoaderThemeColor? ThemeColor { get; set; }

    public LoaderType? Type { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = base.SerializeSettings();
      Dictionary<string, object> source = this.Messages.Serialize();
      if (source.Any<KeyValuePair<string, object>>())
        dictionary1["messages"] = (object) source;
      if (this.Visible.HasValue)
        dictionary1["visible"] = (object) this.Visible;
      LoaderSize? size = this.Size;
      if (size.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        size = this.Size;
        ref LoaderSize? local = ref size;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["size"] = (object) str;
      }
      LoaderThemeColor? themeColor = this.ThemeColor;
      if (themeColor.HasValue)
      {
        Dictionary<string, object> dictionary3 = dictionary1;
        themeColor = this.ThemeColor;
        ref LoaderThemeColor? local = ref themeColor;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary3["themeColor"] = (object) str;
      }
      LoaderType? type = this.Type;
      if (type.HasValue)
      {
        Dictionary<string, object> dictionary4 = dictionary1;
        type = this.Type;
        ref LoaderType? local = ref type;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary4["type"] = (object) str;
      }
      return dictionary1;
    }
  }
}
