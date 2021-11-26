// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.PDFViewerToolbarSettingsItemBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class PDFViewerToolbarSettingsItemBuilder
  {
    public PDFViewerToolbarSettingsItemBuilder(PDFViewerToolbarSettingsItem container) => this.Container = container;

    protected PDFViewerToolbarSettingsItem Container { get; private set; }

    public PDFViewerToolbarSettingsItemBuilder Type(string value)
    {
      this.Container.Type = value;
      return this;
    }

    public PDFViewerToolbarSettingsItemBuilder Overflow(
      string value)
    {
      this.Container.Overflow = value;
      return this;
    }

    public PDFViewerToolbarSettingsItemBuilder Command(
      string value)
    {
      this.Container.Command = value;
      return this;
    }

    public PDFViewerToolbarSettingsItemBuilder Name(string value)
    {
      this.Container.Name = value;
      return this;
    }

    public PDFViewerToolbarSettingsItemBuilder Click(
      string handler)
    {
      this.Container.Click = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public PDFViewerToolbarSettingsItemBuilder Click(
      Func<object, object> handler)
    {
      this.Container.Click = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public PDFViewerToolbarSettingsItemBuilder Toggle(
      string handler)
    {
      this.Container.Toggle = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public PDFViewerToolbarSettingsItemBuilder Toggle(
      Func<object, object> handler)
    {
      this.Container.Toggle = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public PDFViewerToolbarSettingsItemBuilder Togglable(
      bool value)
    {
      this.Container.Togglable = new bool?(value);
      return this;
    }

    public PDFViewerToolbarSettingsItemBuilder Togglable()
    {
      this.Container.Togglable = new bool?(true);
      return this;
    }

    public PDFViewerToolbarSettingsItemBuilder Text(string value)
    {
      this.Container.Text = value;
      return this;
    }

    public PDFViewerToolbarSettingsItemBuilder Template(
      string value)
    {
      this.Container.Template = value;
      return this;
    }

    public PDFViewerToolbarSettingsItemBuilder TemplateId(
      string templateId)
    {
      this.Container.TemplateId = templateId;
      return this;
    }

    public PDFViewerToolbarSettingsItemBuilder ShowText(
      string value)
    {
      this.Container.ShowText = value;
      return this;
    }

    public PDFViewerToolbarSettingsItemBuilder Primary(bool value)
    {
      this.Container.Primary = new bool?(value);
      return this;
    }

    public PDFViewerToolbarSettingsItemBuilder Primary()
    {
      this.Container.Primary = new bool?(true);
      return this;
    }

    public PDFViewerToolbarSettingsItemBuilder HtmlAttributes(
      IDictionary<string, object> value)
    {
      this.Container.HtmlAttributes = value;
      return this;
    }

    public PDFViewerToolbarSettingsItemBuilder HtmlAttributes(
      object value)
    {
      this.Container.HtmlAttributes = value.ToDictionary();
      return this;
    }

    public PDFViewerToolbarSettingsItemBuilder Enable(bool value)
    {
      this.Container.Enable = new bool?(value);
      return this;
    }

    public PDFViewerToolbarSettingsItemBuilder Hidden(bool value)
    {
      this.Container.Hidden = new bool?(value);
      return this;
    }

    public PDFViewerToolbarSettingsItemBuilder Hidden()
    {
      this.Container.Hidden = new bool?(true);
      return this;
    }

    public PDFViewerToolbarSettingsItemBuilder SpriteCssClass(
      string value)
    {
      this.Container.SpriteCssClass = value;
      return this;
    }

    public PDFViewerToolbarSettingsItemBuilder ImageUrl(
      string value)
    {
      this.Container.ImageUrl = value;
      return this;
    }

    public PDFViewerToolbarSettingsItemBuilder ShowIcon(
      string value)
    {
      this.Container.ShowIcon = value;
      return this;
    }

    public PDFViewerToolbarSettingsItemBuilder Icon(string value)
    {
      this.Container.Icon = value;
      return this;
    }

    public PDFViewerToolbarSettingsItemBuilder Id(string value)
    {
      this.Container.Id = value;
      return this;
    }
  }
}
