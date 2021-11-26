// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ReadOnlyCustomDataSourceSchemaBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class ReadOnlyCustomDataSourceSchemaBuilder<TModel> : 
    CustomDataSourceSchemaBuilderBase<ReadOnlyCustomDataSourceSchemaBuilder<TModel>>,
    IHideObjectMembers
    where TModel : class
  {
    private IModelMetadataProvider metadataProvider;

    public ReadOnlyCustomDataSourceSchemaBuilder(
      DataSourceSchema schema,
      IModelMetadataProvider metadataProvider)
      : base(schema)
    {
      this.metadataProvider = metadataProvider;
    }

    public virtual ReadOnlyCustomDataSourceSchemaBuilder<TModel> Model(
      Action<ReadOnlyCustomDataSourceModelDescriptorFactory<TModel>> configurator)
    {
      this.schema.Model = new ModelDescriptor(typeof (TModel), this.metadataProvider);
      configurator(new ReadOnlyCustomDataSourceModelDescriptorFactory<TModel>(this.schema.Model));
      return this;
    }

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
