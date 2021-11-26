// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.GanttDataSourceBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class GanttDataSourceBuilder<TModel> : 
    FilterableAjaxDataSourceBuilder<TModel, GanttDataSourceBuilder<TModel>>
    where TModel : class
  {
    public GanttDataSourceBuilder(
      DataSource dataSource,
      ViewContext viewContext,
      IUrlGenerator urlGenerator)
      : base(dataSource, viewContext, urlGenerator)
    {
    }

    public GanttDataSourceBuilder<TModel> Model(
      Action<GanttTaskModelDescriptorFactory<TModel>> configurator)
    {
      configurator(new GanttTaskModelDescriptorFactory<TModel>((GanttTaskModelDescriptor) this.dataSource.Schema.Model));
      return this;
    }
  }
}
