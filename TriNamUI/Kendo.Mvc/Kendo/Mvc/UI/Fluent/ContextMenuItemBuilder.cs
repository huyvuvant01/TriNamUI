// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ContextMenuItemBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class ContextMenuItemBuilder : 
    NavigationItemBuilder<ContextMenuItem, ContextMenuItemBuilder>,
    IHideObjectMembers
  {
    private readonly ContextMenuItem item;
    private readonly ViewContext viewContext;

    public ContextMenuItemBuilder(ContextMenuItem container, ViewContext viewContext)
      : base((NavigationItem<ContextMenuItem>) container, viewContext)
    {
      this.item = container;
      this.viewContext = viewContext;
    }

    public virtual ContextMenuItemBuilder Items(
      Action<ContextMenuItemFactory> addAction)
    {
      ContextMenuItemFactory contextMenuItemFactory = new ContextMenuItemFactory((INavigationItemContainer<ContextMenuItem>) this.item, this.viewContext);
      addAction(contextMenuItemFactory);
      return this;
    }

    public virtual ContextMenuItemBuilder Items(
      IEnumerable<ContextMenuItem> items)
    {
      this.item.Items.Clear();
      (items as List<ContextMenuItem>).Each<ContextMenuItem>((Action<ContextMenuItem>) (menuItem => this.item.Items.Add(menuItem)));
      return this;
    }

    public ContextMenuItemBuilder Separator(bool value)
    {
      this.item.Separator = value;
      return this;
    }

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
