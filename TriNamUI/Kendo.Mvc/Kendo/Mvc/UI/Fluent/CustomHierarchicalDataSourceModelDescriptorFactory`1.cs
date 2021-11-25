// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.CustomHierarchicalDataSourceModelDescriptorFactory`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class CustomHierarchicalDataSourceModelDescriptorFactory<TModel> : 
    DataSourceModelDescriptorFactoryBase<TModel>,
    IHideObjectMembers
    where TModel : class
  {
    private readonly IUrlGenerator urlGenerator;
    private readonly ViewContext viewContext;

    public CustomHierarchicalDataSourceModelDescriptorFactory(
      ModelDescriptor model,
      ViewContext viewContext,
      IUrlGenerator urlGenerator)
      : base(model)
    {
      this.viewContext = viewContext;
      this.urlGenerator = urlGenerator;
    }

    public CustomHierarchicalDataSourceModelDescriptorFactory<TModel> Id(
      string fieldName)
    {
      base.Id(fieldName);
      return this;
    }

    public CustomHierarchicalDataSourceModelDescriptorFactory<TModel> Children(
      string fieldName)
    {
      this.model.ChildrenMember = fieldName;
      return this;
    }

    public CustomHierarchicalDataSourceModelDescriptorFactory<TModel> Children(
      Action<HierarchicalDataSourceBuilder<object>> configurator)
    {
      this.model.ChildrenDataSource = new DataSource((IModelMetadataProvider) new EmptyModelMetadataProvider());
      this.model.ChildrenDataSource.ModelType(typeof (object));
      this.model.ChildrenDataSource.Type = new DataSourceType?(DataSourceType.Custom);
      configurator(new HierarchicalDataSourceBuilder<object>(this.model.ChildrenDataSource, this.viewContext, this.urlGenerator));
      return this;
    }

    public CustomHierarchicalDataSourceModelDescriptorFactory<TModel> HasChildren(
      string fieldName)
    {
      this.model.HasChildrenMember = fieldName;
      return this;
    }

    public virtual CustomDataSourceModelFieldDescriptorBuilder<TModel> Field(
      string memberName,
      Type memberType)
    {
      return this.AddFieldDescriptor<TModel>(memberName, memberType);
    }

    private CustomDataSourceModelFieldDescriptorBuilder<TValue> AddFieldDescriptor<TValue>(
      string memberName,
      Type memberType)
    {
      ModelFieldDescriptor descriptor = this.model.AddDescriptor(memberName);
      descriptor.MemberType = memberType;
      return new CustomDataSourceModelFieldDescriptorBuilder<TValue>(descriptor);
    }

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
