// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.NavigationBinding`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections;

namespace Kendo.Mvc.UI
{
  public class NavigationBinding<TNavigationItem, TParent> : INavigationBinding<TNavigationItem>
    where TNavigationItem : NavigationItem<TNavigationItem>
    where TParent : class
  {
    public Func<TParent, IEnumerable> Children { get; set; }

    public Action<TNavigationItem, TParent> ItemDataBound { get; set; }

    Type INavigationBinding<TNavigationItem>.Type => typeof (TParent);

    IEnumerable INavigationBinding<TNavigationItem>.Children(
      object parent)
    {
      return this.Children == null ? (IEnumerable) null : this.Children((TParent) parent);
    }

    void INavigationBinding<TNavigationItem>.ItemDataBound(
      TNavigationItem item,
      object value)
    {
      this.ItemDataBound(item, (TParent) value);
    }
  }
}
