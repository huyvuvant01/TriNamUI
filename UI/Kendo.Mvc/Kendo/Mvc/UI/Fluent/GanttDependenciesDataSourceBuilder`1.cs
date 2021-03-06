// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.GanttDependenciesDataSourceBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class GanttDependenciesDataSourceBuilder<TModel> : 
    FilterableAjaxDataSourceBuilder<TModel, GanttDependenciesDataSourceBuilder<TModel>>
    where TModel : class
  {
    public GanttDependenciesDataSourceBuilder(
      DataSource dataSource,
      ViewContext viewContext,
      IUrlGenerator urlGenerator)
      : base(dataSource, viewContext, urlGenerator)
    {
    }

    public GanttDependenciesDataSourceBuilder<TModel> Model(
      Action<GanttDependencyModelDescriptorFactory<TModel>> configurator)
    {
      configurator(new GanttDependencyModelDescriptorFactory<TModel>((GanttDependencyModelDescriptor) this.dataSource.Schema.Model));
      return this;
    }
  }
}
