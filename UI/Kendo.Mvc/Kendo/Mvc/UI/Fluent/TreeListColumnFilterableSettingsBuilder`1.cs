// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.TreeListColumnFilterableSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class TreeListColumnFilterableSettingsBuilder<T> where T : class
  {
    private ViewContext viewContext;
    private IUrlGenerator urlGenerator;

    public TreeListColumnFilterableSettingsBuilder(
      TreeListColumnFilterableSettings<T> container,
      ViewContext viewContext,
      IUrlGenerator urlGenerator)
    {
      this.Container = container;
      this.viewContext = viewContext;
      this.urlGenerator = urlGenerator;
    }

    protected TreeListColumnFilterableSettings<T> Container { get; private set; }

    public TreeListColumnFilterableSettingsBuilder<T> Ui(
      GridFilterUIRole role)
    {
      this.Container.FilterUIRole = role;
      return this;
    }

    public TreeListColumnFilterableSettingsBuilder<T> Ui(
      string handler)
    {
      this.Container.FilterUIHandler.HandlerName = handler;
      return this;
    }

    public TreeListColumnFilterableSettingsBuilder<T> Cell(
      Action<GridColumnFilterableCellSettingsBuilder> configurator)
    {
      configurator(new GridColumnFilterableCellSettingsBuilder(this.Container.CellSettings, this.viewContext, this.urlGenerator));
      return this;
    }
  }
}
