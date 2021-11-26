// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.IScheduler
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public interface IScheduler
  {
    DataSource DataSource { get; }

    IUrlGenerator UrlGenerator { get; }

    bool IsInClientTemplate { get; }

    DateTime? Date { get; }

    DateTime? StartTime { get; }

    DateTime? EndTime { get; }

    DateTime? WorkDayStart { get; }

    DateTime? WorkDayEnd { get; }

    bool? ShowWorkHours { get; set; }

    double? Height { get; }

    string EventTemplate { get; }

    string EventTemplateId { get; }

    string AllDayEventTemplate { get; }

    string AllDayEventTemplateId { get; }

    bool? AllDaySlot { get; }

    bool? Selectable { get; }

    string DateHeaderTemplate { get; }

    string DateHeaderTemplateId { get; }

    int? MajorTick { get; }

    string MajorTimeHeaderTemplate { get; }

    string MajorTimeHeaderTemplateId { get; }

    int? MinorTickCount { get; }

    string MinorTimeHeaderTemplate { get; }

    string MinorTimeHeaderTemplateId { get; }

    string Timezone { get; }

    double? Width { get; }

    bool? Snap { get; }

    int? WorkWeekStart { get; }

    int? WorkWeekEnd { get; }

    IList<SchedulerViewBase> Views { get; }

    IList<SchedulerToolbarCommand> ToolbarCommands { get; }

    SchedulerGroupSettings Group { get; }
  }
}
