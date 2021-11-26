// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.SchedulerMultiDayViewBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class SchedulerMultiDayViewBuilder<TView> : 
    SchedulerBaseViewBuilder<TView, SchedulerMultiDayViewBuilder<TView>>
    where TView : SchedulerMultiDayView
  {
    public SchedulerMultiDayViewBuilder(TView resource)
      : base(resource)
    {
    }

    public SchedulerMultiDayViewBuilder<TView> AllDayEventTemplate(
      string allDayEventTemplate)
    {
      this.view.AllDayEventTemplate = allDayEventTemplate;
      return this;
    }

    public SchedulerMultiDayViewBuilder<TView> AllDayEventTemplateId(
      string allDayEventTemplateId)
    {
      this.view.AllDayEventTemplateId = allDayEventTemplateId;
      return this;
    }

    public SchedulerMultiDayViewBuilder<TView> GroupHeaderTemplate(
      string groupHeaderTemplate)
    {
      this.view.GroupHeaderTemplate = groupHeaderTemplate;
      return this;
    }

    public SchedulerMultiDayViewBuilder<TView> GroupHeaderTemplateId(
      string groupHeaderTemplateId)
    {
      this.view.GroupHeaderTemplateId = groupHeaderTemplateId;
      return this;
    }

    public SchedulerMultiDayViewBuilder<TView> AllDaySlot(
      bool allDaySlot)
    {
      this.view.AllDaySlot = allDaySlot;
      return this;
    }

    public SchedulerMultiDayViewBuilder<TView> DateHeaderTemplate(
      string dateHeaderTemplate)
    {
      this.view.DateHeaderTemplate = dateHeaderTemplate;
      return this;
    }

    public SchedulerMultiDayViewBuilder<TView> DateHeaderTemplateId(
      string dateHeaderTemplateId)
    {
      this.view.DateHeaderTemplateId = dateHeaderTemplateId;
      return this;
    }

    public SchedulerMultiDayViewBuilder<TView> MajorTick(int majorTick)
    {
      this.view.MajorTick = new int?(majorTick);
      return this;
    }

    public SchedulerMultiDayViewBuilder<TView> AllDaySlotTemplate(
      string slotTemplate)
    {
      this.view.AllDaySlotTemplate = slotTemplate;
      return this;
    }

    public SchedulerMultiDayViewBuilder<TView> AllDaySlotTemplateId(
      string slotTemplateId)
    {
      this.view.AllDaySlotTemplateId = slotTemplateId;
      return this;
    }

    public SchedulerMultiDayViewBuilder<TView> SlotTemplate(
      string slotTemplate)
    {
      this.view.SlotTemplate = slotTemplate;
      return this;
    }

    public SchedulerMultiDayViewBuilder<TView> SlotTemplateId(
      string slotTemplateId)
    {
      this.view.SlotTemplateId = slotTemplateId;
      return this;
    }

    public SchedulerMultiDayViewBuilder<TView> MajorTimeHeaderTemplate(
      string majorTimeHeaderTemplate)
    {
      this.view.MajorTimeHeaderTemplate = majorTimeHeaderTemplate;
      return this;
    }

    public SchedulerMultiDayViewBuilder<TView> MajorTimeHeaderTemplateId(
      string majorTimeHeaderTemplateId)
    {
      this.view.MajorTimeHeaderTemplateId = majorTimeHeaderTemplateId;
      return this;
    }

    public SchedulerMultiDayViewBuilder<TView> MinorTickCount(
      int minorTickCount)
    {
      this.view.MinorTickCount = new int?(minorTickCount);
      return this;
    }

    public SchedulerMultiDayViewBuilder<TView> MinorTimeHeaderTemplate(
      string minorTimeHeaderTemplate)
    {
      this.view.MinorTimeHeaderTemplate = minorTimeHeaderTemplate;
      return this;
    }

    public SchedulerMultiDayViewBuilder<TView> MinorTimeHeaderTemplateId(
      string minorTimeHeaderTemplateId)
    {
      this.view.MinorTimeHeaderTemplateId = minorTimeHeaderTemplateId;
      return this;
    }

    public SchedulerMultiDayViewBuilder<TView> StartTime(
      DateTime startTime)
    {
      this.view.StartTime = new DateTime?(startTime);
      return this;
    }

    public SchedulerMultiDayViewBuilder<TView> StartTime(
      int hours,
      int minutes,
      int seconds)
    {
      DateTime today = DateTime.Today;
      this.view.StartTime = new DateTime?(new DateTime(today.Year, today.Month, today.Day, hours, minutes, seconds));
      return this;
    }

    public SchedulerMultiDayViewBuilder<TView> EndTime(DateTime endTime)
    {
      this.view.EndTime = new DateTime?(endTime);
      return this;
    }

    public SchedulerMultiDayViewBuilder<TView> EndTime(
      int hours,
      int minutes,
      int seconds)
    {
      DateTime today = DateTime.Today;
      this.view.EndTime = new DateTime?(new DateTime(today.Year, today.Month, today.Day, hours, minutes, seconds));
      return this;
    }

    public SchedulerMultiDayViewBuilder<TView> WorkDayStart(
      DateTime workDayStart)
    {
      this.view.WorkDayStart = new DateTime?(workDayStart);
      return this;
    }

    public SchedulerMultiDayViewBuilder<TView> WorkDayStart(
      int hours,
      int minutes,
      int seconds)
    {
      DateTime today = DateTime.Today;
      this.view.WorkDayStart = new DateTime?(new DateTime(today.Year, today.Month, today.Day, hours, minutes, seconds));
      return this;
    }

    public SchedulerMultiDayViewBuilder<TView> WorkDays(int[] workDays)
    {
      this.view.WorkDays = workDays;
      return this;
    }

    public SchedulerMultiDayViewBuilder<TView> WorkDayEnd(
      DateTime workDayEnd)
    {
      this.view.WorkDayEnd = new DateTime?(workDayEnd);
      return this;
    }

    public SchedulerMultiDayViewBuilder<TView> WorkDayEnd(
      int hours,
      int minutes,
      int seconds)
    {
      DateTime today = DateTime.Today;
      this.view.WorkDayEnd = new DateTime?(new DateTime(today.Year, today.Month, today.Day, hours, minutes, seconds));
      return this;
    }

    public SchedulerMultiDayViewBuilder<TView> WorkDayCommand(
      bool showWorkDayCommand)
    {
      this.view.WorkDayCommand = showWorkDayCommand;
      return this;
    }

    public SchedulerMultiDayViewBuilder<TView> ShowWorkHours(bool value)
    {
      this.view.ShowWorkHours = new bool?(value);
      return this;
    }

    public SchedulerMultiDayViewBuilder<TView> ShowWorkHours()
    {
      this.view.ShowWorkHours = new bool?(true);
      return this;
    }

    public SchedulerMultiDayViewBuilder<TView> Footer(bool showFooter)
    {
      this.view.Footer = showFooter;
      return this;
    }

    public SchedulerMultiDayViewBuilder<TView> WorkWeekStart(
      int workWeekStartDay)
    {
      this.view.WorkWeekStart = new int?(workWeekStartDay);
      return this;
    }

    public SchedulerMultiDayViewBuilder<TView> WorkWeekEnd(
      int workWeekEndDay)
    {
      this.view.WorkWeekEnd = new int?(workWeekEndDay);
      return this;
    }

    public SchedulerMultiDayViewBuilder<TView> Virtual(bool enable)
    {
      this.view.Virtual = new bool?(enable);
      return this;
    }
  }
}
