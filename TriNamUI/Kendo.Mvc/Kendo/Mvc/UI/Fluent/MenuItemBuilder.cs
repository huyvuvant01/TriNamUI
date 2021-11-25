// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.MenuItemBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class MenuItemBuilder : NavigationItemBuilder<MenuItem, MenuItemBuilder>, IHideObjectMembers
  {
    private readonly MenuItem item;
    private readonly ViewContext viewContext;

    public MenuItemBuilder(MenuItem container, ViewContext viewContext)
      : base((NavigationItem<MenuItem>) container, viewContext)
    {
      this.item = container;
      this.viewContext = viewContext;
    }

    public virtual MenuItemBuilder Items(Action<MenuItemFactory> addAction)
    {
      MenuItemFactory menuItemFactory = new MenuItemFactory((INavigationItemContainer<MenuItem>) this.item, this.viewContext);
      addAction(menuItemFactory);
      return this;
    }

    public virtual MenuItemBuilder Items(IEnumerable<MenuItem> items)
    {
      this.item.Items.Clear();
      (items as List<MenuItem>).Each<MenuItem>((Action<MenuItem>) (menuItem => this.item.Items.Add(menuItem)));
      return this;
    }

    public MenuItemBuilder Separator(bool value)
    {
      this.item.Separator = value;
      return this;
    }

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
