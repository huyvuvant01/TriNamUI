// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.SchedulerMessagesEditorSettingsTagHelper
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
  [HtmlTargetElement("scheduler-editor", ParentTag = "messages", TagStructure = TagStructure.WithoutEndTag)]
  [SuppressTagRendering]
  public class SchedulerMessagesEditorSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (SchedulerMessagesSettingsTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as SchedulerMessagesSettingsTagHelper).Editor = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string AllDayEvent { get; set; }

    public string Description { get; set; }

    public string EditorTitle { get; set; }

    public string End { get; set; }

    public string EndTimezone { get; set; }

    public string Repeat { get; set; }

    public string SeparateTimezones { get; set; }

    public string Start { get; set; }

    public string StartTimezone { get; set; }

    public string Timezone { get; set; }

    public string TimezoneEditorButton { get; set; }

    public string TimezoneEditorTitle { get; set; }

    public string Title { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string allDayEvent = this.AllDayEvent;
      if ((allDayEvent != null ? (allDayEvent.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["allDayEvent"] = (object) this.AllDayEvent;
      string description = this.Description;
      if ((description != null ? (description.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["description"] = (object) this.Description;
      string editorTitle = this.EditorTitle;
      if ((editorTitle != null ? (editorTitle.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["editorTitle"] = (object) this.EditorTitle;
      string end = this.End;
      if ((end != null ? (end.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["end"] = (object) this.End;
      string endTimezone = this.EndTimezone;
      if ((endTimezone != null ? (endTimezone.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["endTimezone"] = (object) this.EndTimezone;
      string repeat = this.Repeat;
      if ((repeat != null ? (repeat.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["repeat"] = (object) this.Repeat;
      string separateTimezones = this.SeparateTimezones;
      if ((separateTimezones != null ? (separateTimezones.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["separateTimezones"] = (object) this.SeparateTimezones;
      string start = this.Start;
      if ((start != null ? (start.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["start"] = (object) this.Start;
      string startTimezone = this.StartTimezone;
      if ((startTimezone != null ? (startTimezone.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["startTimezone"] = (object) this.StartTimezone;
      string timezone = this.Timezone;
      if ((timezone != null ? (timezone.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["timezone"] = (object) this.Timezone;
      string timezoneEditorButton = this.TimezoneEditorButton;
      if ((timezoneEditorButton != null ? (timezoneEditorButton.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["timezoneEditorButton"] = (object) this.TimezoneEditorButton;
      string timezoneEditorTitle = this.TimezoneEditorTitle;
      if ((timezoneEditorTitle != null ? (timezoneEditorTitle.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["timezoneEditorTitle"] = (object) this.TimezoneEditorTitle;
      string title = this.Title;
      if ((title != null ? (title.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["title"] = (object) this.Title;
      return dictionary;
    }
  }
}
