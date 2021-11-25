// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.FilterOperatorsSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class FilterOperatorsSettingsBuilder<T> where T : class
  {
    public FilterOperatorsSettingsBuilder(FilterOperatorsSettings<T> container) => this.Container = container;

    protected FilterOperatorsSettings<T> Container { get; private set; }

    public FilterOperatorsSettingsBuilder<T> String(
      Action<FilterOperatorsStringSettingsBuilder<T>> configurator)
    {
      this.Container.String.Filter = this.Container.Filter;
      configurator(new FilterOperatorsStringSettingsBuilder<T>(this.Container.String));
      return this;
    }

    public FilterOperatorsSettingsBuilder<T> Number(
      Action<FilterOperatorsNumberSettingsBuilder<T>> configurator)
    {
      this.Container.Number.Filter = this.Container.Filter;
      configurator(new FilterOperatorsNumberSettingsBuilder<T>(this.Container.Number));
      return this;
    }

    public FilterOperatorsSettingsBuilder<T> Date(
      Action<FilterOperatorsDateSettingsBuilder<T>> configurator)
    {
      this.Container.Date.Filter = this.Container.Filter;
      configurator(new FilterOperatorsDateSettingsBuilder<T>(this.Container.Date));
      return this;
    }

    public FilterOperatorsSettingsBuilder<T> Boolean(
      Action<FilterOperatorsBooleanSettingsBuilder<T>> configurator)
    {
      this.Container.Boolean.Filter = this.Container.Filter;
      configurator(new FilterOperatorsBooleanSettingsBuilder<T>(this.Container.Boolean));
      return this;
    }
  }
}
