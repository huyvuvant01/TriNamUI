// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.GanttBuilder`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class GanttBuilder<TTaskModel, TDependenciesModel> : 
    WidgetBuilderBase<Gantt<TTaskModel, TDependenciesModel>, GanttBuilder<TTaskModel, TDependenciesModel>>
    where TTaskModel : class, IGanttTask
    where TDependenciesModel : class, IGanttDependency
  {
    public GanttBuilder(Gantt<TTaskModel, TDependenciesModel> component)
      : base(component)
    {
    }

    public GanttBuilder<TTaskModel, TDependenciesModel> DataSource(
      Action<GanttDataSourceBuilder<TTaskModel>> configurator)
    {
      configurator(new GanttDataSourceBuilder<TTaskModel>(this.Component.DataSource, this.Component.ViewContext, this.Component.UrlGenerator));
      return this;
    }

    public GanttBuilder<TTaskModel, TDependenciesModel> DataSource(string dataSourceId)
    {
      this.Component.DataSourceId = dataSourceId;
      return this;
    }

    public GanttBuilder<TTaskModel, TDependenciesModel> DependenciesDataSource(
      string dataSourceId)
    {
      this.Component.DependenciesDataSourceId = dataSourceId;
      return this;
    }

    public GanttBuilder<TTaskModel, TDependenciesModel> DependenciesDataSource(
      Action<GanttDependenciesDataSourceBuilder<TDependenciesModel>> configurator)
    {
      configurator(new GanttDependenciesDataSourceBuilder<TDependenciesModel>(this.Component.DependenciesDataSource, this.Component.ViewContext, this.Component.UrlGenerator));
      return this;
    }

    public GanttBuilder<TTaskModel, TDependenciesModel> Assignments<TAssingmentModel>(
      Action<GanttAssignmentsSettingsBuilder<TAssingmentModel>> configurator)
      where TAssingmentModel : class
    {
      configurator(new GanttAssignmentsSettingsBuilder<TAssingmentModel>(this.Component.Assignments, this.Component.ViewContext, this.Component.UrlGenerator));
      return this;
    }

    public GanttBuilder<TTaskModel, TDependenciesModel> Resources(
      Action<GanttResourcesSettingsBuilder> configurator)
    {
      configurator(new GanttResourcesSettingsBuilder(this.Component.Resources, this.Component.ViewContext, this.Component.UrlGenerator));
      return this;
    }

    public GanttBuilder<TTaskModel, TDependenciesModel> AutoBind(bool value)
    {
      this.Container.AutoBind = new bool?(value);
      return this;
    }

    public GanttBuilder<TTaskModel, TDependenciesModel> ColumnResizeHandleWidth(
      double value)
    {
      this.Container.ColumnResizeHandleWidth = new double?(value);
      return this;
    }

    public GanttBuilder<TTaskModel, TDependenciesModel> ColumnMenu(bool value)
    {
      this.Container.ColumnMenu = new bool?(value);
      return this;
    }

    public GanttBuilder<TTaskModel, TDependenciesModel> ColumnMenu()
    {
      this.Container.ColumnMenu = new bool?(true);
      return this;
    }

    public GanttBuilder<TTaskModel, TDependenciesModel> Columns(
      Action<GanttColumnFactory<TTaskModel, TDependenciesModel>> configurator)
    {
      configurator(new GanttColumnFactory<TTaskModel, TDependenciesModel>(this.Container.Columns)
      {
        Gantt = this.Container
      });
      return this;
    }

    public GanttBuilder<TTaskModel, TDependenciesModel> CurrentTimeMarker(
      Action<GanttCurrentTimeMarkerSettingsBuilder<TTaskModel, TDependenciesModel>> configurator)
    {
      this.Container.CurrentTimeMarker.Enabled = new bool?(true);
      this.Container.CurrentTimeMarker.Gantt = this.Container;
      configurator(new GanttCurrentTimeMarkerSettingsBuilder<TTaskModel, TDependenciesModel>(this.Container.CurrentTimeMarker));
      return this;
    }

    public GanttBuilder<TTaskModel, TDependenciesModel> CurrentTimeMarker(bool enabled)
    {
      this.Container.CurrentTimeMarker.Enabled = new bool?(enabled);
      return this;
    }

    public GanttBuilder<TTaskModel, TDependenciesModel> Date(DateTime value)
    {
      this.Container.Date = new DateTime?(value);
      return this;
    }

    public GanttBuilder<TTaskModel, TDependenciesModel> Editable(
      Action<GanttEditableSettingsBuilder<TTaskModel, TDependenciesModel>> configurator)
    {
      this.Container.Editable.Enabled = new bool?(true);
      this.Container.Editable.Gantt = this.Container;
      configurator(new GanttEditableSettingsBuilder<TTaskModel, TDependenciesModel>(this.Container.Editable));
      return this;
    }

    public GanttBuilder<TTaskModel, TDependenciesModel> Editable(bool enabled)
    {
      this.Container.Editable.Enabled = new bool?(enabled);
      return this;
    }

    public GanttBuilder<TTaskModel, TDependenciesModel> Filterable(bool value)
    {
      this.Container.Filterable = new bool?(value);
      return this;
    }

    public GanttBuilder<TTaskModel, TDependenciesModel> Filterable()
    {
      this.Container.Filterable = new bool?(true);
      return this;
    }

    public GanttBuilder<TTaskModel, TDependenciesModel> Reorderable(bool value)
    {
      this.Container.Reorderable = new bool?(value);
      return this;
    }

    public GanttBuilder<TTaskModel, TDependenciesModel> Reorderable()
    {
      this.Container.Reorderable = new bool?(true);
      return this;
    }

    public GanttBuilder<TTaskModel, TDependenciesModel> Navigatable(bool value)
    {
      this.Container.Navigatable = new bool?(value);
      return this;
    }

    public GanttBuilder<TTaskModel, TDependenciesModel> Navigatable()
    {
      this.Container.Navigatable = new bool?(true);
      return this;
    }

    public GanttBuilder<TTaskModel, TDependenciesModel> WorkDayStart(DateTime value)
    {
      this.Container.WorkDayStart = new DateTime?(value);
      return this;
    }

    public GanttBuilder<TTaskModel, TDependenciesModel> WorkDayEnd(DateTime value)
    {
      this.Container.WorkDayEnd = new DateTime?(value);
      return this;
    }

    public GanttBuilder<TTaskModel, TDependenciesModel> WorkWeekStart(double value)
    {
      this.Container.WorkWeekStart = new double?(value);
      return this;
    }

    public GanttBuilder<TTaskModel, TDependenciesModel> WorkWeekEnd(double value)
    {
      this.Container.WorkWeekEnd = new double?(value);
      return this;
    }

    public GanttBuilder<TTaskModel, TDependenciesModel> HourSpan(double value)
    {
      this.Container.HourSpan = new double?(value);
      return this;
    }

    public GanttBuilder<TTaskModel, TDependenciesModel> Snap(bool value)
    {
      this.Container.Snap = new bool?(value);
      return this;
    }

    public GanttBuilder<TTaskModel, TDependenciesModel> Height(double value)
    {
      this.Container.Height = new double?(value);
      return this;
    }

    public GanttBuilder<TTaskModel, TDependenciesModel> ListWidth(string value)
    {
      this.Container.ListWidth = value;
      return this;
    }

    public GanttBuilder<TTaskModel, TDependenciesModel> Messages(
      Action<GanttMessagesSettingsBuilder<TTaskModel, TDependenciesModel>> configurator)
    {
      this.Container.Messages.Gantt = this.Container;
      configurator(new GanttMessagesSettingsBuilder<TTaskModel, TDependenciesModel>(this.Container.Messages));
      return this;
    }

    public GanttBuilder<TTaskModel, TDependenciesModel> Pdf(
      Action<GanttPdfSettingsBuilder<TTaskModel, TDependenciesModel>> configurator)
    {
      this.Container.Pdf.Gantt = this.Container;
      configurator(new GanttPdfSettingsBuilder<TTaskModel, TDependenciesModel>(this.Container.Pdf));
      return this;
    }

    public GanttBuilder<TTaskModel, TDependenciesModel> Range(
      Action<GanttRangeSettingsBuilder<TTaskModel, TDependenciesModel>> configurator)
    {
      this.Container.Range.Gantt = this.Container;
      configurator(new GanttRangeSettingsBuilder<TTaskModel, TDependenciesModel>(this.Container.Range));
      return this;
    }

    public GanttBuilder<TTaskModel, TDependenciesModel> Resizable(bool value)
    {
      this.Container.Resizable = new bool?(value);
      return this;
    }

    public GanttBuilder<TTaskModel, TDependenciesModel> Resizable()
    {
      this.Container.Resizable = new bool?(true);
      return this;
    }

    public GanttBuilder<TTaskModel, TDependenciesModel> Selectable(bool value)
    {
      this.Container.Selectable = new bool?(value);
      return this;
    }

    public GanttBuilder<TTaskModel, TDependenciesModel> ShowPlannedTasks(bool value)
    {
      this.Container.ShowPlannedTasks = new bool?(value);
      return this;
    }

    public GanttBuilder<TTaskModel, TDependenciesModel> ShowPlannedTasks()
    {
      this.Container.ShowPlannedTasks = new bool?(true);
      return this;
    }

    public GanttBuilder<TTaskModel, TDependenciesModel> ShowWorkDays(bool value)
    {
      this.Container.ShowWorkDays = new bool?(value);
      return this;
    }

    public GanttBuilder<TTaskModel, TDependenciesModel> ShowWorkHours(bool value)
    {
      this.Container.ShowWorkHours = new bool?(value);
      return this;
    }

    public GanttBuilder<TTaskModel, TDependenciesModel> TaskTemplate(string value)
    {
      this.Container.TaskTemplate = value;
      return this;
    }

    public GanttBuilder<TTaskModel, TDependenciesModel> TaskTemplateId(string templateId)
    {
      this.Container.TaskTemplateId = templateId;
      return this;
    }

    public GanttBuilder<TTaskModel, TDependenciesModel> Toolbar(
      Action<GanttToolbarFactory<TTaskModel, TDependenciesModel>> configurator)
    {
      configurator(new GanttToolbarFactory<TTaskModel, TDependenciesModel>(this.Container.Toolbar)
      {
        Gantt = this.Container
      });
      return this;
    }

    public GanttBuilder<TTaskModel, TDependenciesModel> Tooltip(
      Action<GanttTooltipSettingsBuilder<TTaskModel, TDependenciesModel>> configurator)
    {
      this.Container.Tooltip.Gantt = this.Container;
      configurator(new GanttTooltipSettingsBuilder<TTaskModel, TDependenciesModel>(this.Container.Tooltip));
      return this;
    }

    public GanttBuilder<TTaskModel, TDependenciesModel> Views(
      Action<GanttViewFactory<TTaskModel, TDependenciesModel>> configurator)
    {
      configurator(new GanttViewFactory<TTaskModel, TDependenciesModel>(this.Container.Views)
      {
        Gantt = this.Container
      });
      return this;
    }

    public GanttBuilder<TTaskModel, TDependenciesModel> RowHeight(double value)
    {
      this.Container.RowHeight = new double?(value);
      return this;
    }

    public GanttBuilder<TTaskModel, TDependenciesModel> Events(
      Action<GanttEventBuilder> configurator)
    {
      configurator(new GanttEventBuilder(this.Container.Events));
      return this;
    }
  }
}
