// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.NavigationBindingBuilder`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections;

namespace Kendo.Mvc.UI.Fluent
{
  public class NavigationBindingBuilder<TNavigationItem, TParent>
    where TNavigationItem : NavigationItem<TNavigationItem>
    where TParent : class
  {
    private NavigationBinding<TNavigationItem, TParent> item;

    public NavigationBindingBuilder(NavigationBinding<TNavigationItem, TParent> item) => this.item = item;

    public NavigationBindingBuilder<TNavigationItem, TParent> Children(
      Func<TParent, IEnumerable> children)
    {
      this.item.Children = children;
      return this;
    }

    public NavigationBindingBuilder<TNavigationItem, TParent> ItemDataBound(
      Action<TNavigationItem, TParent> itemDataBound)
    {
      this.item.ItemDataBound = itemDataBound;
      return this;
    }
  }
}
