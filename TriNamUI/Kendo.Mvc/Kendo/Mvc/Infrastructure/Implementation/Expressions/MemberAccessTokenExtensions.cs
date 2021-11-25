// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.Infrastructure.Implementation.Expressions.MemberAccessTokenExtensions
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Kendo.Mvc.Infrastructure.Implementation.Expressions
{
  internal static class MemberAccessTokenExtensions
  {
    public static Expression CreateMemberAccessExpression(
      this IMemberAccessToken token,
      Expression instance)
    {
      MemberInfo memberInfoForType = token.GetMemberInfoForType(instance.Type);
      if (memberInfoForType == (MemberInfo) null)
        throw new ArgumentException(MemberAccessTokenExtensions.FormatInvalidTokenErrorMessage(token, instance.Type));
      if (!(token is IndexerToken indexerToken))
        return (Expression) Expression.MakeMemberAccess(instance, memberInfoForType);
      IEnumerable<Expression> indexerArguments = indexerToken.GetIndexerArguments();
      return (Expression) Expression.Call(instance, (MethodInfo) memberInfoForType, indexerArguments);
    }

    private static string FormatInvalidTokenErrorMessage(IMemberAccessToken token, Type type)
    {
      string str1;
      string str2;
      if (token is PropertyToken propertyToken)
      {
        str1 = "property or field";
        str2 = propertyToken.PropertyName;
      }
      else
      {
        str1 = "indexer with arguments";
        str2 = string.Join(",", ((IndexerToken) token).Arguments.Where<object>((Func<object, bool>) (a => a != null)).Select<object, string>((Func<object, string>) (a => a.ToString())).ToArray<string>());
      }
      return string.Format((IFormatProvider) CultureInfo.CurrentCulture, "Invalid {0} - '{1}' for type: {2}", (object) str1, (object) str2, (object) type.GetTypeName());
    }

    private static IEnumerable<Expression> GetIndexerArguments(
      this IndexerToken indexerToken)
    {
      return indexerToken.Arguments.Select<object, Expression>((Func<object, Expression>) (a => (Expression) Expression.Constant(a)));
    }

    private static MemberInfo GetMemberInfoForType(
      this IMemberAccessToken token,
      Type targetType)
    {
      switch (token)
      {
        case PropertyToken token1:
          return MemberAccessTokenExtensions.GetMemberInfoFromPropertyToken(token1, targetType);
        case IndexerToken token2:
          return MemberAccessTokenExtensions.GetMemberInfoFromIndexerToken(token2, targetType);
        default:
          throw new InvalidOperationException(token.GetType().GetTypeName() + " is not supported");
      }
    }

    private static MemberInfo GetMemberInfoFromPropertyToken(
      PropertyToken token,
      Type targetType)
    {
      return targetType.FindPropertyOrField(token.PropertyName);
    }

    private static MemberInfo GetMemberInfoFromIndexerToken(
      IndexerToken token,
      Type targetType)
    {
      PropertyInfo indexerPropertyInfo = targetType.GetIndexerPropertyInfo(token.Arguments.Select<object, Type>((Func<object, Type>) (a => a.GetType())).ToArray<Type>());
      return indexerPropertyInfo != (PropertyInfo) null ? (MemberInfo) indexerPropertyInfo.GetGetMethod() : (MemberInfo) null;
    }
  }
}
