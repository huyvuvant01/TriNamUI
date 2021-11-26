// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.AggregateFunction
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq.Expressions;

namespace Kendo.Mvc
{
  public abstract class AggregateFunction : JsonObject
  {
    private string functionName;

    public abstract string AggregateMethodName { get; }

    public string Caption { get; set; }

    public virtual string SourceField { get; set; }

    public virtual string FunctionName
    {
      get
      {
        if (string.IsNullOrEmpty(this.functionName))
          this.functionName = this.GenerateFunctionName();
        return this.functionName;
      }
      set => this.functionName = value;
    }

    public Type MemberType { get; set; }

    public virtual string ResultFormatString { get; set; }

    public abstract Expression CreateAggregateExpression(
      Expression enumerableExpression,
      bool liftMemberAccessToNull);

    protected virtual string GenerateFunctionName() => string.Format((IFormatProvider) CultureInfo.InvariantCulture, "{0}", (object) this.GetType().Name);

    protected override void Serialize(IDictionary<string, object> json)
    {
      json["field"] = (object) this.SourceField;
      json["aggregate"] = (object) this.FunctionName.Split('_')[0].ToLowerInvariant();
    }
  }
}
