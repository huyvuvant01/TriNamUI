// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.MenuItemTagHelper
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
using System.Text.Encodings.Web;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("menu-item", ParentTag = "items", TagStructure = TagStructure.NormalOrSelfClosing)]
  [HtmlTargetElement("menu-item", ParentTag = "sub-items", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("sub-items", new string[] {"content"})]
  [OutputElementHint("li")]
  public class MenuItemTagHelper : AnchorTagHelper, INavigationItem
  {
    public MenuItemTagHelper(
    #nullable disable
    IHtmlGenerator generator)
      : base(generator)
    {
    }

    public string Text { get; set; }

    public object LinkHtmlAttributes { get; set; }

    public object ImageHtmlAttributes { get; set; }

    public string Url { get; set; }

    public string ImageUrl { get; set; }

    public string IconClass { get; set; }

    public string Icon { get; set; }

    public bool? Enabled { get; set; }

    public bool? Selected { get; set; }

    public bool? Encoded { get; set; }

    public bool? Visible { get; set; }

    public bool? Separator { get; set; }

    [HtmlAttributeNotBound]
    public IEnumerable<MenuItemBase> Children { get; set; }

    [HtmlAttributeNotBound]
    public string Content { get; set; }

    [HtmlAttributeNotBound]
    public object ContentHtmlAttributes { get; set; }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      // ISSUE: reference to a compiler-generated method
      this.\u003C\u003En__0(context, output);
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
        output.Attributes.Remove(output.Attributes.Where<TagHelperAttribute>((Func<TagHelperAttribute, bool>) (attr => attr.Name == "href")).FirstOrDefault<TagHelperAttribute>());
      }
      else
        await this.GenerateItem(context, output, content);
      if (!this.Visible.HasValue || this.Visible.Value)
        return;
      output.SuppressOutput();
    }

    private async Task GenerateItem(
      TagHelperContext context,
      TagHelperOutput output,
      string content)
    {
      if (this.Enabled.HasValue && !this.Enabled.Value)
      {
        object obj = output.Attributes.FirstOrDefault<TagHelperAttribute>((Func<TagHelperAttribute, bool>) (a => a.Name == "class"))?.Value;
        TagHelperAttributeList attributes = output.Attributes;
        DefaultInterpolatedStringHandler interpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 1);
        interpolatedStringHandler.AppendLiteral("k-state-disabled ");
        interpolatedStringHandler.AppendFormatted<object>(obj);
        string stringAndClear = interpolatedStringHandler.ToStringAndClear();
        attributes.SetAttribute("class", (object) stringAndClear);
      }
      if (this.Selected.HasValue && this.Selected.Value)
      {
        object obj = output.Attributes.FirstOrDefault<TagHelperAttribute>((Func<TagHelperAttribute, bool>) (a => a.Name == "class"))?.Value;
        TagHelperAttributeList attributes = output.Attributes;
        DefaultInterpolatedStringHandler interpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 1);
        interpolatedStringHandler.AppendLiteral("k-state-selected ");
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
      output.Content.AppendHtml(content);
      if (this.Children != null)
        output.Content.AppendHtml((IHtmlContent) await this.GenerateChildren(context));
      if (this.Content == null)
        return;
      output.Content.AppendHtml((IHtmlContent) await this.GenerateContentOutput(context));
    }

    private async Task<TagBuilder> GenerateChildren(TagHelperContext context)
    {
      MenuItemTagHelper menuItemTagHelper = this;
      MenuItemTagHelperFactory factory = new MenuItemTagHelperFactory(context, menuItemTagHelper.ViewContext);
      TagBuilder ulBuilder = new TagBuilder("ul");
      foreach (MenuItemBase child in menuItemTagHelper.Children)
      {
        await factory.GenerateItemAsync(child);
        ulBuilder.InnerHtml.AppendHtml((IHtmlContent) factory.Output);
      }
      TagBuilder tagBuilder = ulBuilder;
      factory = (MenuItemTagHelperFactory) null;
      ulBuilder = (TagBuilder) null;
      return tagBuilder;
    }

    private async Task<TagHelperOutput> GenerateContentOutput(
      TagHelperContext context)
    {
      MenuItemContentTagHelper contentTagHelper = new MenuItemContentTagHelper();
      TagHelperAttributeList contentAttributes = new TagHelperAttributeList();
      if (this.ContentHtmlAttributes != null)
        this.ContentHtmlAttributes.ToDictionary().ToList<KeyValuePair<string, object>>().ForEach((Action<KeyValuePair<string, object>>) (attr => contentAttributes.Add(attr.Key, attr.Value)));
      TagHelperOutput outputContent = new TagHelperOutput("", contentAttributes, (Func<bool, HtmlEncoder, Task<TagHelperContent>>) ((useCachedResult, encoder) => Task.Factory.StartNew<TagHelperContent>((Func<TagHelperContent>) (() =>
      {
        DefaultTagHelperContent tagHelperContent = new DefaultTagHelperContent();
        // ISSUE: explicit non-virtual call
        // ISSUE: explicit non-virtual call
        if (__nonvirtual (this.Encoded).HasValue && __nonvirtual (this.Encoded).Value)
        {
          // ISSUE: explicit non-virtual call
          tagHelperContent.SetContent(__nonvirtual (this.Content));
        }
        else
        {
          // ISSUE: explicit non-virtual call
          tagHelperContent.SetHtmlContent(__nonvirtual (this.Content));
        }
        return (TagHelperContent) tagHelperContent;
      }))));
      TagHelperContext context1 = context;
      TagHelperOutput output = outputContent;
      await contentTagHelper.ProcessAsync(context1, output);
      TagHelperOutput tagHelperOutput = outputContent;
      outputContent = (TagHelperOutput) null;
      return tagHelperOutput;
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
      string str = (string) null;
      bool flag = ((this.Route != null ? 1 : 0) | (this.Controller != null ? (true ? 1 : 0) : (this.Action != null ? 1 : 0))) != 0 || this.Page != null || this.PageHandler != null;
      if (!string.IsNullOrEmpty(this.Url))
        str = this.Url;
      else if (((attribute == null ? 0 : (attribute.Value != null ? 1 : 0)) & (flag ? 1 : 0)) != 0)
        str = attribute.Value.ToString();
      output.Attributes.Remove(attribute);
      TagBuilder tagBuilder = new TagBuilder(str.HasValue() ? "a" : "span");
      tagBuilder.MergeAttributes<string, object>(this.LinkHtmlAttributes.ToDictionary());
      tagBuilder.AddCssClass("k-link k-menu-link");
      if (str.HasValue())
        tagBuilder.Attributes.Add("href", str);
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
