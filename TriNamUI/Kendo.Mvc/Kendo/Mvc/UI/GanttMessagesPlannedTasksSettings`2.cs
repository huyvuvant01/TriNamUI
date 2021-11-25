// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.GanttMessagesPlannedTasksSettings`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class GanttMessagesPlannedTasksSettings<TTaskModel, TDependenciesModel>
    where TTaskModel : class, IGanttTask
    where TDependenciesModel : class, IGanttDependency
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string SwitchText { get; set; }

    public string OffsetTooltipAdvanced { get; set; }

    public string OffsetTooltipDelay { get; set; }

    public string Seconds { get; set; }

    public string Minutes { get; set; }

    public string Hours { get; set; }

    public string Days { get; set; }

    public Kendo.Mvc.UI.Gantt<TTaskModel, TDependenciesModel> Gantt { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string switchText = this.SwitchText;
      if ((switchText != null ? (switchText.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["switchText"] = (object) this.SwitchText;
      string offsetTooltipAdvanced = this.OffsetTooltipAdvanced;
      if ((offsetTooltipAdvanced != null ? (offsetTooltipAdvanced.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["offsetTooltipAdvanced"] = (object) this.OffsetTooltipAdvanced;
      string offsetTooltipDelay = this.OffsetTooltipDelay;
      if ((offsetTooltipDelay != null ? (offsetTooltipDelay.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["offsetTooltipDelay"] = (object) this.OffsetTooltipDelay;
      string seconds = this.Seconds;
      if ((seconds != null ? (seconds.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["seconds"] = (object) this.Seconds;
      string minutes = this.Minutes;
      if ((minutes != null ? (minutes.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["minutes"] = (object) this.Minutes;
      string hours = this.Hours;
      if ((hours != null ? (hours.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["hours"] = (object) this.Hours;
      string days = this.Days;
      if ((days != null ? (days.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["days"] = (object) this.Days;
      return dictionary;
    }
  }
}
