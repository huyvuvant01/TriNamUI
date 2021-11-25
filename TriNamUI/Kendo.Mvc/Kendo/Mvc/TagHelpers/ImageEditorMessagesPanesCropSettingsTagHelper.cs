// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.ImageEditorMessagesPanesCropSettingsTagHelper
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
  [HtmlTargetElement("crop", ParentTag = "panes", TagStructure = TagStructure.WithoutEndTag)]
  [SuppressTagRendering]
  public class ImageEditorMessagesPanesCropSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (ImageEditorMessagesPanesSettingsTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as ImageEditorMessagesPanesSettingsTagHelper).Crop = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Title { get; set; }

    public string AspectRatio { get; set; }

    public string Orientation { get; set; }

    public string Portrait { get; set; }

    public string Landscape { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string title = this.Title;
      if ((title != null ? (title.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["title"] = (object) this.Title;
      string aspectRatio = this.AspectRatio;
      if ((aspectRatio != null ? (aspectRatio.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["aspectRatio"] = (object) this.AspectRatio;
      string orientation = this.Orientation;
      if ((orientation != null ? (orientation.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["orientation"] = (object) this.Orientation;
      string portrait = this.Portrait;
      if ((portrait != null ? (portrait.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["portrait"] = (object) this.Portrait;
      string landscape = this.Landscape;
      if ((landscape != null ? (landscape.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["landscape"] = (object) this.Landscape;
      return dictionary;
    }
  }
}
