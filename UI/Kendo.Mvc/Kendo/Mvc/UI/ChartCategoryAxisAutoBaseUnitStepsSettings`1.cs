// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.ChartCategoryAxisAutoBaseUnitStepsSettings`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class ChartCategoryAxisAutoBaseUnitStepsSettings<T> where T : class
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public int[] Milliseconds { get; set; }

    public int[] Seconds { get; set; }

    public int[] Minutes { get; set; }

    public int[] Hours { get; set; }

    public int[] Days { get; set; }

    public int[] Weeks { get; set; }

    public int[] Months { get; set; }

    public int[] Years { get; set; }

    public Kendo.Mvc.UI.Chart<T> Chart { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      int[] milliseconds = this.Milliseconds;
      if ((milliseconds != null ? (((IEnumerable<int>) milliseconds).Any<int>() ? 1 : 0) : 0) != 0)
        dictionary["milliseconds"] = (object) this.Milliseconds;
      int[] seconds = this.Seconds;
      if ((seconds != null ? (((IEnumerable<int>) seconds).Any<int>() ? 1 : 0) : 0) != 0)
        dictionary["seconds"] = (object) this.Seconds;
      int[] minutes = this.Minutes;
      if ((minutes != null ? (((IEnumerable<int>) minutes).Any<int>() ? 1 : 0) : 0) != 0)
        dictionary["minutes"] = (object) this.Minutes;
      int[] hours = this.Hours;
      if ((hours != null ? (((IEnumerable<int>) hours).Any<int>() ? 1 : 0) : 0) != 0)
        dictionary["hours"] = (object) this.Hours;
      int[] days = this.Days;
      if ((days != null ? (((IEnumerable<int>) days).Any<int>() ? 1 : 0) : 0) != 0)
        dictionary["days"] = (object) this.Days;
      int[] weeks = this.Weeks;
      if ((weeks != null ? (((IEnumerable<int>) weeks).Any<int>() ? 1 : 0) : 0) != 0)
        dictionary["weeks"] = (object) this.Weeks;
      int[] months = this.Months;
      if ((months != null ? (((IEnumerable<int>) months).Any<int>() ? 1 : 0) : 0) != 0)
        dictionary["months"] = (object) this.Months;
      int[] years = this.Years;
      if ((years != null ? (((IEnumerable<int>) years).Any<int>() ? 1 : 0) : 0) != 0)
        dictionary["years"] = (object) this.Years;
      return dictionary;
    }
  }
}
