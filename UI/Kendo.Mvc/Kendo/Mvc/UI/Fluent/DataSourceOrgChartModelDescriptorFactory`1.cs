// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.DataSourceOrgChartModelDescriptorFactory`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System;
using System.Linq.Expressions;

namespace Kendo.Mvc.UI.Fluent
{
  public class DataSourceOrgChartModelDescriptorFactory<TModel> : 
    DataSourceModelDescriptorFactoryBase<TModel>,
    IHideObjectMembers
    where TModel : class
  {
    private OrgChartModelDescriptor orgchartModel;

    public DataSourceOrgChartModelDescriptorFactory(OrgChartModelDescriptor model)
      : base((ModelDescriptor) model)
    {
      this.orgchartModel = model;
    }

    public DataSourceOrgChartModelFieldDescriptorBuilder<TValue> ParentId<TValue>(
      Expression<Func<TModel, TValue>> expression)
    {
      this.orgchartModel.ParentId = expression.MemberWithoutInstance();
      return this.AddFieldDescriptor<TValue>(this.orgchartModel.ParentId, typeof (TValue));
    }

    public virtual DataSourceOrgChartModelFieldDescriptorBuilder<TValue> ParentId<TValue>(
      string memberName)
    {
      this.orgchartModel.ParentId = memberName;
      return this.AddFieldDescriptor<TValue>(memberName, typeof (TValue));
    }

    public DataSourceOrgChartModelFieldDescriptorBuilder<TValue> HasChildren<TValue>(
      Expression<Func<TModel, TValue>> expression)
    {
      this.orgchartModel.HasChildren = expression.MemberWithoutInstance();
      return this.AddFieldDescriptor<TValue>(this.orgchartModel.HasChildren, typeof (TValue));
    }

    public virtual DataSourceOrgChartModelFieldDescriptorBuilder<TValue> HasChildren<TValue>(
      string memberName)
    {
      this.orgchartModel.HasChildren = memberName;
      return this.AddFieldDescriptor<TValue>(memberName, typeof (TValue));
    }

    public DataSourceOrgChartModelFieldDescriptorBuilder<TValue> Name<TValue>(
      Expression<Func<TModel, TValue>> expression)
    {
      this.orgchartModel.Name = expression.MemberWithoutInstance();
      return this.AddFieldDescriptor<TValue>(this.orgchartModel.Name, typeof (TValue));
    }

    public virtual DataSourceOrgChartModelFieldDescriptorBuilder<TValue> Name<TValue>(
      string memberName)
    {
      this.orgchartModel.Name = memberName;
      return this.AddFieldDescriptor<TValue>(memberName, typeof (TValue));
    }

    public DataSourceOrgChartModelFieldDescriptorBuilder<TValue> Title<TValue>(
      Expression<Func<TModel, TValue>> expression)
    {
      this.orgchartModel.Title = expression.MemberWithoutInstance();
      return this.AddFieldDescriptor<TValue>(this.orgchartModel.Title, typeof (TValue));
    }

    public virtual DataSourceOrgChartModelFieldDescriptorBuilder<TValue> Title<TValue>(
      string memberName)
    {
      this.orgchartModel.Title = memberName;
      return this.AddFieldDescriptor<TValue>(memberName, typeof (TValue));
    }

    public DataSourceOrgChartModelFieldDescriptorBuilder<TValue> Avatar<TValue>(
      Expression<Func<TModel, TValue>> expression)
    {
      this.orgchartModel.Avatar = expression.MemberWithoutInstance();
      return this.AddFieldDescriptor<TValue>(this.orgchartModel.Avatar, typeof (TValue));
    }

    public virtual DataSourceOrgChartModelFieldDescriptorBuilder<TValue> Avatar<TValue>(
      string memberName)
    {
      this.orgchartModel.Avatar = memberName;
      return this.AddFieldDescriptor<TValue>(memberName, typeof (TValue));
    }

    public DataSourceOrgChartModelFieldDescriptorBuilder<TValue> Expanded<TValue>(
      Expression<Func<TModel, TValue>> expression)
    {
      this.orgchartModel.Expanded = (object) expression.MemberWithoutInstance();
      return this.AddFieldDescriptor<TValue>((string) this.orgchartModel.Expanded, typeof (TValue));
    }

    public virtual DataSourceOrgChartModelFieldDescriptorBuilder<TValue> Expanded<TValue>(
      string memberName)
    {
      this.orgchartModel.Expanded = (object) memberName;
      return this.AddFieldDescriptor<TValue>(memberName, typeof (TValue));
    }

    public virtual DataSourceOrgChartModelDescriptorFactory<TModel> Expanded(
      bool defaultValue)
    {
      this.orgchartModel.Expanded = (object) defaultValue;
      return this;
    }

    public new void Id(string fieldName) => base.Id(fieldName);

    public virtual void Id<TValue>(Expression<Func<TModel, TValue>> expression)
    {
      ModelDataKey<TModel, TValue> modelDataKey = new ModelDataKey<TModel, TValue>(expression);
      modelDataKey.RouteKey = modelDataKey.Name;
      this.model.Id = (IDataKey) modelDataKey;
    }

    public virtual DataSourceOrgChartModelFieldDescriptorBuilder<TValue> Field<TValue>(
      Expression<Func<TModel, TValue>> expression)
    {
      return this.AddFieldDescriptor<TValue>(expression.MemberWithoutInstance(), typeof (TValue));
    }

    public virtual DataSourceOrgChartModelFieldDescriptorBuilder<object> Field(
      string memberName,
      Type memberType)
    {
      return this.AddFieldDescriptor<object>(memberName, memberType);
    }

    public virtual DataSourceOrgChartModelFieldDescriptorBuilder<TValue> Field<TValue>(
      string memberName)
    {
      return this.AddFieldDescriptor<TValue>(memberName, typeof (TValue));
    }

    protected DataSourceOrgChartModelFieldDescriptorBuilder<TValue> AddFieldDescriptor<TValue>(
      string memberName,
      Type memberType)
    {
      ModelFieldDescriptor descriptor = this.model.AddDescriptor(memberName);
      descriptor.MemberType = memberType;
      return new DataSourceOrgChartModelFieldDescriptorBuilder<TValue>(descriptor);
    }

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
