// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.StringOperators
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Resources;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class StringOperators : OperatorsBase
  {
    private const string DefaultIsEqualTo = "Is equal to";
    private const string DefaultIsNotEqualTo = "Is not equal to";
    private const string DefaultStartsWith = "Starts with";
    private const string DefaultEndsWith = "Ends with";
    private const string DefaultContains = "Contains";
    private const string DefaultDoesNotContain = "Does not contain";
    private const string DefaultIsNull = "Is null";
    private const string DefaultIsNotNull = "Is not null";
    private const string DefaultIsEmpty = "Is empty";
    private const string DefaultIsNotEmpty = "Is not empty";
    private const string DefaultIsNullOrEmpty = "Has no value";
    private const string DefaultIsNotNullOrEmpty = "Has value";
    private const int DefaultNumberOfFilters = 12;

    public StringOperators() => this.Operators = (IDictionary<string, string>) new Dictionary<string, string>()
    {
      {
        "eq",
        Messages.Filter_StringIsEqualTo
      },
      {
        "neq",
        Messages.Filter_StringIsNotEqualTo
      },
      {
        "startswith",
        Messages.Filter_StringStartsWith
      },
      {
        "endswith",
        Messages.Filter_StringEndsWith
      },
      {
        "contains",
        Messages.Filter_StringContains
      },
      {
        "doesnotcontain",
        Messages.Filter_StringDoesNotContain
      },
      {
        "isnull",
        Messages.Filter_StringIsNull
      },
      {
        "isnotnull",
        Messages.Filter_StringIsNotNull
      },
      {
        "isempty",
        Messages.Filter_StringIsEmpty
      },
      {
        "isnotempty",
        Messages.Filter_StringIsNotEmpty
      },
      {
        "isnullorempty",
        Messages.Filter_StringIsNullOrEmpty
      },
      {
        "isnotnullorempty",
        Messages.Filter_StringIsNotNullOrEmpty
      }
    };

    protected override void Serialize(IDictionary<string, object> json)
    {
      bool flag = false;
      if (this.Operators.Count != 12)
        flag = true;
      if (this.Operators.ContainsKey("eq") && this.Operators["eq"] != "Is equal to")
        flag = true;
      if (this.Operators.ContainsKey("neq") && this.Operators["neq"] != "Is not equal to")
        flag = true;
      if (this.Operators.ContainsKey("startswith") && this.Operators["startswith"] != "Starts with")
        flag = true;
      if (this.Operators.ContainsKey("endswith") && this.Operators["endswith"] != "Ends with")
        flag = true;
      if (this.Operators.ContainsKey("contains") && this.Operators["contains"] != "Contains")
        flag = true;
      if (this.Operators.ContainsKey("doesnotcontain") && this.Operators["doesnotcontain"] != "Does not contain")
        flag = true;
      if (this.Operators.ContainsKey("isnull") && this.Operators["isnull"] != "Is null")
        flag = true;
      if (this.Operators.ContainsKey("isnotnull") && this.Operators["isnotnull"] != "Is not null")
        flag = true;
      if (this.Operators.ContainsKey("isempty") && this.Operators["isempty"] != "Is empty")
        flag = true;
      if (this.Operators.ContainsKey("isnotempty") && this.Operators["isnotempty"] != "Is not empty")
        flag = true;
      if (this.Operators.ContainsKey("isnullorempty") && this.Operators["isnullorempty"] != "Has no value")
        flag = true;
      if (this.Operators.ContainsKey("isnotnullorempty") && this.Operators["isnotnullorempty"] != "Has value")
        flag = true;
      if (!flag)
        return;
      foreach (KeyValuePair<string, string> keyValuePair in (IEnumerable<KeyValuePair<string, string>>) this.Operators)
        json[keyValuePair.Key] = (object) keyValuePair.Value;
    }
  }
}
