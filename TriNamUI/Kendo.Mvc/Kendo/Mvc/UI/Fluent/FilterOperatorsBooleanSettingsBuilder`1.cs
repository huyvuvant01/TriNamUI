// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.FilterOperatorsBooleanSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class FilterOperatorsBooleanSettingsBuilder<T> where T : class
  {
    public FilterOperatorsBooleanSettingsBuilder(FilterOperatorsBooleanSettings<T> container) => this.Container = container;

    protected FilterOperatorsBooleanSettings<T> Container { get; private set; }

    public FilterOperatorsBooleanSettingsBuilder<T> Custom(
      string name,
      Action<CustomFilterOperatorBuilder> configurator)
    {
      this.Container.Custom.Name = name;
      configurator(new CustomFilterOperatorBuilder(this.Container.Custom));
      return this;
    }

    public FilterOperatorsBooleanSettingsBuilder<T> Eq(
      string value)
    {
      this.Container.Operators["eq"] = value;
      return this;
    }

    public FilterOperatorsBooleanSettingsBuilder<T> Neq(
      string value)
    {
      this.Container.Operators["neq"] = value;
      return this;
    }
  }
}
