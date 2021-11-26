// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.Infrastructure.Implementation.Expressions.GroupDescriptorExpressionBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;


#nullable enable
namespace Kendo.Mvc.Infrastructure.Implementation.Expressions
{
  public class GroupDescriptorExpressionBuilder : GroupDescriptorExpressionBuilderBase
  {
    private readonly 
    #nullable disable
    GroupDescriptor groupDescriptor;
    private readonly GroupDescriptorExpressionBuilder childBuilder;
    private readonly IQueryable notPagedData;
    private readonly bool includeItems;
    private ParameterExpression groupingParameterExpression;
    private Expression aggregateParameterExpression;

    public GroupDescriptorExpressionBuilder ChildBuilder => this.childBuilder;

    public GroupDescriptor GroupDescriptor => this.groupDescriptor;

    public bool HasSubgroups => this.childBuilder != null;

    protected override ListSortDirection? SortDirection => new ListSortDirection?(this.groupDescriptor.SortDirection);

    private ParameterExpression GroupingParameterExpression
    {
      get
      {
        if (this.groupingParameterExpression == null)
          this.groupingParameterExpression = Expression.Parameter(typeof (IGrouping<,>).MakeGenericType(this.CreateGroupByExpression().Body.Type, this.ItemType), "group" + this.GetHashCode().ToString());
        return this.groupingParameterExpression;
      }
    }

    private Expression AggregateParameterExpression
    {
      get
      {
        if (this.aggregateParameterExpression == null)
        {
          LambdaExpression filterExpression = this.CreateChildItemsFilterExpression();
          IQueryable items = this.notPagedData;
          if (this.ParentBuilder != null)
            this.ParentBuilder.CreateChildItemsFilterExpressionFromRecursive().Each<LambdaExpression>((Action<LambdaExpression>) (expression => items = items.Where((Expression) expression)));
          items = items.Where((Expression) filterExpression);
          this.aggregateParameterExpression = items.Expression;
        }
        return this.aggregateParameterExpression;
      }
    }

    public GroupDescriptorExpressionBuilder ParentBuilder { get; set; }

    public GroupDescriptorExpressionBuilder(IQueryable queryable, GroupDescriptor groupDescriptor)
      : this(queryable, groupDescriptor, (GroupDescriptorExpressionBuilder) null, queryable)
    {
      this.groupDescriptor = groupDescriptor;
    }

    public GroupDescriptorExpressionBuilder(
      IQueryable queryable,
      GroupDescriptor groupDescriptor,
      GroupDescriptorExpressionBuilder childBuilder,
      IQueryable notPagedData)
      : base(queryable)
    {
      this.groupDescriptor = groupDescriptor;
      this.childBuilder = childBuilder;
      this.notPagedData = notPagedData;
    }

    public GroupDescriptorExpressionBuilder(
      IQueryable queryable,
      GroupDescriptor groupDescriptor,
      GroupDescriptorExpressionBuilder childBuilder,
      IQueryable notPagedData,
      bool includeItems)
      : base(queryable)
    {
      this.groupDescriptor = groupDescriptor;
      this.childBuilder = childBuilder;
      this.notPagedData = notPagedData;
      this.includeItems = includeItems;
    }

    protected override LambdaExpression CreateGroupByExpression()
    {
      MemberAccessExpressionBuilderBase expressionBuilderBase = ExpressionBuilderFactory.MemberAccess(this.Queryable, this.groupDescriptor.MemberType, this.groupDescriptor.Member);
      expressionBuilderBase.ParameterExpression = this.ParameterExpression;
      return expressionBuilderBase.CreateLambdaExpression();
    }

    protected override LambdaExpression CreateOrderByExpression() => Expression.Lambda((Expression) Expression.Property((Expression) this.GroupingParameterExpression, "Key"), this.GroupingParameterExpression);

    protected override LambdaExpression CreateSelectExpression()
    {
      if (this.HasSubgroups)
        this.childBuilder.ParentBuilder = this;
      return Expression.Lambda(this.CreateSelectBodyExpression(), this.GroupingParameterExpression);
    }

    private Expression CreateSelectBodyExpression() => (Expression) Expression.MemberInit(Expression.New(typeof (AggregateFunctionsGroup)), this.CreateMemberBindings());

    protected virtual IEnumerable<MemberBinding> CreateMemberBindings()
    {
      yield return this.CreateKeyMemberBinding();
      yield return this.CreateCountMemberBinding();
      yield return this.CreateHasSubgroupsMemberBinding();
      yield return this.CreateFieldNameMemberBinding();
      if (this.groupDescriptor.AggregateFunctions.Count > 0)
        yield return this.CreateAggregateFunctionsProjectionMemberBinding();
      if (this.includeItems)
        yield return this.CreateItemsMemberBinding();
    }

    protected MemberBinding CreateItemsMemberBinding() => (MemberBinding) Expression.Bind((MemberInfo) typeof (AggregateFunctionsGroup).GetProperty("Items"), this.CreateItemsExpression());

    private Expression CreateItemsExpression() => this.HasSubgroups ? this.CreateItemsExpressionFromChildBuilder() : (Expression) this.GroupingParameterExpression;

    private Expression CreateItemsExpressionFromChildBuilder()
    {
      this.childBuilder.Queryable = this.Queryable.Where((Expression) this.CreateChildItemsFilterExpression());
      return this.childBuilder.CreateQuery().Expression;
    }

