// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.GridColumnGenerator`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Kendo.Mvc.UI
{
  public class GridColumnGenerator<T> where T : class
  {
    private readonly Grid<T> grid;

    public GridColumnGenerator(Grid<T> grid) => this.grid = grid;

    public IEnumerable<GridColumnBase<T>> GetColumns()
    {
      IEnumerable<PropertyInfo> source = ((IEnumerable<PropertyInfo>) typeof (T).GetProperties(BindingFlags.Instance | BindingFlags.Public)).Where<PropertyInfo>((Func<PropertyInfo, bool>) (property => property.CanRead && property.GetGetMethod().GetParameters().Length == 0)).Where<PropertyInfo>((Func<PropertyInfo, bool>) (property =>
      {
        if (property.PropertyType.IsEnumType() || property.PropertyType != typeof (object) && property.PropertyType.IsPredefinedType())
          return true;
        return property.PropertyType.IsNullableType() && property.PropertyType.GetNonNullableType().IsPredefinedType();
      }));
      IModelMetadataProvider modelMetadataProvider = this.grid.ModelMetadataProvider;
      ViewDataDictionary<T> viewDataDictionary = new ViewDataDictionary<T>(modelMetadataProvider, new ModelStateDictionary());
      Func<PropertyInfo, \u003C\u003Ef__AnonymousType7<int, PropertyInfo>> selector = property => new
      {
        Order = ExpressionMetadataProvider.FromStringExpression(property.Name, (ViewDataDictionary) viewDataDictionary, modelMetadataProvider).Metadata.Order,
        Property = property
      };
      return source.Select(selector).OrderBy(property => property.Order).Select(property => property.Property).Select<PropertyInfo, GridColumnBase<T>>((Func<PropertyInfo, GridColumnBase<T>>) (property => this.CreateBoundColumn(property)));
    }

    public GridColumnBase<T> CreateBoundColumn(string memberName, Type memberType)
    {
      bool checkForNull = false;
      if (this.grid.DataSource.Data != null)
        checkForNull = this.grid.DataSource.Data.AsQueryable().Provider.IsLinqToObjectsProvider();
      LambdaExpression lambdaExpression = ExpressionBuilder.Lambda<T>(memberType, memberName, checkForNull);
      IGridBoundColumn gridBoundColumn = (IGridBoundColumn) typeof (GridBoundColumn<,>).MakeGenericType(typeof (T), lambdaExpression.Body.Type).GetConstructor(new Type[2]
      {
        this.grid.GetType(),
        lambdaExpression.GetType()
      }).Invoke(new object[2]
      {
        (object) this.grid,
        (object) lambdaExpression
      });
      gridBoundColumn.Member = memberName;
      gridBoundColumn.Title = memberName.AsTitle();
      if (memberType != (Type) null)
        gridBoundColumn.MemberType = memberType;
      return (GridColumnBase<T>) gridBoundColumn;
    }

    public GridColumnBase<T> CreateBoundColumn(PropertyInfo property)
    {
      Type type1 = typeof (GridBoundColumn<,>).MakeGenericType(typeof (T), property.PropertyType);
      Type delegateType = typeof (Func<,>).MakeGenericType(typeof (T), property.PropertyType);
      Type type2 = typeof (Expression<>).MakeGenericType(delegateType);
      ParameterExpression parameterExpression = Expression.Parameter(typeof (T), "x");
      Expression body = (Expression) Expression.Property((Expression) parameterExpression, property);
      Expression expression = (Expression) Expression.Lambda(delegateType, body, parameterExpression);
      return (GridColumnBase<T>) type1.GetConstructor(new Type[2]
      {
        this.grid.GetType(),
        type2
      }).Invoke(new object[2]
      {
        (object) this.grid,
        (object) expression
      });
    }

    public GridColumnBase<T> CreateColumn(GridColumnSettings settings)
    {
      if (!(settings is GridCommandColumnSettings commandColumnSettings))
        return this.CreateBoundColumn(settings);
      GridActionColumn<T> gridActionColumn = new GridActionColumn<T>(this.grid);
      gridActionColumn.Settings = settings;
      foreach (GridActionCommandBase command in (IEnumerable<GridActionCommandBase>) commandColumnSettings.Commands)
      {
        this.grid.Editable.Enabled = true;
        gridActionColumn.Commands.Add((IGridActionCommand) command);
      }
      if (settings.ClientHeaderTemplate.HasValue())
        gridActionColumn.ClientHeaderTemplate = settings.ClientHeaderTemplate;
      return (GridColumnBase<T>) gridActionColumn;
    }

    private GridColumnBase<T> CreateBoundColumn(GridColumnSettings settings)
    {
      Type memberType = settings.MemberType;
      LambdaExpression lambdaExpression = ExpressionBuilder.Lambda<T>(memberType, settings.Member, false);
      GridColumnBase<T> gridColumnBase = (GridColumnBase<T>) typeof (GridBoundColumn<,>).MakeGenericType(typeof (T), lambdaExpression.Body.Type).GetConstructor(new Type[2]
      {
        this.grid.GetType(),
        lambdaExpression.GetType()
      }).Invoke(new object[2]
      {
        (object) this.grid,
        (object) lambdaExpression
      });
      if (memberType != (Type) null)
        (gridColumnBase as IGridBoundColumn).MemberType = memberType;
      gridColumnBase.Settings = settings;
      return gridColumnBase;
    }
  }
}
