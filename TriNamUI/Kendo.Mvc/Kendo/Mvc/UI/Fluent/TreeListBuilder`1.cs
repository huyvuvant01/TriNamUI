// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.TreeListBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class TreeListBuilder<T> : WidgetBuilderBase<TreeList<T>, TreeListBuilder<T>>
    where T : class
  {
    public TreeListBuilder(TreeList<T> component)
      : base(component)
    {
    }

    public TreeListBuilder<T> DataSource(
      Action<TreeListAjaxDataSourceBuilder<T>> configurator)
    {
      configurator(new TreeListAjaxDataSourceBuilder<T>(this.Component.DataSource, this.Component.ViewContext, this.Component.UrlGenerator));
      return this;
    }

    public TreeListBuilder<T> DataSource(string dataSourceId)
    {
      this.Component.DataSourceId = dataSourceId;
      return this;
    }

    public TreeListBuilder<T> Selectable()
    {
      this.Container.Selectable.Enabled = new bool?(true);
      return this;
    }

    public TreeListBuilder<T> AltRowTemplate(string value)
    {
      this.Container.AltRowTemplate = value;
      return this;
    }

    public TreeListBuilder<T> AltRowTemplateId(string templateId)
    {
      this.Container.AltRowTemplateId = templateId;
      return this;
    }

    public TreeListBuilder<T> AutoBind(bool value)
    {
      this.Container.AutoBind = new bool?(value);
      return this;
    }

    public TreeListBuilder<T> Columns(Action<TreeListColumnFactory<T>> configurator)
    {
      configurator(new TreeListColumnFactory<T>(this.Container.Columns)
      {
        TreeList = this.Container
      });
      return this;
    }

    public TreeListBuilder<T> Resizable(bool value)
    {
      this.Container.Resizable = new bool?(value);
      return this;
    }

    public TreeListBuilder<T> Resizable()
    {
      this.Container.Resizable = new bool?(true);
      return this;
    }

    public TreeListBuilder<T> Reorderable(bool value)
    {
      this.Container.Reorderable = new bool?(value);
      return this;
    }

    public TreeListBuilder<T> Reorderable()
    {
      this.Container.Reorderable = new bool?(true);
      return this;
    }

    public TreeListBuilder<T> ColumnMenu(
      Action<TreeListColumnMenuSettingsBuilder<T>> configurator)
    {
      this.Container.ColumnMenu.Enabled = new bool?(true);
      this.Container.ColumnMenu.TreeList = this.Container;
      configurator(new TreeListColumnMenuSettingsBuilder<T>(this.Container.ColumnMenu));
      return this;
    }

    public TreeListBuilder<T> ColumnMenu()
    {
      this.Container.ColumnMenu.Enabled = new bool?(true);
      return this;
    }

    public TreeListBuilder<T> ColumnMenu(bool enabled)
    {
      this.Container.ColumnMenu.Enabled = new bool?(enabled);
      return this;
    }

    public TreeListBuilder<T> Editable(
      Action<TreeListEditableSettingsBuilder<T>> configurator)
    {
      this.Container.Editable.Enabled = new bool?(true);
      this.Container.Editable.TreeList = this.Container;
      configurator(new TreeListEditableSettingsBuilder<T>(this.Container.Editable));
      return this;
    }

    public TreeListBuilder<T> Editable()
    {
      this.Container.Editable.Enabled = new bool?(true);
      return this;
    }

    public TreeListBuilder<T> Editable(bool enabled)
    {
      this.Container.Editable.Enabled = new bool?(enabled);
      return this;
    }

    public TreeListBuilder<T> Excel(
      Action<TreeListExcelSettingsBuilder<T>> configurator)
    {
      this.Container.Excel.TreeList = this.Container;
      configurator(new TreeListExcelSettingsBuilder<T>(this.Container.Excel));
      return this;
    }

    public TreeListBuilder<T> Filterable(
      Action<TreeListFilterableSettingsBuilder<T>> configurator)
    {
      this.Container.Filterable.Enabled = new bool?(true);
      this.Container.Filterable.TreeList = this.Container;
      configurator(new TreeListFilterableSettingsBuilder<T>(this.Container.Filterable));
      return this;
    }

    public TreeListBuilder<T> Filterable()
    {
      this.Container.Filterable.Enabled = new bool?(true);
      return this;
    }

    public TreeListBuilder<T> Filterable(bool enabled)
    {
      this.Container.Filterable.Enabled = new bool?(enabled);
      return this;
    }

    public TreeListBuilder<T> Height(double value)
    {
      this.Container.Height = new double?(value);
      return this;
    }

    public TreeListBuilder<T> Messages(
      Action<TreeListMessagesSettingsBuilder<T>> configurator)
    {
      this.Container.Messages.TreeList = this.Container;
      configurator(new TreeListMessagesSettingsBuilder<T>(this.Container.Messages));
      return this;
    }

    public TreeListBuilder<T> Navigatable(bool value)
    {
      this.Container.Navigatable = new bool?(value);
      return this;
    }

    public TreeListBuilder<T> Navigatable()
    {
      this.Container.Navigatable = new bool?(true);
      return this;
    }

    public TreeListBuilder<T> Pageable(
      Action<TreeListPageableSettingsBuilder<T>> configurator)
    {
      this.Container.Pageable.Enabled = new bool?(true);
      this.Container.Pageable.TreeList = this.Container;
      configurator(new TreeListPageableSettingsBuilder<T>(this.Container.Pageable));
      return this;
    }

    public TreeListBuilder<T> Pageable()
    {
      this.Container.Pageable.Enabled = new bool?(true);
      return this;
    }

    public TreeListBuilder<T> Pageable(bool enabled)
    {
      this.Container.Pageable.Enabled = new bool?(enabled);
      return this;
    }

    public TreeListBuilder<T> Pdf(Action<TreeListPdfSettingsBuilder<T>> configurator)
    {
      this.Container.Pdf.TreeList = this.Container;
      configurator(new TreeListPdfSettingsBuilder<T>(this.Container.Pdf));
      return this;
    }

    public TreeListBuilder<T> RowTemplate(string value)
    {
      this.Container.RowTemplate = value;
      return this;
    }

    public TreeListBuilder<T> RowTemplateId(string templateId)
    {
      this.Container.RowTemplateId = templateId;
      return this;
    }

    public TreeListBuilder<T> Scrollable(bool value)
    {
      this.Container.Scrollable = new bool?(value);
      return this;
    }

    public TreeListBuilder<T> Search(
      Action<TreeListSearchSettingsBuilder<T>> configurator)
    {
      this.Container.Search.TreeList = this.Container;
      configurator(new TreeListSearchSettingsBuilder<T>(this.Container.Search));
      return this;
    }

    public TreeListBuilder<T> Sortable(
      Action<TreeListSortableSettingsBuilder<T>> configurator)
    {
      this.Container.Sortable.Enabled = new bool?(true);
      this.Container.Sortable.TreeList = this.Container;
      configurator(new TreeListSortableSettingsBuilder<T>(this.Container.Sortable));
      return this;
    }

    public TreeListBuilder<T> Sortable()
    {
      this.Container.Sortable.Enabled = new bool?(true);
      return this;
    }

    public TreeListBuilder<T> Sortable(bool enabled)
    {
      this.Container.Sortable.Enabled = new bool?(enabled);
      return this;
    }

    public TreeListBuilder<T> Toolbar(Action<TreeListToolbarFactory<T>> configurator)
    {
      configurator(new TreeListToolbarFactory<T>(this.Container.Toolbar)
      {
        TreeList = this.Container
      });
      return this;
    }

    public TreeListBuilder<T> Selectable(
      Action<TreeListSelectableSettingsBuilder<T>> configurator)
    {
      this.Container.Selectable.Enabled = new bool?(true);
      this.Container.Selectable.TreeList = this.Container;
      configurator(new TreeListSelectableSettingsBuilder<T>(this.Container.Selectable));
      return this;
    }

    public TreeListBuilder<T> Selectable(bool enabled)
    {
      this.Container.Selectable.Enabled = new bool?(enabled);
      return this;
    }

    public TreeListBuilder<T> Events(Action<TreeListEventBuilder> configurator)
    {
      configurator(new TreeListEventBuilder(this.Container.Events));
      return this;
    }
  }
}
