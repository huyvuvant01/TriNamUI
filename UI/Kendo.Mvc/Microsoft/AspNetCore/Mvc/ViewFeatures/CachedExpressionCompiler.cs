// Decompiled with JetBrains decompiler
// Type: Microsoft.AspNetCore.Mvc.ViewFeatures.CachedExpressionCompiler
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;

namespace Microsoft.AspNetCore.Mvc.ViewFeatures
{
  internal static class CachedExpressionCompiler
  {
    private static readonly Expression NullExpression = (Expression) Expression.Constant((object) null);

    public static Func<TModel, object> Process<TModel, TResult>(
      Expression<Func<TModel, TResult>> expression)
    {
      return expression != null ? CachedExpressionCompiler.Compiler<TModel, TResult>.Compile(expression) : throw new ArgumentNullException(nameof (expression));
    }

    private static class Compiler<TModel, TResult>
    {
      private static Func<TModel, object> _identityFunc;
      private static readonly ConcurrentDictionary<MemberInfo, Func<TModel, object>> _simpleMemberAccessCache = new ConcurrentDictionary<MemberInfo, Func<TModel, object>>();
      private static readonly ConcurrentDictionary<MemberExpressionCacheKey, Func<TModel, object>> _chainedMemberAccessCache = new ConcurrentDictionary<MemberExpressionCacheKey, Func<TModel, object>>((IEqualityComparer<MemberExpressionCacheKey>) MemberExpressionCacheKeyComparer.Instance);
      private static readonly ConcurrentDictionary<MemberInfo, Func<object, TResult>> _constMemberAccessCache = new ConcurrentDictionary<MemberInfo, Func<object, TResult>>();

      public static Func<TModel, object> Compile(Expression<Func<TModel, TResult>> expression)
      {
        Expression body = expression.Body;
        if (body == expression.Parameters[0])
          return CachedExpressionCompiler.Compiler<TModel, TResult>.CompileFromIdentityFunc(expression);
        switch (body)
        {
          case ConstantExpression constantExpression:
            return CachedExpressionCompiler.Compiler<TModel, TResult>.CompileFromConstLookup(constantExpression);
          case MemberExpression memberExpression5:
            MemberExpression memberExpression1 = memberExpression5;
            if (memberExpression1.Expression is ConstantExpression expression2)
              return CachedExpressionCompiler.Compiler<TModel, TResult>.CompileCapturedConstant(memberExpression1, expression2);
            MemberExpression memberExpression2 = memberExpression5;
            if (memberExpression2.Expression == null)
              return CachedExpressionCompiler.Compiler<TModel, TResult>.CompileFromStaticMemberAccess(expression, memberExpression2);
            MemberExpression memberExpression3 = memberExpression5;
            if (memberExpression3.Expression == expression.Parameters[0])
              return CachedExpressionCompiler.Compiler<TModel, TResult>.CompileFromSimpleMemberAccess(expression, memberExpression3);
            MemberExpression memberExpression4 = memberExpression5;
            if (IsChainedPropertyAccessor(memberExpression4))
              return CachedExpressionCompiler.Compiler<TModel, TResult>.CompileForChainedMemberAccess(expression, memberExpression4);
            break;
        }
        return (Func<TModel, object>) null;

        bool IsChainedPropertyAccessor(MemberExpression memberExpression)
        {
          for (; memberExpression.Expression != null; memberExpression = expression3)
          {
            if (!(memberExpression.Expression is MemberExpression expression3))
            {
              if (memberExpression.Expression == expression.Parameters[0])
                return true;
              break;
            }
          }
          return false;
        }
      }

      private static Func<TModel, object> CompileFromConstLookup(
        ConstantExpression constantExpression)
      {
        object constantValue = constantExpression.Value;
        return (Func<TModel, object>) (_ => constantValue);
      }

      private static Func<TModel, object> CompileFromIdentityFunc(
        Expression<Func<TModel, TResult>> expression)
      {
        if (CachedExpressionCompiler.Compiler<TModel, TResult>._identityFunc == null)
        {
          Func<TModel, TResult> identityFuncCore = expression.Compile();
          CachedExpressionCompiler.Compiler<TModel, TResult>._identityFunc = (Func<TModel, object>) (model => (object) identityFuncCore(model));
        }
        return CachedExpressionCompiler.Compiler<TModel, TResult>._identityFunc;
      }

