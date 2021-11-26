// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.GanttViewFactory`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class GanttViewFactory<TTaskModel, TDependenciesModel>
    where TTaskModel : class, IGanttTask
    where TDependenciesModel : class, IGanttDependency
  {
    public GanttViewFactory(
      List<GanttView<TTaskModel, TDependenciesModel>> container)
    {
      this.Container = container;
    }

    protected List<GanttView<TTaskModel, TDependenciesModel>> Container { get; private set; }

    private GanttViewBuilder<TTaskModel, TDependenciesModel> Add(GanttViewType type)
    {
      GanttView<TTaskModel, TDependenciesModel> container = new GanttView<TTaskModel, TDependenciesModel>()
      {
        Type = new GanttViewType?(type)
      };
      container.Gantt = this.Gantt;
      this.Container.Add(container);
      return new GanttViewBuilder<TTaskModel, TDependenciesModel>(container);
    }

    public virtual GanttViewBuilder<TTaskModel, TDependenciesModel> DayView(
      Action<GanttViewBuilder<TTaskModel, TDependenciesModel>> addViewAction)
    {
      GanttViewBuilder<TTaskModel, TDependenciesModel> ganttViewBuilder = this.Add(GanttViewType.Day);
      addViewAction(ganttViewBuilder);
      return ganttViewBuilder;
    }

    public void DayView() => this.Add(GanttViewType.Day);

    public virtual GanttViewBuilder<TTaskModel, TDependenciesModel> WeekView(
      Action<GanttViewBuilder<TTaskModel, TDependenciesModel>> addViewAction)
    {
      GanttViewBuilder<TTaskModel, TDependenciesModel> ganttViewBuilder = this.Add(GanttViewType.Week);
      addViewAction(ganttViewBuilder);
      return ganttViewBuilder;
    }

    public void WeekView() => this.Add(GanttViewType.Week);

    public virtual GanttViewBuilder<TTaskModel, TDependenciesModel> MonthView(
      Action<GanttViewBuilder<TTaskModel, TDependenciesModel>> addViewAction)
    {
      GanttViewBuilder<TTaskModel, TDependenciesModel> ganttViewBuilder = this.Add(GanttViewType.Month);
      addViewAction(ganttViewBuilder);
      return ganttViewBuilder;
    }

    public void MonthView() => this.Add(GanttViewType.Month);

    public virtual GanttViewBuilder<TTaskModel, TDependenciesModel> YearView(
      Action<GanttViewBuilder<TTaskModel, TDependenciesModel>> addViewAction)
    {
      GanttViewBuilder<TTaskModel, TDependenciesModel> ganttViewBuilder = this.Add(GanttViewType.Year);
      addViewAction(ganttViewBuilder);
      return ganttViewBuilder;
    }

    public void YearView() => this.Add(GanttViewType.Year);

    public Kendo.Mvc.UI.Gantt<TTaskModel, TDependenciesModel> Gantt { get; set; }

    public virtual GanttViewBuilder<TTaskModel, TDependenciesModel> Add()
    {
      GanttView<TTaskModel, TDependenciesModel> container = new GanttView<TTaskModel, TDependenciesModel>();
      container.Gantt = this.Gantt;
      this.Container.Add(container);
      return new GanttViewBuilder<TTaskModel, TDependenciesModel>(container);
    }
  }
}
