﻿// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.PDFViewerMessagesToolbarPagerSettingsTagHelper
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
  [HtmlTargetElement("pager", ParentTag = "toolbar", TagStructure = TagStructure.WithoutEndTag)]
  [SuppressTagRendering]
  public class PDFViewerMessagesToolbarPagerSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (PDFViewerMessagesToolbarSettingsTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as PDFViewerMessagesToolbarSettingsTagHelper).Pager = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string First { get; set; }

    public string Previous { get; set; }

    public string Next { get; set; }

    public string Last { get; set; }

    public string Of { get; set; }

    public string Page { get; set; }

    public string Pages { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string first = this.First;
      if ((first != null ? (first.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["first"] = (object) this.First;
      string previous = this.Previous;
      if ((previous != null ? (previous.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["previous"] = (object) this.Previous;
      string next = this.Next;
      if ((next != null ? (next.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["next"] = (object) this.Next;
      string last = this.Last;
      if ((last != null ? (last.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["last"] = (object) this.Last;
      string of = this.Of;
      if ((of != null ? (of.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["of"] = (object) this.Of;
      string page = this.Page;
      if ((page != null ? (page.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["page"] = (object) this.Page;
      string pages = this.Pages;
      if ((pages != null ? (pages.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["pages"] = (object) this.Pages;
      return dictionary;
    }
  }
}
