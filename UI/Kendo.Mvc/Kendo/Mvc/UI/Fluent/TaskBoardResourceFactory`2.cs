// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.TaskBoardResourceFactory`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Resources;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Kendo.Mvc.UI.Fluent
{
  public class TaskBoardResourceFactory<TCard, TColumn>
    where TCard : class
    where TColumn : class
  {
    public TaskBoardResourceFactory(List<TaskBoardResource<TCard, TColumn>> container) => this.Container = container;

    protected List<TaskBoardResource<TCard, TColumn>> Container { get; private set; }

    public TaskBoardResourceBuilder<TCard, TColumn> Add(
      Expression<Func<TCard, string>> expression)
    {
      TaskBoardResource<TCard, TColumn> container = typeof (TCard).IsPlainType() || expression.IsBindable() ? new TaskBoardResource<TCard, TColumn>(ExpressionHelper.GetExpressionText((LambdaExpression) expression, (ConcurrentDictionary<LambdaExpression, string>) null)) : throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
      container.TaskBoard = this.TaskBoard;
      this.Container.Add(container);
      return new TaskBoardResourceBuilder<TCard, TColumn>(container);
    }

    public Kendo.Mvc.UI.TaskBoard<TCard, TColumn> TaskBoard { get; set; }

    public virtual TaskBoardResourceBuilder<TCard, TColumn> Add()
    {
      TaskBoardResource<TCard, TColumn> container = new TaskBoardResource<TCard, TColumn>();
      container.TaskBoard = this.TaskBoard;
      this.Container.Add(container);
      return new TaskBoardResourceBuilder<TCard, TColumn>(container);
    }
  }
}
