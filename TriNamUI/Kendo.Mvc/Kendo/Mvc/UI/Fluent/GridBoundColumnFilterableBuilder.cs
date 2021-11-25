// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.GridBoundColumnFilterableBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections;

namespace Kendo.Mvc.UI.Fluent
{
  public class GridBoundColumnFilterableBuilder : 
    GridFilterableSettingsBuilderBase<GridBoundColumnFilterableBuilder>
  {
    private readonly GridBoundColumnFilterableSettings settings;
    private ViewContext viewContext;
    private IUrlGenerator urlGenerator;

    public GridBoundColumnFilterableBuilder(
      GridBoundColumnFilterableSettings settings,
      ViewContext viewContext,
      IUrlGenerator urlGenerator)
      : base((GridFilterableSettings) settings)
    {
      this.viewContext = viewContext;
      this.urlGenerator = urlGenerator;
      this.settings = settings;
    }

    public GridBoundColumnFilterableBuilder UI(GridFilterUIRole role)
    {
      this.settings.FilterUIRole = role;
      return this;
    }

    public GridBoundColumnFilterableBuilder Cell(
      Action<GridColumnFilterableCellSettingsBuilder> configurator)
    {
      configurator(new GridColumnFilterableCellSettingsBuilder(this.settings.CellSettings, this.viewContext, this.urlGenerator));
      return this;
    }

    public GridBoundColumnFilterableBuilder UI(
      Func<object, object> handler)
    {
      this.settings.FilterUIHandler.TemplateDelegate = handler;
      return this;
    }

    public GridBoundColumnFilterableBuilder UI(string handler)
    {
      this.settings.FilterUIHandler.HandlerName = handler;
      return this;
    }

    public GridBoundColumnFilterableBuilder ItemTemplate(
      string handler)
    {
      this.settings.ItemTemplate.HandlerName = handler;
      return this;
    }

    public GridBoundColumnFilterableBuilder CheckAll(bool value)
    {
      this.settings.CheckAll = value;
      return this;
    }

    public GridBoundColumnFilterableBuilder Multi(bool value)
    {
      this.settings.Multi = value;
      return this;
    }

    public GridBoundColumnFilterableBuilder Search(bool value)
    {
      this.settings.Search = value;
      return this;
    }

    public GridBoundColumnFilterableBuilder DataSource(
      Action<ReadOnlyDataSourceBuilder> configurator)
    {
      configurator(new ReadOnlyDataSourceBuilder(this.settings.DataSource, this.viewContext, this.urlGenerator));
      return this;
    }

    public GridBoundColumnFilterableBuilder DataSource(
      string dataSourceId)
    {
      this.settings.DataSourceId = dataSourceId;
      return this;
    }

    public GridBoundColumnFilterableBuilder IgnoreCase(bool value)
    {
      this.settings.IgnoreCase = new bool?(value);
      return this;
    }

    public GridBoundColumnFilterableBuilder BindTo(
      IEnumerable dataSource)
    {
      this.settings.DataSource.Data = dataSource;
      return this;
    }
  }
}
