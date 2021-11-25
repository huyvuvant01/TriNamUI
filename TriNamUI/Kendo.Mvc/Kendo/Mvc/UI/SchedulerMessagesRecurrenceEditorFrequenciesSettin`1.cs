// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.SchedulerMessagesRecurrenceEditorFrequenciesSettings`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class SchedulerMessagesRecurrenceEditorFrequenciesSettings<T> where T : class, ISchedulerEvent
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Daily { get; set; }

    public string Monthly { get; set; }

    public string Never { get; set; }

    public string Weekly { get; set; }

    public string Yearly { get; set; }

    public Kendo.Mvc.UI.Scheduler<T> Scheduler { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string daily = this.Daily;
      if ((daily != null ? (daily.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["daily"] = (object) this.Daily;
      string monthly = this.Monthly;
      if ((monthly != null ? (monthly.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["monthly"] = (object) this.Monthly;
      string never = this.Never;
      if ((never != null ? (never.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["never"] = (object) this.Never;
      string weekly = this.Weekly;
      if ((weekly != null ? (weekly.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["weekly"] = (object) this.Weekly;
      string yearly = this.Yearly;
      if ((yearly != null ? (yearly.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["yearly"] = (object) this.Yearly;
      return dictionary;
    }
  }
}
