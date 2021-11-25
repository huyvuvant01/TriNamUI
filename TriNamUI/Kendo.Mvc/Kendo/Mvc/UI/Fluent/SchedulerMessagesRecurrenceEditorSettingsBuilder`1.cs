// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.SchedulerMessagesRecurrenceEditorSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class SchedulerMessagesRecurrenceEditorSettingsBuilder<T> where T : class, ISchedulerEvent
  {
    public SchedulerMessagesRecurrenceEditorSettingsBuilder(
      SchedulerMessagesRecurrenceEditorSettings<T> container)
    {
      this.Container = container;
    }

    protected SchedulerMessagesRecurrenceEditorSettings<T> Container { get; private set; }

    public SchedulerMessagesRecurrenceEditorSettingsBuilder<T> Cancel(
      string value)
    {
      this.Container.Cancel = value;
      return this;
    }

    public SchedulerMessagesRecurrenceEditorSettingsBuilder<T> Daily(
      Action<SchedulerMessagesRecurrenceEditorDailySettingsBuilder<T>> configurator)
    {
      this.Container.Daily.Scheduler = this.Container.Scheduler;
      configurator(new SchedulerMessagesRecurrenceEditorDailySettingsBuilder<T>(this.Container.Daily));
      return this;
    }

    public SchedulerMessagesRecurrenceEditorSettingsBuilder<T> End(
      Action<SchedulerMessagesRecurrenceEditorEndSettingsBuilder<T>> configurator)
    {
      this.Container.End.Scheduler = this.Container.Scheduler;
      configurator(new SchedulerMessagesRecurrenceEditorEndSettingsBuilder<T>(this.Container.End));
      return this;
    }

    public SchedulerMessagesRecurrenceEditorSettingsBuilder<T> EndTitle(
      string value)
    {
      this.Container.EndTitle = value;
      return this;
    }

    public SchedulerMessagesRecurrenceEditorSettingsBuilder<T> Frequencies(
      Action<SchedulerMessagesRecurrenceEditorFrequenciesSettingsBuilder<T>> configurator)
    {
      this.Container.Frequencies.Scheduler = this.Container.Scheduler;
      configurator(new SchedulerMessagesRecurrenceEditorFrequenciesSettingsBuilder<T>(this.Container.Frequencies));
      return this;
    }

    public SchedulerMessagesRecurrenceEditorSettingsBuilder<T> HeaderTitle(
      string value)
    {
      this.Container.HeaderTitle = value;
      return this;
    }

    public SchedulerMessagesRecurrenceEditorSettingsBuilder<T> Monthly(
      Action<SchedulerMessagesRecurrenceEditorMonthlySettingsBuilder<T>> configurator)
    {
      this.Container.Monthly.Scheduler = this.Container.Scheduler;
      configurator(new SchedulerMessagesRecurrenceEditorMonthlySettingsBuilder<T>(this.Container.Monthly));
      return this;
    }

    public SchedulerMessagesRecurrenceEditorSettingsBuilder<T> OffsetPositions(
      Action<SchedulerMessagesRecurrenceEditorOffsetPositionsSettingsBuilder<T>> configurator)
    {
      this.Container.OffsetPositions.Scheduler = this.Container.Scheduler;
      configurator(new SchedulerMessagesRecurrenceEditorOffsetPositionsSettingsBuilder<T>(this.Container.OffsetPositions));
      return this;
    }

    public SchedulerMessagesRecurrenceEditorSettingsBuilder<T> RecurrenceEditorTitle(
      string value)
    {
      this.Container.RecurrenceEditorTitle = value;
      return this;
    }

    public SchedulerMessagesRecurrenceEditorSettingsBuilder<T> RepeatTitle(
      string value)
    {
      this.Container.RepeatTitle = value;
      return this;
    }

    public SchedulerMessagesRecurrenceEditorSettingsBuilder<T> Update(
      string value)
    {
      this.Container.Update = value;
      return this;
    }

    public SchedulerMessagesRecurrenceEditorSettingsBuilder<T> Weekly(
      Action<SchedulerMessagesRecurrenceEditorWeeklySettingsBuilder<T>> configurator)
    {
      this.Container.Weekly.Scheduler = this.Container.Scheduler;
      configurator(new SchedulerMessagesRecurrenceEditorWeeklySettingsBuilder<T>(this.Container.Weekly));
      return this;
    }

    public SchedulerMessagesRecurrenceEditorSettingsBuilder<T> Weekdays(
      Action<SchedulerMessagesRecurrenceEditorWeekdaysSettingsBuilder<T>> configurator)
    {
      this.Container.Weekdays.Scheduler = this.Container.Scheduler;
      configurator(new SchedulerMessagesRecurrenceEditorWeekdaysSettingsBuilder<T>(this.Container.Weekdays));
      return this;
    }

    public SchedulerMessagesRecurrenceEditorSettingsBuilder<T> Yearly(
      Action<SchedulerMessagesRecurrenceEditorYearlySettingsBuilder<T>> configurator)
    {
      this.Container.Yearly.Scheduler = this.Container.Scheduler;
      configurator(new SchedulerMessagesRecurrenceEditorYearlySettingsBuilder<T>(this.Container.Yearly));
      return this;
    }
  }
}
