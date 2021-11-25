// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.FilterFieldFactory`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Kendo.Mvc.UI.Fluent
{
  public class FilterFieldFactory<T> where T : class
  {
    public FilterFieldFactory(List<FilterField<T>> container) => this.Container = container;

    protected List<FilterField<T>> Container { get; private set; }

    public virtual FilterFieldBuilder<T> Add<TValue>(
      Expression<Func<T, TValue>> expression)
    {
      FilterField<T> container = new FilterField<T>();
      container.Filter = this.Filter;
      container.Type = expression.ToMemberExpression().Type().ToJavaScriptType().ToLowerInvariant();
      container.Name = expression.MemberWithoutInstance();
      this.Container.Add(container);
      return new FilterFieldBuilder<T>(container);
    }

    public Kendo.Mvc.UI.Filter<T> Filter { get; set; }

    public virtual FilterFieldBuilder<T> Add()
    {
      FilterField<T> container = new FilterField<T>();
      container.Filter = this.Filter;
      this.Container.Add(container);
      return new FilterFieldBuilder<T>(container);
    }
  }
}
