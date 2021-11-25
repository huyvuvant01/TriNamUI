// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.GanttEditableSettingsBuilder`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class GanttEditableSettingsBuilder<TTaskModel, TDependenciesModel>
    where TTaskModel : class, IGanttTask
    where TDependenciesModel : class, IGanttDependency
  {
    public GanttEditableSettingsBuilder(
      GanttEditableSettings<TTaskModel, TDependenciesModel> container)
    {
      this.Container = container;
    }

    protected GanttEditableSettings<TTaskModel, TDependenciesModel> Container { get; private set; }

    public GanttEditableSettingsBuilder<TTaskModel, TDependenciesModel> Confirmation(
      bool value)
    {
      this.Container.Confirmation = new bool?(value);
      return this;
    }

    public GanttEditableSettingsBuilder<TTaskModel, TDependenciesModel> Create(
      bool value)
    {
      this.Container.Create = new bool?(value);
      return this;
    }

    public GanttEditableSettingsBuilder<TTaskModel, TDependenciesModel> DependencyCreate(
      bool value)
    {
      this.Container.DependencyCreate = new bool?(value);
      return this;
    }

    public GanttEditableSettingsBuilder<TTaskModel, TDependenciesModel> DependencyDestroy(
      bool value)
    {
      this.Container.DependencyDestroy = new bool?(value);
      return this;
    }

    public GanttEditableSettingsBuilder<TTaskModel, TDependenciesModel> DragPercentComplete(
      bool value)
    {
      this.Container.DragPercentComplete = new bool?(value);
      return this;
    }

    public GanttEditableSettingsBuilder<TTaskModel, TDependenciesModel> Destroy(
      bool value)
    {
      this.Container.Destroy = new bool?(value);
      return this;
    }

    public GanttEditableSettingsBuilder<TTaskModel, TDependenciesModel> Move(
      bool value)
    {
      this.Container.Move = new bool?(value);
      return this;
    }

    public GanttEditableSettingsBuilder<TTaskModel, TDependenciesModel> PlannedTasks(
      bool value)
    {
      this.Container.PlannedTasks = new bool?(value);
      return this;
    }

    public GanttEditableSettingsBuilder<TTaskModel, TDependenciesModel> PlannedTasks()
    {
      this.Container.PlannedTasks = new bool?(true);
      return this;
    }

    public GanttEditableSettingsBuilder<TTaskModel, TDependenciesModel> Reorder(
      bool value)
    {
      this.Container.Reorder = new bool?(value);
      return this;
    }

    public GanttEditableSettingsBuilder<TTaskModel, TDependenciesModel> Resize(
      bool value)
    {
      this.Container.Resize = new bool?(value);
      return this;
    }

    public GanttEditableSettingsBuilder<TTaskModel, TDependenciesModel> Template(
      string value)
    {
      this.Container.Template = value;
      return this;
    }

    public GanttEditableSettingsBuilder<TTaskModel, TDependenciesModel> TemplateId(
      string templateId)
    {
      this.Container.TemplateId = templateId;
      return this;
    }

    public GanttEditableSettingsBuilder<TTaskModel, TDependenciesModel> Update(
      bool value)
    {
      this.Container.Update = new bool?(value);
      return this;
    }
  }
}
