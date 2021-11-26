// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.ToolBar
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
  public class ToolBar : WidgetBase
  {
    public ToolBar(ViewContext viewContext)
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
      writer.Write(this.Initializer.Initialize(this.Selector, nameof (ToolBar), (IDictionary<string, object>) dictionary));
    }

    public bool? Resizable { get; set; }

    public List<ToolBarItem> Items { get; set; } = new List<ToolBarItem>();

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = base.SerializeSettings();
      if (this.Resizable.HasValue)
        dictionary["resizable"] = (object) this.Resizable;
      IEnumerable<Dictionary<string, object>> source = this.Items.Select<ToolBarItem, Dictionary<string, object>>((Func<ToolBarItem, Dictionary<string, object>>) (i => i.Serialize()));
      if (source.Any<Dictionary<string, object>>())
        dictionary["items"] = (object) source;
      return dictionary;
    }
  }
}
