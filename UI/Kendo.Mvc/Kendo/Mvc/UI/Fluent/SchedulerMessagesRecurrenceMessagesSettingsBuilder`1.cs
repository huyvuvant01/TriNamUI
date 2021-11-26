// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.SchedulerMessagesRecurrenceMessagesSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class SchedulerMessagesRecurrenceMessagesSettingsBuilder<T> where T : class, ISchedulerEvent
  {
    public SchedulerMessagesRecurrenceMessagesSettingsBuilder(
      SchedulerMessagesRecurrenceMessagesSettings<T> container)
    {
      this.Container = container;
    }

    protected SchedulerMessagesRecurrenceMessagesSettings<T> Container { get; private set; }

    public SchedulerMessagesRecurrenceMessagesSettingsBuilder<T> DeleteRecurring(
      string value)
    {
      this.Container.DeleteRecurring = value;
      return this;
    }

    public SchedulerMessagesRecurrenceMessagesSettingsBuilder<T> DeleteWindowOccurrence(
      string value)
    {
      this.Container.DeleteWindowOccurrence = value;
      return this;
    }

    public SchedulerMessagesRecurrenceMessagesSettingsBuilder<T> DeleteWindowSeries(
      string value)
    {
      this.Container.DeleteWindowSeries = value;
      return this;
    }

    public SchedulerMessagesRecurrenceMessagesSettingsBuilder<T> DeleteWindowTitle(
      string value)
    {
      this.Container.DeleteWindowTitle = value;
      return this;
    }

    public SchedulerMessagesRecurrenceMessagesSettingsBuilder<T> EditRecurring(
      string value)
    {
      this.Container.EditRecurring = value;
      return this;
    }

    public SchedulerMessagesRecurrenceMessagesSettingsBuilder<T> EditWindowOccurrence(
      string value)
    {
      this.Container.EditWindowOccurrence = value;
      return this;
    }

    public SchedulerMessagesRecurrenceMessagesSettingsBuilder<T> EditWindowSeries(
      string value)
    {
      this.Container.EditWindowSeries = value;
      return this;
    }

    public SchedulerMessagesRecurrenceMessagesSettingsBuilder<T> EditWindowTitle(
      string value)
    {
      this.Container.EditWindowTitle = value;
      return this;
    }

    public SchedulerMessagesRecurrenceMessagesSettingsBuilder<T> ResetSeriesWindowTitle(
      string value)
    {
      this.Container.ResetSeriesWindowTitle = value;
      return this;
    }
  }
}
