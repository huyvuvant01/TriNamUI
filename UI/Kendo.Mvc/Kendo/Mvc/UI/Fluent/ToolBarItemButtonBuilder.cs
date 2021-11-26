// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ToolBarItemButtonBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class ToolBarItemButtonBuilder
  {
    public ToolBarItemButtonBuilder(ToolBarItemButton container) => this.Container = container;

    protected ToolBarItemButton Container { get; private set; }

    public ToolBarItemButtonBuilder HtmlAttributes(
      IDictionary<string, object> value)
    {
      this.Container.HtmlAttributes = value;
      return this;
    }

    public ToolBarItemButtonBuilder HtmlAttributes(object value)
    {
      this.Container.HtmlAttributes = value.ToDictionary();
      return this;
    }

    public ToolBarItemButtonBuilder Click(string handler)
    {
      this.Container.Click = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public ToolBarItemButtonBuilder Click(Func<object, object> handler)
    {
      this.Container.Click = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public ToolBarItemButtonBuilder Enable(bool value)
    {
      this.Container.Enable = new bool?(value);
      return this;
    }

    public ToolBarItemButtonBuilder Group(string value)
    {
      this.Container.Group = value;
      return this;
    }

    public ToolBarItemButtonBuilder Hidden(bool value)
    {
      this.Container.Hidden = new bool?(value);
      return this;
    }

    public ToolBarItemButtonBuilder Hidden()
    {
      this.Container.Hidden = new bool?(true);
      return this;
    }

    public ToolBarItemButtonBuilder Icon(string value)
    {
      this.Container.Icon = value;
      return this;
    }

    public ToolBarItemButtonBuilder Id(string value)
    {
      this.Container.Id = value;
      return this;
    }

    public ToolBarItemButtonBuilder ImageUrl(string value)
    {
      this.Container.ImageUrl = value;
      return this;
    }

    public ToolBarItemButtonBuilder Selected(bool value)
    {
      this.Container.Selected = new bool?(value);
      return this;
    }

    public ToolBarItemButtonBuilder Selected()
    {
      this.Container.Selected = new bool?(true);
      return this;
    }

    public ToolBarItemButtonBuilder SpriteCssClass(string value)
    {
      this.Container.SpriteCssClass = value;
      return this;
    }

    public ToolBarItemButtonBuilder Toggle(string handler)
    {
      this.Container.Toggle = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public ToolBarItemButtonBuilder Toggle(Func<object, object> handler)
    {
      this.Container.Toggle = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public ToolBarItemButtonBuilder Togglable(bool value)
    {
      this.Container.Togglable = new bool?(value);
      return this;
    }

    public ToolBarItemButtonBuilder Text(string value)
    {
      this.Container.Text = value;
      return this;
    }

    public ToolBarItemButtonBuilder Url(string value)
    {
      this.Container.Url = value;
      return this;
    }

    public ToolBarItemButtonBuilder ShowText(ShowIn value)
    {
      this.Container.ShowText = new ShowIn?(value);
      return this;
    }

    public ToolBarItemButtonBuilder ShowIcon(ShowIn value)
    {
      this.Container.ShowIcon = new ShowIn?(value);
      return this;
    }
  }
}
