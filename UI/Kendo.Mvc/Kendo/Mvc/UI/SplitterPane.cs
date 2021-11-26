// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.SplitterPane
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Encodings.Web;

namespace Kendo.Mvc.UI
{
  public class SplitterPane
  {
    public string MaxSize { get; set; }

    public string MinSize { get; set; }

    public string ContentUrl { get; set; }

    public string Label { get; set; }

    public string LabelId { get; set; }

    public IDictionary<string, object> HtmlAttributes { get; } = (IDictionary<string, object>) new RouteValueDictionary();

    public Func<object, object> Template { get; set; }

    public Action TemplateAction { get; set; }

    public string Html { get; set; }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      string maxSize = this.MaxSize;
      if ((maxSize != null ? (maxSize.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["max"] = (object) this.MaxSize;
      string minSize = this.MinSize;
      if ((minSize != null ? (minSize.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["min"] = (object) this.MinSize;
      string contentUrl = this.ContentUrl;
      if ((contentUrl != null ? (contentUrl.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["contentUrl"] = (object) this.ContentUrl;
      string label = this.Label;
      if ((label != null ? (label.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["label"] = (object) this.Label;
      string labelId = this.LabelId;
      if ((labelId != null ? (labelId.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["labelId"] = (object) this.LabelId;
      return dictionary;
    }

    public void WriteHtml(TextWriter writer, IKendoHtmlGenerator generator, HtmlEncoder encoder)
    {
      TagBuilder tag = generator.GenerateTag("div", this.HtmlAttributes);
      tag.TagRenderMode = TagRenderMode.StartTag;
      tag.WriteTo(writer, encoder);
      tag.AddCssClass("k-pane");
      if (this.Scrollable.HasValue && this.Scrollable.Value)
        tag.AddCssClass("k-scrollable");
      if (this.Html.HasValue())
        writer.Write(this.Html);
      else if (this.Template != null)
        writer.WriteContent<object>(this.Template, encoder);
      else if (this.TemplateAction != null)
        this.TemplateAction();
      tag.TagRenderMode = TagRenderMode.EndTag;
      tag.WriteTo(writer, encoder);
    }

    public bool? Collapsed { get; set; }

    public string CollapsedSize { get; set; }

    public bool? Collapsible { get; set; }

    public bool? Resizable { get; set; }

    public bool? Scrollable { get; set; }

    public string Size { get; set; }

    public Splitter Splitter { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.Collapsed.HasValue)
        dictionary["collapsed"] = (object) this.Collapsed;
      string collapsedSize = this.CollapsedSize;
      if ((collapsedSize != null ? (collapsedSize.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["collapsedSize"] = (object) this.CollapsedSize;
      if (this.Collapsible.HasValue)
        dictionary["collapsible"] = (object) this.Collapsible;
      if (this.Resizable.HasValue)
        dictionary["resizable"] = (object) this.Resizable;
      if (this.Scrollable.HasValue)
        dictionary["scrollable"] = (object) this.Scrollable;
      string size = this.Size;
      if ((size != null ? (size.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["size"] = (object) this.Size;
      return dictionary;
    }
  }
}
