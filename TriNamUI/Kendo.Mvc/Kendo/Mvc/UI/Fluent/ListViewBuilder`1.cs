// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ListViewBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class ListViewBuilder<T> : WidgetBuilderBase<ListView<T>, ListViewBuilder<T>>
    where T : class
  {
    public ListViewBuilder(ListView<T> component)
      : base(component)
    {
    }

    public ListViewBuilder<T> DataSource(Action<DataSourceBuilder<T>> configurator)
    {
      configurator(new DataSourceBuilder<T>(this.Component.DataSource, this.Component.ViewContext, this.Component.UrlGenerator));
      return this;
    }

    public ListViewBuilder<T> BindTo(IEnumerable<T> dataSource)
    {
      this.Component.DataSource.Data = (IEnumerable) dataSource;
      return this;
    }

    public ListViewBuilder<T> DataSource(string dataSourceId)
    {
      this.Component.DataSourceId = dataSourceId;
      return this;
    }

    public ListViewBuilder<T> BindTo(IEnumerable dataSource)
    {
      this.Component.DataSource.Data = dataSource;
      return this;
    }

    public ListViewBuilder<T> ClientTemplateId(string templateId)
    {
      this.Component.ClientTemplateId = templateId;
      return this;
    }

    public ListViewBuilder<T> ClientAltTemplateId(string templateId)
    {
      this.Component.ClientAltTemplateId = templateId;
      return this;
    }

    public ListViewBuilder<T> Pageable() => this.Pageable((Action<PageableBuilder>) (_param1 => { }));

    public ListViewBuilder<T> Pageable(Action<PageableBuilder> pagerAction)
    {
      this.Component.Pageable.Enabled = true;
      pagerAction(new PageableBuilder(this.Component.Pageable));
      return this;
    }

    public ListViewBuilder<T> Scrollable()
    {
      this.Component.Scrollable.Enabled = true;
      return this;
    }

    public ListViewBuilder<T> Scrollable(ListViewScrollableMode mode)
    {
      this.Component.Scrollable.Mode = new ListViewScrollableMode?(mode);
      return this;
    }

    public ListViewBuilder<T> Selectable(ListViewSelectionMode mode)
    {
      this.Container.Selectable.Enabled = new bool?(true);
      this.Container.Selectable.Mode = new ListViewSelectionMode?(mode);
      return this;
    }

    public ListViewBuilder<T> Selectable()
    {
      this.Component.Selectable.Enabled = new bool?(true);
      if (!this.Component.Selectable.Mode.HasValue)
        this.Component.Selectable.Mode = new ListViewSelectionMode?(ListViewSelectionMode.Single);
      return this;
    }

    public ListViewBuilder<T> Editable(
      Action<ListViewEditingSettingsBuilder<T>> configurator)
    {
      configurator(new ListViewEditingSettingsBuilder<T>(this.Component.Editable));
      return this;
    }

    public ListViewBuilder<T> Editable() => this.Editable((Action<ListViewEditingSettingsBuilder<T>>) (settings => settings.Enabled(true)));

    public ListViewBuilder<T> AutoBind(bool value)
    {
      this.Container.AutoBind = new bool?(value);
      return this;
    }

    public ListViewBuilder<T> Bordered(bool value)
    {
      this.Container.Bordered = new bool?(value);
      return this;
    }

    public ListViewBuilder<T> Borders(string value)
    {
      this.Container.Borders = value;
      return this;
    }

    public ListViewBuilder<T> ContentElement(string value)
    {
      this.Container.ContentElement = value;
      return this;
    }

    public ListViewBuilder<T> Layout(string value)
    {
      this.Container.Layout = value;
      return this;
    }

    public ListViewBuilder<T> Flex(
      Action<ListViewFlexSettingsBuilder<T>> configurator)
    {
      this.Container.Flex.ListView = this.Container;
      configurator(new ListViewFlexSettingsBuilder<T>(this.Container.Flex));
      return this;
    }

    public ListViewBuilder<T> Grid(
      Action<ListViewGridSettingsBuilder<T>> configurator)
    {
      this.Container.Grid.ListView = this.Container;
      configurator(new ListViewGridSettingsBuilder<T>(this.Container.Grid));
      return this;
    }

    public ListViewBuilder<T> Navigatable(bool value)
    {
      this.Container.Navigatable = new bool?(value);
      return this;
    }

    public ListViewBuilder<T> Navigatable()
    {
      this.Container.Navigatable = new bool?(true);
      return this;
    }

    public ListViewBuilder<T> TagName(string value)
    {
      this.Container.TagName = value;
      return this;
    }

    public ListViewBuilder<T> Selectable(
      Action<ListViewSelectableSettingsBuilder<T>> configurator)
    {
      this.Container.Selectable.Enabled = new bool?(true);
      this.Container.Selectable.ListView = this.Container;
      configurator(new ListViewSelectableSettingsBuilder<T>(this.Container.Selectable));
      return this;
    }

    public ListViewBuilder<T> Selectable(bool enabled)
    {
      this.Container.Selectable.Enabled = new bool?(enabled);
      return this;
    }

    public ListViewBuilder<T> Events(Action<ListViewEventBuilder> configurator)
    {
      configurator(new ListViewEventBuilder(this.Container.Events));
      return this;
    }
  }
}
