// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.GanttMessagesPlannedTasksSettingsBuilder`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class GanttMessagesPlannedTasksSettingsBuilder<TTaskModel, TDependenciesModel>
    where TTaskModel : class, IGanttTask
    where TDependenciesModel : class, IGanttDependency
  {
    public GanttMessagesPlannedTasksSettingsBuilder(
      GanttMessagesPlannedTasksSettings<TTaskModel, TDependenciesModel> container)
    {
      this.Container = container;
    }

    protected GanttMessagesPlannedTasksSettings<TTaskModel, TDependenciesModel> Container { get; private set; }

    public GanttMessagesPlannedTasksSettingsBuilder<TTaskModel, TDependenciesModel> SwitchText(
      string value)
    {
      this.Container.SwitchText = value;
      return this;
    }

    public GanttMessagesPlannedTasksSettingsBuilder<TTaskModel, TDependenciesModel> OffsetTooltipAdvanced(
      string value)
    {
      this.Container.OffsetTooltipAdvanced = value;
      return this;
    }

    public GanttMessagesPlannedTasksSettingsBuilder<TTaskModel, TDependenciesModel> OffsetTooltipDelay(
      string value)
    {
      this.Container.OffsetTooltipDelay = value;
      return this;
    }

    public GanttMessagesPlannedTasksSettingsBuilder<TTaskModel, TDependenciesModel> Seconds(
      string value)
    {
      this.Container.Seconds = value;
      return this;
    }

    public GanttMessagesPlannedTasksSettingsBuilder<TTaskModel, TDependenciesModel> Minutes(
      string value)
    {
      this.Container.Minutes = value;
      return this;
    }

    public GanttMessagesPlannedTasksSettingsBuilder<TTaskModel, TDependenciesModel> Hours(
      string value)
    {
      this.Container.Hours = value;
      return this;
    }

    public GanttMessagesPlannedTasksSettingsBuilder<TTaskModel, TDependenciesModel> Days(
      string value)
    {
      this.Container.Days = value;
      return this;
    }
  }
}
