// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.FileManagerBreadcrumbSettingsTagHelper
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
  [HtmlTargetElement("breadcrumb", ParentTag = "kendo-filemanager", TagStructure = TagStructure.WithoutEndTag)]
  [SuppressTagRendering]
  public class FileManagerBreadcrumbSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (FileManagerTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as FileManagerTagHelper).Breadcrumb = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public bool? Enabled { get; set; }

    public string RootIcon { get; set; }

    public string DelimiterIcon { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string rootIcon = this.RootIcon;
      if ((rootIcon != null ? (rootIcon.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["rootIcon"] = (object) this.RootIcon;
      string delimiterIcon = this.DelimiterIcon;
      if ((delimiterIcon != null ? (delimiterIcon.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["delimiterIcon"] = (object) this.DelimiterIcon;
      return dictionary;
    }
  }
}
