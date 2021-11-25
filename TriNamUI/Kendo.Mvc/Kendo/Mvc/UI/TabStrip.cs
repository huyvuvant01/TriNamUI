// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.TabStrip
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;

namespace Kendo.Mvc.UI
{
  public class TabStrip : 
    WidgetBase,
    INavigationItemComponent<TabStripItem>,
    INavigationItemContainer<TabStripItem>
  {
    internal bool isPathHighlighted;

    public PopupAnimation Animation { get; private set; } = new PopupAnimation();

    public IList<TabStripItem> Items { get; private set; } = (IList<TabStripItem>) new List<TabStripItem>();

    public Action<TabStripItem> ItemAction { get; set; }

    public int? SelectedIndex { get; set; } = new int?(-1);

    public bool? HighlightPath { get; set; } = new bool?(true);

    public TabStrip(ViewContext viewContext)
      : base(viewContext)
    {
    }

    protected override void WriteHtml(TextWriter writer)
    {
      if (this.Items.Any<TabStripItem>())
      {
        TabStripHtmlBuilder builder = new TabStripHtmlBuilder(this);
        int itemIndex = 0;
        bool isPathHighlighted = false;
        IHtmlNode parent = builder.TabStripWrapperTag();
        IHtmlNode tabStripTag = builder.TabStripTag();
        bool? highlightPath = this.HighlightPath;
        bool flag = true;
        if (highlightPath.GetValueOrDefault() == flag & highlightPath.HasValue)
          this.Items.Each<TabStripItem>(new Action<TabStripItem>(this.HighlightSelectedItem));
        this.Items.Each<TabStripItem>((Action<TabStripItem>) (item =>
        {
          if (!isPathHighlighted)
          {
            int num = itemIndex;
            int? selectedIndex = this.SelectedIndex;
            int valueOrDefault = selectedIndex.GetValueOrDefault();
            if (num == valueOrDefault & selectedIndex.HasValue)
              item.Selected = true;
            ++itemIndex;
          }
          this.WriteItem(item, tabStripTag, builder);
        }));
        tabStripTag.AppendTo(parent);
        parent.WriteTo(writer, this.HtmlEncoder);
      }
      base.WriteHtml(writer);
    }

    public override void WriteInitializationScript(TextWriter writer)
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      IDictionary<string, object> json = this.Animation.ToJson();
      if (json.Keys.Any<string>())
        dictionary["animation"] = json["animation"];
      IEnumerable<string> source = this.Items.Where<TabStripItem>((Func<TabStripItem, bool>) (item => item.Visible)).Select<TabStripItem, string>((Func<TabStripItem, string>) (item => item.ContentUrl.HasValue() ? WebUtility.UrlDecode(item.ContentUrl) : ""));
      if (source.Any<string>((Func<string, bool>) (url => url.HasValue())))
        dictionary["contentUrls"] = (object) source;
      writer.Write(this.Initializer.Initialize(this.Selector, nameof (TabStrip), (IDictionary<string, object>) dictionary));
    }

    private void WriteItem(TabStripItem item, IHtmlNode parentTag, TabStripHtmlBuilder builder)
    {
      if (this.ItemAction != null)
        this.ItemAction(item);
      if (!item.Visible)
        return;
      IHtmlNode parent = builder.ItemTag(item).AppendTo(parentTag.Children[0]);
      builder.ItemInnerTag(item).AppendTo(parent);
      builder.ItemContentTag(item).AppendTo(parentTag);
    }

    private void HighlightSelectedItem(TabStripItem item)
    {
      if (!item.IsCurrent(this.ViewContext, this.UrlGenerator))
        return;
      this.isPathHighlighted = true;
      item.Selected = true;
    }

    public bool? Collapsible { get; set; }

    public bool? Navigatable { get; set; }

    public TabStripScrollableSettings Scrollable { get; } = new TabStripScrollableSettings();

    public TabStripTabPosition? TabPosition { get; set; }

    public string Value { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = base.SerializeSettings();
      if (this.Collapsible.HasValue)
        dictionary1["collapsible"] = (object) this.Collapsible;
      if (this.Navigatable.HasValue)
        dictionary1["navigatable"] = (object) this.Navigatable;
      Dictionary<string, object> source = this.Scrollable.Serialize();
      if (source.Any<KeyValuePair<string, object>>())
        dictionary1["scrollable"] = (object) source;
      else if (this.Scrollable.Enabled.HasValue)
        dictionary1["scrollable"] = (object) this.Scrollable.Enabled;
      if (this.TabPosition.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        TabStripTabPosition? tabPosition = this.TabPosition;
        ref TabStripTabPosition? local = ref tabPosition;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["tabPosition"] = (object) str;
      }
      string str1 = this.Value;
      if ((str1 != null ? (str1.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["value"] = (object) this.Value;
      return dictionary1;
    }
  }
}
