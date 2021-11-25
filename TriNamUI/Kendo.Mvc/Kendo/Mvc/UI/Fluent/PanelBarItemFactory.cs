﻿// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.PanelBarItemFactory
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc.Rendering;

namespace Kendo.Mvc.UI.Fluent
{
  public class PanelBarItemFactory
  {
    private readonly INavigationItemContainer<PanelBarItem> container;
    private readonly ViewContext viewContext;
    private readonly int level;

    public PanelBarItemFactory(
      INavigationItemContainer<PanelBarItem> container,
      ViewContext viewContext,
      int level = 0)
    {
      this.container = container;
      this.viewContext = viewContext;
      this.level = level;
    }

    public virtual PanelBarItemBuilder Add()
    {
      PanelBarItem panelBarItem = new PanelBarItem();
      panelBarItem.RootLevel = this.level;
      this.container.Items.Add(panelBarItem);
      return new PanelBarItemBuilder(panelBarItem, this.viewContext);
    }
  }
}
