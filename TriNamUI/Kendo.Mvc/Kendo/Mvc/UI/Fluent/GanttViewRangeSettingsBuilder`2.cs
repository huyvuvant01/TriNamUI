﻿// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.GanttViewRangeSettingsBuilder`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class GanttViewRangeSettingsBuilder<TTaskModel, TDependenciesModel>
    where TTaskModel : class, IGanttTask
    where TDependenciesModel : class, IGanttDependency
  {
    public GanttViewRangeSettingsBuilder(
      GanttViewRangeSettings<TTaskModel, TDependenciesModel> container)
    {
      this.Container = container;
    }

    protected GanttViewRangeSettings<TTaskModel, TDependenciesModel> Container { get; private set; }

    public GanttViewRangeSettingsBuilder<TTaskModel, TDependenciesModel> Start(
      DateTime value)
    {
      this.Container.Start = new DateTime?(value);
      return this;
    }

    public GanttViewRangeSettingsBuilder<TTaskModel, TDependenciesModel> End(
      DateTime value)
    {
      this.Container.End = new DateTime?(value);
      return this;
    }
  }
}
