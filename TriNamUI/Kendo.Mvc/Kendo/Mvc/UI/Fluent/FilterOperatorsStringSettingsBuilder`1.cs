// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.FilterOperatorsStringSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class FilterOperatorsStringSettingsBuilder<T> where T : class
  {
    public FilterOperatorsStringSettingsBuilder(FilterOperatorsStringSettings<T> container) => this.Container = container;

    protected FilterOperatorsStringSettings<T> Container { get; private set; }

    public FilterOperatorsStringSettingsBuilder<T> Custom(
      string name,
      Action<CustomFilterOperatorBuilder> configurator)
    {
      this.Container.Custom.Name = name;
      configurator(new CustomFilterOperatorBuilder(this.Container.Custom));
      return this;
    }

    public FilterOperatorsStringSettingsBuilder<T> Eq(
      string value)
    {
      this.Container.Operators["eq"] = value;
      return this;
    }

    public FilterOperatorsStringSettingsBuilder<T> Neq(
      string value)
    {
      this.Container.Operators["neq"] = value;
      return this;
    }

    public FilterOperatorsStringSettingsBuilder<T> Isnull(
      string value)
    {
      this.Container.Operators["isnull"] = value;
      return this;
    }

    public FilterOperatorsStringSettingsBuilder<T> Isnotnull(
      string value)
    {
      this.Container.Operators["isnotnull"] = value;
      return this;
    }

    public FilterOperatorsStringSettingsBuilder<T> Isempty(
      string value)
    {
      this.Container.Operators["isempty"] = value;
      return this;
    }

    public FilterOperatorsStringSettingsBuilder<T> Isnotempty(
      string value)
    {
      this.Container.Operators["isnotempty"] = value;
      return this;
    }

    public FilterOperatorsStringSettingsBuilder<T> Startswith(
      string value)
    {
      this.Container.Operators["startswith"] = value;
      return this;
    }

    public FilterOperatorsStringSettingsBuilder<T> Contains(
      string value)
    {
      this.Container.Operators["contains"] = value;
      return this;
    }

    public FilterOperatorsStringSettingsBuilder<T> Doesnotcontain(
      string value)
    {
      this.Container.Operators["doesnotcontain"] = value;
      return this;
    }

    public FilterOperatorsStringSettingsBuilder<T> Endswith(
      string value)
    {
      this.Container.Operators["endswith"] = value;
      return this;
    }

    public FilterOperatorsStringSettingsBuilder<T> Isnullorempty(
      string value)
    {
      this.Container.Operators["isnullorempty"] = value;
      return this;
    }

    public FilterOperatorsStringSettingsBuilder<T> Isnotnullorempty(
      string value)
    {
      this.Container.Operators["isnotnullorempty"] = value;
      return this;
    }
  }
}
