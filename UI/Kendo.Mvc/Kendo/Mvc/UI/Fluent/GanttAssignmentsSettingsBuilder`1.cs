// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.GanttAssignmentsSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections;

namespace Kendo.Mvc.UI.Fluent
{
  public class GanttAssignmentsSettingsBuilder<TAssingmentModel> where TAssingmentModel : class
  {
    private readonly ViewContext viewContext;
    private readonly IUrlGenerator urlGenerator;

    public GanttAssignmentsSettingsBuilder(
      GanttAssignmentsSettings container,
      ViewContext viewContext,
      IUrlGenerator urlGenerator)
    {
      this.Container = container;
      this.viewContext = viewContext;
      this.urlGenerator = urlGenerator;
    }

    protected GanttAssignmentsSettings Container { get; private set; }

    public GanttAssignmentsSettingsBuilder<TAssingmentModel> DataResourceIdField(
      string value)
    {
      this.Container.DataResourceIdField = value;
      return this;
    }

    public GanttAssignmentsSettingsBuilder<TAssingmentModel> DataTaskIdField(
      string value)
    {
      this.Container.DataTaskIdField = value;
      return this;
    }

    public GanttAssignmentsSettingsBuilder<TAssingmentModel> DataValueField(
      string value)
    {
      this.Container.DataValueField = value;
      return this;
    }

    public GanttAssignmentsSettingsBuilder<TAssingmentModel> DataSource(
      Action<GanttAssignmentsDataSourceBuilder<TAssingmentModel>> configurator)
    {
      this.Container.DataSource.Schema.Model = new ModelDescriptor(typeof (TAssingmentModel), this.Container.ModelMetaDataProvider);
      configurator(new GanttAssignmentsDataSourceBuilder<TAssingmentModel>(this.Container.DataSource, this.viewContext, this.urlGenerator));
      return this;
    }

    public GanttAssignmentsSettingsBuilder<TAssingmentModel> BindTo(
      IEnumerable dataSource)
    {
      this.Container.DataSource.Data = dataSource;
      return this;
    }
  }
}
