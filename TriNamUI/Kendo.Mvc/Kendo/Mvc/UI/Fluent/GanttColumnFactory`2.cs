// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.GanttColumnFactory`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Kendo.Mvc.UI.Fluent
{
  public class GanttColumnFactory<TTaskModel, TDependenciesModel>
    where TTaskModel : class, IGanttTask
    where TDependenciesModel : class, IGanttDependency
  {
    public GanttColumnFactory(
      List<GanttColumn<TTaskModel, TDependenciesModel>> container)
    {
      this.Container = container;
    }

    protected List<GanttColumn<TTaskModel, TDependenciesModel>> Container { get; private set; }

    public virtual GanttColumnBuilder<TTaskModel, TDependenciesModel> Group(
      Action<GanttColumnFactory<TTaskModel, TDependenciesModel>> configurator)
    {
      GanttGroupColumn<TTaskModel, TDependenciesModel> ganttGroupColumn = new GanttGroupColumn<TTaskModel, TDependenciesModel>();
      this.Container.Add((GanttColumn<TTaskModel, TDependenciesModel>) ganttGroupColumn);
      configurator(new GanttColumnFactory<TTaskModel, TDependenciesModel>(ganttGroupColumn.Columns)
      {
        Gantt = this.Gantt
      });
      return new GanttColumnBuilder<TTaskModel, TDependenciesModel>((GanttColumn<TTaskModel, TDependenciesModel>) ganttGroupColumn);
    }

    public virtual GanttBoundColumnBuilder<TTaskModel, TDependenciesModel> Bound<TValue>(
      Expression<Func<TTaskModel, TValue>> expression)
    {
      GanttBoundColumn<TTaskModel, TDependenciesModel, TValue> ganttBoundColumn = new GanttBoundColumn<TTaskModel, TDependenciesModel, TValue>(expression, this.Gantt.ModelMetadataProvider);
      this.Container.Add((GanttColumn<TTaskModel, TDependenciesModel>) ganttBoundColumn);
      return new GanttBoundColumnBuilder<TTaskModel, TDependenciesModel>((GanttColumn<TTaskModel, TDependenciesModel>) ganttBoundColumn);
    }

    public virtual GanttBoundColumnBuilder<TTaskModel, TDependenciesModel> Bound(
      string fieldName)
    {
      return this.Bound((Type) null, fieldName);
    }

    public virtual GanttBoundColumnBuilder<TTaskModel, TDependenciesModel> Bound(
      Type memberType,
      string fieldName)
    {
      LambdaExpression lambdaExpression = ExpressionBuilder.Lambda<TTaskModel>(memberType, fieldName, false);
      if (typeof (TTaskModel).IsDynamicObject() && memberType != (Type) null && lambdaExpression.Body.Type.GetNonNullableType() != memberType.GetNonNullableType())
        lambdaExpression = Expression.Lambda((Expression) Expression.Convert(lambdaExpression.Body, memberType), (IEnumerable<ParameterExpression>) lambdaExpression.Parameters);
      IGanttBoundColumn ganttBoundColumn = (IGanttBoundColumn) typeof (GanttBoundColumn<,,>).MakeGenericType(typeof (TTaskModel), typeof (TDependenciesModel), lambdaExpression.Body.Type).GetConstructor(new Type[2]
      {
        lambdaExpression.GetType(),
        typeof (IModelMetadataProvider)
      }).Invoke(new object[2]
      {
        (object) lambdaExpression,
        (object) this.Gantt.ModelMetadataProvider
      });
      ganttBoundColumn.Field = fieldName;
      if (!ganttBoundColumn.Title.HasValue())
        ganttBoundColumn.Title = fieldName.AsTitle();
      this.Container.Add((GanttColumn<TTaskModel, TDependenciesModel>) ganttBoundColumn);
      return new GanttBoundColumnBuilder<TTaskModel, TDependenciesModel>((GanttColumn<TTaskModel, TDependenciesModel>) ganttBoundColumn);
    }

    public virtual GanttResourceColumnBuilder<TTaskModel, TDependenciesModel> Resources(
      string fieldName)
    {
      GanttResourceColumn<TTaskModel, TDependenciesModel> ganttResourceColumn = new GanttResourceColumn<TTaskModel, TDependenciesModel>(fieldName);
      this.Container.Add((GanttColumn<TTaskModel, TDependenciesModel>) ganttResourceColumn);
      return new GanttResourceColumnBuilder<TTaskModel, TDependenciesModel>((GanttColumn<TTaskModel, TDependenciesModel>) ganttResourceColumn);
    }

    public Kendo.Mvc.UI.Gantt<TTaskModel, TDependenciesModel> Gantt { get; set; }

    public virtual GanttColumnBuilder<TTaskModel, TDependenciesModel> Add()
    {
      GanttColumn<TTaskModel, TDependenciesModel> container = new GanttColumn<TTaskModel, TDependenciesModel>();
      container.Gantt = this.Gantt;
      this.Container.Add(container);
      return new GanttColumnBuilder<TTaskModel, TDependenciesModel>(container);
    }
  }
}
