// Decompiled with JetBrains decompiler
// Type: Microsoft.AspNetCore.Mvc.ViewFeatures.MemberExpressionCacheKeyComparer
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.DotNet.InternalAbstractions;
using System.Collections.Generic;
using System.Reflection;

namespace Microsoft.AspNetCore.Mvc.ViewFeatures
{
  internal class MemberExpressionCacheKeyComparer : IEqualityComparer<MemberExpressionCacheKey>
  {
    public static readonly MemberExpressionCacheKeyComparer Instance = new MemberExpressionCacheKeyComparer();

    public bool Equals(MemberExpressionCacheKey x, MemberExpressionCacheKey y)
    {
      if (x.ModelType != y.ModelType)
        return false;
      MemberExpressionCacheKey.Enumerator enumerator1 = x.GetEnumerator();
      MemberExpressionCacheKey.Enumerator enumerator2 = y.GetEnumerator();
      while (enumerator1.MoveNext())
      {
        if (!enumerator2.MoveNext() || enumerator1.Current != enumerator2.Current)
          return false;
      }
      return !enumerator2.MoveNext();
    }

    public int GetHashCode(MemberExpressionCacheKey obj)
    {
      HashCodeCombiner hashCodeCombiner = new HashCodeCombiner();
      hashCodeCombiner.Add((object) obj.ModelType);
      foreach (MemberInfo memberInfo in obj)
        hashCodeCombiner.Add((object) memberInfo);
      return hashCodeCombiner.CombinedHash;
    }
  }
}
