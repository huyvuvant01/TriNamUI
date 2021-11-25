// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.ImageEditorMessagesCommonSettingsTagHelper
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
  [HtmlTargetElement("common", ParentTag = "imageeditor-messages", TagStructure = TagStructure.WithoutEndTag)]
  [SuppressTagRendering]
  public class ImageEditorMessagesCommonSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (ImageEditorMessagesSettingsTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as ImageEditorMessagesSettingsTagHelper).Common = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Width { get; set; }

    public string Height { get; set; }

    public string Cancel { get; set; }

    public string Confirm { get; set; }

    public string LockAspectRatio { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string width = this.Width;
      if ((width != null ? (width.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["width"] = (object) this.Width;
      string height = this.Height;
      if ((height != null ? (height.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["height"] = (object) this.Height;
      string cancel = this.Cancel;
      if ((cancel != null ? (cancel.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["cancel"] = (object) this.Cancel;
      string confirm = this.Confirm;
      if ((confirm != null ? (confirm.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["confirm"] = (object) this.Confirm;
      string lockAspectRatio = this.LockAspectRatio;
      if ((lockAspectRatio != null ? (lockAspectRatio.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["lockAspectRatio"] = (object) this.LockAspectRatio;
      return dictionary;
    }
  }
}
