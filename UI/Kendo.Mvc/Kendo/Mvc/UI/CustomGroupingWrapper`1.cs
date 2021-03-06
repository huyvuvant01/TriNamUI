// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.CustomGroupingWrapper`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Resources;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  internal class CustomGroupingWrapper<T> : IEnumerable<T>, IEnumerable, IGridCustomGroupingWrapper
  {
    public virtual IEnumerable GroupedEnumerable { get; private set; }

    public CustomGroupingWrapper(IEnumerable groupedEnumerable) => this.GroupedEnumerable = groupedEnumerable;

    public IEnumerator<T> GetEnumerator() => throw new InvalidOperationException(Exceptions.YouCannotCallBindToWithoutCustomBinding);

    IEnumerator IEnumerable.GetEnumerator() => (IEnumerator) this.GetEnumerator();
  }
}
