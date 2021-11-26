// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.SchedulerMessagesRecurrenceEditorOffsetPositionsSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class SchedulerMessagesRecurrenceEditorOffsetPositionsSettingsBuilder<T> where T : class, ISchedulerEvent
  {
    public SchedulerMessagesRecurrenceEditorOffsetPositionsSettingsBuilder(
      SchedulerMessagesRecurrenceEditorOffsetPositionsSettings<T> container)
    {
      this.Container = container;
    }

    protected SchedulerMessagesRecurrenceEditorOffsetPositionsSettings<T> Container { get; private set; }

    public SchedulerMessagesRecurrenceEditorOffsetPositionsSettingsBuilder<T> First(
      string value)
    {
      this.Container.First = value;
      return this;
    }

    public SchedulerMessagesRecurrenceEditorOffsetPositionsSettingsBuilder<T> Second(
      string value)
    {
      this.Container.Second = value;
      return this;
    }

    public SchedulerMessagesRecurrenceEditorOffsetPositionsSettingsBuilder<T> Third(
      string value)
    {
      this.Container.Third = value;
      return this;
    }

    public SchedulerMessagesRecurrenceEditorOffsetPositionsSettingsBuilder<T> Fourth(
      string value)
    {
      this.Container.Fourth = value;
      return this;
    }

    public SchedulerMessagesRecurrenceEditorOffsetPositionsSettingsBuilder<T> Last(
      string value)
    {
      this.Container.Last = value;
      return this;
    }
  }
}
