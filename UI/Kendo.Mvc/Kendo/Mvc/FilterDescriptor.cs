// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.FilterDescriptor
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Infrastructure.Implementation.Expressions;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Kendo.Mvc
{
  public class FilterDescriptor : FilterDescriptorBase
  {
    public FilterDescriptor()
      : this(string.Empty, FilterOperator.IsEqualTo, (object) null)
    {
    }

    public FilterDescriptor(string member, FilterOperator filterOperator, object filterValue)
    {
      this.Member = member;
      this.Operator = filterOperator;
      this.Value = filterValue;
    }

    public object ConvertedValue => this.Value;

    public string Member { get; set; }

    public Type MemberType { get; set; }

    public FilterOperator Operator { get; set; }

    public object Value { get; set; }

    protected override Expression CreateFilterExpression(
      ParameterExpression parameterExpression)
    {
      FilterDescriptorExpressionBuilder expressionBuilder = new FilterDescriptorExpressionBuilder(parameterExpression, this);
      expressionBuilder.Options.CopyFrom(this.ExpressionBuilderOptions);
      return expressionBuilder.CreateBodyExpression();
    }

    public virtual bool Equals(FilterDescriptor other)
    {
      if (other == null)
        return false;
      if (this == other)
        return true;
      return object.Equals((object) other.Operator, (object) this.Operator) && object.Equals((object) other.Member, (object) this.Member) && object.Equals(other.Value, this.Value);
    }

    public override bool Equals(object obj) => obj is FilterDescriptor other && this.Equals(other);

    public override int GetHashCode() => (this.Operator.GetHashCode() * 397 ^ (this.Member != null ? this.Member.GetHashCode() : 0)) * 397 ^ (this.Value != null ? this.Value.GetHashCode() : 0);

    protected override void Serialize(IDictionary<string, object> json)
    {
      base.Serialize(json);
      json["field"] = (object) this.Member;
      json["operator"] = (object) this.Operator.ToToken();
      if (this.Value != null && this.Value.GetType().IsEnumType())
      {
        Type underlyingType = Enum.GetUnderlyingType(this.Value.GetType().GetNonNullableType());
        json["value"] = Convert.ChangeType(this.Value, underlyingType);
      }
      else
        json["value"] = this.Value;
    }
  }
}
