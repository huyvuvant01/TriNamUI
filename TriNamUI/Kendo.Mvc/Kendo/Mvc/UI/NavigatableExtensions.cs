// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.NavigatableExtensions
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Resources;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Kendo.Mvc.UI
{
  public static class NavigatableExtensions
  {
    public static void Action(this INavigatable navigatable, RouteValueDictionary routeValues) => routeValues.ApplyTo(navigatable, new System.Action<INavigatable, string, string, RouteValueDictionary>(NavigatableExtensions.SetAction));

    public static void Action(
      this INavigatable navigatable,
      string actionName,
      string controllerName,
      object routeValues)
    {
      navigatable.ControllerName = controllerName;
      navigatable.ActionName = actionName;
      navigatable.SetRouteValues(routeValues);
    }

    public static void Action(
      this INavigatable navigatable,
      string actionName,
      string controllerName,
      RouteValueDictionary routeValues)
    {
      NavigatableExtensions.SetAction(navigatable, actionName, controllerName, routeValues);
    }

    public static void Action<TController>(
      this INavigatable item,
      Expression<System.Action<TController>> controllerAction)
      where TController : Controller
    {
      MethodCallExpression body = (MethodCallExpression) controllerAction.Body;
      string name = typeof (TController).Name;
      string str1 = name.EndsWith("Controller", StringComparison.OrdinalIgnoreCase) ? name.Substring(0, name.Length - "Controller".Length) : throw new ArgumentException(Exceptions.ControllerNameMustEndWithController, nameof (controllerAction));
      if (str1.Length == 0)
        throw new ArgumentException(Exceptions.CannotRouteToClassNamedController, nameof (controllerAction));
      if (body.Method.IsDefined(typeof (NonActionAttribute), false))
        throw new ArgumentException(Exceptions.TheSpecifiedMethodIsNotAnActionMethod, nameof (controllerAction));
      string str2 = body.Method.GetCustomAttributes(typeof (ActionNameAttribute), false).OfType<ActionNameAttribute>().Select<ActionNameAttribute, string>((Func<ActionNameAttribute, string>) (attribute => attribute.Name)).FirstOrDefault<string>() ?? body.Method.Name;
      item.ControllerName = str1;
      item.ActionName = str2;
      ParameterInfo[] parameters = body.Method.GetParameters();
      for (int index = 0; index < parameters.Length; ++index)
      {
        Expression expression = body.Arguments[index];
        object obj = !(expression is ConstantExpression constantExpression2) ? Expression.Lambda<Func<object>>((Expression) Expression.Convert(expression, typeof (object))).Compile()() : constantExpression2.Value;
        item.RouteValues.Add(parameters[index].Name, obj);
      }
    }

    public static void Url(this INavigatable navigatable, string value) => navigatable.Url = value;

    public static void Route(this INavigatable navigatable, string routeName, object routeValues)
    {
      navigatable.RouteName = routeName;
      navigatable.SetRouteValues(routeValues);
    }

    public static void Route(
      this INavigatable navigatable,
      string routeName,
      RouteValueDictionary routeValues)
    {
      navigatable.RouteName = routeName;
      NavigatableExtensions.SetRouteValues(navigatable, (IDictionary<string, object>) routeValues);
    }

    public static string GenerateUrl(
      this INavigatable navigatable,
      ViewContext viewContext,
      IUrlGenerator urlGenerator)
    {
      return urlGenerator.Generate((ActionContext) viewContext, navigatable);
    }

    public static bool IsCurrent(
      this INavigatable navigatable,
      ViewContext viewContext,
      IUrlGenerator urlGenerator)
    {
      HttpRequest request = viewContext.HttpContext.Request;
      string comparing1 = request.Path + request.QueryString;
      string instance = urlGenerator.Generate((ActionContext) viewContext, navigatable);
      string comparing2 = NavigatableExtensions.GetUrlHelper((ActionContext) viewContext).RouteUrl((object) viewContext.RouteData.Values);
      if (string.IsNullOrEmpty(instance))
        return false;
      return instance.IsCaseInsensitiveEqual(comparing1) || instance.IsCaseInsensitiveEqual(comparing2);
    }

    public static IUrlHelper GetUrlHelper(ActionContext context) => context.HttpContext.RequestServices.GetRequiredService<IUrlHelperFactory>().GetUrlHelper(context);

    public static string GenerateUrl(
      this INavigatable navigatable,
      ViewContext viewContext,
      IUrlGenerator urlGenerator,
      RouteValueDictionary routeValues)
    {
      return urlGenerator.Generate((ActionContext) viewContext, navigatable, routeValues);
    }

    public static bool HasValue(this INavigatable navigatable) => navigatable.ActionName.HasValue() && navigatable.ControllerName.HasValue() || navigatable.RouteName.HasValue() || navigatable.Url.HasValue();

    private static void SetAction(
      INavigatable navigatable,
      string actionName,
      string controllerName,
      RouteValueDictionary routeValues)
    {
      navigatable.ActionName = actionName;
      navigatable.ControllerName = controllerName;
      NavigatableExtensions.SetRouteValues(navigatable, (IDictionary<string, object>) routeValues);
    }

    private static void SetRouteValues(this INavigatable navigatable, object values)
    {
      if (values == null)
        return;
      navigatable.RouteValues.Clear();
      navigatable.RouteValues.Merge(values);
    }

    private static void SetRouteValues(
      this INavigatable navigatable,
      IDictionary<string, object> values)
    {
      if (values == null)
        return;
      navigatable.RouteValues.Clear();
      DictionaryExtensions.Merge(navigatable.RouteValues, values);
    }
  }
}
