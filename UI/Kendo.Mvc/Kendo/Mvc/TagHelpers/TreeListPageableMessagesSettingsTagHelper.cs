// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.TreeListPageableMessagesSettingsTagHelper
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
  [HtmlTargetElement("messages", ParentTag = "pageable", TagStructure = TagStructure.WithoutEndTag)]
  [SuppressTagRendering]
  public class TreeListPageableMessagesSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (TreeListPageableSettingsTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as TreeListPageableSettingsTagHelper).Messages = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Display { get; set; }

    public string Empty { get; set; }

    public string Page { get; set; }

    public string Of { get; set; }

    public string ItemsPerPage { get; set; }

    public string First { get; set; }

    public string Last { get; set; }

    public string Next { get; set; }

    public string Previous { get; set; }

    public string Refresh { get; set; }

    public string MorePages { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string display = this.Display;
      if ((display != null ? (display.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["display"] = (object) this.Display;
      string empty = this.Empty;
      if ((empty != null ? (empty.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["empty"] = (object) this.Empty;
      string page = this.Page;
      if ((page != null ? (page.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["page"] = (object) this.Page;
      string of = this.Of;
      if ((of != null ? (of.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["of"] = (object) this.Of;
      string itemsPerPage = this.ItemsPerPage;
      if ((itemsPerPage != null ? (itemsPerPage.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["itemsPerPage"] = (object) this.ItemsPerPage;
      string first = this.First;
      if ((first != null ? (first.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["first"] = (object) this.First;
      string last = this.Last;
      if ((last != null ? (last.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["last"] = (object) this.Last;
      string next = this.Next;
      if ((next != null ? (next.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["next"] = (object) this.Next;
      string previous = this.Previous;
      if ((previous != null ? (previous.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["previous"] = (object) this.Previous;
      string refresh = this.Refresh;
      if ((refresh != null ? (refresh.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["refresh"] = (object) this.Refresh;
      string morePages = this.MorePages;
      if ((morePages != null ? (morePages.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["morePages"] = (object) this.MorePages;
      return dictionary;
    }
  }
}
