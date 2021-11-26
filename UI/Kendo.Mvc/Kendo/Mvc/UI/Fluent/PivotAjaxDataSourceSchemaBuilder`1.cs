// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.PivotAjaxDataSourceSchemaBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class PivotAjaxDataSourceSchemaBuilder<TModel> where TModel : class
  {
    protected readonly PivotDataSourceSchema schema;

    public PivotAjaxDataSourceSchemaBuilder(PivotDataSourceSchema schema) => this.schema = schema;

    public PivotAjaxDataSourceSchemaBuilder<TModel> Cube(
      Action<PivotAjaxDataSourceSchemaCubeBuilder<TModel>> configurator)
    {
      configurator(new PivotAjaxDataSourceSchemaCubeBuilder<TModel>(this.schema.Cube));
      return this;
    }

    public virtual PivotAjaxDataSourceSchemaBuilder<TModel> Model(
      Action<CustomDataSourceModelDescriptorFactory<TModel>> configurator)
    {
      configurator(new CustomDataSourceModelDescriptorFactory<TModel>(this.schema.Model));
      return this;
    }
  }
}
