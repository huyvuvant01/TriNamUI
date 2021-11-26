// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.SchedulerMessagesRecurrenceEditorSettings`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class SchedulerMessagesRecurrenceEditorSettings<T> where T : class, ISchedulerEvent
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Cancel { get; set; }

    public SchedulerMessagesRecurrenceEditorDailySettings<T> Daily { get; } = new SchedulerMessagesRecurrenceEditorDailySettings<T>();

    public SchedulerMessagesRecurrenceEditorEndSettings<T> End { get; } = new SchedulerMessagesRecurrenceEditorEndSettings<T>();

    public string EndTitle { get; set; }

    public SchedulerMessagesRecurrenceEditorFrequenciesSettings<T> Frequencies { get; } = new SchedulerMessagesRecurrenceEditorFrequenciesSettings<T>();

    public string HeaderTitle { get; set; }

    public SchedulerMessagesRecurrenceEditorMonthlySettings<T> Monthly { get; } = new SchedulerMessagesRecurrenceEditorMonthlySettings<T>();

    public SchedulerMessagesRecurrenceEditorOffsetPositionsSettings<T> OffsetPositions { get; } = new SchedulerMessagesRecurrenceEditorOffsetPositionsSettings<T>();

    public string RecurrenceEditorTitle { get; set; }

    public string RepeatTitle { get; set; }

    public string Update { get; set; }

    public SchedulerMessagesRecurrenceEditorWeeklySettings<T> Weekly { get; } = new SchedulerMessagesRecurrenceEditorWeeklySettings<T>();

    public SchedulerMessagesRecurrenceEditorWeekdaysSettings<T> Weekdays { get; } = new SchedulerMessagesRecurrenceEditorWeekdaysSettings<T>();

    public SchedulerMessagesRecurrenceEditorYearlySettings<T> Yearly { get; } = new SchedulerMessagesRecurrenceEditorYearlySettings<T>();

    public Kendo.Mvc.UI.Scheduler<T> Scheduler { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string cancel = this.Cancel;
      if ((cancel != null ? (cancel.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["cancel"] = (object) this.Cancel;
      Dictionary<string, object> source1 = this.Daily.Serialize();
      if (source1.Any<KeyValuePair<string, object>>())
        dictionary["daily"] = (object) source1;
      Dictionary<string, object> source2 = this.End.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
        dictionary["end"] = (object) source2;
      string endTitle = this.EndTitle;
      if ((endTitle != null ? (endTitle.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["endTitle"] = (object) this.EndTitle;
      Dictionary<string, object> source3 = this.Frequencies.Serialize();
      if (source3.Any<KeyValuePair<string, object>>())
        dictionary["frequencies"] = (object) source3;
      string headerTitle = this.HeaderTitle;
      if ((headerTitle != null ? (headerTitle.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["headerTitle"] = (object) this.HeaderTitle;
      Dictionary<string, object> source4 = this.Monthly.Serialize();
      if (source4.Any<KeyValuePair<string, object>>())
        dictionary["monthly"] = (object) source4;
      Dictionary<string, object> source5 = this.OffsetPositions.Serialize();
      if (source5.Any<KeyValuePair<string, object>>())
        dictionary["offsetPositions"] = (object) source5;
      string recurrenceEditorTitle = this.RecurrenceEditorTitle;
      if ((recurrenceEditorTitle != null ? (recurrenceEditorTitle.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["recurrenceEditorTitle"] = (object) this.RecurrenceEditorTitle;
      string repeatTitle = this.RepeatTitle;
      if ((repeatTitle != null ? (repeatTitle.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["repeatTitle"] = (object) this.RepeatTitle;
      string update = this.Update;
      if ((update != null ? (update.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["update"] = (object) this.Update;
      Dictionary<string, object> source6 = this.Weekly.Serialize();
      if (source6.Any<KeyValuePair<string, object>>())
        dictionary["weekly"] = (object) source6;
      Dictionary<string, object> source7 = this.Weekdays.Serialize();
      if (source7.Any<KeyValuePair<string, object>>())
        dictionary["weekdays"] = (object) source7;
      Dictionary<string, object> source8 = this.Yearly.Serialize();
      if (source8.Any<KeyValuePair<string, object>>())
        dictionary["yearly"] = (object) source8;
      return dictionary;
    }
  }
}
