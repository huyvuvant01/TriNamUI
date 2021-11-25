// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.Infrastructure.Implementation.Expressions.PropertyAccessExpressionBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Linq.Expressions;

namespace Kendo.Mvc.Infrastructure.Implementation.Expressions
{
  internal class PropertyAccessExpressionBuilder : MemberAccessExpressionBuilderBase
  {
    public PropertyAccessExpressionBuilder(Type itemType, string memberName)
      : base(itemType, memberName)
    {
    }

    public override Expression CreateMemberAccessExpression() => string.IsNullOrEmpty(this.MemberName) ? (Expression) this.ParameterExpression : ExpressionFactory.MakeMemberAccess((Expression) this.ParameterExpression, this.MemberName, this.Options.LiftMemberAccessToNull);
  }
}
