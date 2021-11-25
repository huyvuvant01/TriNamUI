// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.SchedulerYearView
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class SchedulerYearView : SchedulerViewBase
  {
    public SchedulerYearView(IScheduler scheduler)
      : base(SchedulerViewType.Year, scheduler)
    {
    }

    public DateTime? StartDate { get; set; }

    public double? Months { get; set; }

    public string TooltipTemplate { get; set; }

    public string TooltipTemplateId { get; set; }

    protected override void Serialize(IDictionary<string, object> json)
    {
      base.Serialize(json);
      string str = "#";
      if (this.StartDate.HasValue)
        json["startDate"] = (object) this.StartDate;
      if (this.Months.HasValue)
        json["months"] = (object) this.Months;
      if (!string.IsNullOrEmpty(this.TooltipTemplate))
        json["tooltipTemplate"] = (object) this.TooltipTemplate;
      if (string.IsNullOrEmpty(this.TooltipTemplateId))
        return;
      json["tooltipTemplate"] = (object) new ClientHandlerDescriptor()
      {
        HandlerName = string.Format("kendo.template(jQuery('{0}{1}').html())", (object) str, (object) this.TooltipTemplateId)
      };
    }
  }
}
