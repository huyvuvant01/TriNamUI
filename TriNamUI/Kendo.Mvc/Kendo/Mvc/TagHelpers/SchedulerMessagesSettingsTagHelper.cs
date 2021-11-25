// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.SchedulerMessagesSettingsTagHelper
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
  [HtmlTargetElement("messages", ParentTag = "kendo-scheduler", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("editable", new string[] {"scheduler-editor", "recurrence-editor", "recurrence-messages", "scheduler-views"})]
  [SuppressTagRendering]
  public class SchedulerMessagesSettingsTagHelper : TagHelperChildBase
  {
    [HtmlAttributeName("ariaeventlabel")]
    public 
    #nullable disable
    string AriaEventLabel { get; set; }

    [HtmlAttributeName("ariaslotlabel")]
    public string AriaSlotLabel { get; set; }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (SchedulerTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as SchedulerTagHelper).Messages = this;
    }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      string ariaEventLabel = this.AriaEventLabel;
      if ((ariaEventLabel != null ? (ariaEventLabel.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["ariaEventLabel"] = (object) this.AriaEventLabel;
      string ariaSlotLabel = this.AriaSlotLabel;
      if ((ariaSlotLabel != null ? (ariaSlotLabel.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["ariaSlotLabel"] = (object) this.AriaSlotLabel;
      return dictionary;
    }

    public string AllDay { get; set; }

    public string Cancel { get; set; }

    public string Date { get; set; }

    public string DeleteWindowTitle { get; set; }

    public string Destroy { get; set; }

    public string Event { get; set; }

    public string DefaultRowText { get; set; }

    public string Next { get; set; }

    public string NoData { get; set; }

    public string Pdf { get; set; }

    public string Previous { get; set; }

    public string ResetSeries { get; set; }

    public string Save { get; set; }

    public string ShowFullDay { get; set; }

    public string ShowWorkDay { get; set; }

    public string Time { get; set; }

    public string Today { get; set; }

    [HtmlAttributeNotBound]
    public SchedulerMessagesEditableSettingsTagHelper Editable { get; set; }

    [HtmlAttributeNotBound]
    public SchedulerMessagesEditorSettingsTagHelper Editor { get; set; }

    [HtmlAttributeNotBound]
    public SchedulerMessagesRecurrenceEditorSettingsTagHelper RecurrenceEditor { get; set; }

    [HtmlAttributeNotBound]
    public SchedulerMessagesRecurrenceMessagesSettingsTagHelper RecurrenceMessages { get; set; }

    public string Search { get; set; }

    [HtmlAttributeNotBound]
    public SchedulerMessagesViewsSettingsTagHelper Views { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string allDay = this.AllDay;
      if ((allDay != null ? (allDay.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["allDay"] = (object) this.AllDay;
      string cancel = this.Cancel;
      if ((cancel != null ? (cancel.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["cancel"] = (object) this.Cancel;
      string date = this.Date;
      if ((date != null ? (date.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["date"] = (object) this.Date;
      string deleteWindowTitle = this.DeleteWindowTitle;
      if ((deleteWindowTitle != null ? (deleteWindowTitle.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["deleteWindowTitle"] = (object) this.DeleteWindowTitle;
      string destroy = this.Destroy;
      if ((destroy != null ? (destroy.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["destroy"] = (object) this.Destroy;
      string str = this.Event;
      if ((str != null ? (str.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["event"] = (object) this.Event;
      string defaultRowText = this.DefaultRowText;
      if ((defaultRowText != null ? (defaultRowText.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["defaultRowText"] = (object) this.DefaultRowText;
      string next = this.Next;
      if ((next != null ? (next.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["next"] = (object) this.Next;
      string noData = this.NoData;
      if ((noData != null ? (noData.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["noData"] = (object) this.NoData;
      string pdf = this.Pdf;
      if ((pdf != null ? (pdf.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["pdf"] = (object) this.Pdf;
      string previous = this.Previous;
      if ((previous != null ? (previous.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["previous"] = (object) this.Previous;
      string resetSeries = this.ResetSeries;
      if ((resetSeries != null ? (resetSeries.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["resetSeries"] = (object) this.ResetSeries;
      string save = this.Save;
      if ((save != null ? (save.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["save"] = (object) this.Save;
      string showFullDay = this.ShowFullDay;
      if ((showFullDay != null ? (showFullDay.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["showFullDay"] = (object) this.ShowFullDay;
      string showWorkDay = this.ShowWorkDay;
      if ((showWorkDay != null ? (showWorkDay.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["showWorkDay"] = (object) this.ShowWorkDay;
      string time = this.Time;
      if ((time != null ? (time.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["time"] = (object) this.Time;
      string today = this.Today;
      if ((today != null ? (today.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["today"] = (object) this.Today;
      if (this.Editable != null)
      {
        Dictionary<string, object> source = this.Editable.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["editable"] = (object) source;
      }
      if (this.Editor != null)
      {
        Dictionary<string, object> source = this.Editor.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["editor"] = (object) source;
      }
      if (this.RecurrenceEditor != null)
      {
        Dictionary<string, object> source = this.RecurrenceEditor.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["recurrenceEditor"] = (object) source;
      }
      if (this.RecurrenceMessages != null)
      {
        Dictionary<string, object> source = this.RecurrenceMessages.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["recurrenceMessages"] = (object) source;
      }
      string search = this.Search;
      if ((search != null ? (search.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["search"] = (object) this.Search;
      if (this.Views != null)
      {
        Dictionary<string, object> source = this.Views.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["views"] = (object) source;
      }
      return dictionary;
    }
  }
}
