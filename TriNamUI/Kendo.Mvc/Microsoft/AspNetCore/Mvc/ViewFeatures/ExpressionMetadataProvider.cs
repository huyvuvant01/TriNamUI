// Decompiled with JetBrains decompiler
// Type: Microsoft.AspNetCore.Mvc.ViewFeatures.ExpressionMetadataProvider
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Globalization;
using System.Linq.Expressions;
using System.Reflection;

namespace Microsoft.AspNetCore.Mvc.ViewFeatures
{
  internal static class ExpressionMetadataProvider
  {
    public static ModelExplorer FromLambdaExpression<TModel, TResult>(
      Expression<Func<TModel, TResult>> expression,
      ViewDataDictionary<TModel> viewData,
      IModelMetadataProvider metadataProvider)
    {
      if (expression == null)
        throw new ArgumentNullException(nameof (expression));
      if (viewData == null)
        throw new ArgumentNullException(nameof (viewData));
      string str = (string) null;
      Type modelType = (Type) null;
      bool flag = false;
      switch (expression.Body.NodeType)
      {
        case ExpressionType.ArrayIndex:
          flag = true;
          break;
        case ExpressionType.Call:
          flag = ExpressionHelper.IsSingleArgumentIndexer(expression.Body);
          break;
        case ExpressionType.MemberAccess:
          MemberExpression body = (MemberExpression) expression.Body;
          str = (object) (body.Member as PropertyInfo) != null ? body.Member.Name : (string) null;
          if (string.Equals(str, "Model", StringComparison.Ordinal) && body.Type == typeof (TModel) && body.Expression.NodeType == ExpressionType.Constant)
            return ExpressionMetadataProvider.FromModel((ViewDataDictionary) viewData, metadataProvider);
          modelType = body.Expression?.Type;
          flag = true;
          break;
        case ExpressionType.Parameter:
          return ExpressionMetadataProvider.FromModel((ViewDataDictionary) viewData, metadataProvider);
      }
      if (!flag)
        throw new InvalidOperationException(Resources.TemplateHelpers_TemplateLimitations);
      ModelMetadata metadata = (ModelMetadata) null;
      if (modelType != (Type) null && str != null)
        metadata = metadataProvider.GetMetadataForType(modelType).Properties[str];
      if (metadata == null)
        metadata = metadataProvider.GetMetadataForType(typeof (TResult));
      return viewData.ModelExplorer.GetExplorerForExpression(metadata, new Func<object, object>(modelAccessor));

      object modelAccessor(object container)
      {
        TModel model = (TModel) container;
        Func<TModel, object> func1 = CachedExpressionCompiler.Process<TModel, TResult>(expression);
        if (func1 != null)
          return func1(model);
        Func<TModel, TResult> func2 = expression.Compile();
        try
        {
          return (object) func2(model);
        }
        catch (NullReferenceException ex)
        {
          return (object) null;
        }
      }
    }

    public static ModelExplorer FromStringExpression(
      string expression,
      ViewDataDictionary viewData,
      IModelMetadataProvider metadataProvider)
    {
      ViewDataInfo viewDataInfo = viewData != null ? ViewDataEvaluator.Eval(viewData, expression) : throw new ArgumentNullException(nameof (viewData));
      if (viewDataInfo == null)
      {
        ModelExplorer explorerForProperty = viewData.ModelExplorer.GetExplorerForProperty(expression);
        if (explorerForProperty != null)
          return explorerForProperty;
      }
      if (viewDataInfo != null)
      {
        if (viewDataInfo.Container == viewData && viewDataInfo.Value == viewData.Model && string.IsNullOrEmpty(expression))
          return ExpressionMetadataProvider.FromModel(viewData, metadataProvider);
        ModelExplorer modelExplorer = viewData.ModelExplorer;
        if (viewDataInfo.Container != null)
          modelExplorer = metadataProvider.GetModelExplorerForType(viewDataInfo.Container.GetType(), viewDataInfo.Container);
        if (viewDataInfo.PropertyInfo != (PropertyInfo) null)
        {
          ModelMetadata property = metadataProvider.GetMetadataForType(viewDataInfo.Container.GetType()).Properties[viewDataInfo.PropertyInfo.Name];
          Func<object, object> modelAccessor = (Func<object, object>) (ignore => viewDataInfo.Value);
          return modelExplorer.GetExplorerForExpression(property, modelAccessor);
        }
        if (viewDataInfo.Value != null)
        {
          ModelMetadata metadataForType = metadataProvider.GetMetadataForType(viewDataInfo.Value.GetType());
          return modelExplorer.GetExplorerForExpression(metadataForType, viewDataInfo.Value);
        }
      }
      ModelMetadata metadataForType1 = metadataProvider.GetMetadataForType(typeof (string));
      return viewData.ModelExplorer.GetExplorerForExpression(metadataForType1, (Func<object, object>) null);
    }

    private static ModelExplorer FromModel(
      ViewDataDictionary viewData,
      IModelMetadataProvider metadataProvider)
    {
      if (viewData == null)
        throw new ArgumentNullException(nameof (viewData));
      if (!(viewData.ModelMetadata.ModelType == typeof (object)))
        return viewData.ModelExplorer;
      string str = viewData.Model == null ? (string) null : Convert.ToString(viewData.Model, (IFormatProvider) CultureInfo.CurrentCulture);
      return metadataProvider.GetModelExplorerForType(typeof (string), (object) str);
    }
  }
}
