// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.DataSourceModelDescriptorFactoryBase`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System;
using System.Linq.Expressions;

namespace Kendo.Mvc.UI.Fluent
{
  public abstract class DataSourceModelDescriptorFactoryBase<TModel> : IHideObjectMembers
    where TModel : class
  {
    protected readonly ModelDescriptor model;

    public DataSourceModelDescriptorFactoryBase(ModelDescriptor model) => this.model = model;

    protected void Id(string fieldName)
    {
      IDataKey<TModel> dataKey;
      if (typeof (TModel).IsDynamicObject())
      {
        Expression<Func<object, object>> expression = ExpressionBuilder.Expression<object, object>(fieldName);
        dataKey = (IDataKey<TModel>) new ModelDynamicDataKey(fieldName, expression);
      }
      else
        dataKey = this.GetDataKeyForField(fieldName);
      dataKey.RouteKey = dataKey.Name;
      this.model.Id = (IDataKey) dataKey;
    }

    protected IDataKey<TModel> GetDataKeyForField(string fieldName)
    {
      LambdaExpression lambdaExpression = ExpressionBuilder.Lambda<TModel>(fieldName);
      return (IDataKey<TModel>) typeof (ModelDataKey<,>).MakeGenericType(typeof (TModel), lambdaExpression.Body.Type).GetConstructor(new Type[1]
      {
        lambdaExpression.GetType()
      }).Invoke(new object[1]{ (object) lambdaExpression });
    }

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
