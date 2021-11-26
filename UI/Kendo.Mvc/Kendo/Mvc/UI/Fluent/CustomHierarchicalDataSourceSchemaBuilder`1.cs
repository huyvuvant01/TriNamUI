// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.CustomHierarchicalDataSourceSchemaBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class CustomHierarchicalDataSourceSchemaBuilder<TModel> : 
    CustomDataSourceSchemaBuilderBase<CustomHierarchicalDataSourceSchemaBuilder<TModel>>
    where TModel : class
  {
    private readonly IUrlGenerator urlGenerator;
    private readonly ViewContext viewContext;

    public CustomHierarchicalDataSourceSchemaBuilder(
      DataSourceSchema schema,
      ViewContext viewContext,
      IUrlGenerator urlGenerator)
      : base(schema)
    {
      this.viewContext = viewContext;
      this.urlGenerator = urlGenerator;
    }

    public virtual CustomHierarchicalDataSourceSchemaBuilder<TModel> Model(
      Action<CustomHierarchicalDataSourceModelDescriptorFactory<TModel>> configurator)
    {
      configurator(new CustomHierarchicalDataSourceModelDescriptorFactory<TModel>(this.schema.Model, this.viewContext, this.urlGenerator));
      return this;
    }
  }
}
