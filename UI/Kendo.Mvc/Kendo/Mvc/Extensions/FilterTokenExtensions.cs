// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.Extensions.FilterTokenExtensions
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Infrastructure.Implementation;
using System.Collections.Generic;

namespace Kendo.Mvc.Extensions
{
  public static class FilterTokenExtensions
  {
    private static readonly IDictionary<string, FilterOperator> tokenToOperator = (IDictionary<string, FilterOperator>) new Dictionary<string, FilterOperator>()
    {
      {
        "eq",
        FilterOperator.IsEqualTo
      },
      {
        "neq",
        FilterOperator.IsNotEqualTo
      },
      {
        "lt",
        FilterOperator.IsLessThan
      },
      {
        "lte",
        FilterOperator.IsLessThanOrEqualTo
      },
      {
        "gt",
        FilterOperator.IsGreaterThan
      },
      {
        "gte",
        FilterOperator.IsGreaterThanOrEqualTo
      },
      {
        "startswith",
        FilterOperator.StartsWith
      },
      {
        "contains",
        FilterOperator.Contains
      },
      {
        "notsubstringof",
        FilterOperator.DoesNotContain
      },
      {
        "endswith",
        FilterOperator.EndsWith
      },
      {
        "doesnotcontain",
        FilterOperator.DoesNotContain
      },
      {
        "isnotnull",
        FilterOperator.IsNotNull
      },
      {
        "isnull",
        FilterOperator.IsNull
      },
      {
        "isempty",
        FilterOperator.IsEmpty
      },
      {
        "isnotempty",
        FilterOperator.IsNotEmpty
      },
      {
        "isnullorempty",
        FilterOperator.IsNullOrEmpty
      },
      {
        "isnotnullorempty",
        FilterOperator.IsNotNullOrEmpty
      }
    };
    private static readonly IDictionary<FilterOperator, string> operatorToToken = (IDictionary<FilterOperator, string>) new Dictionary<FilterOperator, string>()
    {
      {
        FilterOperator.IsEqualTo,
        "eq"
      },
      {
        FilterOperator.IsNotEqualTo,
        "neq"
      },
      {
        FilterOperator.IsLessThan,
        "lt"
      },
      {
        FilterOperator.IsLessThanOrEqualTo,
        "lte"
      },
      {
        FilterOperator.IsGreaterThan,
        "gt"
      },
      {
        FilterOperator.IsGreaterThanOrEqualTo,
        "gte"
      },
      {
        FilterOperator.StartsWith,
        "startswith"
      },
      {
        FilterOperator.Contains,
        "contains"
      },
      {
        FilterOperator.DoesNotContain,
        "notsubstringof"
      },
      {
        FilterOperator.EndsWith,
        "endswith"
      },
      {
        FilterOperator.IsNotNull,
        "isnotnull"
      },
      {
        FilterOperator.IsNull,
        "isnull"
      },
      {
        FilterOperator.IsEmpty,
        "isempty"
      },
      {
        FilterOperator.IsNotEmpty,
        "isnotempty"
      },
      {
        FilterOperator.IsNullOrEmpty,
        "isnullorempty"
      },
      {
        FilterOperator.IsNotNullOrEmpty,
        "isnotnullorempty"
      }
    };

    public static FilterOperator ToFilterOperator(this FilterToken token) => FilterTokenExtensions.tokenToOperator[token.Value];

    public static string ToToken(this FilterOperator filterOperator) => FilterTokenExtensions.operatorToToken[filterOperator];
  }
}
