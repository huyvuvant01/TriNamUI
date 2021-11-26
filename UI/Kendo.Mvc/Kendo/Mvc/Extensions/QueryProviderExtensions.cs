// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.Extensions.QueryProviderExtensions
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Linq;

namespace Kendo.Mvc.Extensions
{
  internal static class QueryProviderExtensions
  {
    public static bool IsEntityFrameworkProvider(this IQueryProvider provider)
    {
      string fullName = provider.GetType().FullName;
      return fullName == "System.Data.Objects.ELinq.ObjectQueryProvider" || fullName == "System.Data.Entity.Core.Objects.ELinq.ObjectQueryProvider" || fullName.StartsWith("LinqKit.ExpandableQueryProvider") || fullName.StartsWith("Microsoft.Data.Entity.Query.EntityQueryProvider") || fullName.StartsWith("System.Data.Entity.Internal.Linq");
    }

    public static bool IsLinqToObjectsProvider(this IQueryProvider provider) => provider.GetType().FullName.Contains("EnumerableQuery");
  }
}
