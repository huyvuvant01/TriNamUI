// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ScrollViewItemFactory
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class ScrollViewItemFactory : IHideObjectMembers
  {
    private readonly INavigationItemContainer<ScrollViewItem> container;
    private readonly ViewContext viewContext;

    public ScrollViewItemFactory(
      INavigationItemContainer<ScrollViewItem> container,
      ViewContext viewContext)
    {
      this.container = container;
      this.viewContext = viewContext;
    }

    public virtual ScrollViewItemBuilder Add()
    {
      ScrollViewItem scrollViewItem = new ScrollViewItem();
      this.container.Items.Add(scrollViewItem);
      return new ScrollViewItemBuilder(scrollViewItem, this.viewContext);
    }

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
