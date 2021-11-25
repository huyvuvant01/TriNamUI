// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.ImageEditorMessagesToolbarSettingsTagHelper
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
  [HtmlTargetElement("toolbar", ParentTag = "imageeditor-messages", TagStructure = TagStructure.WithoutEndTag)]
  [SuppressTagRendering]
  public class ImageEditorMessagesToolbarSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (ImageEditorMessagesSettingsTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as ImageEditorMessagesSettingsTagHelper).Toolbar = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Open { get; set; }

    public string Save { get; set; }

    public string Undo { get; set; }

    public string Redo { get; set; }

    public string Crop { get; set; }

    public string Resize { get; set; }

    public string ZoomIn { get; set; }

    public string ZoomOut { get; set; }

    public string ZoomDropdown { get; set; }

    public string ZoomActualSize { get; set; }

    public string ZoomFitToScreen { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string open = this.Open;
      if ((open != null ? (open.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["open"] = (object) this.Open;
      string save = this.Save;
      if ((save != null ? (save.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["save"] = (object) this.Save;
      string undo = this.Undo;
      if ((undo != null ? (undo.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["undo"] = (object) this.Undo;
      string redo = this.Redo;
      if ((redo != null ? (redo.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["redo"] = (object) this.Redo;
      string crop = this.Crop;
      if ((crop != null ? (crop.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["crop"] = (object) this.Crop;
      string resize = this.Resize;
      if ((resize != null ? (resize.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["resize"] = (object) this.Resize;
      string zoomIn = this.ZoomIn;
      if ((zoomIn != null ? (zoomIn.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["zoomIn"] = (object) this.ZoomIn;
      string zoomOut = this.ZoomOut;
      if ((zoomOut != null ? (zoomOut.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["zoomOut"] = (object) this.ZoomOut;
      string zoomDropdown = this.ZoomDropdown;
      if ((zoomDropdown != null ? (zoomDropdown.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["zoomDropdown"] = (object) this.ZoomDropdown;
      string zoomActualSize = this.ZoomActualSize;
      if ((zoomActualSize != null ? (zoomActualSize.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["zoomActualSize"] = (object) this.ZoomActualSize;
      string zoomFitToScreen = this.ZoomFitToScreen;
      if ((zoomFitToScreen != null ? (zoomFitToScreen.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["zoomFitToScreen"] = (object) this.ZoomFitToScreen;
      return dictionary;
    }
  }
}
