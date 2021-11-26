// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.Infrastructure.Implementation.Expressions.UnboxT`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System;
using System.Globalization;
using System.Reflection;

namespace Kendo.Mvc.Infrastructure.Implementation.Expressions
{
  internal static class UnboxT<T>
  {
    internal static readonly Func<object, T> Unbox = UnboxT<T>.Create(typeof (T));

    private static Func<object, T> Create(Type type)
    {
      if (!type.IsValueType())
        return new Func<object, T>(UnboxT<T>.ReferenceField);
      if (!type.IsGenericType() || type.GetTypeInfo().IsGenericTypeDefinition || !(typeof (Nullable<>) == type.GetGenericTypeDefinition()))
        return new Func<object, T>(UnboxT<T>.ValueField);
      return (Func<object, T>) typeof (UnboxT<T>).GetMethod("NullableField", BindingFlags.Static | BindingFlags.NonPublic).MakeGenericMethod(type.GetGenericArguments()[0]).CreateDelegate(typeof (Func<object, T>));
    }

    private static TElem? NullableField<TElem>(object value) where TElem : struct => DBNull.Value == value ? new TElem?() : (TElem?) value;

    private static T ReferenceField(object value) => DBNull.Value != value ? (T) value : default (T);

    private static T ValueField(object value) => DBNull.Value != value ? (T) value : throw new InvalidCastException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, "Type: {0} cannot be casted to Nullable type", (object) typeof (T)));
  }
}
