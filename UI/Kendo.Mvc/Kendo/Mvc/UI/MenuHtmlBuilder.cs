// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.MenuHtmlBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI
{
  public class MenuHtmlBuilder : 
    NavigationHtmlBuilderBase<Menu, MenuItem>,
    INavigationComponentHtmlBuilder<MenuItem>
  {
    public MenuHtmlBuilder(Menu menu)
      : base(menu)
    {
    }

    public new IHtmlNode ListTag() => new HtmlElement("ul").AddClass(new string[2]
    {
      "k-group",
      "k-menu-group"
    });

    public IHtmlNode ChildrenTag(MenuItem item) => this.ListTag();

    public IHtmlNode Build()
    {
      IHtmlNode htmlNode = this.ComponentTag("ul").PrependClass("k-widget", "k-reset", "k-header", "k-menu");
      MenuOrientation? orientation = this.Component.Orientation;
      MenuOrientation menuOrientation = MenuOrientation.Vertical;
      int num = orientation.GetValueOrDefault() == menuOrientation & orientation.HasValue ? 1 : 0;
      return htmlNode.ToggleClass("k-menu-vertical", num != 0);
    }

    public IHtmlNode ItemTag(MenuItem item)
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

    public IHtmlNode ItemContentTag(MenuItem item)
    {
      IHtmlNode parent1 = this.ListTag();
      IHtmlNode parent2 = new HtmlElement("li").AddClass(new string[1]
      {
        "k-item"
      }).AppendTo(parent1);
      this.ContentTag(item).AppendTo(parent2);
      return parent1;
    }

    public IHtmlNode ItemInnerContentTag(MenuItem item, bool hasAccessibleChildren)
    {
      IHtmlNode parent = this.LinkTag(item);
      if (hasAccessibleChildren || item.Template.HasValue())
      {
        string str = "k-i-arrow-60-right";
        MenuOrientation? orientation = this.Component.Orientation;
        MenuOrientation menuOrientation = MenuOrientation.Horizontal;
        if (orientation.GetValueOrDefault() == menuOrientation & orientation.HasValue && item.Parent == null)
          str = "k-i-arrow-60-down";
        new HtmlElement("span").AddClass(new string[2]
        {
          "k-icon",
          str
        }).AppendTo(parent);
      }
      return parent;
    }

    public IHtmlNode LinkTag(MenuItem item)
    {
      string itemUrl = this.Component.GetItemUrl<Menu, MenuItem>(item);
      IHtmlNode parent = !(itemUrl != "#") || itemUrl.StartsWith("#" + this.Component.Id) ? (IHtmlNode) new HtmlElement("span") : new HtmlElement("a").Attribute("href", itemUrl);
      parent.Attributes<string, object>(item.LinkHtmlAttributes);
      parent.AddClass("k-link", "k-menu-link");
      if (!string.IsNullOrEmpty(item.ImageUrl))
        this.ImageTag(item).AppendTo(parent);
      if (!string.IsNullOrEmpty(item.SpriteCssClasses))
        this.SpriteTag(item).AppendTo(parent);
      this.Text(item).AppendTo(parent);
      return parent;
    }
  }
}
