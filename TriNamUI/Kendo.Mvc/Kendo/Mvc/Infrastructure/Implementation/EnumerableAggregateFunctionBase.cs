// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.Infrastructure.Implementation.EnumerableAggregateFunctionBase
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System;
using System.Globalization;
using System.Linq;

namespace Kendo.Mvc.Infrastructure.Implementation
{
  public abstract class EnumerableAggregateFunctionBase : AggregateFunction
  {
    protected internal virtual Type ExtensionMethodsType => typeof (Enumerable);

    protected override string GenerateFunctionName()
    {
      string str = this.SourceField;
      if (str.HasValue())
        str = str.Replace(".", "-");
      return string.Format((IFormatProvider) CultureInfo.InvariantCulture, "{0}_{1}", (object) this.AggregateMethodName, (object) str);
    }
  }
}
