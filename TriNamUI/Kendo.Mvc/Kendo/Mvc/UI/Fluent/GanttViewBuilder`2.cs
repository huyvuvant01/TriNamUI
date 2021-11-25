// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.GanttViewBuilder`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class GanttViewBuilder<TTaskModel, TDependenciesModel>
    where TTaskModel : class, IGanttTask
    where TDependenciesModel : class, IGanttDependency
  {
    public GanttViewBuilder(
      GanttView<TTaskModel, TDependenciesModel> container)
    {
      this.Container = container;
    }

    protected GanttView<TTaskModel, TDependenciesModel> Container { get; private set; }

    public GanttViewBuilder<TTaskModel, TDependenciesModel> Date(DateTime value)
    {
      this.Container.Date = new DateTime?(value);
      return this;
    }

    public GanttViewBuilder<TTaskModel, TDependenciesModel> Range(
      Action<GanttViewRangeSettingsBuilder<TTaskModel, TDependenciesModel>> configurator)
    {
      this.Container.Range.Gantt = this.Container.Gantt;
      configurator(new GanttViewRangeSettingsBuilder<TTaskModel, TDependenciesModel>(this.Container.Range));
      return this;
    }

    public GanttViewBuilder<TTaskModel, TDependenciesModel> Selected(bool value)
    {
      this.Container.Selected = new bool?(value);
      return this;
    }

    public GanttViewBuilder<TTaskModel, TDependenciesModel> Selected()
    {
      this.Container.Selected = new bool?(true);
      return this;
    }

    public GanttViewBuilder<TTaskModel, TDependenciesModel> SlotSize(double value)
    {
      this.Container.SlotSize = new double?(value);
      return this;
    }

    public GanttViewBuilder<TTaskModel, TDependenciesModel> TimeHeaderTemplate(
      string value)
    {
      this.Container.TimeHeaderTemplate = value;
      return this;
    }

    public GanttViewBuilder<TTaskModel, TDependenciesModel> TimeHeaderTemplateId(
      string templateId)
    {
      this.Container.TimeHeaderTemplateId = templateId;
      return this;
    }

    public GanttViewBuilder<TTaskModel, TDependenciesModel> DayHeaderTemplate(
      string value)
    {
      this.Container.DayHeaderTemplate = value;
      return this;
    }

    public GanttViewBuilder<TTaskModel, TDependenciesModel> DayHeaderTemplateId(
      string templateId)
    {
      this.Container.DayHeaderTemplateId = templateId;
      return this;
    }

    public GanttViewBuilder<TTaskModel, TDependenciesModel> WeekHeaderTemplate(
      string value)
    {
      this.Container.WeekHeaderTemplate = value;
      return this;
    }

    public GanttViewBuilder<TTaskModel, TDependenciesModel> WeekHeaderTemplateId(
      string templateId)
    {
      this.Container.WeekHeaderTemplateId = templateId;
      return this;
    }

    public GanttViewBuilder<TTaskModel, TDependenciesModel> MonthHeaderTemplate(
      string value)
    {
      this.Container.MonthHeaderTemplate = value;
      return this;
    }

    public GanttViewBuilder<TTaskModel, TDependenciesModel> MonthHeaderTemplateId(
      string templateId)
    {
      this.Container.MonthHeaderTemplateId = templateId;
      return this;
    }

    public GanttViewBuilder<TTaskModel, TDependenciesModel> YearHeaderTemplate(
      string value)
    {
      this.Container.YearHeaderTemplate = value;
      return this;
    }

    public GanttViewBuilder<TTaskModel, TDependenciesModel> YearHeaderTemplateId(
      string templateId)
    {
      this.Container.YearHeaderTemplateId = templateId;
      return this;
    }

    public GanttViewBuilder<TTaskModel, TDependenciesModel> ResizeTooltipFormat(
      string value)
    {
      this.Container.ResizeTooltipFormat = value;
      return this;
    }

    public GanttViewBuilder<TTaskModel, TDependenciesModel> Type(GanttViewType value)
    {
      this.Container.Type = new GanttViewType?(value);
      return this;
    }
  }
}
