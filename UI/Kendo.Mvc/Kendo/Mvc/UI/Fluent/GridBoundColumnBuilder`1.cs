// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.GridBoundColumnBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Net;

namespace Kendo.Mvc.UI.Fluent
{
  public class GridBoundColumnBuilder<T> : 
    GridColumnBuilder<IGridBoundColumn, GridBoundColumnBuilder<T>>
    where T : class
  {
    private ViewContext viewContext;
    private IUrlGenerator urlGenerator;

    public GridBoundColumnBuilder(
      IGridBoundColumn column,
      ViewContext viewContext,
      IUrlGenerator urlGenerator)
      : base(column)
    {
      this.viewContext = viewContext;
      this.urlGenerator = urlGenerator;
    }

    public GridBoundColumnBuilder<T> Format(string value)
    {
      this.Column.Format = WebUtility.UrlDecode(value);
      return this;
    }

    public GridBoundColumnBuilder<T> EditorViewData(object additionalViewData)
    {
      this.Column.AdditionalViewData = additionalViewData;
      return this;
    }

    public GridBoundColumnBuilder<T> EditorTemplateName(string templateName)
    {
      this.Column.EditorTemplateName = templateName;
      return this;
    }

    public GridBoundColumnBuilder<T> Sortable(bool value)
    {
      this.Column.Sortable = value;
      return this;
    }

    public GridBoundColumnBuilder<T> Sortable(
      Action<GridBoundColumnSortableBuilder> configurator)
    {
      configurator(new GridBoundColumnSortableBuilder(this.Column.SortableSettings));
      return this;
    }

    public GridBoundColumnBuilder<T> Groupable(bool value)
    {
      this.Column.Groupable = value;
      return this;
    }

    public GridBoundColumnBuilder<T> Groupable(
      Action<GridBoundColumnGroupableBuilder> configurator)
    {
      configurator(new GridBoundColumnGroupableBuilder(this.Column.GroupableSettings));
      return this;
    }

    public GridBoundColumnBuilder<T> Filterable(bool value)
    {
      this.Column.Filterable = value;
      return this;
    }

    public GridBoundColumnBuilder<T> Filterable(
      Action<GridBoundColumnFilterableBuilder> configurator)
    {
      configurator(new GridBoundColumnFilterableBuilder(this.Column.FilterableSettings, this.viewContext, this.urlGenerator));
      return this;
    }

    public GridBoundColumnBuilder<T> Encoded(bool value)
    {
      this.Column.Encoded = value;
      return this;
    }

    public GridBoundColumnBuilder<T> ClientTemplate(string value)
    {
      this.Column.ClientTemplate = value;
      return this;
    }

    public GridBoundColumnBuilder<T> ClientTemplateId(string value)
    {
      this.Column.ClientTemplateId = value;
      return this;
    }

    public GridBoundColumnBuilder<T> ClientGroupHeaderTemplate(string value)
    {
      this.Column.ClientGroupHeaderTemplate = value;
      return this;
    }

    public GridBoundColumnBuilder<T> ClientGroupHeaderColumnTemplate(
      string value)
    {
      this.Column.ClientGroupHeaderColumnTemplate = value;
      return this;
    }

    public GridBoundColumnBuilder<T> Editable(Func<object, object> editable)
    {
      this.Column.Editable.TemplateDelegate = editable;
      return this;
    }

    public GridBoundColumnBuilder<T> Editable(string editable)
    {
      this.Column.Editable.HandlerName = editable;
      return this;
    }
  }
}
