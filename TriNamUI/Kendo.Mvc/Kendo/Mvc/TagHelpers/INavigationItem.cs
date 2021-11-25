// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.INavigationItem
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;

namespace Kendo.Mvc.TagHelpers
{
  public interface INavigationItem
  {
    string Text { get; set; }

    object LinkHtmlAttributes { get; set; }

    object ImageHtmlAttributes { get; set; }

    string Url { get; set; }

    string ImageUrl { get; set; }

    string IconClass { get; set; }

    string Icon { get; set; }

    bool? Enabled { get; set; }

    bool? Selected { get; set; }

    bool? Encoded { get; set; }

    bool? Visible { get; set; }

    bool? Separator { get; set; }

    string Content { get; set; }

    object ContentHtmlAttributes { get; set; }

    string Action { get; set; }

    string Controller { get; set; }

    string Area { get; set; }

    string Protocol { get; set; }

    string Host { get; set; }

    string Fragment { get; set; }

    string Route { get; set; }

    IDictionary<string, string> RouteValues { get; set; }
  }
}
