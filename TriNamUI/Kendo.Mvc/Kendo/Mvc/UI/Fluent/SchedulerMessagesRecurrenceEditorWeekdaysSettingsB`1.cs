// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.SchedulerMessagesRecurrenceEditorWeekdaysSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class SchedulerMessagesRecurrenceEditorWeekdaysSettingsBuilder<T> where T : class, ISchedulerEvent
  {
    public SchedulerMessagesRecurrenceEditorWeekdaysSettingsBuilder(
      SchedulerMessagesRecurrenceEditorWeekdaysSettings<T> container)
    {
      this.Container = container;
    }

    protected SchedulerMessagesRecurrenceEditorWeekdaysSettings<T> Container { get; private set; }

    public SchedulerMessagesRecurrenceEditorWeekdaysSettingsBuilder<T> Day(
      string value)
    {
      this.Container.Day = value;
      return this;
    }

    public SchedulerMessagesRecurrenceEditorWeekdaysSettingsBuilder<T> Weekday(
      string value)
    {
      this.Container.Weekday = value;
      return this;
    }

    public SchedulerMessagesRecurrenceEditorWeekdaysSettingsBuilder<T> Weekend(
      string value)
    {
      this.Container.Weekend = value;
      return this;
    }
  }
}
