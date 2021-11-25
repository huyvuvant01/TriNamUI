// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.MenuItemBase
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;

namespace Kendo.Mvc.TagHelpers
{
  public class MenuItemBase : INavigationItem
  {
    public string Text { get; set; }

    public object LinkHtmlAttributes { get; set; }

    public object ImageHtmlAttributes { get; set; }

    public string Url { get; set; }

    public string ImageUrl { get; set; }

    public string IconClass { get; set; }

    public string Icon { get; set; }

    public bool? Enabled { get; set; }

    public bool? Selected { get; set; }

    public bool? Encoded { get; set; }

    public bool? Visible { get; set; }

    public bool? Separator { get; set; }

    public string Action { get; set; }

    public string Controller { get; set; }

    public string Area { get; set; }

    public string Protocol { get; set; }

    public string Host { get; set; }

    public string Fragment { get; set; }

    public string Route { get; set; }

    public IDictionary<string, string> RouteValues { get; set; }

    public IEnumerable<MenuItemBase> Children { get; set; }

    public string Content { get; set; }

    public object ContentHtmlAttributes { get; set; }
  }
}
