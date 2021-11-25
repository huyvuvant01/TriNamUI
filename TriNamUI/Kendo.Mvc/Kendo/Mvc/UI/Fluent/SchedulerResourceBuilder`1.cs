// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.SchedulerResourceBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections;

namespace Kendo.Mvc.UI.Fluent
{
  public class SchedulerResourceBuilder<T> where T : class, ISchedulerEvent
  {
    private readonly SchedulerResource<T> resource;
    private readonly ViewContext viewContext;
    private readonly IUrlGenerator urlGenerator;

    public SchedulerResourceBuilder(
      SchedulerResource<T> resource,
      ViewContext viewContext,
      IUrlGenerator urlGenerator)
    {
      this.resource = resource;
      this.viewContext = viewContext;
      this.urlGenerator = urlGenerator;
    }

    public SchedulerResourceBuilder<T> Title(string title)
    {
      this.resource.Title = title;
      return this;
    }

    public SchedulerResourceBuilder<T> Multiple(bool isMultiple)
    {
      this.resource.Multiple = isMultiple;
      return this;
    }

    public SchedulerResourceBuilder<T> Name(string value)
    {
      this.resource.Name = value;
      return this;
    }

    public SchedulerResourceBuilder<T> BindTo(IEnumerable dataSource)
    {
      this.resource.DataSource.Data = dataSource;
      return this;
    }

    public SchedulerResourceBuilder<T> DataValueField(string field)
    {
      this.resource.DataValueField = field;
      return this;
    }

    public SchedulerResourceBuilder<T> DataTextField(string field)
    {
      this.resource.DataTextField = field;
      return this;
    }

    public SchedulerResourceBuilder<T> DataColorField(string field)
    {
      this.resource.DataColorField = field;
      return this;
    }

    public SchedulerResourceBuilder<T> DataParentValueField(string field)
    {
      this.resource.DataParentValueField = field;
      return this;
    }

    public SchedulerResourceBuilder<T> ValuePrimitive(bool valuePrimitive)
    {
      this.resource.ValuePrimitive = valuePrimitive;
      return this;
    }

    public SchedulerResourceBuilder<T> DataSource(
      Action<ReadOnlyDataSourceBuilder> configurator)
    {
      configurator(new ReadOnlyDataSourceBuilder(this.resource.DataSource, this.viewContext, this.urlGenerator));
      return this;
    }
  }
}
