// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ListBoxBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI.Fluent
{
  public class ListBoxBuilder : WidgetBuilderBase<ListBox, ListBoxBuilder>
  {
    public ListBoxBuilder(ListBox component)
      : base(component)
    {
    }

    public ListBoxBuilder BindTo(IEnumerable data)
    {
      this.Component.DataSource.Data = data;
      return this;
    }

    public ListBoxBuilder BindTo(IEnumerable<SelectListItem> dataSource)
    {
      if (string.IsNullOrEmpty(this.Component.DataValueField) && string.IsNullOrEmpty(this.Component.DataTextField))
      {
        this.DataValueField("Value");
        this.DataTextField("Text");
      }
      this.Component.DataSource.Data = (IEnumerable) dataSource.Select(item => new
      {
        Text = item.Text,
        Value = item.Value ?? item.Text,
        Selected = item.Selected
      });
      return this;
    }

    public ListBoxBuilder DataSource(Action<ReadOnlyDataSourceBuilder> configurator)
    {
      configurator(new ReadOnlyDataSourceBuilder(this.Component.DataSource, this.Component.ViewContext, this.Component.UrlGenerator));
      return this;
    }

    public ListBoxBuilder DataSource(string dataSourceId)
    {
      this.Component.DataSourceId = dataSourceId;
      return this;
    }

    public ListBoxBuilder AutoBind(bool value)
    {
      this.Container.AutoBind = new bool?(value);
      return this;
    }

    public ListBoxBuilder ConnectWith(string value)
    {
      this.Container.ConnectWith = value;
      return this;
    }

    public ListBoxBuilder DataTextField(string value)
    {
      this.Container.DataTextField = value;
      return this;
    }

    public ListBoxBuilder DataValueField(string value)
    {
      this.Container.DataValueField = value;
      return this;
    }

    public ListBoxBuilder Draggable(
      Action<ListBoxDraggableSettingsBuilder> configurator)
    {
      this.Container.Draggable.Enabled = new bool?(true);
      this.Container.Draggable.ListBox = this.Container;
      configurator(new ListBoxDraggableSettingsBuilder(this.Container.Draggable));
      return this;
    }

    public ListBoxBuilder Draggable()
    {
      this.Container.Draggable.Enabled = new bool?(true);
      return this;
    }

    public ListBoxBuilder Draggable(bool enabled)
    {
      this.Container.Draggable.Enabled = new bool?(enabled);
      return this;
    }

    public ListBoxBuilder DropSources(params string[] value)
    {
      this.Container.DropSources = value;
      return this;
    }

    public ListBoxBuilder Navigatable(bool value)
    {
      this.Container.Navigatable = new bool?(value);
      return this;
    }

    public ListBoxBuilder Messages(
      Action<ListBoxMessagesSettingsBuilder> configurator)
    {
      this.Container.Messages.ListBox = this.Container;
      configurator(new ListBoxMessagesSettingsBuilder(this.Container.Messages));
      return this;
    }

    public ListBoxBuilder Template(string value)
    {
      this.Container.Template = value;
      return this;
    }

    public ListBoxBuilder TemplateId(string templateId)
    {
      this.Container.TemplateId = templateId;
      return this;
    }

    public ListBoxBuilder Toolbar(Action<ListBoxToolbarSettingsBuilder> configurator)
    {
      this.Container.Toolbar.ListBox = this.Container;
      configurator(new ListBoxToolbarSettingsBuilder(this.Container.Toolbar));
      return this;
    }

    public ListBoxBuilder Selectable(ListBoxSelectable value)
    {
      this.Container.Selectable = new ListBoxSelectable?(value);
      return this;
    }

    public ListBoxBuilder Events(Action<ListBoxEventBuilder> configurator)
    {
      configurator(new ListBoxEventBuilder(this.Container.Events));
      return this;
    }
  }
}
