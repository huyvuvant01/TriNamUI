﻿// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.FileManagerMessagesDialogsDeleteConfirmSettingsTagHelper
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
  [HtmlTargetElement("delete-confirm", ParentTag = "dialogs", TagStructure = TagStructure.WithoutEndTag)]
  [SuppressTagRendering]
  public class FileManagerMessagesDialogsDeleteConfirmSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (FileManagerMessagesDialogsSettingsTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as FileManagerMessagesDialogsSettingsTagHelper).DeleteConfirm = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Title { get; set; }

    public string Content { get; set; }

    public string OkText { get; set; }

    public string Cancel { get; set; }

    public string Close { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string title = this.Title;
      if ((title != null ? (title.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["title"] = (object) this.Title;
      string content = this.Content;
      if ((content != null ? (content.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["content"] = (object) this.Content;
      string okText = this.OkText;
      if ((okText != null ? (okText.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["okText"] = (object) this.OkText;
      string cancel = this.Cancel;
      if ((cancel != null ? (cancel.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["cancel"] = (object) this.Cancel;
      string close = this.Close;
      if ((close != null ? (close.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["close"] = (object) this.Close;
      return dictionary;
    }
  }
}
