// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.SchedulerMessagesSettings`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class SchedulerMessagesSettings<T> where T : class, ISchedulerEvent
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string AllDay { get; set; }

    public string AriaEventLabel { get; set; }

    public string AriaSlotLabel { get; set; }

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

    public SchedulerMessagesEditableSettings<T> Editable { get; } = new SchedulerMessagesEditableSettings<T>();

    public SchedulerMessagesEditorSettings<T> Editor { get; } = new SchedulerMessagesEditorSettings<T>();

    public SchedulerMessagesRecurrenceEditorSettings<T> RecurrenceEditor { get; } = new SchedulerMessagesRecurrenceEditorSettings<T>();

    public SchedulerMessagesRecurrenceMessagesSettings<T> RecurrenceMessages { get; } = new SchedulerMessagesRecurrenceMessagesSettings<T>();

    public string Search { get; set; }

    public SchedulerMessagesViewsSettings<T> Views { get; } = new SchedulerMessagesViewsSettings<T>();

    public Kendo.Mvc.UI.Scheduler<T> Scheduler { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string allDay = this.AllDay;
      if ((allDay != null ? (allDay.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["allDay"] = (object) this.AllDay;
      string ariaEventLabel = this.AriaEventLabel;
      if ((ariaEventLabel != null ? (ariaEventLabel.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["ariaEventLabel"] = (object) this.AriaEventLabel;
      string ariaSlotLabel = this.AriaSlotLabel;
      if ((ariaSlotLabel != null ? (ariaSlotLabel.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["ariaSlotLabel"] = (object) this.AriaSlotLabel;
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
      Dictionary<string, object> source1 = this.Editable.Serialize();
      if (source1.Any<KeyValuePair<string, object>>())
        dictionary["editable"] = (object) source1;
      Dictionary<string, object> source2 = this.Editor.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
        dictionary["editor"] = (object) source2;
      Dictionary<string, object> source3 = this.RecurrenceEditor.Serialize();
      if (source3.Any<KeyValuePair<string, object>>())
        dictionary["recurrenceEditor"] = (object) source3;
      Dictionary<string, object> source4 = this.RecurrenceMessages.Serialize();
      if (source4.Any<KeyValuePair<string, object>>())
        dictionary["recurrenceMessages"] = (object) source4;
      string search = this.Search;
      if ((search != null ? (search.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["search"] = (object) this.Search;
      Dictionary<string, object> source5 = this.Views.Serialize();
      if (source5.Any<KeyValuePair<string, object>>())
        dictionary["views"] = (object) source5;
      return dictionary;
    }
  }
}
