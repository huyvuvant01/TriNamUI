// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.GanttBoundColumn`3
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Resources;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Linq.Expressions;
using System.Reflection;

namespace Kendo.Mvc.UI
{
  public class GanttBoundColumn<TTaskModel, TDependenciesModel, ТValue> : 
    GanttColumn<TTaskModel, TDependenciesModel>,
    IGanttBoundColumn
    where TTaskModel : class, IGanttTask
    where TDependenciesModel : class, IGanttDependency
  {
    public GanttBoundColumn(
      Expression<Func<TTaskModel, ТValue>> expression,
      IModelMetadataProvider modelMetadataProvider)
    {
      this.Field = !typeof (TTaskModel).IsPlainType() || expression.IsBindable() ? expression.MemberWithoutInstance() : throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
      if (typeof (TTaskModel).IsPlainType())
      {
        ViewDataDictionary<TTaskModel> viewData = new ViewDataDictionary<TTaskModel>(modelMetadataProvider, new ModelStateDictionary());
        ModelMetadata metadata = ExpressionMetadataProvider.FromLambdaExpression<TTaskModel, ТValue>(expression, viewData, modelMetadataProvider).Metadata;
        this.Title = metadata.DisplayName;
        this.Format = metadata.DisplayFormatString;
      }
      if (string.IsNullOrEmpty(this.Title))
        this.Title = this.Field.AsTitle();
      if (typeof (IGanttTask).GetProperty(this.Field) != (PropertyInfo) null)
        this.Field = this.Field.ToCamelCase();
      if (typeof (IGanttPlannedTask).GetProperty(this.Field) != (PropertyInfo) null)
        this.Field = this.Field.ToCamelCase();
      this.Editor = new ClientHandlerDescriptor();
      this.Sortable = new GanttColumnSortableSettings();
    }
  }
}
