// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.SchedulerViewMessages
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Resources;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class SchedulerViewMessages : JsonObject
  {
    private const string DefaultDay = "Day";
    private const string DefaultWeek = "Week";
    private const string DefaultWorkWeek = "Work Week";
    private const string DefaultMonth = "Month";
    private const string DefaultAgenda = "Agenda";
    private const string DefaultYear = "Year";

    public SchedulerViewMessages()
    {
      this.Day = Messages.Scheduler_View_Day;
      this.Week = Messages.Scheduler_View_Week;
      this.WorkWeek = Messages.Scheduler_View_WorkWeek;
      this.Month = Messages.Scheduler_View_Month;
      this.Agenda = Messages.Scheduler_View_Agenda;
      this.Year = Messages.Scheduler_View_Year;
    }

    public string Day { get; set; }

    public string Week { get; set; }

    public string WorkWeek { get; set; }

    public string Month { get; set; }

    public string Agenda { get; set; }

    public string Year { get; set; }

    protected override void Serialize(IDictionary<string, object> json)
    {
      if (this.Day != "Day")
        json["day"] = (object) this.Day;
      if (this.Week != "Week")
        json["week"] = (object) this.Week;
      if (this.WorkWeek != "Work Week")
        json["workWeek"] = (object) this.WorkWeek;
      if (this.Month != "Month")
        json["month"] = (object) this.Month;
      if (this.Agenda != "Agenda")
        json["agenda"] = (object) this.Agenda;
      if (!(this.Year != "Year"))
        return;
      json["year"] = (object) this.Year;
    }
  }
}
