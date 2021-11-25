// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.Extensions.TypeExtensions
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Resources;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;


#nullable enable
namespace Kendo.Mvc.Extensions
{
  internal static class TypeExtensions
  {
    internal static readonly 
    #nullable disable
    Type[] PredefinedTypes = new Type[20]
    {
      typeof (object),
      typeof (bool),
      typeof (char),
      typeof (string),
      typeof (sbyte),
      typeof (byte),
      typeof (short),
      typeof (ushort),
      typeof (int),
      typeof (uint),
      typeof (long),
      typeof (ulong),
      typeof (float),
      typeof (double),
      typeof (Decimal),
      typeof (DateTime),
      typeof (TimeSpan),
      typeof (Guid),
      typeof (Math),
      typeof (Convert)
    };

    internal static bool IsPredefinedType(this Type type)
    {
      foreach (Type predefinedType in TypeExtensions.PredefinedTypes)
      {
        if (predefinedType == type)
          return true;
      }
      return false;
    }

    internal static bool IsGenericType(this Type type) => type.GetTypeInfo().IsGenericType;

    internal static bool IsInterface(this Type type) => type.GetTypeInfo().IsInterface;

    internal static bool IsDynamicObject(this Type type) => type == typeof (object) || type.IsCompatibleWith(typeof (IDynamicMetaObjectProvider));

    internal static bool IsNullableType(this Type type) => type.IsGenericType() && type.GetGenericTypeDefinition() == typeof (Nullable<>);

    internal static Type GetNonNullableType(this Type type) => !type.IsNullableType() ? type : type.GetGenericArguments()[0];

    internal static bool IsValueType(this Type type) => type.GetTypeInfo().IsValueType;

    internal static Type FindGenericType(this Type type, Type genericType)
    {
      for (; type != (Type) null && type != typeof (object); type = type.GetTypeInfo().BaseType)
      {
        if (type.IsGenericType() && type.GetGenericTypeDefinition() == genericType)
          return type;
        if (genericType.IsInterface())
        {
          foreach (Type type1 in type.GetInterfaces())
          {
            Type genericType1 = type1.FindGenericType(genericType);
            if (genericType1 != (Type) null)
              return genericType1;
          }
        }
      }
      return (Type) null;
    }

    internal static MemberInfo FindPropertyOrField(this Type type, string memberName)
    {
      MemberInfo propertyOrField = type.FindPropertyOrField(memberName, false);
      if (propertyOrField == (MemberInfo) null)
        propertyOrField = type.FindPropertyOrField(memberName, true);
      return propertyOrField;
    }

    internal static MemberInfo FindPropertyOrField(
      this Type type,
      string memberName,
      bool staticAccess)
    {
      BindingFlags bindingAttr = (BindingFlags) (18 | (staticAccess ? 8 : 4));
      foreach (Type selfAndBaseType in type.SelfAndBaseTypes())
      {
        MemberInfo[] array = selfAndBaseType.GetProperties(bindingAttr).OfType<MemberInfo>().Concat<MemberInfo>(selfAndBaseType.GetFields(bindingAttr).OfType<MemberInfo>()).Where<MemberInfo>((Func<MemberInfo, bool>) (m => m.Name.IsCaseInsensitiveEqual(memberName))).ToArray<MemberInfo>();
        if (array.Length != 0)
          return array[0];
      }
      return (MemberInfo) null;
    }

    internal static IEnumerable<Type> SelfAndBaseTypes(this Type type)
    {
      if (!type.IsInterface())
        return type.SelfAndBaseClasses();
      List<Type> types = new List<Type>();
      TypeExtensions.AddInterface(types, type);
      return (IEnumerable<Type>) types;
    }

    internal static IEnumerable<Type> SelfAndBaseClasses(this Type type)
    {
      for (; type != (Type) null; type = type.GetTypeInfo().BaseType)
        yield return type;
    }

    private static void AddInterface(List<Type> types, Type type)
    {
      if (types.Contains(type))
        return;
      types.Add(type);
      foreach (Type type1 in type.GetInterfaces())
        TypeExtensions.AddInterface(types, type1);
    }

    internal static PropertyInfo GetIndexerPropertyInfo(
      this Type type,
      params Type[] indexerArguments)
    {
      return ((IEnumerable<PropertyInfo>) type.GetProperties()).Where<PropertyInfo>((Func<PropertyInfo, bool>) (p => TypeExtensions.AreArgumentsApplicable((IEnumerable<Type>) indexerArguments, (IEnumerable<ParameterInfo>) p.GetIndexParameters()))).FirstOrDefault<PropertyInfo>();
    }

    private static bool AreArgumentsApplicable(
      IEnumerable<Type> arguments,
      IEnumerable<ParameterInfo> parameters)
    {
      List<Type> list1 = arguments.ToList<Type>();
      List<ParameterInfo> list2 = parameters.ToList<ParameterInfo>();
      if (list1.Count != list2.Count)
        return false;
      for (int index = 0; index < list1.Count; ++index)
      {
        if (list2[index].ParameterType != list1[index])
          return false;
      }
      return true;
    }

    internal static string GetTypeName(this Type type)
    {
      Type nonNullableType = type.GetNonNullableType();
      string name = nonNullableType.Name;
      if (type != nonNullableType)
        name += "?";
      return name;
    }

