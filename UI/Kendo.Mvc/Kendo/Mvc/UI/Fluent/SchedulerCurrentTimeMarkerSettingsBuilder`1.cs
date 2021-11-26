// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.SchedulerCurrentTimeMarkerSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class SchedulerCurrentTimeMarkerSettingsBuilder<T> where T : class, ISchedulerEvent
  {
    public SchedulerCurrentTimeMarkerSettingsBuilder(SchedulerCurrentTimeMarkerSettings<T> container) => this.Container = container;

    protected SchedulerCurrentTimeMarkerSettings<T> Container { get; private set; }

    public SchedulerCurrentTimeMarkerSettingsBuilder<T> UpdateInterval(
      double value)
    {
      this.Container.UpdateInterval = new double?(value);
      return this;
    }

    public SchedulerCurrentTimeMarkerSettingsBuilder<T> UseLocalTimezone(
      bool value)
    {
      this.Container.UseLocalTimezone = new bool?(value);
      return this;
    }
  }
}
