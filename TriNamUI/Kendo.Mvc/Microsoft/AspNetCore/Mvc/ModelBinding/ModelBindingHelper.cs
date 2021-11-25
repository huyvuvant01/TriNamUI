// Decompiled with JetBrains decompiler
// Type: Microsoft.AspNetCore.Mvc.ModelBinding.ModelBindingHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc.Core;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.ExceptionServices;
using System.Threading.Tasks;


#nullable enable
namespace Microsoft.AspNetCore.Mvc.ModelBinding
{
  internal static class ModelBindingHelper
  {
    public static 
    #nullable disable
    Task<bool> TryUpdateModelAsync<TModel>(
      TModel model,
      string prefix,
      ActionContext actionContext,
      IModelMetadataProvider metadataProvider,
      IModelBinderFactory modelBinderFactory,
      IValueProvider valueProvider,
      IObjectModelValidator objectModelValidator)
      where TModel : class
    {
      return ModelBindingHelper.TryUpdateModelAsync<TModel>(model, prefix, actionContext, metadataProvider, modelBinderFactory, valueProvider, objectModelValidator, (Func<ModelMetadata, bool>) (m => true));
    }

    public static Task<bool> TryUpdateModelAsync<TModel>(
      TModel model,
      string prefix,
      ActionContext actionContext,
      IModelMetadataProvider metadataProvider,
      IModelBinderFactory modelBinderFactory,
      IValueProvider valueProvider,
      IObjectModelValidator objectModelValidator,
      params Expression<Func<TModel, object>>[] includeExpressions)
      where TModel : class
    {
      Func<ModelMetadata, bool> propertyFilter = includeExpressions != null ? ModelBindingHelper.GetPropertyFilterExpression<TModel>(includeExpressions).Compile() : throw new ArgumentNullException(nameof (includeExpressions));
      return ModelBindingHelper.TryUpdateModelAsync<TModel>(model, prefix, actionContext, metadataProvider, modelBinderFactory, valueProvider, objectModelValidator, propertyFilter);
    }

    public static Task<bool> TryUpdateModelAsync<TModel>(
      TModel model,
      string prefix,
      ActionContext actionContext,
      IModelMetadataProvider metadataProvider,
      IModelBinderFactory modelBinderFactory,
      IValueProvider valueProvider,
      IObjectModelValidator objectModelValidator,
      Func<ModelMetadata, bool> propertyFilter)
      where TModel : class
    {
      return ModelBindingHelper.TryUpdateModelAsync((object) model, typeof (TModel), prefix, actionContext, metadataProvider, modelBinderFactory, valueProvider, objectModelValidator, propertyFilter);
    }

    public static Task<bool> TryUpdateModelAsync(
      object model,
      Type modelType,
      string prefix,
      ActionContext actionContext,
      IModelMetadataProvider metadataProvider,
      IModelBinderFactory modelBinderFactory,
      IValueProvider valueProvider,
      IObjectModelValidator objectModelValidator)
    {
      return ModelBindingHelper.TryUpdateModelAsync(model, modelType, prefix, actionContext, metadataProvider, modelBinderFactory, valueProvider, objectModelValidator, (Func<ModelMetadata, bool>) (m => true));
    }

