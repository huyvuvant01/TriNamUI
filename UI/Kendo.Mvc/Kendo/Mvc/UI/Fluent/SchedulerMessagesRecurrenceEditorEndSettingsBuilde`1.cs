// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.SchedulerMessagesRecurrenceEditorEndSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class SchedulerMessagesRecurrenceEditorEndSettingsBuilder<T> where T : class, ISchedulerEvent
  {
    public SchedulerMessagesRecurrenceEditorEndSettingsBuilder(
      SchedulerMessagesRecurrenceEditorEndSettings<T> container)
    {
      this.Container = container;
    }

    protected SchedulerMessagesRecurrenceEditorEndSettings<T> Container { get; private set; }

    public SchedulerMessagesRecurrenceEditorEndSettingsBuilder<T> After(
      string value)
    {
      this.Container.After = value;
      return this;
    }

    public SchedulerMessagesRecurrenceEditorEndSettingsBuilder<T> Occurrence(
      string value)
    {
      this.Container.Occurrence = value;
      return this;
    }

    public SchedulerMessagesRecurrenceEditorEndSettingsBuilder<T> Label(
      string value)
    {
      this.Container.Label = value;
      return this;
    }

    public SchedulerMessagesRecurrenceEditorEndSettingsBuilder<T> Never(
      string value)
    {
      this.Container.Never = value;
      return this;
    }

    public SchedulerMessagesRecurrenceEditorEndSettingsBuilder<T> MobileLabel(
      string value)
    {
      this.Container.MobileLabel = value;
      return this;
    }

    public SchedulerMessagesRecurrenceEditorEndSettingsBuilder<T> On(
      string value)
    {
      this.Container.On = value;
      return this;
    }
  }
}
