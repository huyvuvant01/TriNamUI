// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.GanttToolbarFactory`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class GanttToolbarFactory<TTaskModel, TDependenciesModel>
    where TTaskModel : class, IGanttTask
    where TDependenciesModel : class, IGanttDependency
  {
    public GanttToolbarFactory(
      List<GanttToolbar<TTaskModel, TDependenciesModel>> container)
    {
      this.Container = container;
    }

    protected List<GanttToolbar<TTaskModel, TDependenciesModel>> Container { get; private set; }

    public virtual GanttToolbarBuilder<TTaskModel, TDependenciesModel> Add() => this.Custom();

    public Kendo.Mvc.UI.Gantt<TTaskModel, TDependenciesModel> Gantt { get; set; }

    public virtual GanttToolbarBuilder<TTaskModel, TDependenciesModel> Custom()
    {
      GanttToolbar<TTaskModel, TDependenciesModel> container = new GanttToolbar<TTaskModel, TDependenciesModel>();
      container.Gantt = this.Gantt;
      this.Container.Add(container);
      return new GanttToolbarBuilder<TTaskModel, TDependenciesModel>(container);
    }

    public virtual GanttToolbarBuilder<TTaskModel, TDependenciesModel> Append()
    {
      GanttToolbar<TTaskModel, TDependenciesModel> container = new GanttToolbar<TTaskModel, TDependenciesModel>()
      {
        Name = "append"
      };
      container.Gantt = this.Gantt;
      this.Container.Add(container);
      return new GanttToolbarBuilder<TTaskModel, TDependenciesModel>(container);
    }

    public virtual GanttToolbarBuilder<TTaskModel, TDependenciesModel> Pdf()
    {
      GanttToolbar<TTaskModel, TDependenciesModel> container = new GanttToolbar<TTaskModel, TDependenciesModel>()
      {
        Name = "pdf"
      };
      container.Gantt = this.Gantt;
      this.Container.Add(container);
      return new GanttToolbarBuilder<TTaskModel, TDependenciesModel>(container);
    }
  }
}
