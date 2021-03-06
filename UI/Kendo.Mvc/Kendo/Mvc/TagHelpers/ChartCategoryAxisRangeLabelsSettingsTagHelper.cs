// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.ChartCategoryAxisRangeLabelsSettingsTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("range-labels", ParentTag = "category-axis-item", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("border", new string[] {"date-formats", "margin", "padding", "rotation"})]
  [SuppressTagRendering]
  public class ChartCategoryAxisRangeLabelsSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (ChartCategoryAxisTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as ChartCategoryAxisTagHelper).RangeLabels = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Background { get; set; }

    [HtmlAttributeNotBound]
    public ChartCategoryAxisRangeLabelsBorderSettingsTagHelper Border { get; set; }

    public string Color { get; set; }

    public string Culture { get; set; }

    [HtmlAttributeNotBound]
    public ChartCategoryAxisRangeLabelsDateFormatsSettingsTagHelper DateFormats { get; set; }

    public string Font { get; set; }

    public string Format { get; set; }

    [HtmlAttributeNotBound]
    public ChartCategoryAxisRangeLabelsMarginSettingsTagHelper Margin { get; set; }

    public bool? Mirror { get; set; }

    [HtmlAttributeNotBound]
    public ChartCategoryAxisRangeLabelsPaddingSettingsTagHelper Padding { get; set; }

    [HtmlAttributeNotBound]
    public ChartCategoryAxisRangeLabelsRotationSettingsTagHelper Rotation { get; set; }

    public string Template { get; set; }

    public string TemplateId { get; set; }

    public bool? Visible { get; set; }

    public string Visual { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string background = this.Background;
      if ((background != null ? (background.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["background"] = (object) this.Background;
      if (this.Border != null)
      {
        Dictionary<string, object> source = this.Border.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["border"] = (object) source;
      }
      string color = this.Color;
      if ((color != null ? (color.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["color"] = (object) this.Color;
      string culture = this.Culture;
      if ((culture != null ? (culture.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["culture"] = (object) this.Culture;
      if (this.DateFormats != null)
      {
        Dictionary<string, object> source = this.DateFormats.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["dateFormats"] = (object) source;
      }
      string font = this.Font;
      if ((font != null ? (font.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["font"] = (object) this.Font;
      string format = this.Format;
      if ((format != null ? (format.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["format"] = (object) this.Format;
      if (this.Margin != null)
      {
        Dictionary<string, object> source = this.Margin.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["margin"] = (object) source;
      }
      bool? nullable = this.Mirror;
      if (nullable.HasValue)
        dictionary["mirror"] = (object) this.Mirror;
      if (this.Padding != null)
      {
        Dictionary<string, object> source = this.Padding.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["padding"] = (object) source;
      }
      if (this.Rotation != null)
      {
        Dictionary<string, object> source = this.Rotation.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["rotation"] = (object) source;
      }
      if (this.TemplateId.HasValue())
        dictionary["template"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.TemplateId)
        };
      else if (this.Template.HasValue())
        dictionary["template"] = (object) this.Template;
      nullable = this.Visible;
      if (nullable.HasValue)
        dictionary["visible"] = (object) this.Visible;
      string visual = this.Visual;
      if ((visual != null ? (visual.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["visual"] = (object) this.CreateHandler(this.Visual);
      return dictionary;
    }
  }
}
