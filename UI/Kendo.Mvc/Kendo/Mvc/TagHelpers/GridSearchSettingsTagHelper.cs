﻿// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.GridSearchSettingsTagHelper
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
  [HtmlTargetElement("search", ParentTag = "kendo-grid", TagStructure = TagStructure.WithoutEndTag)]
  [SuppressTagRendering]
  public class GridSearchSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (GridTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as GridTagHelper).Search = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string[] Fields { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string[] fields = this.Fields;
      if ((fields != null ? (((IEnumerable<string>) fields).Any<string>() ? 1 : 0) : 0) != 0)
        dictionary["fields"] = (object) this.Fields;
      return dictionary;
    }
  }
}