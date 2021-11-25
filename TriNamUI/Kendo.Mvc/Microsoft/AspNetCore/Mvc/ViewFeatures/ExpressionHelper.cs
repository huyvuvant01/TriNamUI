// Decompiled with JetBrains decompiler
// Type: Microsoft.AspNetCore.Mvc.ViewFeatures.ExpressionHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Concurrent;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;

namespace Microsoft.AspNetCore.Mvc.ViewFeatures
{
  internal static class ExpressionHelper
  {
    public static string GetUncachedExpressionText(LambdaExpression expression) => ExpressionHelper.GetExpressionText(expression, (ConcurrentDictionary<LambdaExpression, string>) null);

    public static string GetExpressionText(
      LambdaExpression expression,
      ConcurrentDictionary<LambdaExpression, string> expressionTextCache)
    {
      if (expression == null)
        throw new ArgumentNullException(nameof (expression));
      string str1;
      if (expressionTextCache != null && expressionTextCache.TryGetValue(expression, out str1))
        return str1;
      bool flag1 = false;
      bool flag2 = false;
      int capacity = 0;
      int num1 = 0;
      int num2 = 0;
      Expression expression1 = expression.Body;
      while (expression1 != null)
      {
        switch (expression1.NodeType)
        {
          case ExpressionType.ArrayIndex:
            BinaryExpression binaryExpression1 = (BinaryExpression) expression1;
            flag1 = true;
            flag2 = false;
            capacity += "[99]".Length;
            expression1 = binaryExpression1.Left;
            ++num1;
            num2 = 0;
            continue;
          case ExpressionType.Call:
            flag1 = true;
            flag2 = false;
            MethodCallExpression methodCallExpression1 = (MethodCallExpression) expression1;
            if (ExpressionHelper.IsSingleArgumentIndexer((Expression) methodCallExpression1))
            {
              capacity += "[99]".Length;
              expression1 = methodCallExpression1.Object;
              ++num1;
              num2 = 0;
              continue;
            }
            expression1 = (Expression) null;
            continue;
          case ExpressionType.MemberAccess:
            MemberExpression memberExpression1 = (MemberExpression) expression1;
            string name1 = memberExpression1.Member.Name;
            if (name1.Contains("__"))
            {
              expression1 = (Expression) null;
              continue;
            }
            flag2 = string.Equals("model", name1, StringComparison.OrdinalIgnoreCase);
            capacity += name1.Length + 1;
            expression1 = memberExpression1.Expression;
            ++num1;
            ++num2;
            continue;
          case ExpressionType.Parameter:
            flag2 = false;
            expression1 = (Expression) null;
            continue;
          default:
            expression1 = (Expression) null;
            continue;
        }
      }
      if (flag2)
      {
        capacity -= ".model".Length;
        --num1;
        --num2;
      }
      if (num2 > 0)
        --capacity;
      if (num1 == 0)
      {
        expressionTextCache?.TryAdd(expression, string.Empty);
        return string.Empty;
      }
      StringBuilder builder = new StringBuilder(capacity);
      Expression expression2 = expression.Body;
      while (expression2 != null && num1 > 0)
      {
        --num1;
        switch (expression2.NodeType)
        {
          case ExpressionType.ArrayIndex:
            BinaryExpression binaryExpression2 = (BinaryExpression) expression2;
            ExpressionHelper.InsertIndexerInvocationText(builder, binaryExpression2.Right, expression);
            expression2 = binaryExpression2.Left;
            continue;
          case ExpressionType.Call:
            MethodCallExpression methodCallExpression2 = (MethodCallExpression) expression2;
            ExpressionHelper.InsertIndexerInvocationText(builder, methodCallExpression2.Arguments.Single<Expression>(), expression);
            expression2 = methodCallExpression2.Object;
            continue;
          case ExpressionType.MemberAccess:
            MemberExpression memberExpression2 = (MemberExpression) expression2;
            string name2 = memberExpression2.Member.Name;
            builder.Insert(0, name2);
            if (num1 > 0)
              builder.Insert(0, '.');
            expression2 = memberExpression2.Expression;
            continue;
          default:
            continue;
        }
      }
      string str2 = builder.ToString();
      if (expressionTextCache != null && !flag1)
        expressionTextCache.TryAdd(expression, str2);
      return str2;
    }

    private static void InsertIndexerInvocationText(
      StringBuilder builder,
      Expression indexExpression,
      LambdaExpression parentExpression)
    {
      if (builder == null)
        throw new ArgumentNullException(nameof (builder));
      if (indexExpression == null)
        throw new ArgumentNullException(nameof (indexExpression));
      if (parentExpression == null)
        throw new ArgumentNullException(nameof (parentExpression));
      if (parentExpression.Parameters == null)
        throw new ArgumentException(Resources.FormatPropertyOfTypeCannotBeNull((object) "Parameters", (object) nameof (parentExpression)));
      Expression<Func<object, object>> expression = Expression.Lambda<Func<object, object>>((Expression) Expression.Convert(indexExpression, typeof (object)), Expression.Parameter(typeof (object), (string) null));
      Func<object, object> func;
      try
      {
        func = CachedExpressionCompiler.Process<object, object>(expression) ?? expression.Compile();
      }
      catch (InvalidOperationException ex)
      {
        ParameterExpression[] array = parentExpression.Parameters.ToArray<ParameterExpression>();
        throw new InvalidOperationException(Resources.FormatExpressionHelper_InvalidIndexerExpression((object) indexExpression, (object) array[0].Name), (Exception) ex);
      }
      builder.Insert(0, ']');
      builder.Insert(0, Convert.ToString(func((object) null), (IFormatProvider) CultureInfo.InvariantCulture));
      builder.Insert(0, '[');
    }

    public static bool IsSingleArgumentIndexer(Expression expression)
    {
      if (!(expression is MethodCallExpression methodCallExpression) || methodCallExpression.Arguments.Count != 1)
        return false;
      Type declaringType = methodCallExpression.Method.DeclaringType;
      DefaultMemberAttribute customAttribute = declaringType.GetTypeInfo().GetCustomAttribute<DefaultMemberAttribute>(true);
      if (customAttribute == null)
        return false;
      foreach (PropertyInfo runtimeProperty in declaringType.GetRuntimeProperties())
      {
        if (string.Equals(customAttribute.MemberName, runtimeProperty.Name, StringComparison.Ordinal) && runtimeProperty.GetMethod == methodCallExpression.Method)
          return true;
      }
      return false;
    }
  }
}
