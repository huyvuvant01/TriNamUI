// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.GanttMessagesViewsSettingsBuilder`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class GanttMessagesViewsSettingsBuilder<TTaskModel, TDependenciesModel>
    where TTaskModel : class, IGanttTask
    where TDependenciesModel : class, IGanttDependency
  {
    public GanttMessagesViewsSettingsBuilder(
      GanttMessagesViewsSettings<TTaskModel, TDependenciesModel> container)
    {
      this.Container = container;
    }

    protected GanttMessagesViewsSettings<TTaskModel, TDependenciesModel> Container { get; private set; }

    public GanttMessagesViewsSettingsBuilder<TTaskModel, TDependenciesModel> Day(
      string value)
    {
      this.Container.Day = value;
      return this;
    }

    public GanttMessagesViewsSettingsBuilder<TTaskModel, TDependenciesModel> End(
      string value)
    {
      this.Container.End = value;
      return this;
    }

    public GanttMessagesViewsSettingsBuilder<TTaskModel, TDependenciesModel> Month(
      string value)
    {
      this.Container.Month = value;
      return this;
    }

    public GanttMessagesViewsSettingsBuilder<TTaskModel, TDependenciesModel> Start(
      string value)
    {
      this.Container.Start = value;
      return this;
    }

    public GanttMessagesViewsSettingsBuilder<TTaskModel, TDependenciesModel> Week(
      string value)
    {
      this.Container.Week = value;
      return this;
    }

    public GanttMessagesViewsSettingsBuilder<TTaskModel, TDependenciesModel> Year(
      string value)
    {
      this.Container.Year = value;
      return this;
    }
  }
}