    public static async Task<bool> TryUpdateModelAsync(
      object model,
      Type modelType,
      string prefix,
      ActionContext actionContext,
      IModelMetadataProvider metadataProvider,
      IModelBinderFactory modelBinderFactory,
      IValueProvider valueProvider,
      IObjectModelValidator objectModelValidator,
      Func<ModelMetadata, bool> propertyFilter)
    {
      if (model == null)
        throw new ArgumentNullException(nameof (model));
      if (modelType == (Type) null)
        throw new ArgumentNullException(nameof (modelType));
      if (prefix == null)
        throw new ArgumentNullException(nameof (prefix));
      if (actionContext == null)
        throw new ArgumentNullException(nameof (actionContext));
      if (metadataProvider == null)
        throw new ArgumentNullException(nameof (metadataProvider));
      if (modelBinderFactory == null)
        throw new ArgumentNullException(nameof (modelBinderFactory));
      if (valueProvider == null)
        throw new ArgumentNullException(nameof (valueProvider));
      if (objectModelValidator == null)
        throw new ArgumentNullException(nameof (objectModelValidator));
      if (propertyFilter == null)
        throw new ArgumentNullException(nameof (propertyFilter));
      ModelMetadata metadata = modelType.IsAssignableFrom(model.GetType()) ? metadataProvider.GetMetadataForType(modelType) : throw new ArgumentException(Resources.FormatModelType_WrongType((object) model.GetType().FullName, (object) modelType.FullName), nameof (modelType));
      ModelStateDictionary modelState = actionContext.ModelState;
      ModelBindingContext modelBindingContext = DefaultModelBindingContext.CreateBindingContext(actionContext, valueProvider, metadata, (BindingInfo) null, prefix);
      modelBindingContext.Model = model;
      modelBindingContext.PropertyFilter = propertyFilter;
      await modelBinderFactory.CreateBinder(new ModelBinderFactoryContext()
      {
        Metadata = metadata,
        BindingInfo = new BindingInfo()
        {
          BinderModelName = metadata.BinderModelName,
          BinderType = metadata.BinderType,
          BindingSource = metadata.BindingSource,
          PropertyFilterProvider = metadata.PropertyFilterProvider
        },
        CacheToken = (object) metadata
      }).BindModelAsync(modelBindingContext);
      ModelBindingResult result = modelBindingContext.Result;
      if (!result.IsModelSet)
        return false;
      objectModelValidator.Validate(actionContext, modelBindingContext.ValidationState, modelBindingContext.ModelName, result.Model);
      return modelState.IsValid;
    }

    internal static string GetPropertyName(Expression expression)
    {
      if (expression.NodeType == ExpressionType.Convert || expression.NodeType == ExpressionType.ConvertChecked)
        expression = ((UnaryExpression) expression).Operand;
      MemberExpression memberExpression = expression.NodeType == ExpressionType.MemberAccess ? (MemberExpression) expression : throw new InvalidOperationException(Resources.FormatInvalid_IncludePropertyExpression((object) expression.NodeType));
      PropertyInfo member = memberExpression.Member as PropertyInfo;
      if ((object) member == null)
        throw new InvalidOperationException(Resources.FormatInvalid_IncludePropertyExpression((object) expression.NodeType));
      if (memberExpression.Expression.NodeType != ExpressionType.Parameter)
        throw new InvalidOperationException(Resources.FormatInvalid_IncludePropertyExpression((object) expression.NodeType));
      return member.Name;
    }

    public static Expression<Func<ModelMetadata, bool>> GetPropertyFilterExpression<TModel>(
      Expression<Func<TModel, object>>[] expressions)
    {
      if (expressions.Length == 0)
        return (Expression<Func<ModelMetadata, bool>>) (m => true);
      Expression<Func<ModelMetadata, bool>> predicateExpression1 = ModelBindingHelper.GetPredicateExpression<TModel>(expressions[0]);
      Expression expression1 = predicateExpression1.Body;
      foreach (Expression<Func<TModel, object>> expression2 in ((IEnumerable<Expression<Func<TModel, object>>>) expressions).Skip<Expression<Func<TModel, object>>>(1))
      {
        Expression<Func<ModelMetadata, bool>> predicateExpression2 = ModelBindingHelper.GetPredicateExpression<TModel>(expression2);
        expression1 = (Expression) Expression.OrElse(expression1, (Expression) Expression.Invoke((Expression) predicateExpression2, (IEnumerable<Expression>) predicateExpression1.Parameters));
      }
      return Expression.Lambda<Func<ModelMetadata, bool>>(expression1, (IEnumerable<ParameterExpression>) predicateExpression1.Parameters);
    }

    private static Expression<Func<ModelMetadata, bool>> GetPredicateExpression<TModel>(
      Expression<Func<TModel, object>> expression)
    {
      string propertyName = ModelBindingHelper.GetPropertyName(expression.Body);
      return (Expression<Func<ModelMetadata, bool>>) (metadata => string.Equals(metadata.PropertyName, propertyName, StringComparison.Ordinal));
    }

