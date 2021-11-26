// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.PanelBarItemBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class PanelBarItemBuilder : ContentNavigationItemBuilder<PanelBarItem, PanelBarItemBuilder>
  {
    private readonly PanelBarItem item;
    private readonly ViewContext viewContext;

    public PanelBarItemBuilder(PanelBarItem item, ViewContext viewContext)
      : base(item, viewContext)
    {
      this.item = item;
      this.viewContext = viewContext;
    }

    public PanelBarItemBuilder Items(Action<PanelBarItemFactory> addAction)
    {
      PanelBarItemFactory panelBarItemFactory = new PanelBarItemFactory((INavigationItemContainer<PanelBarItem>) this.item, this.viewContext, this.item.RootLevel + 1);
      addAction(panelBarItemFactory);
      return this;
    }

    public PanelBarItemBuilder Expanded(bool value)
    {
      this.item.Expanded = value;
      return this;
    }
  }
}
