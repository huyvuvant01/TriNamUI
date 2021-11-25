// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.SchedulerMessagesRecurrenceEditorDailySettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class SchedulerMessagesRecurrenceEditorDailySettingsBuilder<T> where T : class, ISchedulerEvent
  {
    public SchedulerMessagesRecurrenceEditorDailySettingsBuilder(
      SchedulerMessagesRecurrenceEditorDailySettings<T> container)
    {
      this.Container = container;
    }

    protected SchedulerMessagesRecurrenceEditorDailySettings<T> Container { get; private set; }

    public SchedulerMessagesRecurrenceEditorDailySettingsBuilder<T> Interval(
      string value)
    {
      this.Container.Interval = value;
      return this;
    }

    public SchedulerMessagesRecurrenceEditorDailySettingsBuilder<T> RepeatEvery(
      string value)
    {
      this.Container.RepeatEvery = value;
      return this;
    }
  }
}
