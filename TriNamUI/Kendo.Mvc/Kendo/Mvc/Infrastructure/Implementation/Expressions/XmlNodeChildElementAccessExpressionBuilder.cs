// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.Infrastructure.Implementation.Expressions.XmlNodeChildElementAccessExpressionBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Linq.Expressions;
using System.Reflection;
using System.Xml;

namespace Kendo.Mvc.Infrastructure.Implementation.Expressions
{
  internal class XmlNodeChildElementAccessExpressionBuilder : MemberAccessExpressionBuilderBase
  {
    private static readonly MethodInfo ChildElementInnerTextMethod = typeof (XmlNodeExtensions).GetMethod("ChildElementInnerText", new Type[2]
    {
      typeof (XmlNode),
      typeof (string)
    });

    public XmlNodeChildElementAccessExpressionBuilder(string memberName)
      : base(typeof (XmlNode), memberName)
    {
    }

    public override Expression CreateMemberAccessExpression()
    {
      ConstantExpression constantExpression = Expression.Constant((object) this.MemberName);
      return (Expression) Expression.Call(XmlNodeChildElementAccessExpressionBuilder.ChildElementInnerTextMethod, (Expression) this.ParameterExpression, (Expression) constantExpression);
    }
  }
}
