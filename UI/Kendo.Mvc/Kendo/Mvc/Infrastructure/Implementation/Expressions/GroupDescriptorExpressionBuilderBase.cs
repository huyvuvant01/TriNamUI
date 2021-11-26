// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.Infrastructure.Implementation.Expressions.GroupDescriptorExpressionBuilderBase
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Linq;
using System.Linq.Expressions;

namespace Kendo.Mvc.Infrastructure.Implementation.Expressions
{
  public abstract class GroupDescriptorExpressionBuilderBase : ExpressionBuilderBase
  {
    private IQueryable queryable;

    protected GroupDescriptorExpressionBuilderBase(IQueryable queryable)
      : base(queryable.ElementType)
    {
      this.queryable = queryable;
    }

    public virtual IQueryable Queryable
    {
      get => this.queryable;
      protected set => this.queryable = value;
    }

    public IQueryable CreateQuery() => this.queryable.GroupBy(this.CreateGroupByExpression()).OrderBy(this.CreateOrderByExpression(), this.SortDirection).Select(this.CreateSelectExpression());

    protected virtual ListSortDirection? SortDirection => new ListSortDirection?();

    protected abstract LambdaExpression CreateGroupByExpression();

    protected abstract LambdaExpression CreateOrderByExpression();

    protected abstract LambdaExpression CreateSelectExpression();
  }
}
