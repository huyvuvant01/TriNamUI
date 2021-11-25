// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.SchedulerToolbarFactory`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class SchedulerToolbarFactory<T> : IHideObjectMembers where T : class, ISchedulerEvent
  {
    private readonly Scheduler<T> container;

    public SchedulerToolbarFactory(Scheduler<T> container) => this.container = container;

    public void Pdf() => this.container.ToolbarCommands.Add(new SchedulerToolbarCommand(SchedulerToolbarCommandType.Pdf));

    public void Search() => this.container.ToolbarCommands.Add(new SchedulerToolbarCommand(SchedulerToolbarCommandType.Search));

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
