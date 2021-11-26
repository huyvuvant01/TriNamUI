// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.ChartYAxisLabelsSettingsTagHelper
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
  [HtmlTargetElement("labels", ParentTag = "y-axis-item", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("chart-y-axis-labels-border", new string[] {"chart-y-axis-labels-date-formats", "chart-y-axis-labels-margin", "chart-y-axis-labels-padding", "chart-y-axis-labels-rotation"})]
  [SuppressTagRendering]
  public class ChartYAxisLabelsSettingsTagHelper : TagHelperChildBase
  {
    public 
    #nullable disable
    string Visual { get; set; }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (ChartYAxisTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as ChartYAxisTagHelper).Labels = this;
    }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      string visual = this.Visual;
      if ((visual != null ? (visual.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["visual"] = (object) this.CreateHandler(this.Visual);
      return dictionary;
    }

    public string Background { get; set; }

    [HtmlAttributeNotBound]
    public ChartYAxisLabelsBorderSettingsTagHelper Border { get; set; }

    public string Color { get; set; }

    public string Culture { get; set; }

    [HtmlAttributeNotBound]
    public ChartYAxisLabelsDateFormatsSettingsTagHelper DateFormats { get; set; }

    public string Font { get; set; }

    public string Format { get; set; }

    [HtmlAttributeNotBound]
    public ChartYAxisLabelsMarginSettingsTagHelper Margin { get; set; }

    public bool? Mirror { get; set; }

    [HtmlAttributeNotBound]
    public ChartYAxisLabelsPaddingSettingsTagHelper Padding { get; set; }

    [HtmlAttributeNotBound]
    public ChartYAxisLabelsRotationSettingsTagHelper Rotation { get; set; }

    public double? Skip { get; set; }

    public double? Step { get; set; }

    public string Template { get; set; }

    public string TemplateId { get; set; }

    public bool? Visible { get; set; }

    public ChartAxisLabelsPosition? Position { get; set; }

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
      string color = this.Color;
      if ((color != null ? (color.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["color"] = (object) this.Color;
      string culture = this.Culture;
      if ((culture != null ? (culture.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["culture"] = (object) this.Culture;
      if (this.DateFormats != null)
      {
        Dictionary<string, object> source = this.DateFormats.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["dateFormats"] = (object) source;
      }
      string font = this.Font;
      if ((font != null ? (font.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["font"] = (object) this.Font;
      string format = this.Format;
      if ((format != null ? (format.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["format"] = (object) this.Format;
      if (this.Margin != null)
      {
        Dictionary<string, object> source = this.Margin.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["margin"] = (object) source;
      }
      bool? nullable1 = this.Mirror;
      if (nullable1.HasValue)
        dictionary1["mirror"] = (object) this.Mirror;
      if (this.Padding != null)
      {
        Dictionary<string, object> source = this.Padding.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["padding"] = (object) source;
      }
      if (this.Rotation != null)
      {
        Dictionary<string, object> source = this.Rotation.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["rotation"] = (object) source;
      }
      double? nullable2 = this.Skip;
      if (nullable2.HasValue)
        dictionary1["skip"] = (object) this.Skip;
      nullable2 = this.Step;
      if (nullable2.HasValue)
        dictionary1["step"] = (object) this.Step;
      if (this.TemplateId.HasValue())
        dictionary1["template"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.TemplateId)
        };
      else if (this.Template.HasValue())
        dictionary1["template"] = (object) this.Template;
      nullable1 = this.Visible;
      if (nullable1.HasValue)
        dictionary1["visible"] = (object) this.Visible;
      ChartAxisLabelsPosition? position = this.Position;
      if (position.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        position = this.Position;
        ref ChartAxisLabelsPosition? local = ref position;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["position"] = (object) str;
      }
      return dictionary1;
    }
  }
}
