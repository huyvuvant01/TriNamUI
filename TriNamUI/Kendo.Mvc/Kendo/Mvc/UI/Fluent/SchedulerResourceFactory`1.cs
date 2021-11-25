// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.SchedulerResourceFactory`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Resources;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Concurrent;
using System.Linq.Expressions;

namespace Kendo.Mvc.UI.Fluent
{
  public class SchedulerResourceFactory<T> : IHideObjectMembers where T : class, ISchedulerEvent
  {
    private readonly Scheduler<T> container;

    public SchedulerResourceFactory(Scheduler<T> container) => this.container = container;

    public SchedulerResourceBuilder<T> Add<TValue>(
      Expression<Func<T, TValue>> expression)
    {
      if (!typeof (T).IsPlainType() && !expression.IsBindable())
        throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
      SchedulerResource<T> resource = new SchedulerResource<T>(ExpressionHelper.GetExpressionText((LambdaExpression) expression, (ConcurrentDictionary<LambdaExpression, string>) null), this.container.ModelMetadataProvider);
      this.container.Resources.Add(resource);
      return new SchedulerResourceBuilder<T>(resource, this.container.ViewContext, this.container.UrlGenerator);
    }

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
