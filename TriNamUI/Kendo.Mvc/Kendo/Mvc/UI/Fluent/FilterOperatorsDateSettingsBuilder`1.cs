// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.FilterOperatorsDateSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class FilterOperatorsDateSettingsBuilder<T> where T : class
  {
    public FilterOperatorsDateSettingsBuilder(FilterOperatorsDateSettings<T> container) => this.Container = container;

    protected FilterOperatorsDateSettings<T> Container { get; private set; }

    public FilterOperatorsDateSettingsBuilder<T> Custom(
      string name,
      Action<CustomFilterOperatorBuilder> configurator)
    {
      this.Container.Custom.Name = name;
      configurator(new CustomFilterOperatorBuilder(this.Container.Custom));
      return this;
    }

    public FilterOperatorsDateSettingsBuilder<T> Eq(string value)
    {
      this.Container.Operators["eq"] = value;
      return this;
    }

    public FilterOperatorsDateSettingsBuilder<T> Neq(string value)
    {
      this.Container.Operators["neq"] = value;
      return this;
    }

    public FilterOperatorsDateSettingsBuilder<T> Isnull(
      string value)
    {
      this.Container.Operators["isnull"] = value;
      return this;
    }

    public FilterOperatorsDateSettingsBuilder<T> Isnotnull(
      string value)
    {
      this.Container.Operators["isnotnull"] = value;
      return this;
    }

    public FilterOperatorsDateSettingsBuilder<T> Gte(string value)
    {
      this.Container.Operators["gte"] = value;
      return this;
    }

    public FilterOperatorsDateSettingsBuilder<T> Gt(string value)
    {
      this.Container.Operators["gt"] = value;
      return this;
    }

    public FilterOperatorsDateSettingsBuilder<T> Lte(string value)
    {
      this.Container.Operators["lte"] = value;
      return this;
    }

    public FilterOperatorsDateSettingsBuilder<T> Lt(string value)
    {
      this.Container.Operators["lt"] = value;
      return this;
    }
  }
}
