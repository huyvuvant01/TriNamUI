// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.SchedulerMessagesRecurrenceEditorWeekdaysSettings`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class SchedulerMessagesRecurrenceEditorWeekdaysSettings<T> where T : class, ISchedulerEvent
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Day { get; set; }

    public string Weekday { get; set; }

    public string Weekend { get; set; }

    public Kendo.Mvc.UI.Scheduler<T> Scheduler { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string day = this.Day;
      if ((day != null ? (day.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["day"] = (object) this.Day;
      string weekday = this.Weekday;
      if ((weekday != null ? (weekday.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["weekday"] = (object) this.Weekday;
      string weekend = this.Weekend;
      if ((weekend != null ? (weekend.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["weekend"] = (object) this.Weekend;
      return dictionary;
    }
  }
}
