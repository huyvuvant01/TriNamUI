// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.DialogTitleSettingsTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;

namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("dialog-title", ParentTag = "kendo-dialog", TagStructure = TagStructure.WithoutEndTag)]
  [SuppressTagRendering]
  public class DialogTitleSettingsTagHelper : TagHelperChildBase
  {
    public bool? Enabled { get; set; }

    public string Text { get; set; }

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (DialogTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as DialogTagHelper).TitleSettings = this;
    }

    public Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string text = this.Text;
      if ((text != null ? (text.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["text"] = (object) this.Text;
      return dictionary;
    }
  }
}
