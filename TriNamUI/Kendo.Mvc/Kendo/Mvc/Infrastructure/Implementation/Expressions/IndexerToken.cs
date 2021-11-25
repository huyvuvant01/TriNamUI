// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.Infrastructure.Implementation.Expressions.IndexerToken
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Kendo.Mvc.Infrastructure.Implementation.Expressions
{
  internal class IndexerToken : IMemberAccessToken
  {
    private readonly ReadOnlyCollection<object> arguments;

    public IndexerToken(IEnumerable<object> arguments) => this.arguments = arguments.ToReadOnlyCollection<object>();

    public IndexerToken(params object[] arguments)
      : this((IEnumerable<object>) arguments)
    {
    }

    public ReadOnlyCollection<object> Arguments => this.arguments;
  }
}
