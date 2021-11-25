// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.Extensions.MemberExpressionExtensions
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Linq.Expressions;
using System.Reflection;

namespace Kendo.Mvc.Extensions
{
  internal static class MemberExpressionExtensions
  {
    internal static System.Type Type(this MemberExpression memberExpression)
    {
      if (memberExpression == null)
        return (System.Type) null;
      MemberInfo member = memberExpression.Member;
      if ((object) (member as PropertyInfo) != null)
        return ((PropertyInfo) member).PropertyType;
      return (object) (member as FieldInfo) != null ? ((FieldInfo) member).FieldType : throw new NotSupportedException();
    }
  }
}
