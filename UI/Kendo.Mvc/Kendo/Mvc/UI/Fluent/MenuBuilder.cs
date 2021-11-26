// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.MenuBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class MenuBuilder : WidgetBuilderBase<Menu, MenuBuilder>
  {
    public MenuBuilder(Menu component)
      : base(component)
    {
    }

    public MenuBuilder Animation(bool enable)
    {
      this.Component.Animation.Enabled = enable;
      return this;
    }

    public MenuBuilder Animation(Action<PopupAnimationBuilder> animationAction)
    {
      animationAction(new PopupAnimationBuilder(this.Component.Animation));
      return this;
    }

    public MenuBuilder Items(Action<MenuItemFactory> addAction)
    {
      MenuItemFactory menuItemFactory = new MenuItemFactory((INavigationItemContainer<MenuItem>) this.Component, this.Component.ViewContext);
      addAction(menuItemFactory);
      return this;
    }

    public MenuBuilder Direction(string value)
    {
      this.Component.Direction = value;
      return this;
    }

    public MenuBuilder Direction(MenuDirection value)
    {
      this.Component.Direction = value.ToString().ToLower();
      return this;
    }

    public MenuBuilder DataSource(
      Action<HierarchicalDataSourceBuilder<object>> configurator)
    {
      configurator(new HierarchicalDataSourceBuilder<object>(this.Component.DataSource, this.Component.ViewContext, this.Component.UrlGenerator));
      return this;
    }

    public MenuBuilder DataSource(string dataSourceId)
    {
      this.Component.DataSourceId = dataSourceId;
      return this;
    }

    public MenuBuilder BindTo<T>(
      IEnumerable<T> dataSource,
      Action<MenuItem, T> itemDataBound)
    {
      this.Component.BindTo<MenuItem, T>(dataSource, itemDataBound);
      return this;
    }

    public MenuBuilder BindTo(
      IEnumerable dataSource,
      Action<NavigationBindingFactory<MenuItem>> factoryAction)
    {
      this.Component.BindTo<MenuItem>(dataSource, factoryAction);
      return this;
    }

    public MenuBuilder BindTo(IEnumerable<MenuItem> items)
    {
      this.Component.Items.Clear();
      foreach (MenuItem menuItem in items)
        this.Component.Items.Add(menuItem);
      return this;
    }

    public MenuBuilder ItemAction(Action<MenuItem> action)
    {
      this.Component.ItemAction = action;
      return this;
    }

    public MenuBuilder HighlightPath(bool value)
    {
      this.Component.HighlightPath = new bool?(value);
      return this;
    }

    public MenuBuilder CloseOnClick(bool value)
    {
      this.Container.CloseOnClick = new bool?(value);
      return this;
    }

    public MenuBuilder DataTextField(string value)
    {
      this.Container.DataTextField = value;
      return this;
    }

    public MenuBuilder DataUrlField(string value)
    {
      this.Container.DataUrlField = value;
      return this;
    }

    public MenuBuilder DataSpriteCssClassField(string value)
    {
      this.Container.DataSpriteCssClassField = value;
      return this;
    }

    public MenuBuilder DataImageUrlField(string value)
    {
      this.Container.DataImageUrlField = value;
      return this;
    }

    public MenuBuilder DataContentField(string value)
    {
      this.Container.DataContentField = value;
      return this;
    }

    public MenuBuilder HoverDelay(double value)
    {
      this.Container.HoverDelay = new double?(value);
      return this;
    }

    public MenuBuilder OpenOnClick(
      Action<MenuOpenOnClickSettingsBuilder> configurator)
    {
      this.Container.OpenOnClick.Enabled = new bool?(true);
      this.Container.OpenOnClick.Menu = this.Container;
      configurator(new MenuOpenOnClickSettingsBuilder(this.Container.OpenOnClick));
      return this;
    }

    public MenuBuilder OpenOnClick()
    {
      this.Container.OpenOnClick.Enabled = new bool?(true);
      return this;
    }

    public MenuBuilder OpenOnClick(bool enabled)
    {
      this.Container.OpenOnClick.Enabled = new bool?(enabled);
      return this;
    }

    public MenuBuilder Scrollable(Action<MenuScrollableSettingsBuilder> configurator)
    {
      this.Container.Scrollable.Enabled = new bool?(true);
      this.Container.Scrollable.Menu = this.Container;
      configurator(new MenuScrollableSettingsBuilder(this.Container.Scrollable));
      return this;
    }

    public MenuBuilder Scrollable()
    {
      this.Container.Scrollable.Enabled = new bool?(true);
      return this;
    }

    public MenuBuilder Scrollable(bool enabled)
    {
      this.Container.Scrollable.Enabled = new bool?(enabled);
      return this;
    }

    public MenuBuilder Orientation(MenuOrientation value)
    {
      this.Container.Orientation = new MenuOrientation?(value);
      return this;
    }

    public MenuBuilder Events(Action<MenuEventBuilder> configurator)
    {
      configurator(new MenuEventBuilder(this.Container.Events));
      return this;
    }
  }
}
