// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.SchedulerAgendaView
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class SchedulerAgendaView : SchedulerViewBase
  {
    public SchedulerAgendaView(IScheduler scheduler)
      : base(SchedulerViewType.Agenda, scheduler)
    {
    }

    public string EventDateTemplate { get; set; }

    public string EventDateTemplateId { get; set; }

    public string EventTimeTemplate { get; set; }

    public string EventTimeTemplateId { get; set; }

    protected override void Serialize(IDictionary<string, object> json)
    {
      base.Serialize(json);
      string str = "#";
      if (!string.IsNullOrEmpty(this.EventDateTemplate))
        json["eventDateTemplate"] = (object) this.EventDateTemplate;
      if (!string.IsNullOrEmpty(this.EventDateTemplateId))
        json["eventDateTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("kendo.template(jQuery('{0}{1}').html())", (object) str, (object) this.EventDateTemplateId)
        };
      if (!string.IsNullOrEmpty(this.EventTimeTemplate))
        json["eventTimeTemplate"] = (object) this.EventTimeTemplate;
      if (string.IsNullOrEmpty(this.EventTimeTemplateId))
        return;
      json["eventTimeTemplate"] = (object) new ClientHandlerDescriptor()
      {
        HandlerName = string.Format("kendo.template(jQuery('{0}{1}').html())", (object) str, (object) this.EventTimeTemplateId)
      };
    }
  }
}
