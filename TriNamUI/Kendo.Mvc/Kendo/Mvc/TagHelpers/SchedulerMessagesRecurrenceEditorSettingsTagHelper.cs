// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.SchedulerMessagesRecurrenceEditorSettingsTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("recurrence-editor", ParentTag = "messages", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("daily", new string[] {"end", "frequencies", "monthly", "offset-positions", "weekly", "weekdays", "yearly"})]
  [SuppressTagRendering]
  public class SchedulerMessagesRecurrenceEditorSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (SchedulerMessagesSettingsTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as SchedulerMessagesSettingsTagHelper).RecurrenceEditor = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Cancel { get; set; }

    [HtmlAttributeNotBound]
    public SchedulerMessagesRecurrenceEditorDailySettingsTagHelper Daily { get; set; }

    [HtmlAttributeNotBound]
    public SchedulerMessagesRecurrenceEditorEndSettingsTagHelper End { get; set; }

    public string EndTitle { get; set; }

    [HtmlAttributeNotBound]
    public SchedulerMessagesRecurrenceEditorFrequenciesSettingsTagHelper Frequencies { get; set; }

    public string HeaderTitle { get; set; }

    [HtmlAttributeNotBound]
    public SchedulerMessagesRecurrenceEditorMonthlySettingsTagHelper Monthly { get; set; }

    [HtmlAttributeNotBound]
    public SchedulerMessagesRecurrenceEditorOffsetPositionsSettingsTagHelper OffsetPositions { get; set; }

    public string RecurrenceEditorTitle { get; set; }

    public string RepeatTitle { get; set; }

    public string Update { get; set; }

    [HtmlAttributeNotBound]
    public SchedulerMessagesRecurrenceEditorWeeklySettingsTagHelper Weekly { get; set; }

    [HtmlAttributeNotBound]
    public SchedulerMessagesRecurrenceEditorWeekdaysSettingsTagHelper Weekdays { get; set; }

    [HtmlAttributeNotBound]
    public SchedulerMessagesRecurrenceEditorYearlySettingsTagHelper Yearly { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string cancel = this.Cancel;
      if ((cancel != null ? (cancel.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["cancel"] = (object) this.Cancel;
      if (this.Daily != null)
      {
        Dictionary<string, object> source = this.Daily.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["daily"] = (object) source;
      }
      if (this.End != null)
      {
        Dictionary<string, object> source = this.End.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["end"] = (object) source;
      }
      string endTitle = this.EndTitle;
      if ((endTitle != null ? (endTitle.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["endTitle"] = (object) this.EndTitle;
      if (this.Frequencies != null)
      {
        Dictionary<string, object> source = this.Frequencies.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["frequencies"] = (object) source;
      }
      string headerTitle = this.HeaderTitle;
      if ((headerTitle != null ? (headerTitle.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["headerTitle"] = (object) this.HeaderTitle;
      if (this.Monthly != null)
      {
        Dictionary<string, object> source = this.Monthly.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["monthly"] = (object) source;
      }
      if (this.OffsetPositions != null)
      {
        Dictionary<string, object> source = this.OffsetPositions.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["offsetPositions"] = (object) source;
      }
      string recurrenceEditorTitle = this.RecurrenceEditorTitle;
      if ((recurrenceEditorTitle != null ? (recurrenceEditorTitle.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["recurrenceEditorTitle"] = (object) this.RecurrenceEditorTitle;
      string repeatTitle = this.RepeatTitle;
      if ((repeatTitle != null ? (repeatTitle.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["repeatTitle"] = (object) this.RepeatTitle;
      string update = this.Update;
      if ((update != null ? (update.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["update"] = (object) this.Update;
      if (this.Weekly != null)
      {
        Dictionary<string, object> source = this.Weekly.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["weekly"] = (object) source;
      }
      if (this.Weekdays != null)
      {
        Dictionary<string, object> source = this.Weekdays.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["weekdays"] = (object) source;
      }
      if (this.Yearly != null)
      {
        Dictionary<string, object> source = this.Yearly.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["yearly"] = (object) source;
      }
      return dictionary;
    }
  }
}
