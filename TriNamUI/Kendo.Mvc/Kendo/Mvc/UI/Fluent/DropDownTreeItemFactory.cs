// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.DropDownTreeItemFactory
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class DropDownTreeItemFactory : IHideObjectMembers
  {
    private readonly INavigationItemContainer<DropDownTreeItem> container;
    private readonly ViewContext viewContext;

    public DropDownTreeItemFactory(
      INavigationItemContainer<DropDownTreeItem> container,
      ViewContext viewContext)
    {
      this.container = container;
      this.viewContext = viewContext;
    }

    public DropDownTreeItemBuilder Add()
    {
      DropDownTreeItem dropDownTreeItem = new DropDownTreeItem();
      this.container.Items.Add(dropDownTreeItem);
      return new DropDownTreeItemBuilder(dropDownTreeItem, this.viewContext);
    }

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
