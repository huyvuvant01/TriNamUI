// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.SchedulerMessagesRecurrenceEditorMonthlySettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class SchedulerMessagesRecurrenceEditorMonthlySettingsBuilder<T> where T : class, ISchedulerEvent
  {
    public SchedulerMessagesRecurrenceEditorMonthlySettingsBuilder(
      SchedulerMessagesRecurrenceEditorMonthlySettings<T> container)
    {
      this.Container = container;
    }

    protected SchedulerMessagesRecurrenceEditorMonthlySettings<T> Container { get; private set; }

    public SchedulerMessagesRecurrenceEditorMonthlySettingsBuilder<T> Day(
      string value)
    {
      this.Container.Day = value;
      return this;
    }

    public SchedulerMessagesRecurrenceEditorMonthlySettingsBuilder<T> Date(
      string value)
    {
      this.Container.Date = value;
      return this;
    }

    public SchedulerMessagesRecurrenceEditorMonthlySettingsBuilder<T> Interval(
      string value)
    {
      this.Container.Interval = value;
      return this;
    }

    public SchedulerMessagesRecurrenceEditorMonthlySettingsBuilder<T> RepeatEvery(
      string value)
    {
      this.Container.RepeatEvery = value;
      return this;
    }

    public SchedulerMessagesRecurrenceEditorMonthlySettingsBuilder<T> RepeatOn(
      string value)
    {
      this.Container.RepeatOn = value;
      return this;
    }
  }
}
