// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.FileManagerToolbarSettingsItemBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class FileManagerToolbarSettingsItemBuilder
  {
    public FileManagerToolbarSettingsItemBuilder(FileManagerToolbarSettingsItem container) => this.Container = container;

    protected FileManagerToolbarSettingsItem Container { get; private set; }

    public FileManagerToolbarSettingsItemBuilder Type(
      string value)
    {
      this.Container.Type = value;
      return this;
    }

    public FileManagerToolbarSettingsItemBuilder Overflow(
      string value)
    {
      this.Container.Overflow = value;
      return this;
    }

    public FileManagerToolbarSettingsItemBuilder Click(
      string handler)
    {
      this.Container.Click = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public FileManagerToolbarSettingsItemBuilder Click(
      Func<object, object> handler)
    {
      this.Container.Click = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public FileManagerToolbarSettingsItemBuilder Command(
      string value)
    {
      this.Container.Command = value;
      return this;
    }

    public FileManagerToolbarSettingsItemBuilder Options(
      string value)
    {
      this.Container.Options = value;
      return this;
    }

    public FileManagerToolbarSettingsItemBuilder Name(
      string value)
    {
      this.Container.Name = value;
      return this;
    }

    public FileManagerToolbarSettingsItemBuilder Togglable(
      bool value)
    {
      this.Container.Togglable = new bool?(value);
      return this;
    }

    public FileManagerToolbarSettingsItemBuilder Togglable()
    {
      this.Container.Togglable = new bool?(true);
      return this;
    }

    public FileManagerToolbarSettingsItemBuilder Text(
      string value)
    {
      this.Container.Text = value;
      return this;
    }

    public FileManagerToolbarSettingsItemBuilder Template(
      string value)
    {
      this.Container.Template = value;
      return this;
    }

    public FileManagerToolbarSettingsItemBuilder TemplateId(
      string templateId)
    {
      this.Container.TemplateId = templateId;
      return this;
    }

    public FileManagerToolbarSettingsItemBuilder ShowText(
      string value)
    {
      this.Container.ShowText = value;
      return this;
    }

    public FileManagerToolbarSettingsItemBuilder Primary(
      bool value)
    {
      this.Container.Primary = new bool?(value);
      return this;
    }

    public FileManagerToolbarSettingsItemBuilder Primary()
    {
      this.Container.Primary = new bool?(true);
      return this;
    }

    public FileManagerToolbarSettingsItemBuilder HtmlAttributes(
      IDictionary<string, object> value)
    {
      this.Container.HtmlAttributes = value;
      return this;
    }

    public FileManagerToolbarSettingsItemBuilder HtmlAttributes(
      object value)
    {
      this.Container.HtmlAttributes = value.ToDictionary();
      return this;
    }

    public FileManagerToolbarSettingsItemBuilder Enable(
      bool value)
    {
      this.Container.Enable = new bool?(value);
      return this;
    }

    public FileManagerToolbarSettingsItemBuilder Hidden(
      bool value)
    {
      this.Container.Hidden = new bool?(value);
      return this;
    }

    public FileManagerToolbarSettingsItemBuilder Hidden()
    {
      this.Container.Hidden = new bool?(true);
      return this;
    }

    public FileManagerToolbarSettingsItemBuilder SpriteCssClass(
      string value)
    {
      this.Container.SpriteCssClass = value;
      return this;
    }

    public FileManagerToolbarSettingsItemBuilder ImageUrl(
      string value)
    {
      this.Container.ImageUrl = value;
      return this;
    }

    public FileManagerToolbarSettingsItemBuilder ShowIcon(
      string value)
    {
      this.Container.ShowIcon = value;
      return this;
    }

    public FileManagerToolbarSettingsItemBuilder Icon(
      string value)
    {
      this.Container.Icon = value;
      return this;
    }

    public FileManagerToolbarSettingsItemBuilder Id(
      string value)
    {
      this.Container.Id = value;
      return this;
    }
  }
}
