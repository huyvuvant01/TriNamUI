// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.Infrastructure.Implementation.BindingHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Infrastructure.Implementation.Expressions;
using System;

namespace Kendo.Mvc.Infrastructure.Implementation
{
  internal static class BindingHelper
  {
    internal static Type ExtractMemberTypeFromObject(object item, string memberName)
    {
      if (!item.GetType().IsDynamicObject())
        return new PropertyAccessExpressionBuilder(item.GetType(), memberName).CreateMemberAccessExpression().Type;
      return ((Func<object, object>) ExpressionBuilder.Lambda<object>(memberName, true).Compile())(item)?.GetType();
    }
  }
}
