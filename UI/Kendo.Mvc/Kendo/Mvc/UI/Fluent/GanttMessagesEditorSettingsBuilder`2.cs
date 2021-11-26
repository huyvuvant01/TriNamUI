// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.GanttMessagesEditorSettingsBuilder`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class GanttMessagesEditorSettingsBuilder<TTaskModel, TDependenciesModel>
    where TTaskModel : class, IGanttTask
    where TDependenciesModel : class, IGanttDependency
  {
    public GanttMessagesEditorSettingsBuilder(
      GanttMessagesEditorSettings<TTaskModel, TDependenciesModel> container)
    {
      this.Container = container;
    }

    protected GanttMessagesEditorSettings<TTaskModel, TDependenciesModel> Container { get; private set; }

    public GanttMessagesEditorSettingsBuilder<TTaskModel, TDependenciesModel> AssignButton(
      string value)
    {
      this.Container.AssignButton = value;
      return this;
    }

    public GanttMessagesEditorSettingsBuilder<TTaskModel, TDependenciesModel> EditorTitle(
      string value)
    {
      this.Container.EditorTitle = value;
      return this;
    }

    public GanttMessagesEditorSettingsBuilder<TTaskModel, TDependenciesModel> End(
      string value)
    {
      this.Container.End = value;
      return this;
    }

    public GanttMessagesEditorSettingsBuilder<TTaskModel, TDependenciesModel> PercentComplete(
      string value)
    {
      this.Container.PercentComplete = value;
      return this;
    }

    public GanttMessagesEditorSettingsBuilder<TTaskModel, TDependenciesModel> PlannedEnd(
      string value)
    {
      this.Container.PlannedEnd = value;
      return this;
    }

    public GanttMessagesEditorSettingsBuilder<TTaskModel, TDependenciesModel> PlannedStart(
      string value)
    {
      this.Container.PlannedStart = value;
      return this;
    }

    public GanttMessagesEditorSettingsBuilder<TTaskModel, TDependenciesModel> Resources(
      string value)
    {
      this.Container.Resources = value;
      return this;
    }

    public GanttMessagesEditorSettingsBuilder<TTaskModel, TDependenciesModel> ResourcesEditorTitle(
      string value)
    {
      this.Container.ResourcesEditorTitle = value;
      return this;
    }

    public GanttMessagesEditorSettingsBuilder<TTaskModel, TDependenciesModel> ResourcesHeader(
      string value)
    {
      this.Container.ResourcesHeader = value;
      return this;
    }

    public GanttMessagesEditorSettingsBuilder<TTaskModel, TDependenciesModel> Start(
      string value)
    {
      this.Container.Start = value;
      return this;
    }

    public GanttMessagesEditorSettingsBuilder<TTaskModel, TDependenciesModel> Title(
      string value)
    {
      this.Container.Title = value;
      return this;
    }

    public GanttMessagesEditorSettingsBuilder<TTaskModel, TDependenciesModel> UnitsHeader(
      string value)
    {
      this.Container.UnitsHeader = value;
      return this;
    }
  }
}
