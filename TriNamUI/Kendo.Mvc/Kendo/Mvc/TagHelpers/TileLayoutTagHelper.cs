// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.TileLayoutTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("kendo-tilelayout")]
  [RestrictChildren("containers", new string[] {"gap"})]
  public class TileLayoutTagHelper : TagHelperBase
  {
    public TileLayoutTagHelper(
    #nullable disable
    IKendoHtmlGenerator generator)
      : base(generator)
    {
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      TileLayoutTagHelper tileLayoutTagHelper = this;
      context.Items[(object) tileLayoutTagHelper.GetType()] = (object) tileLayoutTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      // ISSUE: reference to a compiler-generated method
      await tileLayoutTagHelper.\u003C\u003En__0(context, output);
    }

    protected override void WriteHtml(TagHelperOutput output)
    {
      this.GenerateId(output);
      TagBuilder tag = this.Generator.GenerateTag("div", this.ViewContext, this.Id, this.Name, (IDictionary<string, object>) new Dictionary<string, object>());
      output.TagName = "div";
      output.MergeAttributes(tag);
    }

    protected override string GetInitializationScript() => this.Initializer.Initialize(this.Selector, "TileLayout", (IDictionary<string, object>) this.SerializeSettings());

    public string OnResize { get; set; }

    public string OnReorder { get; set; }

    protected override Dictionary<string, object> SerializeEvents()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string onResize = this.OnResize;
      if ((onResize != null ? (onResize.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["resize"] = (object) this.CreateHandler(this.OnResize);
      string onReorder = this.OnReorder;
      if ((onReorder != null ? (onReorder.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["reorder"] = (object) this.CreateHandler(this.OnReorder);
      return dictionary;
    }

    public double? Columns { get; set; }

    public string ColumnsWidth { get; set; }

    [HtmlAttributeNotBound]
    public TileLayoutContainersTagHelper Containers { get; set; }

    [HtmlAttributeNotBound]
    public TileLayoutGapSettingsTagHelper Gap { get; set; }

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
      if (this.Containers != null)
      {
        IEnumerable<Dictionary<string, object>> source = this.Containers.Select<TileLayoutContainerTagHelper, Dictionary<string, object>>((Func<TileLayoutContainerTagHelper, Dictionary<string, object>>) (i => i.Serialize()));
        if (source.Any<Dictionary<string, object>>())
          dictionary["containers"] = (object) source;
      }
      if (this.Gap != null)
      {
        Dictionary<string, object> source = this.Gap.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["gap"] = (object) source;
      }
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
