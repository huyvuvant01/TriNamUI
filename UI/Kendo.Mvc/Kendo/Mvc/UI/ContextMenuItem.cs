// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.ContextMenuItem
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class ContextMenuItem : 
    NavigationItem<ContextMenuItem>,
    INavigationItemContainer<ContextMenuItem>
  {
    public ContextMenuItem() => this.Items = (IList<ContextMenuItem>) new List<ContextMenuItem>();

    public IList<ContextMenuItem> Items { get; private set; }

    public bool Separator { get; set; }

    public ContextMenu ContextMenu { get; set; }
  }
}
