// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ToolBarItemBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class ToolBarItemBuilder
  {
    public ToolBarItemBuilder(ToolBarItem container) => this.Container = container;

    protected ToolBarItem Container { get; private set; }

    public ToolBarItemBuilder HtmlAttributes(IDictionary<string, object> value)
    {
      this.Container.HtmlAttributes = value;
      return this;
    }

    public ToolBarItemBuilder HtmlAttributes(object value)
    {
      this.Container.HtmlAttributes = value.ToDictionary();
      return this;
    }

    public ToolBarItemBuilder Buttons(
      Action<ToolBarItemButtonFactory> configurator)
    {
      configurator(new ToolBarItemButtonFactory(this.Container.Buttons)
      {
        ToolBar = this.Container.ToolBar
      });
      return this;
    }

    public ToolBarItemBuilder Click(string handler)
    {
      this.Container.Click = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public ToolBarItemBuilder Click(Func<object, object> handler)
    {
      this.Container.Click = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public ToolBarItemBuilder Enable(bool value)
    {
      this.Container.Enable = new bool?(value);
      return this;
    }

    public ToolBarItemBuilder Group(string value)
    {
      this.Container.Group = value;
      return this;
    }

    public ToolBarItemBuilder Hidden(bool value)
    {
      this.Container.Hidden = new bool?(value);
      return this;
    }

    public ToolBarItemBuilder Hidden()
    {
      this.Container.Hidden = new bool?(true);
      return this;
    }

    public ToolBarItemBuilder Icon(string value)
    {
      this.Container.Icon = value;
      return this;
    }

    public ToolBarItemBuilder Id(string value)
    {
      this.Container.Id = value;
      return this;
    }

    public ToolBarItemBuilder ImageUrl(string value)
    {
      this.Container.ImageUrl = value;
      return this;
    }

    public ToolBarItemBuilder MenuButtons(
      Action<ToolBarItemMenuButtonFactory> configurator)
    {
      configurator(new ToolBarItemMenuButtonFactory(this.Container.MenuButtons)
      {
        ToolBar = this.Container.ToolBar
      });
      return this;
    }

    public ToolBarItemBuilder OverflowTemplate(string value)
    {
      this.Container.OverflowTemplate = value;
      return this;
    }

    public ToolBarItemBuilder OverflowTemplateId(string templateId)
    {
      this.Container.OverflowTemplateId = templateId;
      return this;
    }

    public ToolBarItemBuilder Primary(bool value)
    {
      this.Container.Primary = new bool?(value);
      return this;
    }

    public ToolBarItemBuilder Primary()
    {
      this.Container.Primary = new bool?(true);
      return this;
    }

    public ToolBarItemBuilder Selected(bool value)
    {
      this.Container.Selected = new bool?(value);
      return this;
    }

    public ToolBarItemBuilder Selected()
    {
      this.Container.Selected = new bool?(true);
      return this;
    }

    public ToolBarItemBuilder SpriteCssClass(string value)
    {
      this.Container.SpriteCssClass = value;
      return this;
    }

    public ToolBarItemBuilder Template(string value)
    {
      this.Container.Template = value;
      return this;
    }

    public ToolBarItemBuilder TemplateId(string templateId)
    {
      this.Container.TemplateId = templateId;
      return this;
    }

    public ToolBarItemBuilder Text(string value)
    {
      this.Container.Text = value;
      return this;
    }

    public ToolBarItemBuilder Togglable(bool value)
    {
      this.Container.Togglable = new bool?(value);
      return this;
    }

    public ToolBarItemBuilder Togglable()
    {
      this.Container.Togglable = new bool?(true);
      return this;
    }

    public ToolBarItemBuilder Toggle(string handler)
    {
      this.Container.Toggle = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public ToolBarItemBuilder Toggle(Func<object, object> handler)
    {
      this.Container.Toggle = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public ToolBarItemBuilder Url(string value)
    {
      this.Container.Url = value;
      return this;
    }

    public ToolBarItemBuilder Type(CommandType value)
    {
      this.Container.Type = new CommandType?(value);
      return this;
    }

    public ToolBarItemBuilder ShowText(ShowIn value)
    {
      this.Container.ShowText = new ShowIn?(value);
      return this;
    }

    public ToolBarItemBuilder ShowIcon(ShowIn value)
    {
      this.Container.ShowIcon = new ShowIn?(value);
      return this;
    }

    public ToolBarItemBuilder Overflow(ShowInOverflowPopup value)
    {
      this.Container.Overflow = new ShowInOverflowPopup?(value);
      return this;
    }
  }
}
