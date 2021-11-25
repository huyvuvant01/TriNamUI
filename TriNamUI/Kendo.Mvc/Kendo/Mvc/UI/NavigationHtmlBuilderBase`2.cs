// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.NavigationHtmlBuilderBase`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace Kendo.Mvc.UI
{
  public abstract class NavigationHtmlBuilderBase<TComponent, TItem> : 
    INavigationHtmlBuilder<TComponent, TItem>
    where TComponent : WidgetBase, INavigationItemComponent<TItem>
    where TItem : NavigationItem<TItem>
  {
    public NavigationHtmlBuilderBase(TComponent component) => this.Component = component;

    public TComponent Component { get; private set; }

    public IHtmlNode ListTag() => new HtmlElement("ul").AddClass(new string[1]
    {
      "k-group"
    });

    public IHtmlNode ComponentTag(string tagName) => new HtmlElement(tagName).Attribute("id", this.Component.Id).Attributes<string, object>(this.Component.HtmlAttributes);

    public IHtmlNode ImageTag(TItem item) => new HtmlElement("img", TagRenderMode.SelfClosing).Attribute("alt", "image", false).Attributes<string, object>(item.ImageHtmlAttributes).PrependClass("k-image").Attribute("src", item.GetImageUrl<TItem>(this.Component.ViewContext));

    public IHtmlNode Text(TItem item)
    {
      string content = item.Text ?? string.Empty;
      return item.Encoded ? (IHtmlNode) new TextNode(content) : (IHtmlNode) new LiteralNode(content);
    }

    public IHtmlNode SpriteTag(TItem item) => new HtmlElement("span").AddClass(new string[2]
    {
      "k-sprite",
      item.SpriteCssClasses
    });

    public IHtmlNode ContentTag(TItem item)
    {
      IHtmlNode node = new HtmlElement("div").Attributes<string, object>(item.ContentHtmlAttributes).PrependClass("k-content").Attribute("id", this.Component.GetItemContentId<TComponent, TItem>(item));
      if (item.Template.HasValue())
        item.Template.Apply(node);
      return node;
    }

    public IHtmlNode ListItemTag(TItem item, Action<IHtmlNode> configure)
    {
      IHtmlNode htmlNode = new HtmlElement("li").Attributes<string, object>(item.HtmlAttributes);
      if (!item.Enabled)
      {
        htmlNode.PrependClass("k-state-disabled");
        htmlNode.Attributes().Add("aria-disabled", "true");
      }
      else
        configure(htmlNode);
      return htmlNode.PrependClass("k-item");
    }

    public IHtmlNode LinkTag(TItem item, Action<IHtmlNode> configure, bool isInPanelBar = false)
    {
      string itemUrl = this.Component.GetItemUrl<TComponent, TItem>(item);
      IHtmlNode parent1;
      if (itemUrl != "#" && itemUrl != "" && itemUrl != null)
      {
        parent1 = (IHtmlNode) new HtmlElement("a");
        parent1.Attribute("href", itemUrl);
      }
      else
        parent1 = (IHtmlNode) new HtmlElement("span");
      parent1.Attributes<string, object>(item.LinkHtmlAttributes);
      configure(parent1);
      parent1.PrependClass("k-link");
      if (!string.IsNullOrEmpty(item.ImageUrl))
      {
        IHtmlNode htmlNode = this.ImageTag(item);
        if (isInPanelBar)
          htmlNode.AddClass("k-panelbar-item-icon");
        htmlNode.AppendTo(parent1);
      }
      if (!string.IsNullOrEmpty(item.SpriteCssClasses))
        this.SpriteTag(item).AppendTo(parent1);
      if (isInPanelBar)
      {
        IHtmlNode parent2 = new HtmlElement("span").AddClass(new string[1]
        {
          "k-panelbar-item-text"
        });
        this.Text(item).AppendTo(parent2);
        parent2.AppendTo(parent1);
      }
      else
        this.Text(item).AppendTo(parent1);
      return parent1;
    }
  }
}
