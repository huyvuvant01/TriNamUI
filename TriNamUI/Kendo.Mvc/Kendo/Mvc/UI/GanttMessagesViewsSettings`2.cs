// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.GanttMessagesViewsSettings`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class GanttMessagesViewsSettings<TTaskModel, TDependenciesModel>
    where TTaskModel : class, IGanttTask
    where TDependenciesModel : class, IGanttDependency
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Day { get; set; }

    public string End { get; set; }

    public string Month { get; set; }

    public string Start { get; set; }

    public string Week { get; set; }

    public string Year { get; set; }

    public Kendo.Mvc.UI.Gantt<TTaskModel, TDependenciesModel> Gantt { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string day = this.Day;
      if ((day != null ? (day.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["day"] = (object) this.Day;
      string end = this.End;
      if ((end != null ? (end.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["end"] = (object) this.End;
      string month = this.Month;
      if ((month != null ? (month.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["month"] = (object) this.Month;
      string start = this.Start;
      if ((start != null ? (start.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["start"] = (object) this.Start;
      string week = this.Week;
      if ((week != null ? (week.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["week"] = (object) this.Week;
      string year = this.Year;
      if ((year != null ? (year.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["year"] = (object) this.Year;
      return dictionary;
    }
  }
}
