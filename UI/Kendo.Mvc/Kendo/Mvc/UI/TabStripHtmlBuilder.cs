// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.TabStripHtmlBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI
{
  public class TabStripHtmlBuilder : NavigationHtmlBuilderBase<TabStrip, TabStripItem>
  {
    public TabStripHtmlBuilder(TabStrip tabStrip)
      : base(tabStrip)
    {
    }

    public IHtmlNode TabStripTag()
    {
      IHtmlNode parent = this.ComponentTag("div").PrependClass("k-widget", "k-tabstrip", "k-header");
      new HtmlElement("ul").AddClass(new string[2]
      {
        "k-reset",
        "k-tabstrip-items"
      }).AppendTo(parent);
      return parent;
    }

    public IHtmlNode TabStripWrapperTag() => new HtmlElement("div").AddClass(new string[1]
    {
      "k-tabstrip-wrapper"
    });

    public IHtmlNode ItemTag(TabStripItem item) => this.ListItemTag(item, (Action<IHtmlNode>) (li =>
    {
      if (item.Selected)
        li.AddClass("k-state-active");
      else if (!item.Enabled)
        li.AddClass("k-state-disabled");
      li.PrependClass("k-state-default");
    }));

    public IHtmlNode ItemInnerTag(TabStripItem item)
    {
      if (string.IsNullOrEmpty(item.Url) && string.IsNullOrEmpty(item.ActionName))
        item.Url = "#";
      IHtmlNode htmlNode = this.LinkTag(item, (Action<IHtmlNode>) (_param1 => { }));
      if (!string.IsNullOrEmpty(item.ContentUrl))
        htmlNode.RemoveAttribute("href");
      htmlNode.Attributes().Add("unselectable", "on");
      return htmlNode;
    }

    public IHtmlNode ItemContentTag(TabStripItem item) => this.ContentTag(item).ToggleClass("k-state-active", item.Selected).ToggleCss("display", "block", item.Selected);
  }
}
