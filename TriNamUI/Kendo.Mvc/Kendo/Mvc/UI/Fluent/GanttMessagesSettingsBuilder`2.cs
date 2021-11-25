// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.GanttMessagesSettingsBuilder`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class GanttMessagesSettingsBuilder<TTaskModel, TDependenciesModel>
    where TTaskModel : class, IGanttTask
    where TDependenciesModel : class, IGanttDependency
  {
    public GanttMessagesSettingsBuilder(
      GanttMessagesSettings<TTaskModel, TDependenciesModel> container)
    {
      this.Container = container;
    }

    protected GanttMessagesSettings<TTaskModel, TDependenciesModel> Container { get; private set; }

    public GanttMessagesSettingsBuilder<TTaskModel, TDependenciesModel> Actions(
      Action<GanttMessagesActionsSettingsBuilder<TTaskModel, TDependenciesModel>> configurator)
    {
      this.Container.Actions.Gantt = this.Container.Gantt;
      configurator(new GanttMessagesActionsSettingsBuilder<TTaskModel, TDependenciesModel>(this.Container.Actions));
      return this;
    }

    public GanttMessagesSettingsBuilder<TTaskModel, TDependenciesModel> Cancel(
      string value)
    {
      this.Container.Cancel = value;
      return this;
    }

    public GanttMessagesSettingsBuilder<TTaskModel, TDependenciesModel> DeleteDependencyConfirmation(
      string value)
    {
      this.Container.DeleteDependencyConfirmation = value;
      return this;
    }

    public GanttMessagesSettingsBuilder<TTaskModel, TDependenciesModel> DeleteDependencyWindowTitle(
      string value)
    {
      this.Container.DeleteDependencyWindowTitle = value;
      return this;
    }

    public GanttMessagesSettingsBuilder<TTaskModel, TDependenciesModel> DeleteTaskConfirmation(
      string value)
    {
      this.Container.DeleteTaskConfirmation = value;
      return this;
    }

    public GanttMessagesSettingsBuilder<TTaskModel, TDependenciesModel> DeleteTaskWindowTitle(
      string value)
    {
      this.Container.DeleteTaskWindowTitle = value;
      return this;
    }

    public GanttMessagesSettingsBuilder<TTaskModel, TDependenciesModel> Destroy(
      string value)
    {
      this.Container.Destroy = value;
      return this;
    }

    public GanttMessagesSettingsBuilder<TTaskModel, TDependenciesModel> Editor(
      Action<GanttMessagesEditorSettingsBuilder<TTaskModel, TDependenciesModel>> configurator)
    {
      this.Container.Editor.Gantt = this.Container.Gantt;
      configurator(new GanttMessagesEditorSettingsBuilder<TTaskModel, TDependenciesModel>(this.Container.Editor));
      return this;
    }

    public GanttMessagesSettingsBuilder<TTaskModel, TDependenciesModel> PlannedTasks(
      Action<GanttMessagesPlannedTasksSettingsBuilder<TTaskModel, TDependenciesModel>> configurator)
    {
      this.Container.PlannedTasks.Gantt = this.Container.Gantt;
      configurator(new GanttMessagesPlannedTasksSettingsBuilder<TTaskModel, TDependenciesModel>(this.Container.PlannedTasks));
      return this;
    }

    public GanttMessagesSettingsBuilder<TTaskModel, TDependenciesModel> Save(
      string value)
    {
      this.Container.Save = value;
      return this;
    }

    public GanttMessagesSettingsBuilder<TTaskModel, TDependenciesModel> Views(
      Action<GanttMessagesViewsSettingsBuilder<TTaskModel, TDependenciesModel>> configurator)
    {
      this.Container.Views.Gantt = this.Container.Gantt;
      configurator(new GanttMessagesViewsSettingsBuilder<TTaskModel, TDependenciesModel>(this.Container.Views));
      return this;
    }
  }
}
