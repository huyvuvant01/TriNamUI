// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Button
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
  public class Button : WidgetBase
  {
    public string Html { get; set; }

    public Func<object, object> Content { get; set; }

    public Action ContentAction { get; set; }

    public string Tag { get; set; }

    public Button(ViewContext viewContext)
      : base(viewContext)
    {
      this.Enable = new bool?(true);
      this.Tag = "button";
    }

    protected override void WriteHtml(TextWriter writer)
    {
      TagBuilder tag = this.Generator.GenerateTag(this.Tag, this.ViewContext, this.Id, this.Name, this.HtmlAttributes);
      tag.TagRenderMode = TagRenderMode.StartTag;
      tag.WriteTo(writer, this.HtmlEncoder);
      if (this.Html.HasValue())
        writer.Write(this.Html);
      else if (this.Content != null)
        writer.WriteContent<object>(this.Content, this.HtmlEncoder);
      else if (this.ContentAction != null)
        this.ContentAction();
      tag.TagRenderMode = TagRenderMode.EndTag;
      tag.WriteTo(writer, this.HtmlEncoder);
      base.WriteHtml(writer);
    }

    public override void WriteInitializationScript(TextWriter writer)
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      if (this.Enable.Value)
        dictionary.Remove("enable");
      writer.Write(this.Initializer.Initialize(this.Selector, nameof (Button), (IDictionary<string, object>) dictionary));
    }

    public ButtonBadgeSettings Badge { get; } = new ButtonBadgeSettings();

    public bool? Enable { get; set; }

    public string Icon { get; set; }

    public string IconClass { get; set; }

    public string ImageUrl { get; set; }

    public string SpriteCssClass { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = base.SerializeSettings();
      Dictionary<string, object> source = this.Badge.Serialize();
      if (source.Any<KeyValuePair<string, object>>())
        dictionary["badge"] = (object) source;
      else if (this.Badge.Enabled.HasValue)
        dictionary["badge"] = (object) this.Badge.Enabled;
      if (this.Enable.HasValue)
        dictionary["enable"] = (object) this.Enable;
      string icon = this.Icon;
      if ((icon != null ? (icon.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["icon"] = (object) this.Icon;
      string iconClass = this.IconClass;
      if ((iconClass != null ? (iconClass.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["iconClass"] = (object) this.IconClass;
      string imageUrl = this.ImageUrl;
      if ((imageUrl != null ? (imageUrl.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["imageUrl"] = (object) this.ImageUrl;
      string spriteCssClass = this.SpriteCssClass;
      if ((spriteCssClass != null ? (spriteCssClass.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["spriteCssClass"] = (object) this.SpriteCssClass;
      return dictionary;
    }
  }
}
