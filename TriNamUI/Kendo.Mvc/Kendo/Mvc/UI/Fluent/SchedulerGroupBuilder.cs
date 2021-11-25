// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.SchedulerGroupBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class SchedulerGroupBuilder : IHideObjectMembers
  {
    private readonly SchedulerGroupSettings settings;

    public SchedulerGroupBuilder(SchedulerGroupSettings settings) => this.settings = settings;

    public SchedulerGroupBuilder Resources(params string[] names)
    {
      this.settings.Resources = names;
      return this;
    }

    public SchedulerGroupBuilder Orientation(SchedulerGroupOrientation value)
    {
      this.settings.Orientation = value;
      return this;
    }

    public SchedulerGroupBuilder Date(bool date)
    {
      this.settings.Date = date;
      return this;
    }

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
