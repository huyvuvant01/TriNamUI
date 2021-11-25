// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.ContextMenuHtmlBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI
{
  public class ContextMenuHtmlBuilder : 
    NavigationHtmlBuilderBase<ContextMenu, ContextMenuItem>,
    INavigationComponentHtmlBuilder<ContextMenuItem>
  {
    public ContextMenuHtmlBuilder(ContextMenu menu)
      : base(menu)
    {
    }

    public IHtmlNode ChildrenTag(ContextMenuItem item) => this.ListTag();

    public IHtmlNode Build()
    {
      IHtmlNode htmlNode = this.ComponentTag("ul");
      string[] strArray = new string[5]
      {
        "k-widget",
        "k-reset",
        "k-header",
        "k-menu k-context-menu",
        null
      };
      ContextMenuOrientation? orientation = this.Component.Orientation;
      ContextMenuOrientation contextMenuOrientation = ContextMenuOrientation.Horizontal;
      strArray[4] = orientation.GetValueOrDefault() == contextMenuOrientation & orientation.HasValue ? "k-menu-horizontal" : "k-menu-vertical";
      return htmlNode.PrependClass(strArray);
    }

    public IHtmlNode ItemTag(ContextMenuItem item)
    {
      if (!item.Separator)
        return this.ListItemTag(item, (Action<IHtmlNode>) (li =>
        {
          if (item.Selected)
            li.AddClass("k-state-selected");
          else
            li.AddClass("k-state-default");
        }));
      return new HtmlElement("li").Attributes<string, object>(item.HtmlAttributes).PrependClass("k-separator").PrependClass("k-item");
    }

    public IHtmlNode ItemContentTag(ContextMenuItem item)
    {
      IHtmlNode parent1 = this.ListTag();
      IHtmlNode parent2 = new HtmlElement("li").AddClass(new string[1]
      {
        "k-item"
      }).AppendTo(parent1);
      this.ContentTag(item).AppendTo(parent2);
      return parent1;
    }

    public IHtmlNode ItemInnerContentTag(ContextMenuItem item, bool hasAccessibleChildren)
    {
      IHtmlNode parent = this.LinkTag(item);
      if (hasAccessibleChildren || item.Template.HasValue())
      {
        string str = "k-i-arrow-60-right";
        ContextMenuOrientation? orientation = this.Component.Orientation;
        ContextMenuOrientation contextMenuOrientation = ContextMenuOrientation.Horizontal;
        if (orientation.GetValueOrDefault() == contextMenuOrientation & orientation.HasValue && item.Parent == null)
          str = "k-i-arrow-60-down";
        new HtmlElement("span").AddClass(new string[2]
        {
          "k-icon",
          str
        }).AppendTo(parent);
      }
      return parent;
    }

    public IHtmlNode LinkTag(ContextMenuItem item)
    {
      string itemUrl = this.Component.GetItemUrl<ContextMenu, ContextMenuItem>(item);
      IHtmlNode parent = !(itemUrl != "#") || itemUrl.StartsWith("#" + this.Component.Id) ? (IHtmlNode) new HtmlElement("span") : new HtmlElement("a").Attribute("href", itemUrl);
      parent.Attributes<string, object>(item.LinkHtmlAttributes);
      parent.PrependClass("k-link", "k-menu-link");
      if (!string.IsNullOrEmpty(item.ImageUrl))
        this.ImageTag(item).AppendTo(parent);
      if (!string.IsNullOrEmpty(item.SpriteCssClasses))
        this.SpriteTag(item).AppendTo(parent);
      this.Text(item).AppendTo(parent);
      return parent;
    }
  }
}
