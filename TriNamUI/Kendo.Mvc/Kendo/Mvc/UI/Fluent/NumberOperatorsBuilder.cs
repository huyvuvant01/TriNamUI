// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.NumberOperatorsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class NumberOperatorsBuilder : IHideObjectMembers
  {
    private readonly NumberOperators numbers;

    public NumberOperatorsBuilder(NumberOperators operators) => this.numbers = operators;

    public NumberOperatorsBuilder Clear()
    {
      this.numbers.Operators.Clear();
      return this;
    }

    public NumberOperatorsBuilder IsEqualTo(string message)
    {
      this.numbers.Operators["eq"] = message;
      return this;
    }

    public NumberOperatorsBuilder IsNotEqualTo(string message)
    {
      this.numbers.Operators["neq"] = message;
      return this;
    }

    public NumberOperatorsBuilder IsGreaterThanOrEqualTo(string message)
    {
      this.numbers.Operators["gte"] = message;
      return this;
    }

    public NumberOperatorsBuilder IsGreaterThan(string message)
    {
      this.numbers.Operators["gt"] = message;
      return this;
    }

    public NumberOperatorsBuilder IsLessThanOrEqualTo(string message)
    {
      this.numbers.Operators["lte"] = message;
      return this;
    }

    public NumberOperatorsBuilder IsLessThan(string message)
    {
      this.numbers.Operators["lt"] = message;
      return this;
    }

    public NumberOperatorsBuilder IsNull(string message)
    {
      this.numbers.Operators["isnull"] = message;
      return this;
    }

    public NumberOperatorsBuilder IsNotNull(string message)
    {
      this.numbers.Operators["isnotnull"] = message;
      return this;
    }

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
