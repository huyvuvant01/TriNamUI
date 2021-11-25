// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ContextMenuItemFactory
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class ContextMenuItemFactory : IHideObjectMembers
  {
    private readonly ViewContext viewContext;

    public ContextMenu ContextMenu { get; set; }

    public INavigationItemContainer<ContextMenuItem> container { get; set; }

    public ContextMenuItemFactory(
      INavigationItemContainer<ContextMenuItem> container,
      ViewContext viewContext)
    {
      this.container = container;
      this.viewContext = viewContext;
    }

    public ContextMenuItemBuilder Add()
    {
      ContextMenuItem container = new ContextMenuItem();
      this.container.Items.Add(container);
      return new ContextMenuItemBuilder(container, this.viewContext);
    }

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
