// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.TaskBoardToolbarSettingsItemBuilder`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class TaskBoardToolbarSettingsItemBuilder<TCard, TColumn>
    where TCard : class
    where TColumn : class
  {
    public TaskBoardToolbarSettingsItemBuilder(
      TaskBoardToolbarSettingsItem<TCard, TColumn> container)
    {
      this.Container = container;
    }

    protected TaskBoardToolbarSettingsItem<TCard, TColumn> Container { get; private set; }

    public TaskBoardToolbarSettingsItemBuilder<TCard, TColumn> Type(
      string value)
    {
      this.Container.Type = value;
      return this;
    }

    public TaskBoardToolbarSettingsItemBuilder<TCard, TColumn> Overflow(
      string value)
    {
      this.Container.Overflow = value;
      return this;
    }

    public TaskBoardToolbarSettingsItemBuilder<TCard, TColumn> Click(
      string handler)
    {
      this.Container.Click = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public TaskBoardToolbarSettingsItemBuilder<TCard, TColumn> Click(
      Func<object, object> handler)
    {
      this.Container.Click = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public TaskBoardToolbarSettingsItemBuilder<TCard, TColumn> Command(
      string value)
    {
      this.Container.Command = value;
      return this;
    }

    public TaskBoardToolbarSettingsItemBuilder<TCard, TColumn> Options(
      string value)
    {
      this.Container.Options = value;
      return this;
    }

    public TaskBoardToolbarSettingsItemBuilder<TCard, TColumn> Name(
      string value)
    {
      this.Container.Name = value;
      return this;
    }

    public TaskBoardToolbarSettingsItemBuilder<TCard, TColumn> Togglable(
      bool value)
    {
      this.Container.Togglable = new bool?(value);
      return this;
    }

    public TaskBoardToolbarSettingsItemBuilder<TCard, TColumn> Togglable()
    {
      this.Container.Togglable = new bool?(true);
      return this;
    }

    public TaskBoardToolbarSettingsItemBuilder<TCard, TColumn> Text(
      string value)
    {
      this.Container.Text = value;
      return this;
    }

    public TaskBoardToolbarSettingsItemBuilder<TCard, TColumn> Template(
      string value)
    {
      this.Container.Template = value;
      return this;
    }

    public TaskBoardToolbarSettingsItemBuilder<TCard, TColumn> TemplateId(
      string templateId)
    {
      this.Container.TemplateId = templateId;
      return this;
    }

    public TaskBoardToolbarSettingsItemBuilder<TCard, TColumn> ShowText(
      string value)
    {
      this.Container.ShowText = value;
      return this;
    }

    public TaskBoardToolbarSettingsItemBuilder<TCard, TColumn> Primary(
      bool value)
    {
      this.Container.Primary = new bool?(value);
      return this;
    }

    public TaskBoardToolbarSettingsItemBuilder<TCard, TColumn> Primary()
    {
      this.Container.Primary = new bool?(true);
      return this;
    }

    public TaskBoardToolbarSettingsItemBuilder<TCard, TColumn> HtmlAttributes(
      IDictionary<string, object> value)
    {
      this.Container.HtmlAttributes = value;
      return this;
    }

    public TaskBoardToolbarSettingsItemBuilder<TCard, TColumn> HtmlAttributes(
      object value)
    {
      this.Container.HtmlAttributes = value.ToDictionary();
      return this;
    }

    public TaskBoardToolbarSettingsItemBuilder<TCard, TColumn> Enable(
      bool value)
    {
      this.Container.Enable = new bool?(value);
      return this;
    }

    public TaskBoardToolbarSettingsItemBuilder<TCard, TColumn> Hidden(
      bool value)
    {
      this.Container.Hidden = new bool?(value);
      return this;
    }

    public TaskBoardToolbarSettingsItemBuilder<TCard, TColumn> Hidden()
    {
      this.Container.Hidden = new bool?(true);
      return this;
    }

    public TaskBoardToolbarSettingsItemBuilder<TCard, TColumn> SpriteCssClass(
      string value)
    {
      this.Container.SpriteCssClass = value;
      return this;
    }

    public TaskBoardToolbarSettingsItemBuilder<TCard, TColumn> ImageUrl(
      string value)
    {
      this.Container.ImageUrl = value;
      return this;
    }

    public TaskBoardToolbarSettingsItemBuilder<TCard, TColumn> ShowIcon(
      string value)
    {
      this.Container.ShowIcon = value;
      return this;
    }

    public TaskBoardToolbarSettingsItemBuilder<TCard, TColumn> Icon(
      string value)
    {
      this.Container.Icon = value;
      return this;
    }

    public TaskBoardToolbarSettingsItemBuilder<TCard, TColumn> Id(
      string value)
    {
      this.Container.Id = value;
      return this;
    }
  }
}
