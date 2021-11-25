// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.SchedulerAgendaViewBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class SchedulerAgendaViewBuilder<TView> : 
    SchedulerBaseViewBuilder<TView, SchedulerAgendaViewBuilder<TView>>
    where TView : SchedulerAgendaView
  {
    public SchedulerAgendaViewBuilder(TView view)
      : base(view)
    {
    }

    public SchedulerAgendaViewBuilder<TView> EventDateTemplate(
      string eventDateTemplate)
    {
      this.view.EventDateTemplate = eventDateTemplate;
      return this;
    }

    public SchedulerAgendaViewBuilder<TView> EventDateTemplateId(
      string eventDateTemplateId)
    {
      this.view.EventDateTemplateId = eventDateTemplateId;
      return this;
    }

    public SchedulerAgendaViewBuilder<TView> EventTimeTemplate(
      string eventTimeTemplate)
    {
      this.view.EventTimeTemplate = eventTimeTemplate;
      return this;
    }

    public SchedulerAgendaViewBuilder<TView> EventTimeTemplateId(
      string eventTimeTemplateId)
    {
      this.view.EventTimeTemplateId = eventTimeTemplateId;
      return this;
    }
  }
}
