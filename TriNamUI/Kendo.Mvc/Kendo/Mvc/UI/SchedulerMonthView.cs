// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.SchedulerMonthView
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class SchedulerMonthView : SchedulerViewBase
  {
    public SchedulerMonthView(IScheduler scheduler)
      : base(SchedulerViewType.Month, scheduler)
    {
    }

    public string DayTemplate { get; set; }

    public string DayTemplateId { get; set; }

    public object EventHeight { get; set; }

    public double? EventSpacing { get; set; }

    public double? EventsPerDay { get; set; }

    public bool AdaptiveSlotHeight { get; set; }

    public bool? Virtual { get; set; }

    protected override void Serialize(IDictionary<string, object> json)
    {
      base.Serialize(json);
      string str = "#";
      if (!string.IsNullOrEmpty(this.DayTemplate))
        json["dayTemplate"] = (object) this.DayTemplate;
      if (!string.IsNullOrEmpty(this.DayTemplateId))
        json["dayTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("kendo.template(jQuery('{0}{1}').html())", (object) str, (object) this.DayTemplateId)
        };
      if (this.EventHeight != null)
        json["eventHeight"] = this.EventHeight;
      if (this.AdaptiveSlotHeight)
        json["adaptiveSlotHeight"] = (object) this.AdaptiveSlotHeight;
      if (this.EventSpacing.HasValue)
        json["eventSpacing"] = (object) this.EventSpacing;
      if (this.EventsPerDay.HasValue)
        json["eventsPerDay"] = (object) this.EventsPerDay;
      if (!this.Virtual.HasValue)
        return;
      json["virtual"] = (object) this.Virtual;
    }
  }
}
