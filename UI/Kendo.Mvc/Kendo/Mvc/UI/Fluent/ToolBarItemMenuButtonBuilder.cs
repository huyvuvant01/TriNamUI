// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ToolBarItemMenuButtonBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class ToolBarItemMenuButtonBuilder
  {
    public ToolBarItemMenuButtonBuilder(ToolBarItemMenuButton container) => this.Container = container;

    protected ToolBarItemMenuButton Container { get; private set; }

    public ToolBarItemMenuButtonBuilder HtmlAttributes(
      IDictionary<string, object> value)
    {
      this.Container.HtmlAttributes = value;
      return this;
    }

    public ToolBarItemMenuButtonBuilder HtmlAttributes(object value)
    {
      this.Container.HtmlAttributes = value.ToDictionary();
      return this;
    }

    public ToolBarItemMenuButtonBuilder Enable(bool value)
    {
      this.Container.Enable = new bool?(value);
      return this;
    }

    public ToolBarItemMenuButtonBuilder Hidden(bool value)
    {
      this.Container.Hidden = new bool?(value);
      return this;
    }

    public ToolBarItemMenuButtonBuilder Hidden()
    {
      this.Container.Hidden = new bool?(true);
      return this;
    }

    public ToolBarItemMenuButtonBuilder Icon(string value)
    {
      this.Container.Icon = value;
      return this;
    }

    public ToolBarItemMenuButtonBuilder Id(string value)
    {
      this.Container.Id = value;
      return this;
    }

    public ToolBarItemMenuButtonBuilder ImageUrl(string value)
    {
      this.Container.ImageUrl = value;
      return this;
    }

    public ToolBarItemMenuButtonBuilder SpriteCssClass(string value)
    {
      this.Container.SpriteCssClass = value;
      return this;
    }

    public ToolBarItemMenuButtonBuilder Text(string value)
    {
      this.Container.Text = value;
      return this;
    }

    public ToolBarItemMenuButtonBuilder Url(string value)
    {
      this.Container.Url = value;
      return this;
    }
  }
}
