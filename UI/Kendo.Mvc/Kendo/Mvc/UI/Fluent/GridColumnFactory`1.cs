// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.GridColumnFactory`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Kendo.Mvc.UI.Fluent
{
  public class GridColumnFactory<TModel> : IHideObjectMembers where TModel : class
  {
    private bool hasGeneratedColumn;
    private IUrlGenerator urlGenerator;
    private ViewContext viewContext;

    public GridColumnFactory(
      Grid<TModel> container,
      ViewContext viewContext,
      IUrlGenerator urlGenerator)
      : this(container, viewContext, urlGenerator, (IGridColumnContainer<TModel>) container)
    {
    }

    public GridColumnFactory(
      Grid<TModel> container,
      ViewContext viewContext,
      IUrlGenerator urlGenerator,
      IGridColumnContainer<TModel> columnsContainer)
    {
      this.Container = container;
      this.ColumnsContainer = columnsContainer;
      this.viewContext = viewContext;
      this.urlGenerator = urlGenerator;
    }

    public Grid<TModel> Container { get; private set; }

    public IGridColumnContainer<TModel> ColumnsContainer { get; private set; }

    public void LoadSettings(IEnumerable<GridColumnSettings> settings)
    {
      GridColumnGenerator<TModel> gridColumnGenerator = new GridColumnGenerator<TModel>(this.Container);
      foreach (GridColumnSettings setting in settings)
        this.ColumnsContainer.Columns.Add(gridColumnGenerator.CreateColumn(setting));
    }

    public virtual GridBoundColumnBuilder<TModel> Bound<TValue>(
      Expression<Func<TModel, TValue>> expression)
    {
      GridBoundColumn<TModel, TValue> gridBoundColumn = new GridBoundColumn<TModel, TValue>(this.Container, expression);
      this.ColumnsContainer.Columns.Add((GridColumnBase<TModel>) gridBoundColumn);
      return new GridBoundColumnBuilder<TModel>((IGridBoundColumn) gridBoundColumn, this.viewContext, this.urlGenerator);
    }

    public virtual GridBoundColumnBuilder<TModel> Bound(string memberName) => this.Bound((Type) null, memberName);

    public GridColumnFactory<TModel> Group(
      Action<GridColumnGroupBuilder<TModel>> configurator)
    {
      GridColumnGroup<TModel> gridColumnGroup = new GridColumnGroup<TModel>(this.Container);
      this.ColumnsContainer.Columns.Add((GridColumnBase<TModel>) gridColumnGroup);
      GridColumnGroupBuilder<TModel> columnGroupBuilder = new GridColumnGroupBuilder<TModel>((IGridColumnGroup) gridColumnGroup, this.Container, this.viewContext, this.urlGenerator);
      configurator(columnGroupBuilder);
      return this;
    }

    public virtual GridBoundColumnBuilder<TModel> Bound(
      Type memberType,
      string memberName)
    {
      LambdaExpression lambdaExpression = ExpressionBuilder.Lambda<TModel>(memberType, memberName, false);
      if (typeof (TModel).IsDynamicObject() && memberType != (Type) null && lambdaExpression.Body.Type.GetNonNullableType() != memberType.GetNonNullableType())
        lambdaExpression = Expression.Lambda((Expression) Expression.Convert(lambdaExpression.Body, memberType), (IEnumerable<ParameterExpression>) lambdaExpression.Parameters);
      IGridBoundColumn column = (IGridBoundColumn) typeof (GridBoundColumn<,>).MakeGenericType(typeof (TModel), lambdaExpression.Body.Type).GetConstructor(new Type[2]
      {
        this.Container.GetType(),
        lambdaExpression.GetType()
      }).Invoke(new object[2]
      {
        (object) this.Container,
        (object) lambdaExpression
      });
      column.Member = memberName;
      if (!column.Title.HasValue())
        column.Title = memberName.AsTitle();
      if (memberType != (Type) null)
        column.MemberType = memberType;
      this.ColumnsContainer.Columns.Add((GridColumnBase<TModel>) column);
      return new GridBoundColumnBuilder<TModel>(column, this.viewContext, this.urlGenerator);
    }

    public virtual GridBoundColumnBuilder<TModel> ForeignKey<TValue>(
      Expression<Func<TModel, TValue>> expression,
      Action<ReadOnlyDataSourceBuilder> dataSource,
      string dataFieldValue,
      string dataFieldText)
    {
      GridForeignKeyColumn<TModel, TValue> foreignKeyColumn = new GridForeignKeyColumn<TModel, TValue>(this.Container, expression);
      dataSource(new ReadOnlyDataSourceBuilder(foreignKeyColumn.DataSource, this.viewContext, this.urlGenerator));
      foreignKeyColumn.DataTextField = dataFieldText;
      foreignKeyColumn.DataValueField = dataFieldValue;
      this.ColumnsContainer.Columns.Add((GridColumnBase<TModel>) foreignKeyColumn);
      return new GridBoundColumnBuilder<TModel>((IGridBoundColumn) foreignKeyColumn, this.viewContext, this.urlGenerator);
    }

    public virtual GridBoundColumnBuilder<TModel> ForeignKey<TValue>(
      Expression<Func<TModel, TValue>> expression,
      Action<ReadOnlyDataSourceBuilder> dataSource,
      string dataFieldValue,
      string dataFieldText,
      bool useServerEditor)
    {
      GridForeignKeyColumn<TModel, TValue> foreignKeyColumn = new GridForeignKeyColumn<TModel, TValue>(this.Container, expression);
      dataSource(new ReadOnlyDataSourceBuilder(foreignKeyColumn.DataSource, this.viewContext, this.urlGenerator));
      foreignKeyColumn.DataTextField = dataFieldText;
      foreignKeyColumn.DataValueField = dataFieldValue;
      foreignKeyColumn.UseServerEditor = useServerEditor;
      this.ColumnsContainer.Columns.Add((GridColumnBase<TModel>) foreignKeyColumn);
      return new GridBoundColumnBuilder<TModel>((IGridBoundColumn) foreignKeyColumn, this.viewContext, this.urlGenerator);
    }

    public virtual GridBoundColumnBuilder<TModel> ForeignKey<TValue>(
      Expression<Func<TModel, TValue>> expression,
      IEnumerable data,
      string dataFieldValue,
      string dataFieldText)
    {
      return this.ForeignKey<TValue>(expression, new SelectList(data, dataFieldValue, dataFieldText));
    }

    public virtual GridBoundColumnBuilder<TModel> ForeignKey<TValue>(
      Expression<Func<TModel, TValue>> expression,
      SelectList data)
    {
      GridForeignKeyColumn<TModel, TValue> foreignKeyColumn = new GridForeignKeyColumn<TModel, TValue>(this.Container, expression, data);
      foreignKeyColumn.Data = data;
      this.ColumnsContainer.Columns.Add((GridColumnBase<TModel>) foreignKeyColumn);
      return new GridBoundColumnBuilder<TModel>((IGridBoundColumn) foreignKeyColumn, this.viewContext, this.urlGenerator);
    }

    public virtual GridBoundColumnBuilder<TModel> ForeignKey(
      string memberName,
      IEnumerable data,
      string dataFieldValue,
      string dataFieldText)
    {
      return this.ForeignKey((Type) null, memberName, new SelectList(data, dataFieldValue, dataFieldText));
    }

    public virtual GridBoundColumnBuilder<TModel> ForeignKey(
      string memberName,
      SelectList data)
    {
      return this.ForeignKey((Type) null, memberName, data);
    }

    public virtual GridBoundColumnBuilder<TModel> ForeignKey(
      Type memberType,
      string memberName,
      IEnumerable data,
      string dataFieldValue,
      string dataFieldText)
    {
      return this.ForeignKey(memberType, memberName, new SelectList(data, dataFieldValue, dataFieldText));
    }

    public virtual GridBoundColumnBuilder<TModel> ForeignKey(
      Type memberType,
      string memberName,
      SelectList data)
    {
      LambdaExpression lambdaExpression = ExpressionBuilder.Lambda<TModel>(memberType, memberName, false);
      if (typeof (TModel).IsDynamicObject() && memberType != (Type) null && lambdaExpression.Body.Type.GetNonNullableType() != memberType.GetNonNullableType())
        lambdaExpression = Expression.Lambda((Expression) Expression.Convert(lambdaExpression.Body, memberType), (IEnumerable<ParameterExpression>) lambdaExpression.Parameters);
      IGridBoundColumn column = (IGridBoundColumn) typeof (GridForeignKeyColumn<,>).MakeGenericType(typeof (TModel), lambdaExpression.Body.Type).GetConstructor(new Type[3]
      {
        this.Container.GetType(),
        lambdaExpression.GetType(),
        data.GetType()
      }).Invoke(new object[3]
      {
        (object) this.Container,
        (object) lambdaExpression,
        (object) data
      });
      column.Member = memberName;
      if (!column.Title.HasValue())
        column.Title = memberName.AsTitle();
      if (memberType != (Type) null)
        column.MemberType = memberType;
      this.ColumnsContainer.Columns.Add((GridColumnBase<TModel>) column);
      return new GridBoundColumnBuilder<TModel>(column, this.viewContext, this.urlGenerator);
    }

    protected virtual void AutoGenerate(
      bool shouldGenerate,
      Action<GridColumnBase<TModel>> columnAction)
    {
      if (this.hasGeneratedColumn)
        return;
      if (shouldGenerate)
      {
        new GridColumnGenerator<TModel>(this.Container).GetColumns().Each<GridColumnBase<TModel>>((Action<GridColumnBase<TModel>>) (c =>
        {
          if (columnAction != null)
            columnAction(c);
          this.ColumnsContainer.Columns.Add(c);
        }));
        this.hasGeneratedColumn = true;
      }
      this.Container.AutoGenerateColumns = shouldGenerate;
    }

    public virtual void AutoGenerate(bool shouldGenerate) => this.AutoGenerate(shouldGenerate, (Action<GridColumnBase<TModel>>) null);

    public virtual void AutoGenerate(Action<GridColumnBase<TModel>> columnAction) => this.AutoGenerate(true, columnAction);

    public virtual GridTemplateColumnBuilder<TModel> Template(
      string template)
    {
      GridTemplateColumn<TModel> column = new GridTemplateColumn<TModel>(this.Container);
      this.ColumnsContainer.Columns.Add((GridColumnBase<TModel>) column);
      column.ClientTemplate = template;
      return new GridTemplateColumnBuilder<TModel>(column);
    }

    public virtual GridActionColumnBuilder Command(
      Action<GridActionCommandFactory<TModel>> commandAction)
    {
      GridActionColumn<TModel> column = new GridActionColumn<TModel>(this.Container);
      commandAction(new GridActionCommandFactory<TModel>(column));
      this.ColumnsContainer.Columns.Add((GridColumnBase<TModel>) column);
      return new GridActionColumnBuilder((IGridColumn) column);
    }

    public virtual GridSelectColumnBuilder Select()
    {
      GridSelectColumn<TModel> gridSelectColumn = new GridSelectColumn<TModel>(this.Container);
      this.ColumnsContainer.Columns.Add((GridColumnBase<TModel>) gridSelectColumn);
      return new GridSelectColumnBuilder((IGridColumn) gridSelectColumn);
    }

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
