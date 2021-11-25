// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.ChartSeriesDefaultsLabelsSettingsTagHelper
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
  [HtmlTargetElement("labels", ParentTag = "series-defaults", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("chart-series-defaults-labels-border", new string[] {"chart-series-defaults-labels-margin", "chart-series-defaults-labels-padding", "chart-series-defaults-labels-from", "chart-series-defaults-labels-to"})]
  [SuppressTagRendering]
  public class ChartSeriesDefaultsLabelsSettingsTagHelper : TagHelperChildBase
  {
    public 
    #nullable disable
    string Visual { get; set; }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (ChartSeriesDefaultsSettingsTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as ChartSeriesDefaultsSettingsTagHelper).Labels = this;
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
    public ChartSeriesDefaultsLabelsBorderSettingsTagHelper Border { get; set; }

    public string Color { get; set; }

    public string Font { get; set; }

    public string Format { get; set; }

    [HtmlAttributeNotBound]
    public ChartSeriesDefaultsLabelsMarginSettingsTagHelper Margin { get; set; }

    [HtmlAttributeNotBound]
    public ChartSeriesDefaultsLabelsPaddingSettingsTagHelper Padding { get; set; }

    public string Position { get; set; }

    public string PositionHandler { get; set; }

    public string Rotation { get; set; }

    public string Template { get; set; }

    public string TemplateId { get; set; }

    public bool? Visible { get; set; }

    [HtmlAttributeNotBound]
    public ChartSeriesDefaultsLabelsFromSettingsTagHelper From { get; set; }

    [HtmlAttributeNotBound]
    public ChartSeriesDefaultsLabelsToSettingsTagHelper To { get; set; }

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
      if (this.Padding != null)
      {
        Dictionary<string, object> source = this.Padding.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["padding"] = (object) source;
      }
      string positionHandler = this.PositionHandler;
      if ((positionHandler != null ? (positionHandler.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary["position"] = (object) this.CreateHandler(this.PositionHandler);
      }
      else
      {
        string position = this.Position;
        if ((position != null ? (position.HasValue() ? 1 : 0) : 0) != 0)
          dictionary["position"] = (object) this.Position;
      }
      string rotation = this.Rotation;
      if ((rotation != null ? (rotation.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["rotation"] = (object) this.Rotation;
      if (this.TemplateId.HasValue())
        dictionary["template"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.TemplateId)
        };
      else if (this.Template.HasValue())
        dictionary["template"] = (object) this.Template;
      if (this.Visible.HasValue)
        dictionary["visible"] = (object) this.Visible;
      if (this.From != null)
      {
        Dictionary<string, object> source = this.From.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["from"] = (object) source;
      }
      if (this.To != null)
      {
        Dictionary<string, object> source = this.To.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["to"] = (object) source;
      }
      return dictionary;
    }
  }
}
