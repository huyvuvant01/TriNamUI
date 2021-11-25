// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.SchedulerMessagesRecurrenceEditorMonthlySettingsTagHelper
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
  [HtmlTargetElement("monthly", ParentTag = "recurrence-editor", TagStructure = TagStructure.WithoutEndTag)]
  [SuppressTagRendering]
  public class SchedulerMessagesRecurrenceEditorMonthlySettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (SchedulerMessagesRecurrenceEditorSettingsTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as SchedulerMessagesRecurrenceEditorSettingsTagHelper).Monthly = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Day { get; set; }

    public string Date { get; set; }

    public string Interval { get; set; }

    public string RepeatEvery { get; set; }

    public string RepeatOn { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string day = this.Day;
      if ((day != null ? (day.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["day"] = (object) this.Day;
      string date = this.Date;
      if ((date != null ? (date.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["date"] = (object) this.Date;
      string interval = this.Interval;
      if ((interval != null ? (interval.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["interval"] = (object) this.Interval;
      string repeatEvery = this.RepeatEvery;
      if ((repeatEvery != null ? (repeatEvery.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["repeatEvery"] = (object) this.RepeatEvery;
      string repeatOn = this.RepeatOn;
      if ((repeatOn != null ? (repeatOn.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["repeatOn"] = (object) this.RepeatOn;
      return dictionary;
    }
  }
}
