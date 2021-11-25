// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.GridBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI.Fluent
{
  public class GridBuilder<T> : WidgetBuilderBase<Grid<T>, GridBuilder<T>>
    where T : class
  {
    public GridBuilder(Grid<T> component)
      : base(component)
    {
    }

    public GridBuilder<T> EnableCustomBinding(bool value)
    {
      this.Component.EnableCustomBinding = value;
      return this;
    }

    public GridBuilder<T> BindTo(IEnumerable<T> dataSource)
    {
      this.Component.DataSource.Data = (IEnumerable) dataSource;
      return this;
    }

    public GridBuilder<T> BindTo(IEnumerable dataSource)
    {
      this.Component.DataSource.Data = (IEnumerable) new CustomGroupingWrapper<T>(dataSource);
      return this;
    }

    public GridBuilder<T> Editable(Action<GridEditingSettingsBuilder<T>> configurator)
    {
      configurator(new GridEditingSettingsBuilder<T>(this.Component.Editable));
      return this;
    }

    public GridBuilder<T> Editable(GridEditMode editMode)
    {
      this.Component.Editable.Mode = editMode;
      return this;
    }

    public GridBuilder<T> Editable()
    {
      this.Component.Editable.Enabled = true;
      return this;
    }

    public GridBuilder<T> DataSource(Action<DataSourceBuilder<T>> configurator)
    {
      this.Component.DataSource.ServerAggregates = true;
      this.Component.DataSource.ServerFiltering = true;
      this.Component.DataSource.ServerGrouping = true;
      this.Component.DataSource.ServerPaging = true;
      this.Component.DataSource.ServerSorting = true;
      configurator(new DataSourceBuilder<T>(this.Component.DataSource, this.Component.ViewContext, this.Component.UrlGenerator));
      return this;
    }

    public GridBuilder<T> DataSource(string dataSourceId)
    {
      this.Component.DataSourceId = dataSourceId;
      return this;
    }

    public GridBuilder<T> Pageable() => this.Pageable((Action<GridPageableSettingsBuilder>) (_param1 => { }));

    public GridBuilder<T> Pageable(Action<GridPageableSettingsBuilder> configurator)
    {
      this.Component.Pageable.Enabled = true;
      configurator(new GridPageableSettingsBuilder(this.Component.Pageable));
      return this;
    }

    public GridBuilder<T> Filterable()
    {
      this.Component.Filterable.Enabled = true;
      return this;
    }

    public GridBuilder<T> Filterable(Action<GridFilterableSettingsBuilder> configurator)
    {
      this.Component.Filterable.Enabled = true;
      configurator(new GridFilterableSettingsBuilder(this.Component.Filterable));
      this.ApplyFilterableSettingsToColumns();
      return this;
    }

    public GridBuilder<T> Resizable(Action<GridResizingSettingsBuilder> configurator)
    {
      configurator(new GridResizingSettingsBuilder(this.Component.Resizable));
      return this;
    }

    public GridBuilder<T> Reorderable(Action<GridReorderingSettingsBuilder> configurator)
    {
      configurator(new GridReorderingSettingsBuilder(this.Component.Reorderable));
      return this;
    }

    public GridBuilder<T> Selectable()
    {
      this.Component.Selectable.Enabled = true;
      return this;
    }

    public GridBuilder<T> Selectable(Action<GridSelectionSettingsBuilder> configurator)
    {
      this.Selectable();
      configurator(new GridSelectionSettingsBuilder(this.Component.Selectable));
      return this;
    }

    public GridBuilder<T> Scrollable()
    {
      this.Component.Scrollable.Enabled = true;
      return this;
    }

    public GridBuilder<T> Scrollable(Action<GridScrollSettingsBuilder> configurator)
    {
      this.Scrollable();
      configurator(new GridScrollSettingsBuilder(this.Component.Scrollable));
      return this;
    }

    public GridBuilder<T> Columns(Action<GridColumnFactory<T>> configurator)
    {
      GridColumnFactory<T> gridColumnFactory = new GridColumnFactory<T>(this.Component, this.Component.ViewContext, this.Component.UrlGenerator);
      configurator(gridColumnFactory);
      return this;
    }

    public GridBuilder<T> Mobile()
    {
      this.Component.Mobile = MobileMode.Auto;
      return this;
    }

    public GridBuilder<T> Mobile(MobileMode type)
    {
      this.Component.Mobile = type;
      return this;
    }

    public GridBuilder<T> ToolBar(Action<GridToolBarCommandFactory<T>> configurator)
    {
      configurator(new GridToolBarCommandFactory<T>(this.Component.ToolBar, this.Component));
      return this;
    }

    public GridBuilder<T> ClientRowTemplate(string template)
    {
      this.Component.ClientRowTemplate = template;
      return this;
    }

    public GridBuilder<T> ClientAltRowTemplate(string template)
    {
      this.Component.ClientAltRowTemplate = template;
      return this;
    }

    public GridBuilder<T> ClientRowTemplate(Func<Grid<T>, string> template)
    {
      this.Component.ClientRowTemplate = template(this.Component);
      return this;
    }

    public GridBuilder<T> ClientAltRowTemplate(Func<Grid<T>, string> template)
    {
      this.Component.ClientAltRowTemplate = template(this.Component);
      return this;
    }

    public GridBuilder<T> ClientDetailTemplateId(string id)
    {
      this.Component.ClientDetailTemplateId = id;
      return this;
    }

    public GridBuilder<T> Width(int pixelWidth)
    {
      this.Component.Width = pixelWidth.ToString() + "px";
      return this;
    }

    public GridBuilder<T> Width(string value)
    {
      this.Component.Width = value;
      return this;
    }

    public GridBuilder<T> Height(int pixelHeight)
    {
      this.Component.Height = pixelHeight.ToString() + "px";
      return this;
    }

    public GridBuilder<T> Height(string value)
    {
      this.Component.Height = value;
      return this;
    }

    public GridBuilder<T> Messages(Action<GridMessagesBuilder> configurator)
    {
      configurator(new GridMessagesBuilder(this.Component.Messages));
      return this;
    }

    internal void ApplyFilterableSettingsToColumns()
    {
      List<IGridBoundColumn> list = ((IEnumerable<IGridColumn>) this.Component.Columns).FlatColumns().OfType<IGridBoundColumn>().ToList<IGridBoundColumn>();
      GridFilterableSettings filterableSettings = new GridFilterableSettings();
      for (int index = 0; index < list.Count; ++index)
      {
        if (list[index].FilterableSettings.Operators.Equals(filterableSettings.Operators))
          list[index].FilterableSettings.Operators = this.Component.Filterable.Operators.Clone();
      }
    }

    public GridBuilder<T> AllowCopy(
      Action<GridAllowCopySettingsBuilder<T>> configurator)
    {
      this.Container.AllowCopy.Enabled = new bool?(true);
      this.Container.AllowCopy.Grid = this.Container;
      configurator(new GridAllowCopySettingsBuilder<T>(this.Container.AllowCopy));
      return this;
    }

    public GridBuilder<T> AllowCopy()
    {
      this.Container.AllowCopy.Enabled = new bool?(true);
      return this;
    }

    public GridBuilder<T> AllowCopy(bool enabled)
    {
      this.Container.AllowCopy.Enabled = new bool?(enabled);
      return this;
    }

    public GridBuilder<T> AutoBind(bool value)
    {
      this.Container.AutoBind = new bool?(value);
      return this;
    }

    public GridBuilder<T> ColumnResizeHandleWidth(double value)
    {
      this.Container.ColumnResizeHandleWidth = new double?(value);
      return this;
    }

    public GridBuilder<T> ColumnMenu(
      Action<GridColumnMenuSettingsBuilder<T>> configurator)
    {
      this.Container.ColumnMenu.Enabled = new bool?(true);
      this.Container.ColumnMenu.Grid = this.Container;
      configurator(new GridColumnMenuSettingsBuilder<T>(this.Container.ColumnMenu));
      return this;
    }

    public GridBuilder<T> ColumnMenu()
    {
      this.Container.ColumnMenu.Enabled = new bool?(true);
      return this;
    }

    public GridBuilder<T> ColumnMenu(bool enabled)
    {
      this.Container.ColumnMenu.Enabled = new bool?(enabled);
      return this;
    }

    public GridBuilder<T> EncodeTitles(bool value)
    {
      this.Container.EncodeTitles = new bool?(value);
      return this;
    }

    public GridBuilder<T> EncodeTitles()
    {
      this.Container.EncodeTitles = new bool?(true);
      return this;
    }

    public GridBuilder<T> Excel(Action<GridExcelSettingsBuilder<T>> configurator)
    {
      this.Container.Excel.Grid = this.Container;
      configurator(new GridExcelSettingsBuilder<T>(this.Container.Excel));
      return this;
    }

    public GridBuilder<T> Groupable(
      Action<GridGroupableSettingsBuilder<T>> configurator)
    {
      this.Container.Groupable.Enabled = new bool?(true);
      this.Container.Groupable.Grid = this.Container;
      configurator(new GridGroupableSettingsBuilder<T>(this.Container.Groupable));
      return this;
    }

    public GridBuilder<T> Groupable()
    {
      this.Container.Groupable.Enabled = new bool?(true);
      return this;
    }

    public GridBuilder<T> Groupable(bool enabled)
    {
      this.Container.Groupable.Enabled = new bool?(enabled);
      return this;
    }

    public GridBuilder<T> Navigatable(bool value)
    {
      this.Container.Navigatable = new bool?(value);
      return this;
    }

    public GridBuilder<T> Navigatable()
    {
      this.Container.Navigatable = new bool?(true);
      return this;
    }

    public GridBuilder<T> NoRecords(
      Action<GridNoRecordsSettingsBuilder<T>> configurator)
    {
      this.Container.NoRecords.Enabled = new bool?(true);
      this.Container.NoRecords.Grid = this.Container;
      configurator(new GridNoRecordsSettingsBuilder<T>(this.Container.NoRecords));
      return this;
    }

    public GridBuilder<T> NoRecords()
    {
      this.Container.NoRecords.Enabled = new bool?(true);
      return this;
    }

    public GridBuilder<T> NoRecords(bool enabled)
    {
      this.Container.NoRecords.Enabled = new bool?(enabled);
      return this;
    }

    public GridBuilder<T> Pdf(Action<GridPdfSettingsBuilder<T>> configurator)
    {
      this.Container.Pdf.Grid = this.Container;
      configurator(new GridPdfSettingsBuilder<T>(this.Container.Pdf));
      return this;
    }

    public GridBuilder<T> PersistSelection(bool value)
    {
      this.Container.PersistSelection = new bool?(value);
      return this;
    }

    public GridBuilder<T> PersistSelection()
    {
      this.Container.PersistSelection = new bool?(true);
      return this;
    }

    public GridBuilder<T> Search(Action<GridSearchSettingsBuilder<T>> configurator)
    {
      this.Container.Search.Grid = this.Container;
      configurator(new GridSearchSettingsBuilder<T>(this.Container.Search));
      return this;
    }

    public GridBuilder<T> Sortable(
      Action<GridSortableSettingsBuilder<T>> configurator)
    {
      this.Container.Sortable.Enabled = new bool?(true);
      this.Container.Sortable.Grid = this.Container;
      configurator(new GridSortableSettingsBuilder<T>(this.Container.Sortable));
      return this;
    }

    public GridBuilder<T> Sortable()
    {
      this.Container.Sortable.Enabled = new bool?(true);
      return this;
    }

    public GridBuilder<T> Sortable(bool enabled)
    {
      this.Container.Sortable.Enabled = new bool?(enabled);
      return this;
    }

    public GridBuilder<T> LoaderType(GridLoaderType value)
    {
      this.Container.LoaderType = new GridLoaderType?(value);
      return this;
    }

    public GridBuilder<T> Events(Action<GridEventBuilder> configurator)
    {
      configurator(new GridEventBuilder(this.Container.Events));
      return this;
    }
  }
}
