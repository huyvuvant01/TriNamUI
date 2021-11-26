// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.EnumOperatorsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class EnumOperatorsBuilder : IHideObjectMembers
  {
    private readonly EnumOperators enums;

    public EnumOperatorsBuilder(EnumOperators operators) => this.enums = operators;

    public EnumOperatorsBuilder Clear()
    {
      this.enums.Operators.Clear();
      return this;
    }

    public EnumOperatorsBuilder IsEqualTo(string message)
    {
      this.enums.Operators["eq"] = message;
      return this;
    }

    public EnumOperatorsBuilder IsNotEqualTo(string message)
    {
      this.enums.Operators["neq"] = message;
      return this;
    }

    public EnumOperatorsBuilder IsNull(string message)
    {
      this.enums.Operators["isnull"] = message;
      return this;
    }

    public EnumOperatorsBuilder IsNotNull(string message)
    {
      this.enums.Operators["isnotnull"] = message;
      return this;
    }

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
