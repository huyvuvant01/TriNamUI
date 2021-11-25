// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.ImageEditorMessagesPanesSettingsTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("panes", ParentTag = "imageeditor-messages", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("crop", new string[] {"resize"})]
  [SuppressTagRendering]
  public class ImageEditorMessagesPanesSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (ImageEditorMessagesSettingsTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as ImageEditorMessagesSettingsTagHelper).Panes = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    [HtmlAttributeNotBound]
    public ImageEditorMessagesPanesCropSettingsTagHelper Crop { get; set; }

    [HtmlAttributeNotBound]
    public ImageEditorMessagesPanesResizeSettingsTagHelper Resize { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.Crop != null)
      {
        Dictionary<string, object> source = this.Crop.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["crop"] = (object) source;
      }
      if (this.Resize != null)
      {
        Dictionary<string, object> source = this.Resize.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["resize"] = (object) source;
      }
      return dictionary;
    }
  }
}
