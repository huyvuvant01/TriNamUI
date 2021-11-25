// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.Infrastructure.Implementation.FilterDescriptorExtensions
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.Infrastructure.Implementation
{
  public static class FilterDescriptorExtensions
  {
    internal static bool IsActive(this FilterDescriptor filter)
    {
      object obj = filter.Value;
      if (obj == null)
        return false;
      return !(obj is string str) || !string.IsNullOrEmpty(str);
    }

    public static IEnumerable<FilterDescriptor> SelectMemberDescriptors(
      this IEnumerable<IFilterDescriptor> descriptors)
    {
      return descriptors.SelectRecursive<IFilterDescriptor>((Func<IFilterDescriptor, IEnumerable<IFilterDescriptor>>) (f => FilterDescriptorExtensions.GetChildDescriptors(f))).OfType<FilterDescriptor>();
    }

    private static IEnumerable<IFilterDescriptor> GetChildDescriptors(
      IFilterDescriptor f)
    {
      return f is CompositeFilterDescriptor ? (IEnumerable<IFilterDescriptor>) ((CompositeFilterDescriptor) f).FilterDescriptors : (IEnumerable<IFilterDescriptor>) null;
    }

    public static void SetMemberTypeFrom(this FilterDescriptor descriptor, object item)
    {
      if (!descriptor.Member.HasValue())
        return;
      descriptor.MemberType = BindingHelper.ExtractMemberTypeFromObject(item, descriptor.Member);
    }

    public static IEnumerable<IFilterDescriptor> SetMemberTypeFrom(
      this IEnumerable<IFilterDescriptor> descriptors,
      object item)
    {
      if (item != null)
        descriptors.SelectMemberDescriptors().Each<FilterDescriptor>((Action<FilterDescriptor>) (f => f.SetMemberTypeFrom(item)));
      return descriptors;
    }
  }
}
