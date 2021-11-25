// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.DropDownTreeItemBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class DropDownTreeItemBuilder : 
    NavigationItemBuilder<DropDownTreeItem, DropDownTreeItemBuilder>,
    IHideObjectMembers
  {
    private readonly DropDownTreeItem item;
    private readonly ViewContext viewContext;

    public DropDownTreeItemBuilder(DropDownTreeItem item, ViewContext viewContext)
      : base((NavigationItem<DropDownTreeItem>) item, viewContext)
    {
      this.item = item;
      this.viewContext = viewContext;
    }

    public virtual DropDownTreeItemBuilder Items(
      Action<DropDownTreeItemFactory> addAction)
    {
      DropDownTreeItemFactory downTreeItemFactory = new DropDownTreeItemFactory((INavigationItemContainer<DropDownTreeItem>) this.item, this.viewContext);
      addAction(downTreeItemFactory);
      return this;
    }

    public DropDownTreeItemBuilder Id(string id)
    {
      this.item.Id = id;
      return this;
    }

    public DropDownTreeItemBuilder Value(string value)
    {
      this.item.Value = value;
      return this;
    }

    public DropDownTreeItemBuilder Expanded(bool value)
    {
      this.item.Expanded = value;
      return this;
    }

    public DropDownTreeItemBuilder Checked(bool value)
    {
      this.item.Checked = value;
      return this;
    }

    public DropDownTreeItemBuilder HasChildren(bool value)
    {
      this.item.HasChildren = value;
      return this;
    }

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
