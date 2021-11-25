// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.SchedulerMessagesRecurrenceEditorOffsetPositionsSettings`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class SchedulerMessagesRecurrenceEditorOffsetPositionsSettings<T> where T : class, ISchedulerEvent
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string First { get; set; }

    public string Second { get; set; }

    public string Third { get; set; }

    public string Fourth { get; set; }

    public string Last { get; set; }

    public Kendo.Mvc.UI.Scheduler<T> Scheduler { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string first = this.First;
      if ((first != null ? (first.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["first"] = (object) this.First;
      string second = this.Second;
      if ((second != null ? (second.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["second"] = (object) this.Second;
      string third = this.Third;
      if ((third != null ? (third.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["third"] = (object) this.Third;
      string fourth = this.Fourth;
      if ((fourth != null ? (fourth.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["fourth"] = (object) this.Fourth;
      string last = this.Last;
      if ((last != null ? (last.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["last"] = (object) this.Last;
      return dictionary;
    }
  }
}
