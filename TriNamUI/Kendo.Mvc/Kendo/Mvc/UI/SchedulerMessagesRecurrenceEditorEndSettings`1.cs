// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.SchedulerMessagesRecurrenceEditorEndSettings`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class SchedulerMessagesRecurrenceEditorEndSettings<T> where T : class, ISchedulerEvent
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string After { get; set; }

    public string Occurrence { get; set; }

    public string Label { get; set; }

    public string Never { get; set; }

    public string MobileLabel { get; set; }

    public string On { get; set; }

    public Kendo.Mvc.UI.Scheduler<T> Scheduler { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string after = this.After;
      if ((after != null ? (after.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["after"] = (object) this.After;
      string occurrence = this.Occurrence;
      if ((occurrence != null ? (occurrence.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["occurrence"] = (object) this.Occurrence;
      string label = this.Label;
      if ((label != null ? (label.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["label"] = (object) this.Label;
      string never = this.Never;
      if ((never != null ? (never.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["never"] = (object) this.Never;
      string mobileLabel = this.MobileLabel;
      if ((mobileLabel != null ? (mobileLabel.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["mobileLabel"] = (object) this.MobileLabel;
      string on = this.On;
      if ((on != null ? (on.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["on"] = (object) this.On;
      return dictionary;
    }
  }
}