    internal static bool IsCompatibleWith(this Type source, Type target)
    {
      if (source == target)
        return true;
      if (!target.IsValueType())
        return target.IsAssignableFrom(source);
      Type nonNullableType1 = source.GetNonNullableType();
      Type nonNullableType2 = target.GetNonNullableType();
      if (nonNullableType1 != source && nonNullableType2 == target)
        return false;
      if (nonNullableType1.IsEnumType() || nonNullableType2.IsEnumType())
        return nonNullableType1 == nonNullableType2;
      if (nonNullableType1 == typeof (sbyte))
        return nonNullableType2 == typeof (sbyte) || nonNullableType2 == typeof (short) || nonNullableType2 == typeof (int) || nonNullableType2 == typeof (long) || nonNullableType2 == typeof (float) || nonNullableType2 == typeof (double) || nonNullableType2 == typeof (Decimal);
      if (nonNullableType1 == typeof (byte))
        return nonNullableType2 == typeof (byte) || nonNullableType2 == typeof (short) || nonNullableType2 == typeof (ushort) || nonNullableType2 == typeof (int) || nonNullableType2 == typeof (uint) || nonNullableType2 == typeof (long) || nonNullableType2 == typeof (ulong) || nonNullableType2 == typeof (float) || nonNullableType2 == typeof (double) || nonNullableType2 == typeof (Decimal);
      if (nonNullableType1 == typeof (short))
        return nonNullableType2 == typeof (short) || nonNullableType2 == typeof (int) || nonNullableType2 == typeof (long) || nonNullableType2 == typeof (float) || nonNullableType2 == typeof (double) || nonNullableType2 == typeof (Decimal);
      if (nonNullableType1 == typeof (ushort))
        return nonNullableType2 == typeof (ushort) || nonNullableType2 == typeof (int) || nonNullableType2 == typeof (uint) || nonNullableType2 == typeof (long) || nonNullableType2 == typeof (ulong) || nonNullableType2 == typeof (float) || nonNullableType2 == typeof (double) || nonNullableType2 == typeof (Decimal);
      if (nonNullableType1 == typeof (int))
        return nonNullableType2 == typeof (int) || nonNullableType2 == typeof (long) || nonNullableType2 == typeof (float) || nonNullableType2 == typeof (double) || nonNullableType2 == typeof (Decimal);
      if (nonNullableType1 == typeof (uint))
        return nonNullableType2 == typeof (uint) || nonNullableType2 == typeof (long) || nonNullableType2 == typeof (ulong) || nonNullableType2 == typeof (float) || nonNullableType2 == typeof (double) || nonNullableType2 == typeof (Decimal);
      if (nonNullableType1 == typeof (long))
        return nonNullableType2 == typeof (long) || nonNullableType2 == typeof (float) || nonNullableType2 == typeof (double) || nonNullableType2 == typeof (Decimal);
      if (nonNullableType1 == typeof (ulong))
        return nonNullableType2 == typeof (ulong) || nonNullableType2 == typeof (float) || nonNullableType2 == typeof (double) || nonNullableType2 == typeof (Decimal);
      if (!(nonNullableType1 == typeof (float)))
        return false;
      return nonNullableType2 == typeof (float) || nonNullableType2 == typeof (double);
    }

    internal static string FirstSortableProperty(this Type type)
    {
      PropertyInfo propertyInfo = ((IEnumerable<PropertyInfo>) type.GetProperties()).Where<PropertyInfo>((Func<PropertyInfo, bool>) (property => property.PropertyType.IsPredefinedType())).FirstOrDefault<PropertyInfo>();
      return !(propertyInfo == (PropertyInfo) null) ? propertyInfo.Name : throw new NotSupportedException(Exceptions.CannotFindPropertyToSortBy);
    }

    internal static object DefaultValue(this Type type) => type.IsValueType() ? Activator.CreateInstance(type) : (object) null;

    internal static bool IsEnumType(this Type type) => type.GetNonNullableType().GetTypeInfo().IsEnum;

    internal static bool IsNumericType(this Type type) => (uint) type.GetNumericTypeKind() > 0U;

    internal static int GetNumericTypeKind(this Type type)
    {
      if (type == (Type) null)
        return 0;
      type = type.GetNonNullableType();
      if (type.IsEnumType())
        return 0;
      if (type == typeof (char) || type == typeof (float) || type == typeof (double) || type == typeof (Decimal))
        return 1;
      if (type == typeof (sbyte) || type == typeof (short) || type == typeof (int) || type == typeof (long))
        return 2;
      return type == typeof (byte) || type == typeof (ushort) || type == typeof (uint) || type == typeof (ulong) ? 3 : 0;
    }

    internal static string ToJavaScriptType(this Type type)
    {
      if (type == (Type) null)
        return "Object";
      if (type == typeof (char) || type == typeof (char?))
        return "String";
      if (type.IsNumericType())
        return "Number";
      if (type == typeof (DateTime) || type == typeof (DateTime?))
        return "Date";
      if (type == typeof (string))
        return "String";
      if (type == typeof (bool) || type == typeof (bool?))
        return "Boolean";
      if (type.IsEnumType())
        return "Number";
      return type.GetNonNullableType() == typeof (Guid) ? "String" : "Object";
    }

    internal static bool IsPlainType(this Type type) => !type.IsDynamicObject();
  }
}
