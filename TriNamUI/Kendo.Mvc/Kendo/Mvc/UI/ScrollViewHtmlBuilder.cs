// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.ScrollViewHtmlBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI
{
  public class ScrollViewHtmlBuilder : NavigationHtmlBuilderBase<ScrollView, ScrollViewItem>
  {
    public ScrollViewHtmlBuilder(ScrollView ScrollView)
      : base(ScrollView)
    {
    }

    public IHtmlNode ScrollViewTag() => this.ComponentTag("div").PrependClass("k-widget", "k-scrollView");

    public IHtmlNode ItemTag(ScrollViewItem item) => this.ListItemTag(item, (Action<IHtmlNode>) (li =>
    {
      if (item.Selected)
        li.AddClass("k-state-active");
      else if (!item.Enabled)
        li.AddClass("k-state-disabled");
      li.PrependClass("k-state-default");
    }));

    public IHtmlNode ItemContentTag(ScrollViewItem item)
    {
      IHtmlNode node = new HtmlElement("div").Attribute("data-role", "page");
      if (item.Template.HasValue())
        item.Template.Apply(node);
      return node;
    }
  }
}
