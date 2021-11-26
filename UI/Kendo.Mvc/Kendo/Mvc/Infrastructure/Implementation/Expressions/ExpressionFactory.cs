// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.Infrastructure.Implementation.Expressions.ExpressionFactory
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System;
using System.Linq.Expressions;
using System.Reflection;

namespace Kendo.Mvc.Infrastructure.Implementation.Expressions
{
  public static class ExpressionFactory
  {
    public static ConstantExpression ZeroExpression => Expression.Constant((object) 0);

    public static ConstantExpression EmptyStringExpression => Expression.Constant((object) string.Empty);

    public static Expression DefaltValueExpression(Type type) => (Expression) Expression.Constant(type.DefaultValue(), type);

    public static Expression MakeMemberAccess(Expression instance, string memberName)
    {
      foreach (IMemberAccessToken token in MemberAccessTokenizer.GetTokens(memberName))
        instance = token.CreateMemberAccessExpression(instance);
      return instance;
    }

    public static Expression MakeMemberAccess(
      Expression instance,
      string memberName,
      bool liftMemberAccessToNull)
    {
      Expression memberAccess = ExpressionFactory.MakeMemberAccess(instance, memberName);
      return liftMemberAccessToNull ? ExpressionFactory.LiftMemberAccessToNull(memberAccess) : memberAccess;
    }

    public static Expression LiftMemberAccessToNull(Expression memberAccess)
    {
      Expression defaultValue = ExpressionFactory.DefaltValueExpression(memberAccess.Type);
      return ExpressionFactory.LiftMemberAccessToNullRecursive(memberAccess, memberAccess, defaultValue);
    }

    public static Expression LiftMethodCallToNull(
      Expression instance,
      MethodInfo method,
      params Expression[] arguments)
    {
      return ExpressionFactory.LiftMemberAccessToNull((Expression) Expression.Call(ExpressionFactory.ExtractMemberAccessExpressionFromLiftedExpression(instance), method, arguments));
    }

    private static Expression LiftMemberAccessToNullRecursive(
      Expression memberAccess,
      Expression conditionalExpression,
      Expression defaultValue)
    {
      Expression expressionFromExpression = ExpressionFactory.GetInstanceExpressionFromExpression(memberAccess);
      if (expressionFromExpression == null)
        return conditionalExpression;
      conditionalExpression = ExpressionFactory.CreateIfNullExpression(expressionFromExpression, conditionalExpression, defaultValue);
      return ExpressionFactory.LiftMemberAccessToNullRecursive(expressionFromExpression, conditionalExpression, defaultValue);
    }

    private static Expression GetInstanceExpressionFromExpression(Expression memberAccess)
    {
      switch (memberAccess)
      {
        case MemberExpression memberExpression:
          return memberExpression.Expression;
        case MethodCallExpression methodCallExpression:
          return methodCallExpression.Object;
        default:
          return (Expression) null;
      }
    }

    private static Expression CreateIfNullExpression(
      Expression instance,
      Expression memberAccess,
      Expression defaultValue)
    {
      return ExpressionFactory.ShouldGenerateCondition(instance.Type) ? ExpressionFactory.CreateConditionExpression(instance, memberAccess, defaultValue) : memberAccess;
    }

    private static bool ShouldGenerateCondition(Type type) => !type.IsValueType() || type.IsNullableType();

    private static Expression CreateConditionExpression(
      Expression instance,
      Expression memberAccess,
      Expression defaultValue)
    {
      Expression right = ExpressionFactory.DefaltValueExpression(instance.Type);
      return (Expression) Expression.Condition((Expression) Expression.NotEqual(instance, right), memberAccess, defaultValue);
    }

    private static Expression ExtractMemberAccessExpressionFromLiftedExpression(
      Expression liftedToNullExpression)
    {
      ConditionalExpression conditionalExpression;
      for (; liftedToNullExpression.NodeType == ExpressionType.Conditional; liftedToNullExpression = conditionalExpression.Test.NodeType != ExpressionType.NotEqual ? conditionalExpression.IfFalse : conditionalExpression.IfTrue)
        conditionalExpression = (ConditionalExpression) liftedToNullExpression;
      return liftedToNullExpression;
    }

    internal static Expression LiftStringExpressionToEmpty(Expression stringExpression)
    {
      if (stringExpression.Type != typeof (string))
        throw new ArgumentException("Provided expression should have string type", nameof (stringExpression));
      return ExpressionFactory.IsNotNullConstantExpression(stringExpression) ? stringExpression : (Expression) Expression.Coalesce(stringExpression, (Expression) ExpressionFactory.EmptyStringExpression);
    }

    internal static bool IsNotNullConstantExpression(Expression expression) => expression.NodeType == ExpressionType.Constant && ((ConstantExpression) expression).Value != null;
  }
}
