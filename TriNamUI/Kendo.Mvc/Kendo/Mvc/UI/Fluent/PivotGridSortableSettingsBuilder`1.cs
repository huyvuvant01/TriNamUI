﻿// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.PivotGridSortableSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class PivotGridSortableSettingsBuilder<T> where T : class
  {
    public PivotGridSortableSettingsBuilder(PivotGridSortableSettings<T> container) => this.Container = container;

    protected PivotGridSortableSettings<T> Container { get; private set; }

    public PivotGridSortableSettingsBuilder<T> AllowUnsort(
      bool value)
    {
      this.Container.AllowUnsort = new bool?(value);
      return this;
    }
  }
}