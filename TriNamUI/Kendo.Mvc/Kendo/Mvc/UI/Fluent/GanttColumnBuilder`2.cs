// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.GanttColumnBuilder`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System;
using System.Collections.Generic;
using System.Net;

namespace Kendo.Mvc.UI.Fluent
{
  public class GanttColumnBuilder<TTaskModel, TDependenciesModel>
    where TTaskModel : class, IGanttTask
    where TDependenciesModel : class, IGanttDependency
  {
    public GanttColumnBuilder(
      GanttColumn<TTaskModel, TDependenciesModel> container)
    {
      this.Container = container;
    }

    protected GanttColumn<TTaskModel, TDependenciesModel> Container { get; private set; }

    public GanttColumnBuilder<TTaskModel, TDependenciesModel> Format(string value)
    {
      this.Container.Format = WebUtility.UrlDecode(value);
      return this;
    }

    public GanttColumnBuilder<TTaskModel, TDependenciesModel> HeaderTemplate(
      string value)
    {
      this.Container.HeaderTemplate = value;
      return this;
    }

    public GanttColumnBuilder<TTaskModel, TDependenciesModel> HeaderTemplateId(
      string templateId)
    {
      this.Container.HeaderTemplateId = templateId;
      return this;
    }

    public GanttColumnBuilder<TTaskModel, TDependenciesModel> Width(double value)
    {
      this.Container.Width = string.Format("{0}px", (object) value);
      return this;
    }

    public GanttColumnBuilder<TTaskModel, TDependenciesModel> Sortable(
      Action<GanttColumnSortableSettingsBuilder> configurator)
    {
      this.Container.Sortable.Enabled = new bool?(true);
      configurator(new GanttColumnSortableSettingsBuilder(this.Container.Sortable));
      return this;
    }

    public GanttColumnBuilder<TTaskModel, TDependenciesModel> Sortable()
    {
      this.Container.Sortable.Enabled = new bool?(true);
      return this;
    }

    public GanttColumnBuilder<TTaskModel, TDependenciesModel> Sortable(bool value)
    {
      this.Container.Sortable.Enabled = new bool?(value);
      return this;
    }

    public GanttColumnBuilder<TTaskModel, TDependenciesModel> Template(
      string value)
    {
      this.Container.Template = value;
      return this;
    }

    public GanttColumnBuilder<TTaskModel, TDependenciesModel> TemplateId(
      string templateId)
    {
      this.Container.TemplateId = templateId;
      return this;
    }

    public GanttColumnBuilder<TTaskModel, TDependenciesModel> HtmlAttributes(
      IDictionary<string, object> value)
    {
      this.Container.HtmlAttributes = value;
      return this;
    }

    public GanttColumnBuilder<TTaskModel, TDependenciesModel> HtmlAttributes(
      object value)
    {
      this.Container.HtmlAttributes = value.ToDictionary();
      return this;
    }

    public GanttColumnBuilder<TTaskModel, TDependenciesModel> Editable(bool value)
    {
      this.Container.Editable = new bool?(value);
      return this;
    }

    public GanttColumnBuilder<TTaskModel, TDependenciesModel> Editable()
    {
      this.Container.Editable = new bool?(true);
      return this;
    }

    public GanttColumnBuilder<TTaskModel, TDependenciesModel> Expandable(
      bool value)
    {
      this.Container.Expandable = new bool?(value);
      return this;
    }

    public GanttColumnBuilder<TTaskModel, TDependenciesModel> Expandable()
    {
      this.Container.Expandable = new bool?(true);
      return this;
    }

    public GanttColumnBuilder<TTaskModel, TDependenciesModel> Field(string value)
    {
      this.Container.Field = value;
      return this;
    }

    public GanttColumnBuilder<TTaskModel, TDependenciesModel> Filterable(
      Action<GanttColumnFilterableSettingsBuilder<TTaskModel, TDependenciesModel>> configurator)
    {
      this.Container.Filterable.Enabled = new bool?(true);
      this.Container.Filterable.Gantt = this.Container.Gantt;
      configurator(new GanttColumnFilterableSettingsBuilder<TTaskModel, TDependenciesModel>(this.Container.Filterable));
      return this;
    }

    public GanttColumnBuilder<TTaskModel, TDependenciesModel> Filterable(
      bool enabled)
    {
      this.Container.Filterable.Enabled = new bool?(enabled);
      return this;
    }

    public GanttColumnBuilder<TTaskModel, TDependenciesModel> HeaderAttributes(
      IDictionary<string, object> value)
    {
      this.Container.HeaderAttributes = value;
      return this;
    }

    public GanttColumnBuilder<TTaskModel, TDependenciesModel> HeaderAttributes(
      object value)
    {
      this.Container.HeaderAttributes = value.ToDictionary();
      return this;
    }

    public GanttColumnBuilder<TTaskModel, TDependenciesModel> Hidden(bool value)
    {
      this.Container.Hidden = new bool?(value);
      return this;
    }

    public GanttColumnBuilder<TTaskModel, TDependenciesModel> Hidden()
    {
      this.Container.Hidden = new bool?(true);
      return this;
    }

    public GanttColumnBuilder<TTaskModel, TDependenciesModel> Menu(bool value)
    {
      this.Container.Menu = new bool?(value);
      return this;
    }

    public GanttColumnBuilder<TTaskModel, TDependenciesModel> MinScreenWidth(
      double value)
    {
      this.Container.MinScreenWidth = new double?(value);
      return this;
    }

    public GanttColumnBuilder<TTaskModel, TDependenciesModel> Title(string value)
    {
      this.Container.Title = value;
      return this;
    }

    public GanttColumnBuilder<TTaskModel, TDependenciesModel> Width(string value)
    {
      this.Container.Width = value;
      return this;
    }
  }
}
