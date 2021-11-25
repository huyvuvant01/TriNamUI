// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.PanelBarItemTagHelper
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
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("panelbar-item", ParentTag = "items", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("items", new string[] {"content"})]
  [SuppressTagRendering]
  [OutputElementHint("li")]
  public class PanelBarItemTagHelper : TagHelperCollectionItemBase
  {
    public 
    #nullable disable
    string Text { get; set; }

    public object LinkHtmlAttributes { get; set; }

    public object ImageHtmlAttributes { get; set; }

    public string Url { get; set; }

    private string Href { get; set; }

    public string ImageUrl { get; set; }

    public string IconClass { get; set; }

    public string Icon { get; set; }

    public bool? Enabled { get; set; }

    public bool? Selected { get; set; }

    public bool? Expanded { get; set; }

    public bool? Encoded { get; set; }

    public bool? Visible { get; set; }

    [HtmlAttributeNotBound]
    public object ContentHtmlAttributes { get; set; }

    public string ContentUrl { get; set; }

    [HtmlAttributeNotBound]
    public string Content { get; set; }

    private PanelBarItemTagHelper PreviousInstance { get; set; }

    [HtmlAttributeNotBound]
    public PanelBarNestedItemsTagHelper DeclaredItems { get; set; }

    [HtmlAttributeNotBound]
    public IEnumerable<PanelBarItemBase> Items { get; set; }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      PanelBarItemTagHelper barItemTagHelper = this;
      Type type = barItemTagHelper.GetType();
      if (context.Items.ContainsKey((object) type))
        barItemTagHelper.PreviousInstance = context.Items[(object) type] as PanelBarItemTagHelper;
      context.Items[(object) type] = (object) barItemTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      barItemTagHelper.AddSelfToParent(context);
      context.Items[(object) type] = (object) barItemTagHelper.PreviousInstance;
      output.TagName = "li";
      output.TagMode = TagMode.StartTagAndEndTag;
      barItemTagHelper.Href = output.Attributes.FirstOrDefault<TagHelperAttribute>((Func<TagHelperAttribute, bool>) (a => a.Name == "href"))?.Value.ToString();
      TagBuilder tagBuilder = barItemTagHelper.EnhanceItem();
      output.MergeAttributes(tagBuilder);
      output.Content.AppendHtml((IHtmlContent) tagBuilder.InnerHtml);
      output.Content.AppendHtml((IHtmlContent) childContentAsync);
      if (!barItemTagHelper.Visible.HasValue)
        type = (Type) null;
      else if (barItemTagHelper.Visible.Value)
      {
        type = (Type) null;
      }
      else
      {
        output.SuppressOutput();
        type = (Type) null;
      }
    }

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type1 = typeof (PanelBarNestedItemsTagHelper);
      if (context.Items.ContainsKey((object) type1))
      {
        (context.Items[(object) type1] as PanelBarNestedItemsTagHelper).Add(this);
      }
      else
      {
        Type type2 = typeof (PanelBarItemsTagHelper);
        (context.Items[(object) type2] as PanelBarItemsTagHelper).Add(this);
      }
    }

    public TagBuilder EnhanceItem()
    {
      TagBuilder tagBuilder1 = new TagBuilder("li");
      bool flag1 = (this.Url ?? this.ContentUrl).HasValue();
      if (this.Expanded.HasValue)
      {
        bool? expanded = this.Expanded;
        bool flag2 = true;
        if (expanded.GetValueOrDefault() == flag2 & expanded.HasValue)
          tagBuilder1.Attributes.Add("class", "k-state-active");
      }
      TagBuilder link = this.GenerateLink();
      if (this.ImageUrl.HasValue())
      {
        TagBuilder image = this.GenerateImage();
        link.InnerHtml.AppendHtml((IHtmlContent) image);
      }
      if (this.IconClass.HasValue() || this.Icon.HasValue())
      {
        TagBuilder icon = this.GenerateIcon();
        link.InnerHtml.AppendHtml((IHtmlContent) icon);
      }
      bool? nullable = this.Encoded;
      if (nullable.HasValue)
      {
        nullable = this.Encoded;
        if (nullable.Value)
        {
          link.InnerHtml.Append(this.Text);
          goto label_11;
        }
      }
      link.InnerHtml.AppendHtml(this.Text);
label_11:
      nullable = this.Selected;
      if (nullable.HasValue)
      {
        nullable = this.Selected;
        if (nullable.Value)
        {
          link.Attributes["class"] += " k-state-selected";
          goto label_15;
        }
      }
      tagBuilder1.MergeAttribute("class", "k-state-default");
label_15:
      tagBuilder1.InnerHtml.AppendHtml((IHtmlContent) link);
      if (this.Content != null | flag1)
      {
        TagBuilder tagBuilder2 = new TagBuilder("div");
        tagBuilder2.MergeAttributes<string, object>(HtmlHelper.AnonymousObjectToHtmlAttributes(this.ContentHtmlAttributes));
        tagBuilder2.MergeAttribute("class", "k-content");
        tagBuilder2.InnerHtml.AppendHtml(this.Content);
        tagBuilder1.InnerHtml.AppendHtml((IHtmlContent) tagBuilder2);
      }
      if (this.Items != null)
      {
        TagBuilder tagBuilder3 = new TagBuilder("ul");
        foreach (PanelBarItemBase panelBarItemBase in this.Items)
        {
          PanelBarItemTagHelper tagHelper = panelBarItemBase.ConvertToTagHelper();
          tagBuilder3.InnerHtml.AppendHtml((IHtmlContent) tagHelper.EnhanceItem());
        }
        tagBuilder1.InnerHtml.AppendHtml((IHtmlContent) tagBuilder3);
      }
      return tagBuilder1;
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

    private TagBuilder GenerateLink()
    {
      string str = this.Url ?? this.Href ?? this.ContentUrl;
      TagBuilder tagBuilder = new TagBuilder(str.HasValue() ? "a" : "span");
      tagBuilder.MergeAttributes<string, object>(this.LinkHtmlAttributes.ToDictionary());
      tagBuilder.AddCssClass("k-link");
      if (str.HasValue())
        tagBuilder.Attributes.Add("href", str);
      return tagBuilder;
    }
  }
}
