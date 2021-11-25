// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.DateOperatorsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class DateOperatorsBuilder : IHideObjectMembers
  {
    private readonly DateOperators numbers;

    public DateOperatorsBuilder(DateOperators operators) => this.numbers = operators;

    public DateOperatorsBuilder Clear()
    {
      this.numbers.Operators.Clear();
      return this;
    }

    public DateOperatorsBuilder IsEqualTo(string message)
    {
      this.numbers.Operators["eq"] = message;
      return this;
    }

    public DateOperatorsBuilder IsNotEqualTo(string message)
    {
      this.numbers.Operators["neq"] = message;
      return this;
    }

    public DateOperatorsBuilder IsGreaterThanOrEqualTo(string message)
    {
      this.numbers.Operators["gte"] = message;
      return this;
    }

    public DateOperatorsBuilder IsGreaterThan(string message)
    {
      this.numbers.Operators["gt"] = message;
      return this;
    }

    public DateOperatorsBuilder IsLessThanOrEqualTo(string message)
    {
      this.numbers.Operators["lte"] = message;
      return this;
    }

    public DateOperatorsBuilder IsLessThan(string message)
    {
      this.numbers.Operators["lt"] = message;
      return this;
    }

    public DateOperatorsBuilder IsNull(string message)
    {
      this.numbers.Operators["isnull"] = message;
      return this;
    }

    public DateOperatorsBuilder IsNotNull(string message)
    {
      this.numbers.Operators["isnotnull"] = message;
      return this;
    }

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
