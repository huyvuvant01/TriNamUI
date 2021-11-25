// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.Infrastructure.Implementation.Expressions.ExpressionBuilderFactory
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;
using System.Xml;

namespace Kendo.Mvc.Infrastructure.Implementation.Expressions
{
  public static class ExpressionBuilderFactory
  {
    public static MemberAccessExpressionBuilderBase MemberAccess(
      Type elementType,
      Type memberType,
      string memberName)
    {
      Type type = memberType;
      if ((object) type == null)
        type = typeof (object);
      memberType = type;
      if (elementType.IsCompatibleWith(typeof (XmlNode)))
        return (MemberAccessExpressionBuilderBase) new XmlNodeChildElementAccessExpressionBuilder(memberName);
      if (elementType.IsCompatibleWith(typeof (ICustomTypeDescriptor)))
        return (MemberAccessExpressionBuilderBase) new CustomTypeDescriptorPropertyAccessExpressionBuilder(elementType, memberType, memberName);
      return elementType == typeof (object) || elementType.IsCompatibleWith(typeof (IDynamicMetaObjectProvider)) ? (MemberAccessExpressionBuilderBase) new DynamicPropertyAccessExpressionBuilder(elementType, memberName) : (MemberAccessExpressionBuilderBase) new PropertyAccessExpressionBuilder(elementType, memberName);
    }

    public static MemberAccessExpressionBuilderBase MemberAccess(
      Type elementType,
      string memberName,
      bool liftMemberAccess)
    {
      MemberAccessExpressionBuilderBase expressionBuilderBase = ExpressionBuilderFactory.MemberAccess(elementType, (Type) null, memberName);
      expressionBuilderBase.Options.LiftMemberAccessToNull = liftMemberAccess;
      return expressionBuilderBase;
    }

    public static MemberAccessExpressionBuilderBase MemberAccess(
      Type elementType,
      Type memberType,
      string memberName,
      bool liftMemberAccess)
    {
      MemberAccessExpressionBuilderBase expressionBuilderBase = ExpressionBuilderFactory.MemberAccess(elementType, memberType, memberName);
      expressionBuilderBase.Options.LiftMemberAccessToNull = liftMemberAccess;
      return expressionBuilderBase;
    }

    public static MemberAccessExpressionBuilderBase MemberAccess(
      IQueryable source,
      Type memberType,
      string memberName)
    {
      MemberAccessExpressionBuilderBase expressionBuilderBase = ExpressionBuilderFactory.MemberAccess(source.ElementType, memberType, memberName);
      expressionBuilderBase.Options.LiftMemberAccessToNull = source.Provider.IsLinqToObjectsProvider();
      return expressionBuilderBase;
    }
  }
}
