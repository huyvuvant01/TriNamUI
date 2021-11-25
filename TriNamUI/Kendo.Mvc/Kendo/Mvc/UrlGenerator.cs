// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UrlGenerator
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc
{
  public class UrlGenerator : IUrlGenerator
  {
    public string Generate(ActionContext context, string url) => this.GetUrlHelper(context).Content(url);

    private IUrlHelper GetUrlHelper(ActionContext context) => context.HttpContext.RequestServices.GetRequiredService<IUrlHelperFactory>().GetUrlHelper(context);

    public string Generate(
      ActionContext context,
      INavigatable navigationItem,
      RouteValueDictionary routeValues)
    {
      IUrlHelper urlHelper = this.GetUrlHelper(context);
      string str = (string) null;
      if (!string.IsNullOrEmpty(navigationItem.RouteName))
        str = urlHelper.RouteUrl(navigationItem.RouteName, (object) routeValues);
      else if (!string.IsNullOrEmpty(navigationItem.ControllerName) && !string.IsNullOrEmpty(navigationItem.ActionName))
        str = urlHelper.Action(navigationItem.ActionName, navigationItem.ControllerName, (object) routeValues, (string) null, (string) null);
      else if (!string.IsNullOrEmpty(navigationItem.Url))
        str = navigationItem.Url.StartsWith("~/", StringComparison.Ordinal) ? urlHelper.Content(navigationItem.Url) : navigationItem.Url;
      else if (routeValues.Any<KeyValuePair<string, object>>())
        str = urlHelper.RouteUrl((object) routeValues);
      return str;
    }

    public string Generate(ActionContext context, INavigatable navigationItem)
    {
      RouteValueDictionary routeValueDictionary = new RouteValueDictionary();
      if (navigationItem.RouteValues.Any<KeyValuePair<string, object>>())
        DictionaryExtensions.Merge(routeValueDictionary, (IDictionary<string, object>) navigationItem.RouteValues);
      return this.Generate(context, navigationItem, routeValueDictionary);
    }
  }
}
