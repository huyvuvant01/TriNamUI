// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.EnumOperators
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Resources;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class EnumOperators : OperatorsBase
  {
    private const int DefaultDateOfFilters = 4;
    private const string DefaultIsEqualTo = "Is equal to";
    private const string DefaultIsNotEqualTo = "Is not equal to";
    private const string DefaultIsNull = "Is null";
    private const string DefaultIsNotNull = "Is not null";

    public EnumOperators() => this.Operators = (IDictionary<string, string>) new Dictionary<string, string>()
    {
      {
        "eq",
        Messages.Filter_EnumIsEqualTo
      },
      {
        "neq",
        Messages.Filter_EnumIsNotEqualTo
      },
      {
        "isnull",
        Messages.Filter_EnumIsNull
      },
      {
        "isnotnull",
        Messages.Filter_EnumIsNotNull
      }
    };

    protected override void Serialize(IDictionary<string, object> json)
    {
      bool flag = false;
      if (this.Operators.Count != 4)
        flag = true;
      if (this.Operators.ContainsKey("eq") && this.Operators["eq"] != "Is equal to")
        flag = true;
      if (this.Operators.ContainsKey("neq") && this.Operators["neq"] != "Is not equal to")
        flag = true;
      if (this.Operators.ContainsKey("isnull") && this.Operators["isnull"] != "Is null")
        flag = true;
      if (this.Operators.ContainsKey("isnotnull") && this.Operators["isnotnull"] != "Is not null")
        flag = true;
      if (!flag)
        return;
      foreach (KeyValuePair<string, string> keyValuePair in (IEnumerable<KeyValuePair<string, string>>) this.Operators)
        json[keyValuePair.Key] = (object) keyValuePair.Value;
    }
  }
}
