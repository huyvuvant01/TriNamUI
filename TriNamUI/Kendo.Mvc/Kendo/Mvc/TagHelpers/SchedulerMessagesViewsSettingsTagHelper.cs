// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.SchedulerMessagesViewsSettingsTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("scheduler-views", ParentTag = "messages", TagStructure = TagStructure.WithoutEndTag)]
  [SuppressTagRendering]
  public class SchedulerMessagesViewsSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (SchedulerMessagesSettingsTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as SchedulerMessagesSettingsTagHelper).Views = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Day { get; set; }

    public string Week { get; set; }

    public string Month { get; set; }

    public string Agenda { get; set; }

    public string TimelineMonth { get; set; }

    public string TimelineWeek { get; set; }

    public string Year { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string day = this.Day;
      if ((day != null ? (day.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["day"] = (object) this.Day;
      string week = this.Week;
      if ((week != null ? (week.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["week"] = (object) this.Week;
      string month = this.Month;
      if ((month != null ? (month.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["month"] = (object) this.Month;
      string agenda = this.Agenda;
      if ((agenda != null ? (agenda.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["agenda"] = (object) this.Agenda;
      string timelineMonth = this.TimelineMonth;
      if ((timelineMonth != null ? (timelineMonth.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["timelineMonth"] = (object) this.TimelineMonth;
      string timelineWeek = this.TimelineWeek;
      if ((timelineWeek != null ? (timelineWeek.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["timelineWeek"] = (object) this.TimelineWeek;
      string year = this.Year;
      if ((year != null ? (year.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["year"] = (object) this.Year;
      return dictionary;
    }
  }
}
