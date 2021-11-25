// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.FileManagerDialogsRenamePromptSettingsTagHelper
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
  [HtmlTargetElement("rename-prompt", ParentTag = "dialogs", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("actions", new string[] {})]
  [SuppressTagRendering]
  public class FileManagerDialogsRenamePromptSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (FileManagerDialogsSettingsTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as FileManagerDialogsSettingsTagHelper).RenamePrompt = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public double? Width { get; set; }

    public string Title { get; set; }

    public bool? Closable { get; set; }

    public string Content { get; set; }

    [HtmlAttributeNotBound]
    public FileManagerDialogsRenamePromptSettingsActionsTagHelper Actions { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.Width.HasValue)
        dictionary["width"] = (object) this.Width;
      string title = this.Title;
      if ((title != null ? (title.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["title"] = (object) this.Title;
      if (this.Closable.HasValue)
        dictionary["closable"] = (object) this.Closable;
      string content = this.Content;
      if ((content != null ? (content.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["content"] = (object) this.Content;
      if (this.Actions != null)
      {
        IEnumerable<Dictionary<string, object>> source = this.Actions.Select<FileManagerDialogsRenamePromptSettingsActionTagHelper, Dictionary<string, object>>((Func<FileManagerDialogsRenamePromptSettingsActionTagHelper, Dictionary<string, object>>) (i => i.Serialize()));
        if (source.Any<Dictionary<string, object>>())
          dictionary["actions"] = (object) source;
      }
      return dictionary;
    }
  }
}
