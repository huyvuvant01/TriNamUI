// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.Infrastructure.Implementation.Expressions.CustomTypeDescriptorExtensions
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.ComponentModel;
using System.Globalization;

namespace Kendo.Mvc.Infrastructure.Implementation.Expressions
{
  internal static class CustomTypeDescriptorExtensions
  {
    public static T Property<T>(this ICustomTypeDescriptor typeDescriptor, string propertyName)
    {
      PropertyDescriptor property = TypeDescriptor.GetProperties((object) typeDescriptor)[propertyName];
      if (property == null)
        throw new ArgumentException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, "Property with specified name: {0} cannot be found on type: {1}", (object) propertyName, (object) typeDescriptor.GetType()), nameof (propertyName));
      return UnboxT<T>.Unbox(property.GetValue((object) typeDescriptor));
    }
  }
}
