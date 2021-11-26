// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.SchedulerViewTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("view", ParentTag = "views", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("editable", new string[] {"group"})]
  [SuppressTagRendering]
  public class SchedulerViewTagHelper : TagHelperCollectionItemBase
  {
    public 
    #nullable disable
    string EventDateTemplate { get; set; }

    public object EventHeight { get; set; }

    public int[] WorkDays { get; set; }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      System.Type type = typeof (SchedulerViewsTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as SchedulerViewsTagHelper).Add(this);
    }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      if (this.EventDateTemplate.HasValue())
        dictionary["eventDateTemplate"] = (object) this.EventDateTemplate;
      if (this.EventHeight != null)
        dictionary["eventHeight"] = this.EventHeight;
      if (this.WorkDays != null)
        dictionary["workDays"] = (object) this.WorkDays;
      return dictionary;
    }

    public bool? AdaptiveSlotHeight { get; set; }

    public string AllDayEventTemplate { get; set; }

    public string AllDayEventTemplateId { get; set; }

    public bool? AllDaySlot { get; set; }

    public string AllDaySlotTemplate { get; set; }

    public string AllDaySlotTemplateId { get; set; }

    public double? ColumnWidth { get; set; }

    public string DateHeaderTemplate { get; set; }

    public string DateHeaderTemplateId { get; set; }

    public string DayTemplate { get; set; }

    public string DayTemplateId { get; set; }

    [HtmlAttributeNotBound]
    public SchedulerViewEditableSettingsTagHelper Editable { get; set; }

    public DateTime? EndTime { get; set; }

    public double? EventSpacing { get; set; }

    public double? EventsPerDay { get; set; }

    public string EventTemplate { get; set; }

    public string EventTemplateId { get; set; }

    public string EventTimeTemplate { get; set; }

    public string EventTimeTemplateId { get; set; }

    [HtmlAttributeNotBound]
    public SchedulerViewGroupSettingsTagHelper Group { get; set; }

    public double? MajorTick { get; set; }

    public string MajorTimeHeaderTemplate { get; set; }

    public string MajorTimeHeaderTemplateId { get; set; }

    public double? MinorTickCount { get; set; }

    public string MinorTimeHeaderTemplate { get; set; }

    public string MinorTimeHeaderTemplateId { get; set; }

    public double? Months { get; set; }

    public string Name { get; set; }

    public bool? Selected { get; set; }

    public string SelectedDateFormat { get; set; }

    public string SelectedShortDateFormat { get; set; }

    public bool? ShowWorkHours { get; set; }

    public string SlotTemplate { get; set; }

    public string SlotTemplateId { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? StartTime { get; set; }

    public string Title { get; set; }

    public string TooltipTemplate { get; set; }

    public string TooltipTemplateId { get; set; }

    public string Type { get; set; }

    public bool? Virtual { get; set; }

    public double? WorkWeekStart { get; set; }

    public double? WorkWeekEnd { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.AdaptiveSlotHeight.HasValue)
        dictionary["adaptiveSlotHeight"] = (object) this.AdaptiveSlotHeight;
      if (this.AllDayEventTemplateId.HasValue())
        dictionary["allDayEventTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.AllDayEventTemplateId)
        };
      else if (this.AllDayEventTemplate.HasValue())
        dictionary["allDayEventTemplate"] = (object) this.AllDayEventTemplate;
      if (this.AllDaySlot.HasValue)
        dictionary["allDaySlot"] = (object) this.AllDaySlot;
      if (this.AllDaySlotTemplateId.HasValue())
        dictionary["allDaySlotTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.AllDaySlotTemplateId)
        };
      else if (this.AllDaySlotTemplate.HasValue())
        dictionary["allDaySlotTemplate"] = (object) this.AllDaySlotTemplate;
      if (this.ColumnWidth.HasValue)
        dictionary["columnWidth"] = (object) this.ColumnWidth;
      if (this.DateHeaderTemplateId.HasValue())
        dictionary["dateHeaderTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.DateHeaderTemplateId)
        };
      else if (this.DateHeaderTemplate.HasValue())
        dictionary["dateHeaderTemplate"] = (object) this.DateHeaderTemplate;
      if (this.DayTemplateId.HasValue())
        dictionary["dayTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.DayTemplateId)
        };
      else if (this.DayTemplate.HasValue())
        dictionary["dayTemplate"] = (object) this.DayTemplate;
      bool? nullable;
      if (this.Editable != null)
      {
        Dictionary<string, object> source = this.Editable.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
        {
          nullable = this.Editable.Enabled;
          if (nullable.HasValue)
          {
            nullable = this.Editable.Enabled;
            if (!nullable.Value)
              goto label_27;
          }
          dictionary["editable"] = (object) source;
          goto label_30;
        }
label_27:
        nullable = this.Editable.Enabled;
        if (nullable.HasValue)
        {
          nullable = this.Editable.Enabled;
          if (!nullable.Value)
            dictionary["editable"] = (object) this.Editable.Enabled;
        }
      }
label_30:
      if (this.EndTime.HasValue)
        dictionary["endTime"] = (object) this.EndTime;
      if (this.EventSpacing.HasValue)
        dictionary["eventSpacing"] = (object) this.EventSpacing;
      if (this.EventsPerDay.HasValue)
        dictionary["eventsPerDay"] = (object) this.EventsPerDay;
      if (this.EventTemplateId.HasValue())
        dictionary["eventTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.EventTemplateId)
        };
      else if (this.EventTemplate.HasValue())
        dictionary["eventTemplate"] = (object) this.EventTemplate;
      if (this.EventTimeTemplateId.HasValue())
        dictionary["eventTimeTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.EventTimeTemplateId)
        };
      else if (this.EventTimeTemplate.HasValue())
        dictionary["eventTimeTemplate"] = (object) this.EventTimeTemplate;
      if (this.Group != null)
      {
        Dictionary<string, object> source = this.Group.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["group"] = (object) source;
      }
      if (this.MajorTick.HasValue)
        dictionary["majorTick"] = (object) this.MajorTick;
      if (this.MajorTimeHeaderTemplateId.HasValue())
        dictionary["majorTimeHeaderTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.MajorTimeHeaderTemplateId)
        };
      else if (this.MajorTimeHeaderTemplate.HasValue())
        dictionary["majorTimeHeaderTemplate"] = (object) this.MajorTimeHeaderTemplate;
      if (this.MinorTickCount.HasValue)
        dictionary["minorTickCount"] = (object) this.MinorTickCount;
      if (this.MinorTimeHeaderTemplateId.HasValue())
        dictionary["minorTimeHeaderTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.MinorTimeHeaderTemplateId)
        };
      else if (this.MinorTimeHeaderTemplate.HasValue())
        dictionary["minorTimeHeaderTemplate"] = (object) this.MinorTimeHeaderTemplate;
      if (this.Months.HasValue)
        dictionary["months"] = (object) this.Months;
      string name = this.Name;
      if ((name != null ? (name.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["name"] = (object) this.Name;
      nullable = this.Selected;
      if (nullable.HasValue)
        dictionary["selected"] = (object) this.Selected;
      string selectedDateFormat = this.SelectedDateFormat;
      if ((selectedDateFormat != null ? (selectedDateFormat.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["selectedDateFormat"] = (object) this.SelectedDateFormat;
      string selectedShortDateFormat = this.SelectedShortDateFormat;
      if ((selectedShortDateFormat != null ? (selectedShortDateFormat.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["selectedShortDateFormat"] = (object) this.SelectedShortDateFormat;
      nullable = this.ShowWorkHours;
      if (nullable.HasValue)
        dictionary["showWorkHours"] = (object) this.ShowWorkHours;
      if (this.SlotTemplateId.HasValue())
        dictionary["slotTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.SlotTemplateId)
        };
      else if (this.SlotTemplate.HasValue())
        dictionary["slotTemplate"] = (object) this.SlotTemplate;
      if (this.StartDate.HasValue)
        dictionary["startDate"] = (object) this.StartDate;
      if (this.StartTime.HasValue)
        dictionary["startTime"] = (object) this.StartTime;
      string title = this.Title;
      if ((title != null ? (title.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["title"] = (object) this.Title;
      if (this.TooltipTemplateId.HasValue())
        dictionary["tooltipTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.TooltipTemplateId)
        };
      else if (this.TooltipTemplate.HasValue())
        dictionary["tooltipTemplate"] = (object) this.TooltipTemplate;
      string type = this.Type;
      if ((type != null ? (type.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["type"] = (object) this.Type;
      nullable = this.Virtual;
      if (nullable.HasValue)
        dictionary["virtual"] = (object) this.Virtual;
      if (this.WorkWeekStart.HasValue)
        dictionary["workWeekStart"] = (object) this.WorkWeekStart;
      if (this.WorkWeekEnd.HasValue)
        dictionary["workWeekEnd"] = (object) this.WorkWeekEnd;
      return dictionary;
    }
  }
}
