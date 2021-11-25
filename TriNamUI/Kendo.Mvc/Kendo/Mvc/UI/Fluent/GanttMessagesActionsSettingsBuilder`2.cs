// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.GanttMessagesActionsSettingsBuilder`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class GanttMessagesActionsSettingsBuilder<TTaskModel, TDependenciesModel>
    where TTaskModel : class, IGanttTask
    where TDependenciesModel : class, IGanttDependency
  {
    public GanttMessagesActionsSettingsBuilder(
      GanttMessagesActionsSettings<TTaskModel, TDependenciesModel> container)
    {
      this.Container = container;
    }

    protected GanttMessagesActionsSettings<TTaskModel, TDependenciesModel> Container { get; private set; }

    public GanttMessagesActionsSettingsBuilder<TTaskModel, TDependenciesModel> AddChild(
      string value)
    {
      this.Container.AddChild = value;
      return this;
    }

    public GanttMessagesActionsSettingsBuilder<TTaskModel, TDependenciesModel> Append(
      string value)
    {
      this.Container.Append = value;
      return this;
    }

    public GanttMessagesActionsSettingsBuilder<TTaskModel, TDependenciesModel> InsertAfter(
      string value)
    {
      this.Container.InsertAfter = value;
      return this;
    }

    public GanttMessagesActionsSettingsBuilder<TTaskModel, TDependenciesModel> InsertBefore(
      string value)
    {
      this.Container.InsertBefore = value;
      return this;
    }

    public GanttMessagesActionsSettingsBuilder<TTaskModel, TDependenciesModel> Pdf(
      string value)
    {
      this.Container.Pdf = value;
      return this;
    }
  }
}