    public IEnumerable<LambdaExpression> CreateChildItemsFilterExpressionFromRecursive()
    {
      List<LambdaExpression> lambdaExpressionList = new List<LambdaExpression>()
      {
        this.CreateChildItemsFilterExpression()
      };
      if (this.ParentBuilder != null)
        lambdaExpressionList.AddRange(this.ParentBuilder.CreateChildItemsFilterExpressionFromRecursive());
      return (IEnumerable<LambdaExpression>) lambdaExpressionList;
    }

    public LambdaExpression CreateChildItemsFilterExpression() => Expression.Lambda((Expression) Expression.Equal(this.CreateGroupByExpression().Body, (Expression) Expression.Property((Expression) this.GroupingParameterExpression, "Key")), this.ParameterExpression);

    protected MemberBinding CreateKeyMemberBinding()
    {
      PropertyInfo property = typeof (AggregateFunctionsGroup).GetProperty("Key");
      Expression expression1 = (Expression) Expression.Property((Expression) this.GroupingParameterExpression, "Key");
      if (expression1.Type.IsValueType() && !this.Queryable.Provider.IsEntityFrameworkProvider())
        expression1 = (Expression) Expression.Convert(expression1, typeof (object));
      Expression expression2 = expression1;
      return (MemberBinding) Expression.Bind((MemberInfo) property, expression2);
    }

    protected MemberBinding CreateCountMemberBinding() => (MemberBinding) Expression.Bind((MemberInfo) typeof (AggregateFunctionsGroup).GetProperty("ItemCount"), (Expression) Expression.Call(typeof (Enumerable), "Count", new Type[1]
    {
      this.ItemType
    }, (Expression) this.GroupingParameterExpression));

    protected MemberBinding CreateFieldNameMemberBinding() => (MemberBinding) Expression.Bind((MemberInfo) typeof (AggregateFunctionsGroup).GetProperty("Member"), (Expression) Expression.Constant((object) (this.GroupDescriptor.Member ?? "")));

    protected MemberBinding CreateHasSubgroupsMemberBinding() => (MemberBinding) Expression.Bind((MemberInfo) typeof (AggregateFunctionsGroup).GetProperty("HasSubgroups"), (Expression) Expression.Constant((object) this.HasSubgroups));

    protected MemberBinding CreateAggregateFunctionsProjectionMemberBinding() => (MemberBinding) Expression.Bind((MemberInfo) typeof (AggregateFunctionsGroup).GetProperty("AggregateFunctionsProjection"), this.CreateProjectionInitExpression());

    protected MemberBinding CreateSubgroupCountMemberBinding()
    {
      PropertyInfo property = typeof (AggregateFunctionsGroup).GetProperty("SubgroupCount");
      Expression fromChildBuilder = this.CreateItemsExpressionFromChildBuilder();
      Type type = typeof (AggregateFunctionsGroup);
      Expression expression = (Expression) Expression.Call(((IEnumerable<MethodInfo>) typeof (Queryable).GetMethods(BindingFlags.Static | BindingFlags.Public)).Single<MethodInfo>((Func<MethodInfo, bool>) (mi => mi.Name == "Count" && mi.IsGenericMethodDefinition && mi.GetParameters().Length == 1)).MakeGenericMethod(type), fromChildBuilder);
      return (MemberBinding) Expression.Bind((MemberInfo) property, expression);
    }

    private Expression CreateProjectionInitExpression()
    {
      List<Expression> list = this.ProjectionPropertyValueExpressions().ToList<Expression>();
      NewExpression projectionNewExpression = this.CreateProjectionNewExpression((IEnumerable<Expression>) list);
      IEnumerable<MemberBinding> projectionMemberBindings = this.CreateProjectionMemberBindings(projectionNewExpression.Type, (IEnumerable<Expression>) list);
      return (Expression) Expression.MemberInit(projectionNewExpression, projectionMemberBindings);
    }

    private IEnumerable<Expression> ProjectionPropertyValueExpressions() => this.groupDescriptor.AggregateFunctions.Select<AggregateFunction, Expression>((Func<AggregateFunction, Expression>) (f => f.CreateAggregateExpression(this.AggregateParameterExpression, this.Options.LiftMemberAccessToNull)));

    private NewExpression CreateProjectionNewExpression(
      IEnumerable<Expression> propertyValuesExpressions)
    {
      return Expression.New(ClassFactory.Instance.GetDynamicClass(this.groupDescriptor.AggregateFunctions.Consolidate<AggregateFunction, Expression, DynamicProperty>(propertyValuesExpressions, (Func<AggregateFunction, Expression, DynamicProperty>) ((f, e) => new DynamicProperty(f.FunctionName, e.Type)))));
    }

    private IEnumerable<MemberBinding> CreateProjectionMemberBindings(
      Type projectionType,
      IEnumerable<Expression> propertyValuesExpressions)
    {
      return this.groupDescriptor.AggregateFunctions.Consolidate<AggregateFunction, Expression, MemberAssignment>(propertyValuesExpressions, (Func<AggregateFunction, Expression, MemberAssignment>) ((f, e) => Expression.Bind((MemberInfo) projectionType.GetProperty(f.FunctionName), e))).Cast<MemberBinding>();
    }
  }
}
