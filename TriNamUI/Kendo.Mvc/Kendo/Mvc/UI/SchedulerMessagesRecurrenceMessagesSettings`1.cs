// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.SchedulerMessagesRecurrenceMessagesSettings`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class SchedulerMessagesRecurrenceMessagesSettings<T> where T : class, ISchedulerEvent
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string DeleteRecurring { get; set; }

    public string DeleteWindowOccurrence { get; set; }

    public string DeleteWindowSeries { get; set; }

    public string DeleteWindowTitle { get; set; }

    public string EditRecurring { get; set; }

    public string EditWindowOccurrence { get; set; }

    public string EditWindowSeries { get; set; }

    public string EditWindowTitle { get; set; }

    public string ResetSeriesWindowTitle { get; set; }

    public Kendo.Mvc.UI.Scheduler<T> Scheduler { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string deleteRecurring = this.DeleteRecurring;
      if ((deleteRecurring != null ? (deleteRecurring.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["deleteRecurring"] = (object) this.DeleteRecurring;
      string windowOccurrence1 = this.DeleteWindowOccurrence;
      if ((windowOccurrence1 != null ? (windowOccurrence1.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["deleteWindowOccurrence"] = (object) this.DeleteWindowOccurrence;
      string deleteWindowSeries = this.DeleteWindowSeries;
      if ((deleteWindowSeries != null ? (deleteWindowSeries.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["deleteWindowSeries"] = (object) this.DeleteWindowSeries;
      string deleteWindowTitle = this.DeleteWindowTitle;
      if ((deleteWindowTitle != null ? (deleteWindowTitle.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["deleteWindowTitle"] = (object) this.DeleteWindowTitle;
      string editRecurring = this.EditRecurring;
      if ((editRecurring != null ? (editRecurring.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["editRecurring"] = (object) this.EditRecurring;
      string windowOccurrence2 = this.EditWindowOccurrence;
      if ((windowOccurrence2 != null ? (windowOccurrence2.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["editWindowOccurrence"] = (object) this.EditWindowOccurrence;
      string editWindowSeries = this.EditWindowSeries;
      if ((editWindowSeries != null ? (editWindowSeries.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["editWindowSeries"] = (object) this.EditWindowSeries;
      string editWindowTitle = this.EditWindowTitle;
      if ((editWindowTitle != null ? (editWindowTitle.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["editWindowTitle"] = (object) this.EditWindowTitle;
      string seriesWindowTitle = this.ResetSeriesWindowTitle;
      if ((seriesWindowTitle != null ? (seriesWindowTitle.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["resetSeriesWindowTitle"] = (object) this.ResetSeriesWindowTitle;
      return dictionary;
    }
  }
}