    public static void ClearValidationStateForModel(
      Type modelType,
      ModelStateDictionary modelState,
      IModelMetadataProvider metadataProvider,
      string modelKey)
    {
      if (modelType == (Type) null)
        throw new ArgumentNullException(nameof (modelType));
      if (modelState == null)
        throw new ArgumentNullException(nameof (modelState));
      if (metadataProvider == null)
        throw new ArgumentNullException(nameof (metadataProvider));
      ModelBindingHelper.ClearValidationStateForModel(metadataProvider.GetMetadataForType(modelType), modelState, modelKey);
    }

    public static void ClearValidationStateForModel(
      ModelMetadata modelMetadata,
      ModelStateDictionary modelState,
      string modelKey)
    {
      if (modelMetadata == null)
        throw new ArgumentNullException(nameof (modelMetadata));
      if (modelState == null)
        throw new ArgumentNullException(nameof (modelState));
      if (string.IsNullOrEmpty(modelKey))
      {
        if (modelMetadata.IsEnumerableType)
        {
          foreach (KeyValuePair<string, ModelStateEntry> keyValuePair in modelState)
          {
            if (keyValuePair.Key.Length > 0 && keyValuePair.Key[0] == '[')
            {
              keyValuePair.Value.Errors.Clear();
              keyValuePair.Value.ValidationState = ModelValidationState.Unvalidated;
            }
          }
        }
        else if (modelMetadata.IsComplexType)
        {
          for (int index = 0; index < modelMetadata.Properties.Count; ++index)
          {
            ModelMetadata property = modelMetadata.Properties[index];
            modelState.ClearValidationState(property.BinderModelName ?? property.PropertyName);
          }
        }
        else
        {
          ModelStateEntry modelStateEntry = modelState[string.Empty];
          if (modelStateEntry == null)
            return;
          modelStateEntry.Errors.Clear();
          modelStateEntry.ValidationState = ModelValidationState.Unvalidated;
        }
      }
      else
        modelState.ClearValidationState(modelKey);
    }

    internal static TModel CastOrDefault<TModel>(object model) => !(model is TModel model1) ? default (TModel) : model1;

    public static bool CanGetCompatibleCollection<T>(ModelBindingContext bindingContext)
    {
      object model = bindingContext.Model;
      Type modelType = bindingContext.ModelType;
      if (typeof (T).IsAssignableFrom(modelType) || modelType == typeof (T[]))
        return true;
      if (!typeof (IEnumerable<T>).IsAssignableFrom(modelType))
        return false;
      if (model is ICollection<T> objs && !objs.IsReadOnly || modelType.IsAssignableFrom(typeof (List<T>)))
        return true;
      return modelType.GetTypeInfo().IsClass && !modelType.GetTypeInfo().IsAbstract && typeof (ICollection<T>).IsAssignableFrom(modelType);
    }

    public static ICollection<T> GetCompatibleCollection<T>(
      ModelBindingContext bindingContext)
    {
      return ModelBindingHelper.GetCompatibleCollection<T>(bindingContext, new int?());
    }

    public static ICollection<T> GetCompatibleCollection<T>(
      ModelBindingContext bindingContext,
      int capacity)
    {
      return ModelBindingHelper.GetCompatibleCollection<T>(bindingContext, new int?(capacity));
    }

    private static ICollection<T> GetCompatibleCollection<T>(
      ModelBindingContext bindingContext,
      int? capacity)
    {
      object model = bindingContext.Model;
      Type modelType = bindingContext.ModelType;
      if (typeof (T).IsAssignableFrom(modelType))
        return (ICollection<T>) ModelBindingHelper.CreateList<T>(capacity);
      if (modelType == typeof (T[]))
        return (ICollection<T>) ModelBindingHelper.CreateList<T>(capacity);
      if (model is ICollection<T> objs && !objs.IsReadOnly)
      {
        objs.Clear();
        return objs;
      }
      return modelType.IsAssignableFrom(typeof (List<T>)) ? (ICollection<T>) ModelBindingHelper.CreateList<T>(capacity) : (ICollection<T>) Activator.CreateInstance(modelType);
    }

