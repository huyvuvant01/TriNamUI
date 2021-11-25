// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Diagram.Fluent.DiagramShapeDataSourceBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.UI.Fluent;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace Kendo.Mvc.UI.Diagram.Fluent
{
  public class DiagramShapeDataSourceBuilder<TModel> : AjaxDataSourceBuilder<TModel>
    where TModel : class
  {
    public DiagramShapeDataSourceBuilder(
      DataSource dataSource,
      ViewContext viewContext,
      IUrlGenerator urlGenerator)
      : base(dataSource, viewContext, urlGenerator)
    {
    }

    public DiagramShapeDataSourceBuilder<TModel> Model(
      Action<DiagramShapeModelDescriptorFactory<TModel>> configurator)
    {
      configurator(new DiagramShapeModelDescriptorFactory<TModel>((DiagramShapeModelDescriptor) this.dataSource.Schema.Model));
      return this;
    }
  }
}
