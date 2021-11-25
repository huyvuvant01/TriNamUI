// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.SchedulerMultiDayView
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public abstract class SchedulerMultiDayView : SchedulerViewBase
  {
    protected SchedulerMultiDayView(SchedulerViewType type, IScheduler scheduler)
      : base(type, scheduler)
    {
      this.AllDaySlot = true;
      this.WorkDayCommand = true;
      this.Footer = true;
      this.ShowWorkHours = scheduler.ShowWorkHours;
    }

    public string AllDayEventTemplate { get; set; }

    public string AllDayEventTemplateId { get; set; }

    public string GroupHeaderTemplate { get; set; }

    public string GroupHeaderTemplateId { get; set; }

    public bool AllDaySlot { get; set; }

    public string DateHeaderTemplate { get; set; }

    public string DateHeaderTemplateId { get; set; }

    public int? MajorTick { get; set; }

    public string MajorTimeHeaderTemplate { get; set; }

    public string MajorTimeHeaderTemplateId { get; set; }

    public string SlotTemplate { get; set; }

    public string SlotTemplateId { get; set; }

    public string AllDaySlotTemplate { get; set; }

    public string AllDaySlotTemplateId { get; set; }

    public int? MinorTickCount { get; set; }

    public string MinorTimeHeaderTemplate { get; set; }

    public string MinorTimeHeaderTemplateId { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public DateTime? WorkDayStart { get; set; }

    public int[] WorkDays { get; set; }

    public DateTime? WorkDayEnd { get; set; }

    public bool? ShowWorkHours { get; set; }

    public bool WorkDayCommand { get; set; }

    public bool Footer { get; set; }

    public int? WorkWeekStart { get; set; }

    public int? WorkWeekEnd { get; set; }

    public bool? Virtual { get; set; }

    protected override void Serialize(IDictionary<string, object> json)
    {
      base.Serialize(json);
      string str = "#";
      if (!string.IsNullOrEmpty(this.AllDayEventTemplate))
        json["allDayEventTemplate"] = (object) this.AllDayEventTemplate;
      if (!string.IsNullOrEmpty(this.AllDayEventTemplateId))
        json["allDayEventTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("kendo.template(jQuery('{0}{1}').html())", (object) str, (object) this.AllDayEventTemplateId)
        };
      if (!string.IsNullOrEmpty(this.GroupHeaderTemplate))
        json["groupHeaderTemplate"] = (object) this.GroupHeaderTemplate;
      if (!string.IsNullOrEmpty(this.GroupHeaderTemplateId))
        json["groupHeaderTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("kendo.template(jQuery('{0}{1}').html())", (object) str, (object) this.GroupHeaderTemplateId)
        };
      if (!this.AllDaySlot)
        json["allDaySlot"] = (object) this.AllDaySlot;
      if (!string.IsNullOrEmpty(this.DateHeaderTemplate))
        json["dateHeaderTemplate"] = (object) this.DateHeaderTemplate;
      if (!string.IsNullOrEmpty(this.DateHeaderTemplateId))
        json["dateHeaderTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("kendo.template(jQuery('{0}{1}').html())", (object) str, (object) this.DateHeaderTemplateId)
        };
      if (this.MajorTick.HasValue)
        json["majorTick"] = (object) this.MajorTick;
      if (!string.IsNullOrEmpty(this.MajorTimeHeaderTemplate))
        json["majorTimeHeaderTemplate"] = (object) this.MajorTimeHeaderTemplate;
      if (!string.IsNullOrEmpty(this.MajorTimeHeaderTemplateId))
        json["majorTimeHeaderTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("kendo.template(jQuery('{0}{1}').html())", (object) str, (object) this.MajorTimeHeaderTemplateId)
        };
      if (this.MinorTickCount.HasValue)
        json["minorTickCount"] = (object) this.MinorTickCount;
      if (!string.IsNullOrEmpty(this.MinorTimeHeaderTemplate))
        json["minorTimeHeaderTemplate"] = (object) this.MinorTimeHeaderTemplate;
      if (!string.IsNullOrEmpty(this.MinorTimeHeaderTemplateId))
        json["minorTimeHeaderTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("kendo.template(jQuery('{0}{1}').html())", (object) str, (object) this.MinorTimeHeaderTemplateId)
        };
      if (!string.IsNullOrEmpty(this.SlotTemplate))
        json["slotTemplate"] = (object) this.SlotTemplate;
      if (!string.IsNullOrEmpty(this.SlotTemplateId))
        json["slotTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("kendo.template(jQuery('{0}{1}').html())", (object) str, (object) this.SlotTemplateId)
        };
      if (!string.IsNullOrEmpty(this.AllDaySlotTemplate))
        json["allDaySlotTemplate"] = (object) this.AllDaySlotTemplate;
      if (!string.IsNullOrEmpty(this.AllDaySlotTemplateId))
        json["allDaySlotTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("kendo.template(jQuery('{0}{1}').html())", (object) str, (object) this.AllDaySlotTemplateId)
        };
      if (this.StartTime.HasValue)
        json["startTime"] = (object) this.StartTime;
      if (this.EndTime.HasValue)
        json["endTime"] = (object) this.EndTime;
      if (this.WorkDayStart.HasValue)
        json["workDayStart"] = (object) this.WorkDayStart;
      if (this.WorkDays != null)
        json["workDays"] = (object) this.WorkDays;
      if (this.WorkDayEnd.HasValue)
        json["workDayEnd"] = (object) this.WorkDayEnd;
      if (!this.Footer)
        json["footer"] = (object) this.Footer;
      if (!this.WorkDayCommand && this.Footer)
        json["footer"] = (object) new Dictionary<string, object>()
        {
          {
            "command",
            (object) false
          }
        };
      if (this.WorkWeekStart.HasValue)
        json["workWeekStart"] = (object) this.WorkWeekStart;
      if (this.WorkWeekEnd.HasValue)
        json["workWeekEnd"] = (object) this.WorkWeekEnd;
      bool? showWorkHours1 = this.Scheduler.ShowWorkHours;
      bool? showWorkHours2 = this.ShowWorkHours;
      if (!(showWorkHours1.GetValueOrDefault() == showWorkHours2.GetValueOrDefault() & showWorkHours1.HasValue == showWorkHours2.HasValue))
        json["showWorkHours"] = (object) this.ShowWorkHours;
      if (!this.Virtual.HasValue)
        return;
      json["virtual"] = (object) this.Virtual;
    }
  }
}
