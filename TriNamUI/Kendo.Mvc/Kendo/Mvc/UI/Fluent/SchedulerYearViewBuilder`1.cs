// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.SchedulerYearViewBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class SchedulerYearViewBuilder<TView> : 
    SchedulerBaseViewBuilder<TView, SchedulerYearViewBuilder<TView>>
    where TView : SchedulerYearView
  {
    public SchedulerYearViewBuilder(TView resource)
      : base(resource)
    {
    }

    public SchedulerYearViewBuilder<TView> StartDate(DateTime startDate)
    {
      this.view.StartDate = new DateTime?(startDate);
      return this;
    }

    public SchedulerYearViewBuilder<TView> Months(double? months)
    {
      this.view.Months = months;
      return this;
    }

    public SchedulerYearViewBuilder<TView> TooltipTemplate(
      string tooltipTemplate)
    {
      this.view.TooltipTemplate = tooltipTemplate;
      return this;
    }

    public SchedulerYearViewBuilder<TView> TooltipTemplateId(
      string tooltipTemplateId)
    {
      this.view.TooltipTemplateId = tooltipTemplateId;
      return this;
    }
  }
}
