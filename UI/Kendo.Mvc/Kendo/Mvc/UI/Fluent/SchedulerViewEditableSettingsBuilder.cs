// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.SchedulerViewEditableSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class SchedulerViewEditableSettingsBuilder
  {
    private readonly SchedulerViewEditableSettings container;

    public SchedulerViewEditableSettingsBuilder(SchedulerViewEditableSettings container) => this.container = container;

    public SchedulerViewEditableSettingsBuilder Create(
      bool create)
    {
      this.container.Create = create;
      return this;
    }

    public SchedulerViewEditableSettingsBuilder Destroy(
      bool destroy)
    {
      this.container.Destroy = destroy;
      return this;
    }

    public SchedulerViewEditableSettingsBuilder Update(
      bool update)
    {
      this.container.Update = update;
      return this;
    }
  }
}
