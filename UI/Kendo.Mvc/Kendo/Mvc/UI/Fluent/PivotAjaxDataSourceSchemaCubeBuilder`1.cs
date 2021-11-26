// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.PivotAjaxDataSourceSchemaCubeBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class PivotAjaxDataSourceSchemaCubeBuilder<TModel> where TModel : class
  {
    protected readonly PivotDataSourceSchemaCube cube;

    public PivotAjaxDataSourceSchemaCubeBuilder(PivotDataSourceSchemaCube cube) => this.cube = cube;

    public PivotAjaxDataSourceSchemaCubeBuilder<TModel> Dimensions(
      Action<PivotAjaxDataSourceSchemaCubeDimensionFactory<TModel>> configurator)
    {
      configurator(new PivotAjaxDataSourceSchemaCubeDimensionFactory<TModel>(this.cube.Dimensions));
      return this;
    }

    public PivotAjaxDataSourceSchemaCubeBuilder<TModel> Measures(
      Action<PivotAjaxDataSourceSchemaCubeMeasureFactory<TModel>> configurator)
    {
      configurator(new PivotAjaxDataSourceSchemaCubeMeasureFactory<TModel>(this.cube.Measures));
      return this;
    }
  }
}
