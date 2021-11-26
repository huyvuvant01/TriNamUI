// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.SpreadsheetSheetDrawingTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("drawing", ParentTag = "drawings", TagStructure = TagStructure.NormalOrSelfClosing)]
  [SuppressTagRendering]
  public class SpreadsheetSheetDrawingTagHelper : TagHelperCollectionItemBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (SpreadsheetSheetDrawingsTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as SpreadsheetSheetDrawingsTagHelper).Add(this);
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string TopLeftCell { get; set; }

    public double? OffsetX { get; set; }

    public double? OffsetY { get; set; }

    public double? Width { get; set; }

    public double? Height { get; set; }

    public string Image { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string topLeftCell = this.TopLeftCell;
      if ((topLeftCell != null ? (topLeftCell.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["topLeftCell"] = (object) this.TopLeftCell;
      double? nullable = this.OffsetX;
      if (nullable.HasValue)
        dictionary["offsetX"] = (object) this.OffsetX;
      nullable = this.OffsetY;
      if (nullable.HasValue)
        dictionary["offsetY"] = (object) this.OffsetY;
      nullable = this.Width;
      if (nullable.HasValue)
        dictionary["width"] = (object) this.Width;
      nullable = this.Height;
      if (nullable.HasValue)
        dictionary["height"] = (object) this.Height;
      string image = this.Image;
      if ((image != null ? (image.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["image"] = (object) this.Image;
      return dictionary;
    }
  }
}
