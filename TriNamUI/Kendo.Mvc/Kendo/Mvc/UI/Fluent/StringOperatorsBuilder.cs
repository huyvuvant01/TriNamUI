// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.StringOperatorsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class StringOperatorsBuilder : IHideObjectMembers
  {
    private readonly StringOperators strings;

    public StringOperatorsBuilder(StringOperators operators) => this.strings = operators;

    public StringOperatorsBuilder Clear()
    {
      this.strings.Operators.Clear();
      return this;
    }

    public StringOperatorsBuilder IsEqualTo(string message)
    {
      this.strings.Operators["eq"] = message;
      return this;
    }

    public StringOperatorsBuilder IsNotEqualTo(string message)
    {
      this.strings.Operators["neq"] = message;
      return this;
    }

    public StringOperatorsBuilder StartsWith(string message)
    {
      this.strings.Operators["startswith"] = message;
      return this;
    }

    public StringOperatorsBuilder EndsWith(string message)
    {
      this.strings.Operators["endswith"] = message;
      return this;
    }

    public StringOperatorsBuilder Contains(string message)
    {
      this.strings.Operators["contains"] = message;
      return this;
    }

    public StringOperatorsBuilder DoesNotContain(string message)
    {
      this.strings.Operators["doesnotcontain"] = message;
      return this;
    }

    public StringOperatorsBuilder IsNull(string message)
    {
      this.strings.Operators["isnull"] = message;
      return this;
    }

    public StringOperatorsBuilder IsNotNull(string message)
    {
      this.strings.Operators["isnotnull"] = message;
      return this;
    }

    public StringOperatorsBuilder IsEmpty(string message)
    {
      this.strings.Operators["isempty"] = message;
      return this;
    }

    public StringOperatorsBuilder IsNotEmpty(string message)
    {
      this.strings.Operators["isnotempty"] = message;
      return this;
    }

    public StringOperatorsBuilder IsNullOrEmpty(string message)
    {
      this.strings.Operators["isnullorempty"] = message;
      return this;
    }

    public StringOperatorsBuilder IsNotNullOrEmpty(string message)
    {
      this.strings.Operators["isnotnullorempty"] = message;
      return this;
    }

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
