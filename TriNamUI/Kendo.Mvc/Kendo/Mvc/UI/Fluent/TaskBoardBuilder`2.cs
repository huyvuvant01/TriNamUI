// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.TaskBoardBuilder`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class TaskBoardBuilder<TCard, TColumn> : 
    WidgetBuilderBase<TaskBoard<TCard, TColumn>, TaskBoardBuilder<TCard, TColumn>>
    where TCard : class
    where TColumn : class
  {
    public TaskBoardBuilder(TaskBoard<TCard, TColumn> component)
      : base(component)
    {
    }

    public TaskBoardBuilder<TCard, TColumn> BindTo(IEnumerable<TCard> dataSource)
    {
      this.Component.DataSource.Data = (IEnumerable) dataSource;
      return this;
    }

    public TaskBoardBuilder<TCard, TColumn> BindTo(IEnumerable dataSource)
    {
      this.Component.DataSource.Data = (IEnumerable) new CustomGroupingWrapper<TCard>(dataSource);
      return this;
    }

    public TaskBoardBuilder<TCard, TColumn> DataSource(
      Action<DataSourceBuilder<TCard>> configurator)
    {
      configurator(new DataSourceBuilder<TCard>(this.Component.DataSource, this.Component.ViewContext, this.Component.UrlGenerator));
      return this;
    }

    public TaskBoardBuilder<TCard, TColumn> DataSource(string dataSourceId)
    {
      this.Component.DataSourceId = dataSourceId;
      return this;
    }

    public TaskBoardBuilder<TCard, TColumn> Columns(IEnumerable<TColumn> dataSource)
    {
      this.Component.Columns.Data = (IEnumerable) dataSource;
      return this;
    }

    public TaskBoardBuilder<TCard, TColumn> Columns(IEnumerable dataSource)
    {
      this.Component.Columns.Data = (IEnumerable) new CustomGroupingWrapper<TColumn>(dataSource);
      return this;
    }

    public TaskBoardBuilder<TCard, TColumn> Columns(
      Action<DataSourceBuilder<TColumn>> configurator)
    {
      configurator(new DataSourceBuilder<TColumn>(this.Component.Columns, this.Component.ViewContext, this.Component.UrlGenerator));
      return this;
    }

    public TaskBoardBuilder<TCard, TColumn> ColumnsId(string dataSourceId)
    {
      this.Component.ColumnsId = dataSourceId;
      return this;
    }

    public TaskBoardBuilder<TCard, TColumn> Columns(
      Action<TaskBoardColumnsBuilder> configurator)
    {
      configurator(new TaskBoardColumnsBuilder(this.Component.Columns));
      if (string.IsNullOrEmpty(this.Component.ColumnSettings.DataStatusField) && string.IsNullOrEmpty(this.Component.ColumnSettings.DataTextField))
      {
        this.Component.ColumnSettings.DataStatusField = "Status";
        this.Component.ColumnSettings.DataTextField = "Text";
      }
      return this;
    }

    public TaskBoardBuilder<TCard, TColumn> AutoBind(bool value)
    {
      this.Container.AutoBind = new bool?(value);
      return this;
    }

    public TaskBoardBuilder<TCard, TColumn> CardMenu(
      Action<TaskBoardCardMenuFactory<TCard, TColumn>> configurator)
    {
      configurator(new TaskBoardCardMenuFactory<TCard, TColumn>(this.Container.CardMenu)
      {
        TaskBoard = this.Container
      });
      return this;
    }

    public TaskBoardBuilder<TCard, TColumn> ColumnSettings(
      Action<TaskBoardColumnSettingsSettingsBuilder<TCard, TColumn>> configurator)
    {
      this.Container.ColumnSettings.TaskBoard = this.Container;
      configurator(new TaskBoardColumnSettingsSettingsBuilder<TCard, TColumn>(this.Container.ColumnSettings));
      return this;
    }

    public TaskBoardBuilder<TCard, TColumn> DataOrderField(string value)
    {
      this.Container.DataOrderField = value;
      return this;
    }

    public TaskBoardBuilder<TCard, TColumn> DataCategoryField(string value)
    {
      this.Container.DataCategoryField = value;
      return this;
    }

    public TaskBoardBuilder<TCard, TColumn> DataDescriptionField(string value)
    {
      this.Container.DataDescriptionField = value;
      return this;
    }

    public TaskBoardBuilder<TCard, TColumn> DataStatusField(string value)
    {
      this.Container.DataStatusField = value;
      return this;
    }

    public TaskBoardBuilder<TCard, TColumn> DataTitleField(string value)
    {
      this.Container.DataTitleField = value;
      return this;
    }

    public TaskBoardBuilder<TCard, TColumn> Editable(
      Action<TaskBoardEditableSettingsBuilder<TCard, TColumn>> configurator)
    {
      this.Container.Editable.Enabled = new bool?(true);
      this.Container.Editable.TaskBoard = this.Container;
      configurator(new TaskBoardEditableSettingsBuilder<TCard, TColumn>(this.Container.Editable));
      return this;
    }

    public TaskBoardBuilder<TCard, TColumn> Editable(bool enabled)
    {
      this.Container.Editable.Enabled = new bool?(enabled);
      return this;
    }

    public TaskBoardBuilder<TCard, TColumn> Height(string value)
    {
      this.Container.Height = value;
      return this;
    }

    public TaskBoardBuilder<TCard, TColumn> PreviewPane(
      Action<TaskBoardPreviewPaneSettingsBuilder<TCard, TColumn>> configurator)
    {
      this.Container.PreviewPane.Enabled = new bool?(true);
      this.Container.PreviewPane.TaskBoard = this.Container;
      configurator(new TaskBoardPreviewPaneSettingsBuilder<TCard, TColumn>(this.Container.PreviewPane));
      return this;
    }

    public TaskBoardBuilder<TCard, TColumn> PreviewPane(bool enabled)
    {
      this.Container.PreviewPane.Enabled = new bool?(enabled);
      return this;
    }

    public TaskBoardBuilder<TCard, TColumn> Reorderable(bool value)
    {
      this.Container.Reorderable = new bool?(value);
      return this;
    }

    public TaskBoardBuilder<TCard, TColumn> Resources(
      Action<TaskBoardResourceFactory<TCard, TColumn>> configurator)
    {
      configurator(new TaskBoardResourceFactory<TCard, TColumn>(this.Container.Resources)
      {
        TaskBoard = this.Container
      });
      return this;
    }

    public TaskBoardBuilder<TCard, TColumn> Selectable(bool value)
    {
      this.Container.Selectable = new bool?(value);
      return this;
    }

    public TaskBoardBuilder<TCard, TColumn> Template(string value)
    {
      this.Container.Template = value;
      return this;
    }

    public TaskBoardBuilder<TCard, TColumn> TemplateId(string templateId)
    {
      this.Container.TemplateId = templateId;
      return this;
    }

    public TaskBoardBuilder<TCard, TColumn> Toolbar(
      Action<TaskBoardToolbarSettingsBuilder<TCard, TColumn>> configurator)
    {
      this.Container.Toolbar.Enabled = new bool?(true);
      this.Container.Toolbar.TaskBoard = this.Container;
      configurator(new TaskBoardToolbarSettingsBuilder<TCard, TColumn>(this.Container.Toolbar));
      return this;
    }

    public TaskBoardBuilder<TCard, TColumn> Toolbar(bool enabled)
    {
      this.Container.Toolbar.Enabled = new bool?(enabled);
      return this;
    }

    public TaskBoardBuilder<TCard, TColumn> Width(string value)
    {
      this.Container.Width = value;
      return this;
    }

    public TaskBoardBuilder<TCard, TColumn> Messages(
      Action<TaskBoardMessagesSettingsBuilder<TCard, TColumn>> configurator)
    {
      this.Container.Messages.TaskBoard = this.Container;
      configurator(new TaskBoardMessagesSettingsBuilder<TCard, TColumn>(this.Container.Messages));
      return this;
    }

    public TaskBoardBuilder<TCard, TColumn> Events(
      Action<TaskBoardEventBuilder> configurator)
    {
      configurator(new TaskBoardEventBuilder(this.Container.Events));
      return this;
    }
  }
}
