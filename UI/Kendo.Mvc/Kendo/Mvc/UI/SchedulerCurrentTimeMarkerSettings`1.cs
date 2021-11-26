// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.SchedulerCurrentTimeMarkerSettings`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class SchedulerCurrentTimeMarkerSettings<T> where T : class, ISchedulerEvent
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public double? UpdateInterval { get; set; }

    public bool? UseLocalTimezone { get; set; }

    public bool? Enabled { get; set; }

    public Kendo.Mvc.UI.Scheduler<T> Scheduler { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.UpdateInterval.HasValue)
        dictionary["updateInterval"] = (object) this.UpdateInterval;
      if (this.UseLocalTimezone.HasValue)
        dictionary["useLocalTimezone"] = (object) this.UseLocalTimezone;
      return dictionary;
    }
  }
}
