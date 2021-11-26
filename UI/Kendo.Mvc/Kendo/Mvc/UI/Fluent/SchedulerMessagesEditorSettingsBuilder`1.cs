// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.SchedulerMessagesEditorSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class SchedulerMessagesEditorSettingsBuilder<T> where T : class, ISchedulerEvent
  {
    public SchedulerMessagesEditorSettingsBuilder(SchedulerMessagesEditorSettings<T> container) => this.Container = container;

    protected SchedulerMessagesEditorSettings<T> Container { get; private set; }

    public SchedulerMessagesEditorSettingsBuilder<T> AllDayEvent(
      string value)
    {
      this.Container.AllDayEvent = value;
      return this;
    }

    public SchedulerMessagesEditorSettingsBuilder<T> Description(
      string value)
    {
      this.Container.Description = value;
      return this;
    }

    public SchedulerMessagesEditorSettingsBuilder<T> EditorTitle(
      string value)
    {
      this.Container.EditorTitle = value;
      return this;
    }

    public SchedulerMessagesEditorSettingsBuilder<T> End(
      string value)
    {
      this.Container.End = value;
      return this;
    }

    public SchedulerMessagesEditorSettingsBuilder<T> EndTimezone(
      string value)
    {
      this.Container.EndTimezone = value;
      return this;
    }

    public SchedulerMessagesEditorSettingsBuilder<T> Repeat(
      string value)
    {
      this.Container.Repeat = value;
      return this;
    }

    public SchedulerMessagesEditorSettingsBuilder<T> SeparateTimezones(
      string value)
    {
      this.Container.SeparateTimezones = value;
      return this;
    }

    public SchedulerMessagesEditorSettingsBuilder<T> Start(
      string value)
    {
      this.Container.Start = value;
      return this;
    }

    public SchedulerMessagesEditorSettingsBuilder<T> StartTimezone(
      string value)
    {
      this.Container.StartTimezone = value;
      return this;
    }

    public SchedulerMessagesEditorSettingsBuilder<T> Timezone(
      string value)
    {
      this.Container.Timezone = value;
      return this;
    }

    public SchedulerMessagesEditorSettingsBuilder<T> TimezoneEditorButton(
      string value)
    {
      this.Container.TimezoneEditorButton = value;
      return this;
    }

    public SchedulerMessagesEditorSettingsBuilder<T> TimezoneEditorTitle(
      string value)
    {
      this.Container.TimezoneEditorTitle = value;
      return this;
    }

    public SchedulerMessagesEditorSettingsBuilder<T> Title(
      string value)
    {
      this.Container.Title = value;
      return this;
    }
  }
}
