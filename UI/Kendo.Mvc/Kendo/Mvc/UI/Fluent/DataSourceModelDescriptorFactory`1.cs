// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.DataSourceModelDescriptorFactory`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System;
using System.Linq.Expressions;

namespace Kendo.Mvc.UI.Fluent
{
  public class DataSourceModelDescriptorFactory<TModel> : 
    DataSourceModelDescriptorFactoryBase<TModel>,
    IHideObjectMembers
    where TModel : class
  {
    public DataSourceModelDescriptorFactory(ModelDescriptor model)
      : base(model)
    {
    }

    public new void Id(string fieldName) => base.Id(fieldName);

    public virtual void Id<TValue>(Expression<Func<TModel, TValue>> expression)
    {
      ModelDataKey<TModel, TValue> modelDataKey = new ModelDataKey<TModel, TValue>(expression);
      modelDataKey.RouteKey = modelDataKey.Name;
      this.model.Id = (IDataKey) modelDataKey;
    }

    public virtual DataSourceModelFieldDescriptorBuilder<TValue> Field<TValue>(
      Expression<Func<TModel, TValue>> expression)
    {
      return this.AddFieldDescriptor<TValue>(expression.MemberWithoutInstance(), typeof (TValue));
    }

    public virtual DataSourceModelFieldDescriptorBuilder<object> Field(
      string memberName,
      Type memberType)
    {
      return this.AddFieldDescriptor<object>(memberName, memberType);
    }

    public virtual DataSourceModelFieldDescriptorBuilder<TValue> Field<TValue>(
      string memberName)
    {
      return this.AddFieldDescriptor<TValue>(memberName, typeof (TValue));
    }

    protected DataSourceModelFieldDescriptorBuilder<TValue> AddFieldDescriptor<TValue>(
      string memberName,
      Type memberType)
    {
      ModelFieldDescriptor descriptor = this.model.AddDescriptor(memberName);
      descriptor.MemberType = memberType;
      return new DataSourceModelFieldDescriptorBuilder<TValue>(descriptor);
    }

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