    private static List<T> CreateList<T>(int? capacity) => !capacity.HasValue ? new List<T>() : new List<T>(capacity.Value);

    public static T ConvertTo<T>(object value, CultureInfo culture)
    {
      object obj = ModelBindingHelper.ConvertTo(value, typeof (T), culture);
      return obj != null ? (T) obj : default (T);
    }

    public static object ConvertTo(object value, Type type, CultureInfo culture)
    {
      if (type == (Type) null)
        throw new ArgumentNullException(nameof (type));
      if (value == null)
        return !type.GetTypeInfo().IsValueType ? (object) null : Activator.CreateInstance(type);
      if (type.IsAssignableFrom(value.GetType()))
        return value;
      CultureInfo culture1 = culture ?? CultureInfo.InvariantCulture;
      return ModelBindingHelper.UnwrapPossibleArrayType(value, type, culture1);
    }

    private static object UnwrapPossibleArrayType(
      object value,
      Type destinationType,
      CultureInfo culture)
    {
      Array array = value as Array;
      if (destinationType.IsArray)
      {
        Type elementType = destinationType.GetElementType();
        if (array != null)
        {
          IList instance = (IList) Array.CreateInstance(elementType, array.Length);
          for (int index = 0; index < array.Length; ++index)
            instance[index] = ModelBindingHelper.ConvertSimpleType(array.GetValue(index), elementType, culture);
          return (object) instance;
        }
        object obj = ModelBindingHelper.ConvertSimpleType(value, elementType, culture);
        Array instance1 = Array.CreateInstance(elementType, 1);
        ((IList) instance1)[0] = obj;
        return (object) instance1;
      }
      if (array == null)
        return ModelBindingHelper.ConvertSimpleType(value, destinationType, culture);
      if (array.Length <= 0)
        return (object) null;
      value = array.GetValue(0);
      return ModelBindingHelper.ConvertSimpleType(value, destinationType, culture);
    }

    private static object ConvertSimpleType(
      object value,
      Type destinationType,
      CultureInfo culture)
    {
      if (value == null || destinationType.IsAssignableFrom(value.GetType()))
        return value;
      destinationType = ModelBindingHelper.UnwrapNullableType(destinationType);
      if (value is string str && string.IsNullOrWhiteSpace(str))
        return (object) null;
      TypeConverter converter = TypeDescriptor.GetConverter(destinationType);
      bool flag = converter.CanConvertFrom(value.GetType());
      if (!flag)
        converter = TypeDescriptor.GetConverter(value.GetType());
      if (!flag && !converter.CanConvertTo(destinationType))
      {
        if (destinationType.GetTypeInfo().IsEnum)
        {
          switch (value)
          {
            case int _:
            case uint _:
            case long _:
            case ulong _:
            case short _:
            case ushort _:
            case byte _:
            case sbyte _:
              return Enum.ToObject(destinationType, value);
          }
        }
        throw new InvalidOperationException(Resources.FormatValueProviderResult_NoConverterExists((object) value.GetType(), (object) destinationType));
      }
      try
      {
        return flag ? converter.ConvertFrom((ITypeDescriptorContext) null, culture, value) : converter.ConvertTo((ITypeDescriptorContext) null, culture, value, destinationType);
      }
      catch (FormatException ex)
      {
        throw;
      }
      catch (Exception ex)
      {
        if (ex.InnerException == null)
        {
          throw;
        }
        else
        {
          ExceptionDispatchInfo.Capture(ex.InnerException).Throw();
          throw;
        }
      }
    }

    private static Type UnwrapNullableType(Type destinationType)
    {
      Type underlyingType = Nullable.GetUnderlyingType(destinationType);
      return (object) underlyingType != null ? underlyingType : destinationType;
    }
  }
}
