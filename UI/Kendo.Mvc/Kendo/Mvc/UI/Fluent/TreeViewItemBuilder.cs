// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.TreeViewItemBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class TreeViewItemBuilder : 
    NavigationItemBuilder<TreeViewItem, TreeViewItemBuilder>,
    IHideObjectMembers
  {
    private readonly TreeViewItem item;
    private readonly ViewContext viewContext;

    public TreeViewItemBuilder(TreeViewItem item, ViewContext viewContext)
      : base((NavigationItem<TreeViewItem>) item, viewContext)
    {
      this.item = item;
      this.viewContext = viewContext;
    }

    public virtual TreeViewItemBuilder Items(
      Action<TreeViewItemFactory> addAction)
    {
      TreeViewItemFactory treeViewItemFactory = new TreeViewItemFactory((INavigationItemContainer<TreeViewItem>) this.item, this.viewContext);
      addAction(treeViewItemFactory);
      return this;
    }

    public TreeViewItemBuilder Id(string id)
    {
      this.item.Id = id;
      return this;
    }

    public TreeViewItemBuilder Expanded(bool value)
    {
      this.item.Expanded = value;
      return this;
    }

    public TreeViewItemBuilder Checked(bool value)
    {
      this.item.Checked = value;
      return this;
    }

    public TreeViewItemBuilder HasChildren(bool value)
    {
      this.item.HasChildren = value;
      return this;
    }

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
