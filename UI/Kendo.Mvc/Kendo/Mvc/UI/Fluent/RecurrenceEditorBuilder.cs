// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.RecurrenceEditorBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class RecurrenceEditorBuilder : WidgetBuilderBase<RecurrenceEditor, RecurrenceEditorBuilder>
  {
    public RecurrenceEditorBuilder(RecurrenceEditor component)
      : base(component)
    {
    }

    public RecurrenceEditorBuilder Start(DateTime start)
    {
      this.Component.Start = new DateTime?(start);
      return this;
    }

    public RecurrenceEditorBuilder FirstWeekDay(int firstWeekDay)
    {
      this.Component.FirstWeekDay = firstWeekDay;
      return this;
    }

    public RecurrenceEditorBuilder Timezone(string timezone)
    {
      this.Component.Timezone = timezone;
      return this;
    }

    public RecurrenceEditorBuilder Value(string value)
    {
      this.Component.Value = value;
      return this;
    }

    public RecurrenceEditorBuilder Frequency(
      Action<RecurrenceEditorFrequencyBuilder> addFrequencyAction)
    {
      RecurrenceEditorFrequencyBuilder frequencyBuilder = new RecurrenceEditorFrequencyBuilder(this.Component);
      addFrequencyAction(frequencyBuilder);
      return this;
    }

    public RecurrenceEditorBuilder Frequency(
      IEnumerable<RecurrenceEditorFrequency> frequencies)
    {
      foreach (RecurrenceEditorFrequency frequency in frequencies)
        this.Component.Frequencies.Add(frequency);
      return this;
    }

    public RecurrenceEditorBuilder Messages(
      Action<SchedulerMessagesRecurrenceEditorSettingsBuilder<ISchedulerEvent>> addViewAction)
    {
      SchedulerMessagesRecurrenceEditorSettingsBuilder<ISchedulerEvent> editorSettingsBuilder = new SchedulerMessagesRecurrenceEditorSettingsBuilder<ISchedulerEvent>(this.Component.Messages);
      addViewAction(editorSettingsBuilder);
      return this;
    }

    public RecurrenceEditorBuilder Events(
      Action<RecurrenceEditorEventBuilder> clientEventsAction)
    {
      clientEventsAction(new RecurrenceEditorEventBuilder(this.Component.Events));
      return this;
    }
  }
}
