// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.FilterableOperatorsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class FilterableOperatorsBuilder : IHideObjectMembers
  {
    private readonly GridFilterableOperators operators;

    public FilterableOperatorsBuilder(GridFilterableOperators operators) => this.operators = operators;

    public FilterableOperatorsBuilder ForString(
      Action<StringOperatorsBuilder> configurator)
    {
      configurator(new StringOperatorsBuilder(this.operators.Strings));
      return this;
    }

    public FilterableOperatorsBuilder ForNumber(
      Action<NumberOperatorsBuilder> configurator)
    {
      configurator(new NumberOperatorsBuilder(this.operators.Numbers));
      return this;
    }

    public FilterableOperatorsBuilder ForDate(
      Action<DateOperatorsBuilder> configurator)
    {
      configurator(new DateOperatorsBuilder(this.operators.Dates));
      return this;
    }

    public FilterableOperatorsBuilder ForEnums(
      Action<EnumOperatorsBuilder> configurator)
    {
      configurator(new EnumOperatorsBuilder(this.operators.Enums));
      return this;
    }

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
