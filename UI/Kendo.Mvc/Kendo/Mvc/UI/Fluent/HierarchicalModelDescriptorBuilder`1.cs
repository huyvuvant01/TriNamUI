// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.HierarchicalModelDescriptorBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class HierarchicalModelDescriptorBuilder<TModel> : 
    DataSourceModelDescriptorFactoryBase<TModel>
    where TModel : class
  {
    private readonly IUrlGenerator urlGenerator;
    private readonly ViewContext viewContext;

    public HierarchicalModelDescriptorBuilder(
      ModelDescriptor model,
      ViewContext viewContext,
      IUrlGenerator urlGenerator)
      : base(model)
    {
      this.urlGenerator = urlGenerator;
      this.viewContext = viewContext;
    }

    public HierarchicalModelDescriptorBuilder<TModel> Id(
      string fieldName)
    {
      base.Id(fieldName);
      return this;
    }

    public HierarchicalModelDescriptorBuilder<TModel> Children(
      string fieldName)
    {
      this.model.ChildrenMember = fieldName;
      return this;
    }

    public HierarchicalModelDescriptorBuilder<TModel> Children(
      Action<HierarchicalDataSourceBuilder<object>> configurator)
    {
      this.model.ChildrenDataSource = new DataSource((IModelMetadataProvider) new EmptyModelMetadataProvider());
      this.model.ChildrenDataSource.ModelType(typeof (object));
      configurator(new HierarchicalDataSourceBuilder<object>(this.model.ChildrenDataSource, this.viewContext, this.urlGenerator));
      return this;
    }

    public HierarchicalModelDescriptorBuilder<TModel> HasChildren(
      string fieldName)
    {
      this.model.HasChildrenMember = fieldName;
      return this;
    }

    public virtual HierarchicalModelDescriptorBuilder<TModel> Field(
      string memberName,
      Type memberType)
    {
      this.model.AddDescriptor(memberName).MemberType = memberType;
      return this;
    }
  }
}
