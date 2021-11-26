// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.ChartSeriesExtremesSettingsTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("extremes", ParentTag = "series-item", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("border", new string[] {})]
  [SuppressTagRendering]
  public class ChartSeriesExtremesSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      System.Type type = typeof (ChartSeriesTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as ChartSeriesTagHelper).Extremes = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Background { get; set; }

    public string BackgroundHandler { get; set; }

    [HtmlAttributeNotBound]
    public ChartSeriesExtremesBorderSettingsTagHelper Border { get; set; }

    public double? Size { get; set; }

    public string SizeHandler { get; set; }

    public string Type { get; set; }

    public string TypeHandler { get; set; }

    public double? Rotation { get; set; }

    public string RotationHandler { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string backgroundHandler = this.BackgroundHandler;
      if ((backgroundHandler != null ? (backgroundHandler.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary["background"] = (object) this.CreateHandler(this.BackgroundHandler);
      }
      else
      {
        string background = this.Background;
        if ((background != null ? (background.HasValue() ? 1 : 0) : 0) != 0)
          dictionary["background"] = (object) this.Background;
      }
      if (this.Border != null)
      {
        Dictionary<string, object> source = this.Border.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["border"] = (object) source;
      }
      string sizeHandler = this.SizeHandler;
      double? nullable;
      if ((sizeHandler != null ? (sizeHandler.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary["size"] = (object) this.CreateHandler(this.SizeHandler);
      }
      else
      {
        nullable = this.Size;
        if (nullable.HasValue)
          dictionary["size"] = (object) this.Size;
      }
      string typeHandler = this.TypeHandler;
      if ((typeHandler != null ? (typeHandler.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary["type"] = (object) this.CreateHandler(this.TypeHandler);
      }
      else
      {
        string type = this.Type;
        if ((type != null ? (type.HasValue() ? 1 : 0) : 0) != 0)
          dictionary["type"] = (object) this.Type;
      }
      string rotationHandler = this.RotationHandler;
      if ((rotationHandler != null ? (rotationHandler.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary["rotation"] = (object) this.CreateHandler(this.RotationHandler);
      }
      else
      {
        nullable = this.Rotation;
        if (nullable.HasValue)
          dictionary["rotation"] = (object) this.Rotation;
      }
      return dictionary;
    }
  }
}
