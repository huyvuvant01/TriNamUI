// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.SchedulerMessagesViewsSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class SchedulerMessagesViewsSettingsBuilder<T> where T : class, ISchedulerEvent
  {
    public SchedulerMessagesViewsSettingsBuilder(SchedulerMessagesViewsSettings<T> container) => this.Container = container;

    protected SchedulerMessagesViewsSettings<T> Container { get; private set; }

    public SchedulerMessagesViewsSettingsBuilder<T> Day(
      string value)
    {
      this.Container.Day = value;
      return this;
    }

    public SchedulerMessagesViewsSettingsBuilder<T> Week(
      string value)
    {
      this.Container.Week = value;
      return this;
    }

    public SchedulerMessagesViewsSettingsBuilder<T> Month(
      string value)
    {
      this.Container.Month = value;
      return this;
    }

    public SchedulerMessagesViewsSettingsBuilder<T> Agenda(
      string value)
    {
      this.Container.Agenda = value;
      return this;
    }

    public SchedulerMessagesViewsSettingsBuilder<T> TimelineMonth(
      string value)
    {
      this.Container.TimelineMonth = value;
      return this;
    }

    public SchedulerMessagesViewsSettingsBuilder<T> TimelineWeek(
      string value)
    {
      this.Container.TimelineWeek = value;
      return this;
    }

    public SchedulerMessagesViewsSettingsBuilder<T> Year(
      string value)
    {
      this.Container.Year = value;
      return this;
    }
  }
}
