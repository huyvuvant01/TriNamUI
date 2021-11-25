// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.SchedulerTimelineViewBuilderBase`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public abstract class SchedulerTimelineViewBuilderBase<TView, TTimelineViewBuilder> : 
    SchedulerBaseViewBuilder<TView, TTimelineViewBuilder>
    where TView : SchedulerTimelineViewBase
    where TTimelineViewBuilder : SchedulerTimelineViewBuilderBase<TView, TTimelineViewBuilder>
  {
    public SchedulerTimelineViewBuilderBase(TView resource)
      : base(resource)
    {
    }

    public TTimelineViewBuilder EventHeight(object eventHeight)
    {
      this.view.EventHeight = eventHeight;
      return (TTimelineViewBuilder) this;
    }

    public TTimelineViewBuilder ColumnWidth(int columnWidth)
    {
      this.view.ColumnWidth = new int?(columnWidth);
      return (TTimelineViewBuilder) this;
    }

    public TTimelineViewBuilder MajorTick(int majorTick)
    {
      this.view.MajorTick = new int?(majorTick);
      return (TTimelineViewBuilder) this;
    }

    public TTimelineViewBuilder MinorTickCount(int minorTickCount)
    {
      this.view.MinorTickCount = new int?(minorTickCount);
      return (TTimelineViewBuilder) this;
    }

    public TTimelineViewBuilder StartTime(DateTime startTime)
    {
      this.view.StartTime = new DateTime?(startTime);
      return (TTimelineViewBuilder) this;
    }

    public TTimelineViewBuilder StartTime(int hours, int minutes, int seconds)
    {
      DateTime today = DateTime.Today;
      this.view.StartTime = new DateTime?(new DateTime(today.Year, today.Month, today.Day, hours, minutes, seconds));
      return (TTimelineViewBuilder) this;
    }

    public TTimelineViewBuilder EndTime(DateTime endTime)
    {
      this.view.EndTime = new DateTime?(endTime);
      return (TTimelineViewBuilder) this;
    }

    public TTimelineViewBuilder EndTime(int hours, int minutes, int seconds)
    {
      DateTime today = DateTime.Today;
      this.view.EndTime = new DateTime?(new DateTime(today.Year, today.Month, today.Day, hours, minutes, seconds));
      return (TTimelineViewBuilder) this;
    }

    public TTimelineViewBuilder GroupHeaderTemplate(string groupHeaderTemplate)
    {
      this.view.GroupHeaderTemplate = groupHeaderTemplate;
      return (TTimelineViewBuilder) this;
    }

    public TTimelineViewBuilder GroupHeaderTemplateId(string groupHeaderTemplateId)
    {
      this.view.GroupHeaderTemplateId = groupHeaderTemplateId;
      return (TTimelineViewBuilder) this;
    }

    public TTimelineViewBuilder WorkDayStart(DateTime workDayStart)
    {
      this.view.WorkDayStart = new DateTime?(workDayStart);
      return (TTimelineViewBuilder) this;
    }

    public TTimelineViewBuilder WorkDayStart(int hours, int minutes, int seconds)
    {
      DateTime today = DateTime.Today;
      this.view.WorkDayStart = new DateTime?(new DateTime(today.Year, today.Month, today.Day, hours, minutes, seconds));
      return (TTimelineViewBuilder) this;
    }

    public TTimelineViewBuilder WorkDays(int[] workDays)
    {
      this.view.WorkDays = workDays;
      return (TTimelineViewBuilder) this;
    }

    public TTimelineViewBuilder WorkDayEnd(DateTime workDayEnd)
    {
      this.view.WorkDayEnd = new DateTime?(workDayEnd);
      return (TTimelineViewBuilder) this;
    }

    public TTimelineViewBuilder WorkDayEnd(int hours, int minutes, int seconds)
    {
      DateTime today = DateTime.Today;
      this.view.WorkDayEnd = new DateTime?(new DateTime(today.Year, today.Month, today.Day, hours, minutes, seconds));
      return (TTimelineViewBuilder) this;
    }

    public TTimelineViewBuilder WorkDayCommand(bool showWorkDayCommand)
    {
      this.view.WorkDayCommand = showWorkDayCommand;
      return (TTimelineViewBuilder) this;
    }

    public TTimelineViewBuilder ShowWorkHours(bool value)
    {
      this.view.ShowWorkHours = new bool?(value);
      return (TTimelineViewBuilder) this;
    }

    public TTimelineViewBuilder ShowWorkHours()
    {
      this.view.ShowWorkHours = new bool?(true);
      return (TTimelineViewBuilder) this;
    }

    public TTimelineViewBuilder Footer(bool showFooter)
    {
      this.view.Footer = showFooter;
      return (TTimelineViewBuilder) this;
    }

    public TTimelineViewBuilder WorkWeekStart(int workWeekStartDay)
    {
      this.view.WorkWeekStart = new int?(workWeekStartDay);
      return (TTimelineViewBuilder) this;
    }

    public TTimelineViewBuilder WorkWeekEnd(int workWeekEndDay)
    {
      this.view.WorkWeekEnd = new int?(workWeekEndDay);
      return (TTimelineViewBuilder) this;
    }

    public TTimelineViewBuilder DateHeaderTemplate(string dateHeaderTemplate)
    {
      this.view.DateHeaderTemplate = dateHeaderTemplate;
      return (TTimelineViewBuilder) this;
    }

    public TTimelineViewBuilder DateHeaderTemplateId(string dateHeaderTemplateId)
    {
      this.view.DateHeaderTemplateId = dateHeaderTemplateId;
      return (TTimelineViewBuilder) this;
    }

    public TTimelineViewBuilder MajorTimeHeaderTemplate(string majorTimeHeaderTemplate)
    {
      this.view.MajorTimeHeaderTemplate = majorTimeHeaderTemplate;
      return (TTimelineViewBuilder) this;
    }

    public TTimelineViewBuilder MajorTimeHeaderTemplateId(string majorTimeHeaderTemplateId)
    {
      this.view.MajorTimeHeaderTemplateId = majorTimeHeaderTemplateId;
      return (TTimelineViewBuilder) this;
    }

    public TTimelineViewBuilder SlotTemplate(string slotTemplate)
    {
      this.view.SlotTemplate = slotTemplate;
      return (TTimelineViewBuilder) this;
    }

    public TTimelineViewBuilder SlotTemplateId(string slotTemplateId)
    {
      this.view.SlotTemplateId = slotTemplateId;
      return (TTimelineViewBuilder) this;
    }
  }
}
