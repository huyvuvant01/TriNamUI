// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.SchedulerMessagesSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class SchedulerMessagesSettingsBuilder<T> where T : class, ISchedulerEvent
  {
    public SchedulerMessagesSettingsBuilder(SchedulerMessagesSettings<T> container) => this.Container = container;

    protected SchedulerMessagesSettings<T> Container { get; private set; }

    public SchedulerMessagesSettingsBuilder<T> AllDay(string value)
    {
      this.Container.AllDay = value;
      return this;
    }

    public SchedulerMessagesSettingsBuilder<T> AriaEventLabel(
      string value)
    {
      this.Container.AriaEventLabel = value;
      return this;
    }

    public SchedulerMessagesSettingsBuilder<T> AriaSlotLabel(
      string value)
    {
      this.Container.AriaSlotLabel = value;
      return this;
    }

    public SchedulerMessagesSettingsBuilder<T> Cancel(string value)
    {
      this.Container.Cancel = value;
      return this;
    }

    public SchedulerMessagesSettingsBuilder<T> Date(string value)
    {
      this.Container.Date = value;
      return this;
    }

    public SchedulerMessagesSettingsBuilder<T> DeleteWindowTitle(
      string value)
    {
      this.Container.DeleteWindowTitle = value;
      return this;
    }

    public SchedulerMessagesSettingsBuilder<T> Destroy(string value)
    {
      this.Container.Destroy = value;
      return this;
    }

    public SchedulerMessagesSettingsBuilder<T> Event(string value)
    {
      this.Container.Event = value;
      return this;
    }

    public SchedulerMessagesSettingsBuilder<T> DefaultRowText(
      string value)
    {
      this.Container.DefaultRowText = value;
      return this;
    }

    public SchedulerMessagesSettingsBuilder<T> Next(string value)
    {
      this.Container.Next = value;
      return this;
    }

    public SchedulerMessagesSettingsBuilder<T> NoData(string value)
    {
      this.Container.NoData = value;
      return this;
    }

    public SchedulerMessagesSettingsBuilder<T> Pdf(string value)
    {
      this.Container.Pdf = value;
      return this;
    }

    public SchedulerMessagesSettingsBuilder<T> Previous(string value)
    {
      this.Container.Previous = value;
      return this;
    }

    public SchedulerMessagesSettingsBuilder<T> ResetSeries(
      string value)
    {
      this.Container.ResetSeries = value;
      return this;
    }

    public SchedulerMessagesSettingsBuilder<T> Save(string value)
    {
      this.Container.Save = value;
      return this;
    }

    public SchedulerMessagesSettingsBuilder<T> ShowFullDay(
      string value)
    {
      this.Container.ShowFullDay = value;
      return this;
    }

    public SchedulerMessagesSettingsBuilder<T> ShowWorkDay(
      string value)
    {
      this.Container.ShowWorkDay = value;
      return this;
    }

    public SchedulerMessagesSettingsBuilder<T> Time(string value)
    {
      this.Container.Time = value;
      return this;
    }

    public SchedulerMessagesSettingsBuilder<T> Today(string value)
    {
      this.Container.Today = value;
      return this;
    }

    public SchedulerMessagesSettingsBuilder<T> Editable(
      Action<SchedulerMessagesEditableSettingsBuilder<T>> configurator)
    {
      this.Container.Editable.Scheduler = this.Container.Scheduler;
      configurator(new SchedulerMessagesEditableSettingsBuilder<T>(this.Container.Editable));
      return this;
    }

    public SchedulerMessagesSettingsBuilder<T> Editor(
      Action<SchedulerMessagesEditorSettingsBuilder<T>> configurator)
    {
      this.Container.Editor.Scheduler = this.Container.Scheduler;
      configurator(new SchedulerMessagesEditorSettingsBuilder<T>(this.Container.Editor));
      return this;
    }

    public SchedulerMessagesSettingsBuilder<T> RecurrenceEditor(
      Action<SchedulerMessagesRecurrenceEditorSettingsBuilder<T>> configurator)
    {
      this.Container.RecurrenceEditor.Scheduler = this.Container.Scheduler;
      configurator(new SchedulerMessagesRecurrenceEditorSettingsBuilder<T>(this.Container.RecurrenceEditor));
      return this;
    }

    public SchedulerMessagesSettingsBuilder<T> RecurrenceMessages(
      Action<SchedulerMessagesRecurrenceMessagesSettingsBuilder<T>> configurator)
    {
      this.Container.RecurrenceMessages.Scheduler = this.Container.Scheduler;
      configurator(new SchedulerMessagesRecurrenceMessagesSettingsBuilder<T>(this.Container.RecurrenceMessages));
      return this;
    }

    public SchedulerMessagesSettingsBuilder<T> Search(string value)
    {
      this.Container.Search = value;
      return this;
    }

    public SchedulerMessagesSettingsBuilder<T> Views(
      Action<SchedulerMessagesViewsSettingsBuilder<T>> configurator)
    {
      this.Container.Views.Scheduler = this.Container.Scheduler;
      configurator(new SchedulerMessagesViewsSettingsBuilder<T>(this.Container.Views));
      return this;
    }
  }
}
