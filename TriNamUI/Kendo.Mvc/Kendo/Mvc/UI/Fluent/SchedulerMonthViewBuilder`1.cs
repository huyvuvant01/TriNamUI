// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.SchedulerMonthViewBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class SchedulerMonthViewBuilder<TView> : 
    SchedulerBaseViewBuilder<TView, SchedulerMonthViewBuilder<TView>>
    where TView : SchedulerMonthView
  {
    public SchedulerMonthViewBuilder(TView resource)
      : base(resource)
    {
    }

    public SchedulerMonthViewBuilder<TView> DayTemplate(string dayTemplate)
    {
      this.view.DayTemplate = dayTemplate;
      return this;
    }

    public SchedulerMonthViewBuilder<TView> DayTemplateId(
      string dayTemplateId)
    {
      this.view.DayTemplateId = dayTemplateId;
      return this;
    }

    public SchedulerMonthViewBuilder<TView> EventHeight(object eventHeight)
    {
      this.view.EventHeight = eventHeight;
      return this;
    }

    public SchedulerMonthViewBuilder<TView> EventSpacing(
      double? eventSpacing)
    {
      this.view.EventSpacing = eventSpacing;
      return this;
    }

    public SchedulerMonthViewBuilder<TView> EventsPerDay(
      double? eventsPerDay)
    {
      this.view.EventsPerDay = eventsPerDay;
      return this;
    }

    public SchedulerMonthViewBuilder<TView> AdaptiveSlotHeight(
      bool adaptiveSlotHeight)
    {
      this.view.AdaptiveSlotHeight = adaptiveSlotHeight;
      return this;
    }

    public SchedulerMonthViewBuilder<TView> Virtual(bool enable)
    {
      this.view.Virtual = new bool?(enable);
      return this;
    }
  }
}
