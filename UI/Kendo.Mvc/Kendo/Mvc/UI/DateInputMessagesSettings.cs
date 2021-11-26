// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.DateInputMessagesSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class DateInputMessagesSettings
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Year { get; set; }

    public string Month { get; set; }

    public string Day { get; set; }

    public string Weekday { get; set; }

    public string Hour { get; set; }

    public string Minute { get; set; }

    public string Second { get; set; }

    public string Dayperiod { get; set; }

    public DateInput DateInput { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string year = this.Year;
      if ((year != null ? (year.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["year"] = (object) this.Year;
      string month = this.Month;
      if ((month != null ? (month.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["month"] = (object) this.Month;
      string day = this.Day;
      if ((day != null ? (day.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["day"] = (object) this.Day;
      string weekday = this.Weekday;
      if ((weekday != null ? (weekday.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["weekday"] = (object) this.Weekday;
      string hour = this.Hour;
      if ((hour != null ? (hour.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["hour"] = (object) this.Hour;
      string minute = this.Minute;
      if ((minute != null ? (minute.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["minute"] = (object) this.Minute;
      string second = this.Second;
      if ((second != null ? (second.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["second"] = (object) this.Second;
      string dayperiod = this.Dayperiod;
      if ((dayperiod != null ? (dayperiod.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dayperiod"] = (object) this.Dayperiod;
      return dictionary;
    }
  }
}
