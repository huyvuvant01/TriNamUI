// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.SchedulerViewFactory`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class SchedulerViewFactory<TModel> : IHideObjectMembers where TModel : class, ISchedulerEvent
  {
    private readonly IScheduler<TModel> container;

    public SchedulerViewFactory(Scheduler<TModel> container) => this.container = (IScheduler<TModel>) container;

    public SchedulerDayViewBuilder<SchedulerDayView> DayView(
      Action<SchedulerDayViewBuilder<SchedulerDayView>> addViewAction)
    {
      SchedulerDayView resource = new SchedulerDayView((IScheduler) this.container);
      this.container.Views.Add((SchedulerViewBase) resource);
      SchedulerDayViewBuilder<SchedulerDayView> schedulerDayViewBuilder = new SchedulerDayViewBuilder<SchedulerDayView>(resource);
      addViewAction(schedulerDayViewBuilder);
      return schedulerDayViewBuilder;
    }

    public void DayView() => this.container.Views.Add((SchedulerViewBase) new SchedulerDayView((IScheduler) this.container));

    public void CustomView(string type) => this.container.Views.Add((SchedulerViewBase) new SchedulerCustomView(type, (IScheduler) this.container));

    public SchedulerCustomViewBuilder<SchedulerCustomView> CustomView(
      string type,
      Action<SchedulerCustomViewBuilder<SchedulerCustomView>> addViewAction)
    {
      SchedulerCustomView view = new SchedulerCustomView(type, (IScheduler) this.container);
      this.container.Views.Add((SchedulerViewBase) view);
      SchedulerCustomViewBuilder<SchedulerCustomView> customViewBuilder = new SchedulerCustomViewBuilder<SchedulerCustomView>(view);
      addViewAction(customViewBuilder);
      return customViewBuilder;
    }

    public SchedulerWorkWeekViewBuilder<SchedulerWorkWeekView> WorkWeekView(
      Action<SchedulerWorkWeekViewBuilder<SchedulerWorkWeekView>> addViewAction)
    {
      SchedulerWorkWeekView resource = new SchedulerWorkWeekView((IScheduler) this.container);
      this.container.Views.Add((SchedulerViewBase) resource);
      SchedulerWorkWeekViewBuilder<SchedulerWorkWeekView> workWeekViewBuilder = new SchedulerWorkWeekViewBuilder<SchedulerWorkWeekView>(resource);
      addViewAction(workWeekViewBuilder);
      return workWeekViewBuilder;
    }

    public void WorkWeekView() => this.container.Views.Add((SchedulerViewBase) new SchedulerWorkWeekView((IScheduler) this.container));

    public SchedulerWeekViewBuilder<SchedulerWeekView> WeekView(
      Action<SchedulerWeekViewBuilder<SchedulerWeekView>> addViewAction)
    {
      SchedulerWeekView resource = new SchedulerWeekView((IScheduler) this.container);
      this.container.Views.Add((SchedulerViewBase) resource);
      SchedulerWeekViewBuilder<SchedulerWeekView> schedulerWeekViewBuilder = new SchedulerWeekViewBuilder<SchedulerWeekView>(resource);
      addViewAction(schedulerWeekViewBuilder);
      return schedulerWeekViewBuilder;
    }

    public void WeekView() => this.container.Views.Add((SchedulerViewBase) new SchedulerWeekView((IScheduler) this.container));

    public SchedulerMonthViewBuilder<SchedulerMonthView> MonthView(
      Action<SchedulerMonthViewBuilder<SchedulerMonthView>> addViewAction)
    {
      SchedulerMonthView resource = new SchedulerMonthView((IScheduler) this.container);
      this.container.Views.Add((SchedulerViewBase) resource);
      SchedulerMonthViewBuilder<SchedulerMonthView> monthViewBuilder = new SchedulerMonthViewBuilder<SchedulerMonthView>(resource);
      addViewAction(monthViewBuilder);
      return monthViewBuilder;
    }

    public void MonthView() => this.container.Views.Add((SchedulerViewBase) new SchedulerMonthView((IScheduler) this.container));

    public SchedulerAgendaViewBuilder<SchedulerAgendaView> AgendaView(
      Action<SchedulerAgendaViewBuilder<SchedulerAgendaView>> addViewAction)
    {
      SchedulerAgendaView view = new SchedulerAgendaView((IScheduler) this.container);
      this.container.Views.Add((SchedulerViewBase) view);
      SchedulerAgendaViewBuilder<SchedulerAgendaView> agendaViewBuilder = new SchedulerAgendaViewBuilder<SchedulerAgendaView>(view);
      addViewAction(agendaViewBuilder);
      return agendaViewBuilder;
    }

    public void TimelineView() => this.container.Views.Add((SchedulerViewBase) new SchedulerTimelineView((IScheduler) this.container));

    public SchedulerTimelineViewBuilder<SchedulerTimelineView> TimelineView(
      Action<SchedulerTimelineViewBuilder<SchedulerTimelineView>> addViewAction)
    {
      SchedulerTimelineView resource = new SchedulerTimelineView((IScheduler) this.container);
      this.container.Views.Add((SchedulerViewBase) resource);
      SchedulerTimelineViewBuilder<SchedulerTimelineView> timelineViewBuilder = new SchedulerTimelineViewBuilder<SchedulerTimelineView>(resource);
      addViewAction(timelineViewBuilder);
      return timelineViewBuilder;
    }

    public void TimelineWeekView() => this.container.Views.Add((SchedulerViewBase) new SchedulerTimelineWeekView((IScheduler) this.container));

    public SchedulerTimelineWeekViewBuilder<SchedulerTimelineWeekView> TimelineWeekView(
      Action<SchedulerTimelineWeekViewBuilder<SchedulerTimelineWeekView>> addViewAction)
    {
      SchedulerTimelineWeekView resource = new SchedulerTimelineWeekView((IScheduler) this.container);
      this.container.Views.Add((SchedulerViewBase) resource);
      SchedulerTimelineWeekViewBuilder<SchedulerTimelineWeekView> timelineWeekViewBuilder = new SchedulerTimelineWeekViewBuilder<SchedulerTimelineWeekView>(resource);
      addViewAction(timelineWeekViewBuilder);
      return timelineWeekViewBuilder;
    }

    public void TimelineWorkWeekView() => this.container.Views.Add((SchedulerViewBase) new SchedulerTimelineWorkWeekView((IScheduler) this.container));

    public SchedulerTimelineWorkWeekViewBuilder<SchedulerTimelineWorkWeekView> TimelineWorkWeekView(
      Action<SchedulerTimelineWorkWeekViewBuilder<SchedulerTimelineWorkWeekView>> addViewAction)
    {
      SchedulerTimelineWorkWeekView resource = new SchedulerTimelineWorkWeekView((IScheduler) this.container);
      this.container.Views.Add((SchedulerViewBase) resource);
      SchedulerTimelineWorkWeekViewBuilder<SchedulerTimelineWorkWeekView> workWeekViewBuilder = new SchedulerTimelineWorkWeekViewBuilder<SchedulerTimelineWorkWeekView>(resource);
      addViewAction(workWeekViewBuilder);
      return workWeekViewBuilder;
    }

    public void TimelineMonthView() => this.container.Views.Add((SchedulerViewBase) new SchedulerTimelineMonthView((IScheduler) this.container));

    public SchedulerTimelineMonthViewBuilder<SchedulerTimelineMonthView> TimelineMonthView(
      Action<SchedulerTimelineMonthViewBuilder<SchedulerTimelineMonthView>> addViewAction)
    {
      SchedulerTimelineMonthView resource = new SchedulerTimelineMonthView((IScheduler) this.container);
      this.container.Views.Add((SchedulerViewBase) resource);
      SchedulerTimelineMonthViewBuilder<SchedulerTimelineMonthView> monthViewBuilder = new SchedulerTimelineMonthViewBuilder<SchedulerTimelineMonthView>(resource);
      addViewAction(monthViewBuilder);
      return monthViewBuilder;
    }

    public void AgendaView() => this.container.Views.Add((SchedulerViewBase) new SchedulerAgendaView((IScheduler) this.container));

    public SchedulerYearViewBuilder<SchedulerYearView> YearView(
      Action<SchedulerYearViewBuilder<SchedulerYearView>> addViewAction)
    {
      SchedulerYearView resource = new SchedulerYearView((IScheduler) this.container);
      this.container.Views.Add((SchedulerViewBase) resource);
      SchedulerYearViewBuilder<SchedulerYearView> schedulerYearViewBuilder = new SchedulerYearViewBuilder<SchedulerYearView>(resource);
      addViewAction(schedulerYearViewBuilder);
      return schedulerYearViewBuilder;
    }

    public void YearView() => this.container.Views.Add((SchedulerViewBase) new SchedulerYearView((IScheduler) this.container));

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
