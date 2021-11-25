// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.TabStripItemTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("tabstrip-item", ParentTag = "items", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("content", new string[] {})]
  [OutputElementHint("li")]
  public class TabStripItemTagHelper : AnchorTagHelper, INavigationItem
  {
    public TabStripItemTagHelper(
    #nullable disable
    IHtmlGenerator generator)
      : base(generator)
    {
    }

    public string Text { get; set; }

    public object LinkHtmlAttributes { get; set; }

    public object ImageHtmlAttributes { get; set; }

    [HtmlAttributeNotBound]
    public string Url { get; set; }

    public string ImageUrl { get; set; }

    public string IconClass { get; set; }

    public string Icon { get; set; }

    public bool? Enabled { get; set; }

    public bool? Selected { get; set; }

    public bool? Encoded { get; set; }

    public bool? Visible { get; set; }

    [HtmlAttributeNotBound]
    public bool? Separator { get; set; }

    [HtmlAttributeNotBound]
    public IEnumerable<TabStripItemBase> Children { get; set; }

    [HtmlAttributeNotBound]
    public string Content { get; set; }

    [HtmlAttributeNotBound]
    public object ContentHtmlAttributes { get; set; }

    public string ContentUrl { get; set; }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      await base.ProcessAsync(context, output);
      string content = (await output.GetChildContentAsync()).GetContent();
      output.TagName = "li";
      output.TagMode = TagMode.StartTagAndEndTag;
      if (this.Separator.HasValue && this.Separator.Value)
      {
        object obj = output.Attributes.FirstOrDefault<TagHelperAttribute>((Func<TagHelperAttribute, bool>) (a => a.Name == "class"))?.Value;
        TagHelperAttributeList attributes = output.Attributes;
        DefaultInterpolatedStringHandler interpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 1);
        interpolatedStringHandler.AppendLiteral("k-separator ");
        interpolatedStringHandler.AppendFormatted<object>(obj);
        string stringAndClear = interpolatedStringHandler.ToStringAndClear();
        attributes.SetAttribute("class", (object) stringAndClear);
      }
      else if (!this.Visible.HasValue || this.Visible.Value)
      {
        this.GenerateItem(context, output);
        this.CacheContent(context, content);
      }
      if (!this.Visible.HasValue || this.Visible.Value)
        return;
      output.SuppressOutput();
    }

    private void CacheContent(TagHelperContext context, string content)
    {
      TabStripItemsTagHelper stripItemsTagHelper = context.Items[(object) typeof (TabStripItemsTagHelper)] as TabStripItemsTagHelper;
      TabStripTagHelper tabStripTagHelper = context.Items[(object) typeof (TabStripTagHelper)] as TabStripTagHelper;
      string str = !this.Content.HasValue() ? content : "<div>" + this.Content + "</div>";
      bool flag = !string.IsNullOrEmpty(str.Trim());
      stripItemsTagHelper.ContentOutputs.Add(flag ? str : "<div></div>");
      tabStripTagHelper.ContentUrls.Add(this.ContentUrl ?? "");
    }

    private void GenerateItem(TagHelperContext context, TagHelperOutput output)
    {
      DefaultInterpolatedStringHandler interpolatedStringHandler;
      if (this.Enabled.HasValue && !this.Enabled.Value)
      {
        object obj = output.Attributes.FirstOrDefault<TagHelperAttribute>((Func<TagHelperAttribute, bool>) (a => a.Name == "class"))?.Value;
        TagHelperAttributeList attributes = output.Attributes;
        interpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 1);
        interpolatedStringHandler.AppendLiteral("k-state-disabled ");
        interpolatedStringHandler.AppendFormatted<object>(obj);
        string stringAndClear = interpolatedStringHandler.ToStringAndClear();
        attributes.SetAttribute("class", (object) stringAndClear);
      }
      if (this.Selected.HasValue && this.Selected.Value)
      {
        object obj = output.Attributes.FirstOrDefault<TagHelperAttribute>((Func<TagHelperAttribute, bool>) (a => a.Name == "class"))?.Value;
        TagHelperAttributeList attributes = output.Attributes;
        interpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 1);
        interpolatedStringHandler.AppendLiteral("k-state-active ");
        interpolatedStringHandler.AppendFormatted<object>(obj);
        string stringAndClear = interpolatedStringHandler.ToStringAndClear();
        attributes.SetAttribute("class", (object) stringAndClear);
      }
      TagBuilder tagBuilder = this.GeneretaLink(output);
      if (this.ImageUrl.HasValue())
      {
        TagBuilder image = this.GenerateImage();
        tagBuilder.InnerHtml.AppendHtml((IHtmlContent) image);
      }
      if (this.IconClass.HasValue() || this.Icon.HasValue())
      {
        TagBuilder icon = this.GenerateIcon();
        tagBuilder.InnerHtml.AppendHtml((IHtmlContent) icon);
      }
      if (this.Encoded.HasValue && this.Encoded.Value)
        tagBuilder.InnerHtml.Append(this.Text);
      else
        tagBuilder.InnerHtml.AppendHtml(this.Text);
      output.Content.AppendHtml((IHtmlContent) tagBuilder);
    }

    private TagBuilder GenerateImage()
    {
      TagBuilder tagBuilder = new TagBuilder("img");
      tagBuilder.Attributes.Add("src", this.ImageUrl);
      tagBuilder.AddCssClass("k-image");
      tagBuilder.MergeAttributes<string, object>(this.ImageHtmlAttributes.ToDictionary());
      return tagBuilder;
    }

    private TagBuilder GenerateIcon()
    {
      TagBuilder tagBuilder = new TagBuilder("span");
      tagBuilder.AddCssClass(this.IconClass ?? "k-icon k-i-" + this.Icon);
      return tagBuilder;
    }

    private TagBuilder GeneretaLink(TagHelperOutput output)
    {
      TagHelperAttribute attribute = output.Attributes.FirstOrDefault<TagHelperAttribute>((Func<TagHelperAttribute, bool>) (a => a.Name == "href"));
      string str = this.ContentUrl != null ? this.ContentUrl : attribute?.Value.ToString();
      output.Attributes.Remove(attribute);
      if (this.Action == null && this.ContentUrl == null)
        str = (string) null;
      TagBuilder tagBuilder = new TagBuilder(str.HasValue() ? "a" : "span");
      tagBuilder.MergeAttributes<string, object>(this.LinkHtmlAttributes.ToDictionary());
      tagBuilder.AddCssClass("k-link");
      if (!str.HasValue())
        return tagBuilder;
      this.ContentUrl = str;
      return tagBuilder;
    }

    string INavigationItem.get_Action() => this.Action;

    void INavigationItem.set_Action(string value) => this.Action = value;

    string INavigationItem.get_Controller() => this.Controller;

    void INavigationItem.set_Controller(string value) => this.Controller = value;

    string INavigationItem.get_Area() => this.Area;

    void INavigationItem.set_Area(string value) => this.Area = value;

    string INavigationItem.get_Protocol() => this.Protocol;

    void INavigationItem.set_Protocol(string value) => this.Protocol = value;

    string INavigationItem.get_Host() => this.Host;

    void INavigationItem.set_Host(string value) => this.Host = value;

    string INavigationItem.get_Fragment() => this.Fragment;

    void INavigationItem.set_Fragment(string value) => this.Fragment = value;

    string INavigationItem.get_Route() => this.Route;

    void INavigationItem.set_Route(string value) => this.Route = value;

    IDictionary<string, string> INavigationItem.get_RouteValues() => this.RouteValues;

    void INavigationItem.set_RouteValues(IDictionary<string, string> value) => this.RouteValues = value;
  }
}
