// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.TreeViewItemFactory
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class TreeViewItemFactory : IHideObjectMembers
  {
    private readonly INavigationItemContainer<TreeViewItem> container;
    private readonly ViewContext viewContext;

    public TreeViewItemFactory(
      INavigationItemContainer<TreeViewItem> container,
      ViewContext viewContext)
    {
      this.container = container;
      this.viewContext = viewContext;
    }

    public TreeViewItemBuilder Add()
    {
      TreeViewItem treeViewItem = new TreeViewItem();
      this.container.Items.Add(treeViewItem);
      return new TreeViewItemBuilder(treeViewItem, this.viewContext);
    }

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
