// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.RecurrenceEditor
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class RecurrenceEditor : WidgetBase
  {
    public RecurrenceEditor(ViewContext viewContext)
      : base(viewContext)
    {
      this.Frequencies = (IList<RecurrenceEditorFrequency>) new List<RecurrenceEditorFrequency>();
      this.FirstWeekDay = 0;
      this.Messages = new SchedulerMessagesRecurrenceEditorSettings<ISchedulerEvent>();
    }

    public DateTime? Start { get; set; }

    public int FirstWeekDay { get; set; }

    public string Timezone { get; set; }

    public string Value { get; set; }

    public SchedulerMessagesRecurrenceEditorSettings<ISchedulerEvent> Messages { get; private set; }

    public IList<RecurrenceEditorFrequency> Frequencies { get; private set; }

    protected override void WriteHtml(TextWriter writer)
    {
      this.Generator.GenerateTag("div", this.ViewContext, this.Id, this.Name, this.HtmlAttributes).WriteTo(writer, this.HtmlEncoder);
      base.WriteHtml(writer);
    }

    public override void WriteInitializationScript(TextWriter writer)
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      writer.Write(this.Initializer.Initialize(this.Selector, nameof (RecurrenceEditor), (IDictionary<string, object>) dictionary));
    }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = base.SerializeSettings();
      if (this.Start.HasValue)
        dictionary["start"] = (object) this.Start;
      if (this.FirstWeekDay != 0)
        dictionary["firstWeekDay"] = (object) this.FirstWeekDay;
      string timezone = this.Timezone;
      if ((timezone != null ? (timezone.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["timezone"] = (object) this.Timezone;
      string str = this.Value;
      if ((str != null ? (str.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["value"] = (object) this.Value;
      Dictionary<string, object> source1 = this.Messages.Serialize();
      if (source1.Any<KeyValuePair<string, object>>())
        dictionary["messages"] = (object) source1;
      IEnumerable<string> source2 = this.Frequencies.Select<RecurrenceEditorFrequency, string>((Func<RecurrenceEditorFrequency, string>) (f => f.Serialize()));
      if (source2.Any<string>())
        dictionary["frequencies"] = (object) source2;
      return dictionary;
    }
  }
}
