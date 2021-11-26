// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Diagram.Fluent.DiagramDataSourceBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.UI.Fluent;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Kendo.Mvc.UI.Diagram.Fluent
{
  public class DiagramDataSourceBuilder<TModel> : HierarchicalDataSourceBuilder<TModel>
    where TModel : class
  {
    protected DataSource dataSource;
    protected readonly IUrlGenerator urlGenerator;
    protected readonly ViewContext viewContext;

    public DiagramDataSourceBuilder(
      DataSource dataSource,
      ViewContext viewContext,
      IUrlGenerator urlGenerator)
      : base(dataSource, viewContext, urlGenerator)
    {
      this.viewContext = viewContext;
      this.urlGenerator = urlGenerator;
      this.dataSource = dataSource;
    }

    public DiagramShapeDataSourceBuilder<TModel> ShapeDataSource()
    {
      this.dataSource.Schema.Data = "Data";
      this.dataSource.Schema.Total = "Total";
      this.dataSource.Schema.Errors = "Errors";
      this.dataSource.Schema.Model = (ModelDescriptor) new DiagramShapeModelDescriptor(typeof (TModel));
      return new DiagramShapeDataSourceBuilder<TModel>(this.dataSource, this.viewContext, this.urlGenerator);
    }
  }
}
