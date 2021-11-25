// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.GanttView`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class GanttView<TTaskModel, TDependenciesModel>
    where TTaskModel : class, IGanttTask
    where TDependenciesModel : class, IGanttDependency
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public DateTime? Date { get; set; }

    public GanttViewRangeSettings<TTaskModel, TDependenciesModel> Range { get; } = new GanttViewRangeSettings<TTaskModel, TDependenciesModel>();

    public bool? Selected { get; set; }

    public double? SlotSize { get; set; }

    public string TimeHeaderTemplate { get; set; }

    public string TimeHeaderTemplateId { get; set; }

    public string DayHeaderTemplate { get; set; }

    public string DayHeaderTemplateId { get; set; }

    public string WeekHeaderTemplate { get; set; }

    public string WeekHeaderTemplateId { get; set; }

    public string MonthHeaderTemplate { get; set; }

    public string MonthHeaderTemplateId { get; set; }

    public string YearHeaderTemplate { get; set; }

    public string YearHeaderTemplateId { get; set; }

    public string ResizeTooltipFormat { get; set; }

    public GanttViewType? Type { get; set; }

    public Kendo.Mvc.UI.Gantt<TTaskModel, TDependenciesModel> Gantt { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = new Dictionary<string, object>();
      if (this.Date.HasValue)
        dictionary1["date"] = (object) this.Date;
      Dictionary<string, object> source = this.Range.Serialize();
      if (source.Any<KeyValuePair<string, object>>())
        dictionary1["range"] = (object) source;
      if (this.Selected.HasValue)
        dictionary1["selected"] = (object) this.Selected;
      if (this.SlotSize.HasValue)
        dictionary1["slotSize"] = (object) this.SlotSize;
      if (this.TimeHeaderTemplateId.HasValue())
        dictionary1["timeHeaderTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.Gantt.IdPrefix, (object) this.TimeHeaderTemplateId)
        };
      else if (this.TimeHeaderTemplate.HasValue())
        dictionary1["timeHeaderTemplate"] = (object) this.TimeHeaderTemplate;
      if (this.DayHeaderTemplateId.HasValue())
        dictionary1["dayHeaderTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.Gantt.IdPrefix, (object) this.DayHeaderTemplateId)
        };
      else if (this.DayHeaderTemplate.HasValue())
        dictionary1["dayHeaderTemplate"] = (object) this.DayHeaderTemplate;
      if (this.WeekHeaderTemplateId.HasValue())
        dictionary1["weekHeaderTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.Gantt.IdPrefix, (object) this.WeekHeaderTemplateId)
        };
      else if (this.WeekHeaderTemplate.HasValue())
        dictionary1["weekHeaderTemplate"] = (object) this.WeekHeaderTemplate;
      if (this.MonthHeaderTemplateId.HasValue())
        dictionary1["monthHeaderTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.Gantt.IdPrefix, (object) this.MonthHeaderTemplateId)
        };
      else if (this.MonthHeaderTemplate.HasValue())
        dictionary1["monthHeaderTemplate"] = (object) this.MonthHeaderTemplate;
      if (this.YearHeaderTemplateId.HasValue())
        dictionary1["yearHeaderTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.Gantt.IdPrefix, (object) this.YearHeaderTemplateId)
        };
      else if (this.YearHeaderTemplate.HasValue())
        dictionary1["yearHeaderTemplate"] = (object) this.YearHeaderTemplate;
      string resizeTooltipFormat = this.ResizeTooltipFormat;
      if ((resizeTooltipFormat != null ? (resizeTooltipFormat.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["resizeTooltipFormat"] = (object) this.ResizeTooltipFormat;
      if (this.Type.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        GanttViewType? type = this.Type;
        ref GanttViewType? local = ref type;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["type"] = (object) str;
      }
      return dictionary1;
    }
  }
}
