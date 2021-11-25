// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.Infrastructure.Implementation.Expressions.CustomTypeDescriptorPropertyAccessExpressionBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System;
using System.ComponentModel;
using System.Globalization;
using System.Linq.Expressions;
using System.Reflection;

namespace Kendo.Mvc.Infrastructure.Implementation.Expressions
{
  internal class CustomTypeDescriptorPropertyAccessExpressionBuilder : 
    MemberAccessExpressionBuilderBase
  {
    private static readonly MethodInfo PropertyMethod = typeof (CustomTypeDescriptorExtensions).GetMethod("Property");
    private readonly Type propertyType;

    public CustomTypeDescriptorPropertyAccessExpressionBuilder(
      Type elementType,
      Type memberType,
      string memberName)
      : base(elementType, memberName)
    {
      if (!elementType.IsCompatibleWith(typeof (ICustomTypeDescriptor)))
        throw new ArgumentException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, "ElementType: {0} did not implement {1}", (object) elementType, (object) typeof (ICustomTypeDescriptor)), nameof (elementType));
      this.propertyType = this.GetPropertyType(memberType);
    }

    private Type GetPropertyType(Type memberType)
    {
      Type descriptorProvider = this.GetPropertyTypeFromTypeDescriptorProvider();
      if (descriptorProvider != (Type) null)
        memberType = descriptorProvider;
      if (!memberType.IsValueType || memberType.IsNullableType())
        return memberType;
      return typeof (Nullable<>).MakeGenericType(memberType);
    }

    private Type GetPropertyTypeFromTypeDescriptorProvider() => TypeDescriptor.GetProperties(this.ItemType)[this.MemberName]?.PropertyType;

    public Type PropertyType => this.propertyType;

    public override Expression CreateMemberAccessExpression()
    {
      ConstantExpression constantExpression = Expression.Constant((object) this.MemberName);
      return (Expression) Expression.Call(CustomTypeDescriptorPropertyAccessExpressionBuilder.PropertyMethod.MakeGenericMethod(this.propertyType), (Expression) this.ParameterExpression, (Expression) constantExpression);
    }
  }
}
