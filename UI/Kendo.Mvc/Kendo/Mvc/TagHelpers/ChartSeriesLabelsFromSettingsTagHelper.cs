// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.ChartSeriesLabelsFromSettingsTagHelper
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
  [HtmlTargetElement("chart-series-labels-from", ParentTag = "labels", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("border", new string[] {"margin", "padding"})]
  [SuppressTagRendering]
  public class ChartSeriesLabelsFromSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (ChartSeriesLabelsSettingsTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as ChartSeriesLabelsSettingsTagHelper).From = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Background { get; set; }

    public string BackgroundHandler { get; set; }

    [HtmlAttributeNotBound]
    public ChartSeriesLabelsFromBorderSettingsTagHelper Border { get; set; }

    public string Color { get; set; }

    public string ColorHandler { get; set; }

    public string Font { get; set; }

    public string FontHandler { get; set; }

    public string Format { get; set; }

    public string FormatHandler { get; set; }

    [HtmlAttributeNotBound]
    public ChartSeriesLabelsFromMarginSettingsTagHelper Margin { get; set; }

    [HtmlAttributeNotBound]
    public ChartSeriesLabelsFromPaddingSettingsTagHelper Padding { get; set; }

    public string Template { get; set; }

    public string TemplateId { get; set; }

    public bool? Visible { get; set; }

    public string VisibleHandler { get; set; }

    public ChartSeriesLabelsPosition? Position { get; set; }

    public string PositionHandler { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = new Dictionary<string, object>();
      string backgroundHandler = this.BackgroundHandler;
      if ((backgroundHandler != null ? (backgroundHandler.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary1["background"] = (object) this.CreateHandler(this.BackgroundHandler);
      }
      else
      {
        string background = this.Background;
        if ((background != null ? (background.HasValue() ? 1 : 0) : 0) != 0)
          dictionary1["background"] = (object) this.Background;
      }
      if (this.Border != null)
      {
        Dictionary<string, object> source = this.Border.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["border"] = (object) source;
      }
      string colorHandler = this.ColorHandler;
      if ((colorHandler != null ? (colorHandler.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary1["color"] = (object) this.CreateHandler(this.ColorHandler);
      }
      else
      {
        string color = this.Color;
        if ((color != null ? (color.HasValue() ? 1 : 0) : 0) != 0)
          dictionary1["color"] = (object) this.Color;
      }
      string fontHandler = this.FontHandler;
      if ((fontHandler != null ? (fontHandler.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary1["font"] = (object) this.CreateHandler(this.FontHandler);
      }
      else
      {
        string font = this.Font;
        if ((font != null ? (font.HasValue() ? 1 : 0) : 0) != 0)
          dictionary1["font"] = (object) this.Font;
      }
      string formatHandler = this.FormatHandler;
      if ((formatHandler != null ? (formatHandler.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary1["format"] = (object) this.CreateHandler(this.FormatHandler);
      }
      else
      {
        string format = this.Format;
        if ((format != null ? (format.HasValue() ? 1 : 0) : 0) != 0)
          dictionary1["format"] = (object) this.Format;
      }
      if (this.Margin != null)
      {
        Dictionary<string, object> source = this.Margin.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["margin"] = (object) source;
      }
      if (this.Padding != null)
      {
        Dictionary<string, object> source = this.Padding.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["padding"] = (object) source;
      }
      if (this.TemplateId.HasValue())
        dictionary1["template"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.TemplateId)
        };
      else if (this.Template.HasValue())
        dictionary1["template"] = (object) this.Template;
      string visibleHandler = this.VisibleHandler;
      if ((visibleHandler != null ? (visibleHandler.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["visible"] = (object) this.CreateHandler(this.VisibleHandler);
      else if (this.Visible.HasValue)
        dictionary1["visible"] = (object) this.Visible;
      string positionHandler = this.PositionHandler;
      if ((positionHandler != null ? (positionHandler.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary1["position"] = (object) this.CreateHandler(this.PositionHandler);
      }
      else
      {
        ChartSeriesLabelsPosition? position = this.Position;
        if (position.HasValue)
        {
          Dictionary<string, object> dictionary2 = dictionary1;
          position = this.Position;
          ref ChartSeriesLabelsPosition? local = ref position;
          string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
          dictionary2["position"] = (object) str;
        }
      }
      return dictionary1;
    }
  }
}
