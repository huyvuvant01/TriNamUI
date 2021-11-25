// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.PanelBarHtmlBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System;

namespace Kendo.Mvc.UI
{
  public class PanelBarHtmlBuilder : 
    NavigationHtmlBuilderBase<PanelBar, PanelBarItem>,
    INavigationComponentHtmlBuilder<PanelBarItem>
  {
    public PanelBarHtmlBuilder(PanelBar panelBar)
      : base(panelBar)
    {
    }

    public IHtmlNode ChildrenTag(PanelBarItem item)
    {
      IHtmlNode htmlNode = this.ListTag();
      if (!item.Enabled)
        htmlNode.Attribute("style", "display:none");
      else if (item.Enabled && !item.Expanded)
        htmlNode.Attribute("style", "display:none");
      if (item.Expanded)
        htmlNode.Attribute("aria-hidden", "false");
      htmlNode.AddClass("k-panelbar-group");
      return htmlNode;
    }

    public IHtmlNode Build() => this.ComponentTag("ul").PrependClass("k-panelbar");

    public IHtmlNode ItemTag(PanelBarItem item)
    {
      IHtmlNode htmlNode = this.ListItemTag(item, (Action<IHtmlNode>) (li =>
      {
        if (item.Expanded)
        {
          li.PrependClass("k-state-active");
          li.Attribute("aria-expanded", "true");
        }
        else
        {
          if (item.Selected)
            return;
          li.PrependClass("k-state-default");
        }
      }));
      if (item.RootLevel == 0)
        htmlNode.PrependClass("k-panelbar-header");
      else
        htmlNode.PrependClass("k-panelbar-item");
      htmlNode.PrependClass("k-level-" + item.RootLevel.ToString());
      return htmlNode;
    }

    public IHtmlNode ItemInnerContentTag(PanelBarItem item, bool hasAccessibleChildren)
    {
      IHtmlNode parent = this.LinkTag(item, (Action<IHtmlNode>) (tag =>
      {
        if (!item.Selected)
          return;
        tag.PrependClass("k-state-selected");
      }), true);
      if (hasAccessibleChildren || item.Template.HasValue() || item.ContentUrl.HasValue())
        new HtmlElement("span").AddClass(new string[1]
        {
          "k-icon"
        }).AddClass("k-panelbar-item-icon").AddClass("k-panelbar-toggle").ToggleClass("k-i-arrow-chevron-up", item.Expanded).ToggleClass("k-panelbar-collapse", item.Expanded).ToggleClass("k-i-arrow-chevron-down", !item.Expanded).ToggleClass("k-panelbar-expand", !item.Expanded).AppendTo(parent);
      return parent;
    }

    public IHtmlNode ItemContentTag(PanelBarItem item)
    {
      IHtmlNode htmlNode = this.ContentTag(item);
      if (!item.Expanded || item.ContentUrl.HasValue() || !item.Enabled)
        htmlNode.Attribute("style", "display:none");
      htmlNode.AddClass("k-panelbar-content");
      return htmlNode;
    }
  }
}
