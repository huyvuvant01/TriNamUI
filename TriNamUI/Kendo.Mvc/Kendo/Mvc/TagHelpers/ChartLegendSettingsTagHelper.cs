// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.ChartLegendSettingsTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("chart-legend", ParentTag = "kendo-chart", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("border", new string[] {"inactive-items", "item", "labels", "margin", "padding"})]
  [SuppressTagRendering]
  public class ChartLegendSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (ChartTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as ChartTagHelper).Legend = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Background { get; set; }

    [HtmlAttributeNotBound]
    public ChartLegendBorderSettingsTagHelper Border { get; set; }

    public double? Height { get; set; }

    [HtmlAttributeNotBound]
    public ChartLegendInactiveItemsSettingsTagHelper InactiveItems { get; set; }

    [HtmlAttributeNotBound]
    public ChartLegendItemSettingsTagHelper Item { get; set; }

    [HtmlAttributeNotBound]
    public ChartLegendLabelsSettingsTagHelper Labels { get; set; }

    [HtmlAttributeNotBound]
    public ChartLegendMarginSettingsTagHelper Margin { get; set; }

    public double? OffsetX { get; set; }

    public double? OffsetY { get; set; }

    [HtmlAttributeNotBound]
    public ChartLegendPaddingSettingsTagHelper Padding { get; set; }

    public bool? Reverse { get; set; }

    public double? Spacing { get; set; }

    [HtmlAttributeNotBound]
    public ChartLegendTitleSettingsTagHelper Title { get; set; }

    public bool? Visible { get; set; }

    public double? Width { get; set; }

    public ChartLegendAlign? Align { get; set; }

    public ChartLegendOrientation? Orientation { get; set; }

    public ChartLegendPosition? Position { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = new Dictionary<string, object>();
      string background = this.Background;
      if ((background != null ? (background.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["background"] = (object) this.Background;
      if (this.Border != null)
      {
        Dictionary<string, object> source = this.Border.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["border"] = (object) source;
      }
      double? nullable1 = this.Height;
      if (nullable1.HasValue)
        dictionary1["height"] = (object) this.Height;
      if (this.InactiveItems != null)
      {
        Dictionary<string, object> source = this.InactiveItems.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["inactiveItems"] = (object) source;
      }
      if (this.Item != null)
      {
        Dictionary<string, object> source = this.Item.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["item"] = (object) source;
      }
      if (this.Labels != null)
      {
        Dictionary<string, object> source = this.Labels.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["labels"] = (object) source;
      }
      if (this.Margin != null)
      {
        Dictionary<string, object> source = this.Margin.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["margin"] = (object) source;
      }
      nullable1 = this.OffsetX;
      if (nullable1.HasValue)
        dictionary1["offsetX"] = (object) this.OffsetX;
      nullable1 = this.OffsetY;
      if (nullable1.HasValue)
        dictionary1["offsetY"] = (object) this.OffsetY;
      if (this.Padding != null)
      {
        Dictionary<string, object> source = this.Padding.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["padding"] = (object) source;
      }
      bool? nullable2 = this.Reverse;
      if (nullable2.HasValue)
        dictionary1["reverse"] = (object) this.Reverse;
      nullable1 = this.Spacing;
      if (nullable1.HasValue)
        dictionary1["spacing"] = (object) this.Spacing;
      if (this.Title != null)
      {
        Dictionary<string, object> source = this.Title.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["title"] = (object) source;
      }
      nullable2 = this.Visible;
      if (nullable2.HasValue)
        dictionary1["visible"] = (object) this.Visible;
      nullable1 = this.Width;
      if (nullable1.HasValue)
        dictionary1["width"] = (object) this.Width;
      ChartLegendAlign? align = this.Align;
      if (align.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        align = this.Align;
        ref ChartLegendAlign? local = ref align;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["align"] = (object) str;
      }
      ChartLegendOrientation? orientation = this.Orientation;
      if (orientation.HasValue)
      {
        Dictionary<string, object> dictionary3 = dictionary1;
        orientation = this.Orientation;
        ref ChartLegendOrientation? local = ref orientation;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary3["orientation"] = (object) str;
      }
      ChartLegendPosition? position = this.Position;
      if (position.HasValue)
      {
        Dictionary<string, object> dictionary4 = dictionary1;
        position = this.Position;
        ref ChartLegendPosition? local = ref position;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary4["position"] = (object) str;
      }
      return dictionary1;
    }
  }
}
