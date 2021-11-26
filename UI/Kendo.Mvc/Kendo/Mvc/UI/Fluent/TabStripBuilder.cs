// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.TabStripBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class TabStripBuilder : WidgetBuilderBase<TabStrip, TabStripBuilder>
  {
    public TabStripBuilder(TabStrip component)
      : base(component)
    {
    }

    public TabStripBuilder Animation(bool enable)
    {
      this.Component.Animation.Enabled = enable;
      return this;
    }

    public TabStripBuilder Animation(Action<PopupAnimationBuilder> animationAction)
    {
      animationAction(new PopupAnimationBuilder(this.Component.Animation));
      return this;
    }

    public TabStripBuilder SelectedIndex(int index)
    {
      this.Component.SelectedIndex = new int?(index);
      return this;
    }

    public TabStripBuilder ItemAction(Action<TabStripItem> action)
    {
      this.Component.ItemAction = action;
      return this;
    }

    public TabStripBuilder HighlightPath(bool value)
    {
      this.Component.HighlightPath = new bool?(value);
      return this;
    }

    public TabStripBuilder Items(Action<TabStripItemFactory> addAction)
    {
      TabStripItemFactory stripItemFactory = new TabStripItemFactory((INavigationItemContainer<TabStripItem>) this.Component, this.Component.ViewContext);
      addAction(stripItemFactory);
      return this;
    }

    public TabStripBuilder BindTo<T>(
      IEnumerable<T> dataSource,
      Action<TabStripItem, T> itemDataBound)
    {
      this.Component.BindTo<TabStripItem, T>(dataSource, itemDataBound);
      return this;
    }

    public TabStripBuilder Collapsible(bool value)
    {
      this.Container.Collapsible = new bool?(value);
      return this;
    }

    public TabStripBuilder Collapsible()
    {
      this.Container.Collapsible = new bool?(true);
      return this;
    }

    public TabStripBuilder Navigatable(bool value)
    {
      this.Container.Navigatable = new bool?(value);
      return this;
    }

    public TabStripBuilder Scrollable(
      Action<TabStripScrollableSettingsBuilder> configurator)
    {
      this.Container.Scrollable.Enabled = new bool?(true);
      this.Container.Scrollable.TabStrip = this.Container;
      configurator(new TabStripScrollableSettingsBuilder(this.Container.Scrollable));
      return this;
    }

    public TabStripBuilder Scrollable(bool enabled)
    {
      this.Container.Scrollable.Enabled = new bool?(enabled);
      return this;
    }

    public TabStripBuilder TabPosition(TabStripTabPosition value)
    {
      this.Container.TabPosition = new TabStripTabPosition?(value);
      return this;
    }

    public TabStripBuilder Value(string value)
    {
      this.Container.Value = value;
      return this;
    }

    public TabStripBuilder Events(Action<TabStripEventBuilder> configurator)
    {
      configurator(new TabStripEventBuilder(this.Container.Events));
      return this;
    }
  }
}
