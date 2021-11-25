// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.DataSourceTreeListModelDescriptorFactory`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System;
using System.Linq.Expressions;

namespace Kendo.Mvc.UI.Fluent
{
  public class DataSourceTreeListModelDescriptorFactory<TModel> : 
    DataSourceModelDescriptorFactoryBase<TModel>,
    IHideObjectMembers
    where TModel : class
  {
    private TreeListModelDescriptor treelistModel;

    public DataSourceTreeListModelDescriptorFactory(TreeListModelDescriptor model)
      : base((ModelDescriptor) model)
    {
      this.treelistModel = model;
    }

    public DataSourceTreeListModelFieldDescriptorBuilder<TValue> ParentId<TValue>(
      Expression<Func<TModel, TValue>> expression)
    {
      this.treelistModel.ParentId = expression.MemberWithoutInstance();
      return this.AddFieldDescriptor<TValue>(this.treelistModel.ParentId, typeof (TValue));
    }

    public virtual DataSourceTreeListModelFieldDescriptorBuilder<TValue> ParentId<TValue>(
      string memberName)
    {
      this.treelistModel.ParentId = memberName;
      return this.AddFieldDescriptor<TValue>(memberName, typeof (TValue));
    }

    public DataSourceTreeListModelFieldDescriptorBuilder<TValue> Expanded<TValue>(
      Expression<Func<TModel, TValue>> expression)
    {
      this.treelistModel.Expanded = (object) expression.MemberWithoutInstance();
      return this.AddFieldDescriptor<TValue>((string) this.treelistModel.Expanded, typeof (TValue));
    }

    public virtual DataSourceTreeListModelFieldDescriptorBuilder<TValue> Expanded<TValue>(
      string memberName)
    {
      this.treelistModel.Expanded = (object) memberName;
      return this.AddFieldDescriptor<TValue>(memberName, typeof (TValue));
    }

    public virtual DataSourceTreeListModelDescriptorFactory<TModel> Expanded(
      bool defaultValue)
    {
      this.treelistModel.Expanded = (object) defaultValue;
      return this;
    }

    public new void Id(string fieldName) => base.Id(fieldName);

    public virtual void Id<TValue>(Expression<Func<TModel, TValue>> expression)
    {
      ModelDataKey<TModel, TValue> modelDataKey = new ModelDataKey<TModel, TValue>(expression);
      modelDataKey.RouteKey = modelDataKey.Name;
      this.model.Id = (IDataKey) modelDataKey;
    }

    public virtual DataSourceTreeListModelFieldDescriptorBuilder<TValue> Field<TValue>(
      Expression<Func<TModel, TValue>> expression)
    {
      return this.AddFieldDescriptor<TValue>(expression.MemberWithoutInstance(), typeof (TValue));
    }

    public virtual DataSourceTreeListModelFieldDescriptorBuilder<object> Field(
      string memberName,
      Type memberType)
    {
      return this.AddFieldDescriptor<object>(memberName, memberType);
    }

    public virtual DataSourceTreeListModelFieldDescriptorBuilder<TValue> Field<TValue>(
      string memberName)
    {
      return this.AddFieldDescriptor<TValue>(memberName, typeof (TValue));
    }

    protected DataSourceTreeListModelFieldDescriptorBuilder<TValue> AddFieldDescriptor<TValue>(
      string memberName,
      Type memberType)
    {
      ModelFieldDescriptor descriptor = this.model.AddDescriptor(memberName);
      descriptor.MemberType = memberType;
      return new DataSourceTreeListModelFieldDescriptorBuilder<TValue>(descriptor);
    }

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
