// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.Extensions.ExpressionExtensions
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System.Collections.Concurrent;
using System.Linq.Expressions;

namespace Kendo.Mvc.Extensions
{
  public static class ExpressionExtensions
  {
    public static string MemberWithoutInstance(this LambdaExpression expression) => ExpressionHelper.GetExpressionText(expression, (ConcurrentDictionary<LambdaExpression, string>) null);

    public static bool IsBindable(this LambdaExpression expression)
    {
      switch (expression.Body.NodeType)
      {
        case ExpressionType.MemberAccess:
        case ExpressionType.Parameter:
          return true;
        default:
          return false;
      }
    }

    public static MemberExpression ToMemberExpression(
      this LambdaExpression expression)
    {
      if (!(expression.Body is MemberExpression memberExpression) && expression.Body is UnaryExpression body)
        memberExpression = body.Operand as MemberExpression;
      return memberExpression;
    }
  }
}
