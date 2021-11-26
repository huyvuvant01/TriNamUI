// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.TileLayout
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
  public class TileLayout : WidgetBase
  {
    public TileLayout(ViewContext viewContext)
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
      writer.Write(this.Initializer.Initialize(this.Selector, nameof (TileLayout), (IDictionary<string, object>) dictionary));
    }

    public double? Columns { get; set; }

    public string ColumnsWidth { get; set; }

    public List<TileLayoutContainer> Containers { get; set; } = new List<TileLayoutContainer>();

    public TileLayoutGapSettings Gap { get; } = new TileLayoutGapSettings();

    public string Height { get; set; }

    public bool? Navigatable { get; set; }

    public bool? Reorderable { get; set; }

    public bool? Resizable { get; set; }

    public string RowsHeight { get; set; }

    public string Width { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = base.SerializeSettings();
      if (this.Columns.HasValue)
        dictionary["columns"] = (object) this.Columns;
      string columnsWidth = this.ColumnsWidth;
      if ((columnsWidth != null ? (columnsWidth.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["columnsWidth"] = (object) this.ColumnsWidth;
      IEnumerable<Dictionary<string, object>> source1 = this.Containers.Select<TileLayoutContainer, Dictionary<string, object>>((Func<TileLayoutContainer, Dictionary<string, object>>) (i => i.Serialize()));
      if (source1.Any<Dictionary<string, object>>())
        dictionary["containers"] = (object) source1;
      Dictionary<string, object> source2 = this.Gap.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
        dictionary["gap"] = (object) source2;
      string height = this.Height;
      if ((height != null ? (height.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["height"] = (object) this.Height;
      if (this.Navigatable.HasValue)
        dictionary["navigatable"] = (object) this.Navigatable;
      if (this.Reorderable.HasValue)
        dictionary["reorderable"] = (object) this.Reorderable;
      if (this.Resizable.HasValue)
        dictionary["resizable"] = (object) this.Resizable;
      string rowsHeight = this.RowsHeight;
      if ((rowsHeight != null ? (rowsHeight.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["rowsHeight"] = (object) this.RowsHeight;
      string width = this.Width;
      if ((width != null ? (width.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["width"] = (object) this.Width;
      return dictionary;
    }
  }
}
