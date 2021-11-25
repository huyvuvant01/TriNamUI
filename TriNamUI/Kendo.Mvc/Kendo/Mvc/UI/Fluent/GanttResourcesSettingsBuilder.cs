// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.GanttResourcesSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections;

namespace Kendo.Mvc.UI.Fluent
{
  public class GanttResourcesSettingsBuilder
  {
    private readonly ViewContext viewContext;
    private readonly IUrlGenerator urlGenerator;

    public GanttResourcesSettingsBuilder(
      GanttResourcesSettings container,
      ViewContext viewContext,
      IUrlGenerator urlGenerator)
    {
      this.Container = container;
      this.viewContext = viewContext;
      this.urlGenerator = urlGenerator;
    }

    protected GanttResourcesSettings Container { get; private set; }

    public GanttResourcesSettingsBuilder DataFormatField(string value)
    {
      this.Container.DataFormatField = value;
      return this;
    }

    public GanttResourcesSettingsBuilder DataColorField(string value)
    {
      this.Container.DataColorField = value;
      return this;
    }

    public GanttResourcesSettingsBuilder DataTextField(string value)
    {
      this.Container.DataTextField = value;
      return this;
    }

    public GanttResourcesSettingsBuilder Field(string value)
    {
      this.Container.Field = value;
      return this;
    }

    public GanttResourcesSettingsBuilder DataSource(
      Action<ReadOnlyAjaxDataSourceBuilder<object>> configurator)
    {
      configurator(new ReadOnlyAjaxDataSourceBuilder<object>(this.Container.DataSource, this.viewContext, this.urlGenerator));
      return this;
    }

    public GanttResourcesSettingsBuilder BindTo(IEnumerable dataSource)
    {
      this.Container.DataSource.Data = dataSource;
      return this;
    }
  }
}
