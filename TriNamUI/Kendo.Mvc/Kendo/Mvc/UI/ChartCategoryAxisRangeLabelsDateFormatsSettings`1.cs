// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.ChartCategoryAxisRangeLabelsDateFormatsSettings`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class ChartCategoryAxisRangeLabelsDateFormatsSettings<T> where T : class
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Days { get; set; }

    public string Hours { get; set; }

    public string Months { get; set; }

    public string Weeks { get; set; }

    public string Years { get; set; }

    public Kendo.Mvc.UI.Chart<T> Chart { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string days = this.Days;
      if ((days != null ? (days.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["days"] = (object) this.Days;
      string hours = this.Hours;
      if ((hours != null ? (hours.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["hours"] = (object) this.Hours;
      string months = this.Months;
      if ((months != null ? (months.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["months"] = (object) this.Months;
      string weeks = this.Weeks;
      if ((weeks != null ? (weeks.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["weeks"] = (object) this.Weeks;
      string years = this.Years;
      if ((years != null ? (years.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["years"] = (object) this.Years;
      return dictionary;
    }
  }
}
