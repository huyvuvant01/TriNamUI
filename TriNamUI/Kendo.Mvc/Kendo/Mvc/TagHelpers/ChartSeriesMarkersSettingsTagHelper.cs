// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.ChartSeriesMarkersSettingsTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("markers", ParentTag = "series-item", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("border", new string[] {"from", "to"})]
  [SuppressTagRendering]
  public class ChartSeriesMarkersSettingsTagHelper : TagHelperChildBase
  {
    public 
    #nullable disable
    string Visual { get; set; }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      System.Type type = typeof (ChartSeriesTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as ChartSeriesTagHelper).Markers = this;
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

    public string BackgroundHandler { get; set; }

    [HtmlAttributeNotBound]
    public ChartSeriesMarkersBorderSettingsTagHelper Border { get; set; }

    public double? BorderRadius { get; set; }

    [HtmlAttributeNotBound]
    public ChartSeriesMarkersFromSettingsTagHelper From { get; set; }

    public double? Size { get; set; }

    public string SizeHandler { get; set; }

    [HtmlAttributeNotBound]
    public ChartSeriesMarkersToSettingsTagHelper To { get; set; }

    public bool? Visible { get; set; }

    public string VisibleHandler { get; set; }

    public double? Rotation { get; set; }

    public string RotationHandler { get; set; }

    public double? ZIndex { get; set; }

    public string ZIndexHandler { get; set; }

    public ChartMarkerShape? Type { get; set; }

    public string TypeHandler { get; set; }

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
      double? nullable = this.BorderRadius;
      if (nullable.HasValue)
        dictionary1["borderRadius"] = (object) this.BorderRadius;
      if (this.From != null)
      {
        Dictionary<string, object> source = this.From.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["from"] = (object) source;
      }
      string sizeHandler = this.SizeHandler;
      if ((sizeHandler != null ? (sizeHandler.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary1["size"] = (object) this.CreateHandler(this.SizeHandler);
      }
      else
      {
        nullable = this.Size;
        if (nullable.HasValue)
          dictionary1["size"] = (object) this.Size;
      }
      if (this.To != null)
      {
        Dictionary<string, object> source = this.To.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["to"] = (object) source;
      }
      string visibleHandler = this.VisibleHandler;
      if ((visibleHandler != null ? (visibleHandler.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["visible"] = (object) this.CreateHandler(this.VisibleHandler);
      else if (this.Visible.HasValue)
        dictionary1["visible"] = (object) this.Visible;
      string rotationHandler = this.RotationHandler;
      if ((rotationHandler != null ? (rotationHandler.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary1["rotation"] = (object) this.CreateHandler(this.RotationHandler);
      }
      else
      {
        nullable = this.Rotation;
        if (nullable.HasValue)
          dictionary1["rotation"] = (object) this.Rotation;
      }
      string zindexHandler = this.ZIndexHandler;
      if ((zindexHandler != null ? (zindexHandler.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary1["zIndex"] = (object) this.CreateHandler(this.ZIndexHandler);
      }
      else
      {
        nullable = this.ZIndex;
        if (nullable.HasValue)
          dictionary1["zIndex"] = (object) this.ZIndex;
      }
      string typeHandler = this.TypeHandler;
      if ((typeHandler != null ? (typeHandler.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary1["type"] = (object) this.CreateHandler(this.TypeHandler);
      }
      else
      {
        ChartMarkerShape? type = this.Type;
        if (type.HasValue)
        {
          Dictionary<string, object> dictionary2 = dictionary1;
          type = this.Type;
          ref ChartMarkerShape? local = ref type;
          string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
          dictionary2["type"] = (object) str;
        }
      }
      return dictionary1;
    }
  }
}
