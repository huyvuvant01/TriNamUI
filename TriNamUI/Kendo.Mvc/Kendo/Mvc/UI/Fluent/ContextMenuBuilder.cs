// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ContextMenuBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class ContextMenuBuilder : 
    WidgetBuilderBase<ContextMenu, ContextMenuBuilder>,
    IHideObjectMembers
  {
    public ContextMenuBuilder(ContextMenu component)
      : base(component)
    {
    }

    public ContextMenuBuilder Animation(bool enable)
    {
      this.Component.Animation.Enabled = enable;
      return this;
    }

    public ContextMenuBuilder Animation(
      Action<PopupAnimationBuilder> animationAction)
    {
      animationAction(new PopupAnimationBuilder(this.Component.Animation));
      return this;
    }

    public ContextMenuBuilder OpenOnClick(bool value)
    {
      this.Component.OpenOnClick = new bool?(value);
      return this;
    }

    public ContextMenuBuilder DataSource(
      Action<HierarchicalDataSourceBuilder<object>> configurator)
    {
      configurator(new HierarchicalDataSourceBuilder<object>(this.Component.DataSource, this.Component.ViewContext, this.Component.UrlGenerator));
      return this;
    }

    public ContextMenuBuilder DataSource(string dataSourceId)
    {
      this.Component.DataSourceId = dataSourceId;
      return this;
    }

    public ContextMenuBuilder Items(Action<ContextMenuItemFactory> addAction)
    {
      ContextMenuItemFactory contextMenuItemFactory = new ContextMenuItemFactory((INavigationItemContainer<ContextMenuItem>) this.Component, this.Component.ViewContext);
      addAction(contextMenuItemFactory);
      return this;
    }

    public ContextMenuBuilder Direction(string value)
    {
      this.Component.Direction = value;
      return this;
    }

    public ContextMenuBuilder BindTo<T>(
      IEnumerable<T> dataSource,
      Action<ContextMenuItem, T> itemDataBound)
    {
      this.Component.BindTo<ContextMenuItem, T>(dataSource, itemDataBound);
      return this;
    }

    public ContextMenuBuilder BindTo(
      IEnumerable dataSource,
      Action<NavigationBindingFactory<ContextMenuItem>> factoryAction)
    {
      this.Component.BindTo<ContextMenuItem>(dataSource, factoryAction);
      return this;
    }

    public ContextMenuBuilder BindTo(IEnumerable<ContextMenuItem> items)
    {
      this.Component.Items.Clear();
      foreach (ContextMenuItem contextMenuItem in items)
        this.Component.Items.Add(contextMenuItem);
      return this;
    }

    public ContextMenuBuilder ItemAction(Action<ContextMenuItem> action)
    {
      this.Component.ItemAction = action;
      return this;
    }

    public ContextMenuBuilder HighlightPath(bool value)
    {
      this.Component.HighlightPath = new bool?(value);
      return this;
    }

    public ContextMenuBuilder AlignToAnchor(bool value)
    {
      this.Container.AlignToAnchor = new bool?(value);
      return this;
    }

    public ContextMenuBuilder AlignToAnchor()
    {
      this.Container.AlignToAnchor = new bool?(true);
      return this;
    }

    public ContextMenuBuilder AppendTo(string value)
    {
      this.Container.AppendTo = value;
      return this;
    }

    public ContextMenuBuilder CloseOnClick(bool value)
    {
      this.Container.CloseOnClick = new bool?(value);
      return this;
    }

    public ContextMenuBuilder CopyAnchorStyles(bool value)
    {
      this.Container.CopyAnchorStyles = new bool?(value);
      return this;
    }

    public ContextMenuBuilder DataTextField(string value)
    {
      this.Container.DataTextField = value;
      return this;
    }

    public ContextMenuBuilder DataUrlField(string value)
    {
      this.Container.DataUrlField = value;
      return this;
    }

    public ContextMenuBuilder DataSpriteCssClassField(string value)
    {
      this.Container.DataSpriteCssClassField = value;
      return this;
    }

    public ContextMenuBuilder DataImageUrlField(string value)
    {
      this.Container.DataImageUrlField = value;
      return this;
    }

    public ContextMenuBuilder DataContentField(string value)
    {
      this.Container.DataContentField = value;
      return this;
    }

    public ContextMenuBuilder Filter(string value)
    {
      this.Container.Filter = value;
      return this;
    }

    public ContextMenuBuilder HoverDelay(double value)
    {
      this.Container.HoverDelay = new double?(value);
      return this;
    }

    public ContextMenuBuilder Scrollable(
      Action<ContextMenuScrollableSettingsBuilder> configurator)
    {
      this.Container.Scrollable.Enabled = new bool?(true);
      this.Container.Scrollable.ContextMenu = this.Container;
      configurator(new ContextMenuScrollableSettingsBuilder(this.Container.Scrollable));
      return this;
    }

    public ContextMenuBuilder Scrollable()
    {
      this.Container.Scrollable.Enabled = new bool?(true);
      return this;
    }

    public ContextMenuBuilder Scrollable(bool enabled)
    {
      this.Container.Scrollable.Enabled = new bool?(enabled);
      return this;
    }

    public ContextMenuBuilder ShowOn(string value)
    {
      this.Container.ShowOn = value;
      return this;
    }

    public ContextMenuBuilder Target(string value)
    {
      this.Container.Target = value;
      return this;
    }

    public ContextMenuBuilder Orientation(ContextMenuOrientation value)
    {
      this.Container.Orientation = new ContextMenuOrientation?(value);
      return this;
    }

    public ContextMenuBuilder Events(Action<ContextMenuEventBuilder> configurator)
    {
      configurator(new ContextMenuEventBuilder(this.Container.Events));
      return this;
    }

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
