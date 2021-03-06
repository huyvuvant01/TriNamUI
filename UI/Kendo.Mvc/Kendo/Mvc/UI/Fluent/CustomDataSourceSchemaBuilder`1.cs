// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.CustomDataSourceSchemaBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class CustomDataSourceSchemaBuilder<TModel> : 
    CustomDataSourceSchemaBuilderBase<CustomDataSourceSchemaBuilder<TModel>>,
    IHideObjectMembers
    where TModel : class
  {
    public CustomDataSourceSchemaBuilder(DataSourceSchema schema)
      : base(schema)
    {
    }

    public virtual CustomDataSourceSchemaBuilder<TModel> Model(
      Action<CustomDataSourceModelDescriptorFactory<TModel>> configurator)
    {
      configurator(new CustomDataSourceModelDescriptorFactory<TModel>(this.schema.Model));
      return this;
    }

    public virtual CustomDataSourceSchemaBuilder<TModel> Model(
      object settings)
    {
      this.schema.FunctionModel = settings;
      return this;
    }

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
