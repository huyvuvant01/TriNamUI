// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.Infrastructure.Implementation.Expressions.MemberAccessExpressionBuilderBase
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Linq.Expressions;

namespace Kendo.Mvc.Infrastructure.Implementation.Expressions
{
  public abstract class MemberAccessExpressionBuilderBase : ExpressionBuilderBase
  {
    private readonly string memberName;

    protected MemberAccessExpressionBuilderBase(Type itemType, string memberName)
      : base(itemType)
    {
      this.memberName = memberName;
    }

    public string MemberName => this.memberName;

    public abstract Expression CreateMemberAccessExpression();

    public LambdaExpression CreateLambdaExpression() => Expression.Lambda(this.CreateMemberAccessExpression(), this.ParameterExpression);
  }
}