      private static Func<TModel, object> CompileFromStaticMemberAccess(
        Expression<Func<TModel, TResult>> expression,
        MemberExpression memberExpression)
      {
        Func<TModel, object> func1;
        if (CachedExpressionCompiler.Compiler<TModel, TResult>._simpleMemberAccessCache.TryGetValue(memberExpression.Member, out func1))
          return func1;
        Func<TModel, TResult> func = expression.Compile();
        Func<TModel, object> func2 = (Func<TModel, object>) (model => (object) func(model));
        return CachedExpressionCompiler.Compiler<TModel, TResult>._simpleMemberAccessCache.GetOrAdd(memberExpression.Member, func2);
      }

      private static Func<TModel, object> CompileFromSimpleMemberAccess(
        Expression<Func<TModel, TResult>> expression,
        MemberExpression memberExpression)
      {
        Func<TModel, object> func;
        return CachedExpressionCompiler.Compiler<TModel, TResult>._simpleMemberAccessCache.TryGetValue(memberExpression.Member, out func) ? func : CachedExpressionCompiler.Compiler<TModel, TResult>._simpleMemberAccessCache.GetOrAdd(memberExpression.Member, CachedExpressionCompiler.Compiler<TModel, TResult>.Rewrite(expression, memberExpression));
      }

      private static Func<TModel, object> CompileForChainedMemberAccess(
        Expression<Func<TModel, TResult>> expression,
        MemberExpression memberExpression)
      {
        MemberExpressionCacheKey key1 = new MemberExpressionCacheKey(typeof (TModel), memberExpression);
        Func<TModel, object> func;
        if (CachedExpressionCompiler.Compiler<TModel, TResult>._chainedMemberAccessCache.TryGetValue(key1, out func))
          return func;
        MemberExpressionCacheKey key2 = key1.MakeCacheable();
        return CachedExpressionCompiler.Compiler<TModel, TResult>._chainedMemberAccessCache.GetOrAdd(key2, CachedExpressionCompiler.Compiler<TModel, TResult>.Rewrite(expression, memberExpression));
      }

      private static Func<TModel, object> CompileCapturedConstant(
        MemberExpression memberExpression,
        ConstantExpression constantExpression)
      {
        Func<object, TResult> result;
        if (!CachedExpressionCompiler.Compiler<TModel, TResult>._constMemberAccessCache.TryGetValue(memberExpression.Member, out result))
        {
          ParameterExpression parameterExpression = Expression.Parameter(typeof (object), "capturedLocal");
          UnaryExpression unaryExpression = Expression.Convert((Expression) parameterExpression, memberExpression.Member.DeclaringType);
          result = Expression.Lambda<Func<object, TResult>>((Expression) memberExpression.Update((Expression) unaryExpression), parameterExpression).Compile();
          result = CachedExpressionCompiler.Compiler<TModel, TResult>._constMemberAccessCache.GetOrAdd(memberExpression.Member, result);
        }
        object capturedLocal = constantExpression.Value;
        return (Func<TModel, object>) (_ => (object) result(capturedLocal));
      }

      private static Func<TModel, object> Rewrite(
        Expression<Func<TModel, TResult>> expression,
        MemberExpression memberExpression)
      {
        Expression combinedNullTest = (Expression) null;
        for (MemberExpression memberExpression1 = memberExpression; memberExpression1 != null; memberExpression1 = expression3)
        {
          CachedExpressionCompiler.Compiler<TModel, TResult>.AddNullCheck(memberExpression1.Expression, ref combinedNullTest);
          if (!(memberExpression1.Expression is MemberExpression expression3))
            break;
        }
        Expression expression4 = expression.Body;
        if (expression4.Type.IsValueType)
          expression4 = (Expression) Expression.Convert(expression4, typeof (object));
        if (combinedNullTest != null)
          expression4 = (Expression) Expression.Condition(combinedNullTest, (Expression) Expression.Constant((object) null, expression4.Type), expression4);
        return Expression.Lambda<Func<TModel, object>>(expression4, (IEnumerable<ParameterExpression>) expression.Parameters).Compile();
      }

      private static void AddNullCheck(
        Expression invokingExpression,
        ref Expression combinedNullTest)
      {
        Type type = invokingExpression.Type;
        bool flag = type.IsValueType && Nullable.GetUnderlyingType(type) != (Type) null;
        if (type.IsValueType && !flag)
          return;
        BinaryExpression binaryExpression = flag ? Expression.Equal(invokingExpression, CachedExpressionCompiler.NullExpression) : Expression.ReferenceEqual(invokingExpression, CachedExpressionCompiler.NullExpression);
        if (combinedNullTest == null)
          combinedNullTest = (Expression) binaryExpression;
        else
          combinedNullTest = (Expression) Expression.OrElse((Expression) binaryExpression, combinedNullTest);
      }
    }
  }
}
