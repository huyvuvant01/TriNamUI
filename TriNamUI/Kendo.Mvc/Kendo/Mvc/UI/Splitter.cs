// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Splitter
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
  public class Splitter : WidgetBase
  {
    public Splitter(ViewContext viewContext)
      : base(viewContext)
    {
    }

    protected override void WriteHtml(TextWriter writer)
    {
      TagBuilder tag = this.Generator.GenerateTag("div", this.ViewContext, this.Id, this.Name, this.HtmlAttributes);
      tag.TagRenderMode = TagRenderMode.StartTag;
      tag.WriteTo(writer, this.HtmlEncoder);
      tag.AddCssClass("k-widget k-splitter");
      SplitterOrientation? orientation = this.Orientation;
      SplitterOrientation splitterOrientation = SplitterOrientation.Horizontal;
      tag.AddCssClass(orientation.GetValueOrDefault() == splitterOrientation & orientation.HasValue ? "k-splitter-horizontal" : "k-splitter-vertical");
      this.Panes.Each<SplitterPane>((Action<SplitterPane>) (p => p.WriteHtml(writer, this.Generator, this.HtmlEncoder)));
      tag.TagRenderMode = TagRenderMode.EndTag;
      tag.WriteTo(writer, this.HtmlEncoder);
      base.WriteHtml(writer);
    }

    public override void WriteInitializationScript(TextWriter writer)
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      writer.Write(this.Initializer.Initialize(this.Selector, nameof (Splitter), (IDictionary<string, object>) dictionary));
    }

    public List<SplitterPane> Panes { get; set; } = new List<SplitterPane>();

    public SplitterOrientation? Orientation { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = base.SerializeSettings();
      IEnumerable<Dictionary<string, object>> source = this.Panes.Select<SplitterPane, Dictionary<string, object>>((Func<SplitterPane, Dictionary<string, object>>) (i => i.Serialize()));
      if (source.Any<Dictionary<string, object>>())
        dictionary1["panes"] = (object) source;
      SplitterOrientation? orientation = this.Orientation;
      if (orientation.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        orientation = this.Orientation;
        ref SplitterOrientation? local = ref orientation;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["orientation"] = (object) str;
      }
      return dictionary1;
    }
  }
}
