// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.NumberOperators
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Resources;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class NumberOperators : OperatorsBase
  {
    private const int DefaultNumberOfFilters = 8;
    private const string DefaultIsEqualTo = "Is equal to";
    private const string DefaultIsNotEqualTo = "Is not equal to";
    private const string DefaultIsGreaterThanOrEqualTo = "Is greater than or equal to";
    private const string DefaultIsGreaterThan = "Is greater than";
    private const string DefaultIsLessThanOrEqualTo = "Is less than or equal to";
    private const string DefaultIsLessThan = "Is less than";
    private const string DefaultIsNull = "Is null";
    private const string DefaultIsNotNull = "Is not null";

    public NumberOperators() => this.Operators = (IDictionary<string, string>) new Dictionary<string, string>()
    {
      {
        "eq",
        Messages.Filter_NumberIsEqualTo
      },
      {
        "neq",
        Messages.Filter_NumberIsNotEqualTo
      },
      {
        "gte",
        Messages.Filter_NumberIsGreaterThanOrEqualTo
      },
      {
        "gt",
        Messages.Filter_NumberIsGreaterThan
      },
      {
        "lte",
        Messages.Filter_NumberIsLessThanOrEqualTo
      },
      {
        "lt",
        Messages.Filter_NumberIsLessThan
      },
      {
        "isnull",
        Messages.Filter_NumberIsNull
      },
      {
        "isnotnull",
        Messages.Filter_NumberIsNotNull
      }
    };

    protected override void Serialize(IDictionary<string, object> json)
    {
      bool flag = false;
      if (this.Operators.Count != 8)
        flag = true;
      if (this.Operators.ContainsKey("eq") && this.Operators["eq"] != "Is equal to")
        flag = true;
      if (this.Operators.ContainsKey("neq") && this.Operators["neq"] != "Is not equal to")
        flag = true;
      if (this.Operators.ContainsKey("gte") && this.Operators["gte"] != "Is greater than or equal to")
        flag = true;
      if (this.Operators.ContainsKey("gt") && this.Operators["gt"] != "Is greater than")
        flag = true;
      if (this.Operators.ContainsKey("lte") && this.Operators["lte"] != "Is less than or equal to")
        flag = true;
      if (this.Operators.ContainsKey("lt") && this.Operators["lt"] != "Is less than")
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
