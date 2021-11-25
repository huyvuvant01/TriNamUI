// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.SchedulerMessagesRecurrenceEditorFrequenciesSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class SchedulerMessagesRecurrenceEditorFrequenciesSettingsBuilder<T> where T : class, ISchedulerEvent
  {
    public SchedulerMessagesRecurrenceEditorFrequenciesSettingsBuilder(
      SchedulerMessagesRecurrenceEditorFrequenciesSettings<T> container)
    {
      this.Container = container;
    }

    protected SchedulerMessagesRecurrenceEditorFrequenciesSettings<T> Container { get; private set; }

    public SchedulerMessagesRecurrenceEditorFrequenciesSettingsBuilder<T> Daily(
      string value)
    {
      this.Container.Daily = value;
      return this;
    }

    public SchedulerMessagesRecurrenceEditorFrequenciesSettingsBuilder<T> Monthly(
      string value)
    {
      this.Container.Monthly = value;
      return this;
    }

    public SchedulerMessagesRecurrenceEditorFrequenciesSettingsBuilder<T> Never(
      string value)
    {
      this.Container.Never = value;
      return this;
    }

    public SchedulerMessagesRecurrenceEditorFrequenciesSettingsBuilder<T> Weekly(
      string value)
    {
      this.Container.Weekly = value;
      return this;
    }

    public SchedulerMessagesRecurrenceEditorFrequenciesSettingsBuilder<T> Yearly(
      string value)
    {
      this.Container.Yearly = value;
      return this;
    }
  }
}
