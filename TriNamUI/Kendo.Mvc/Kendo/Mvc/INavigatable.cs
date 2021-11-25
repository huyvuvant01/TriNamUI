// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.INavigatable
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Routing;

namespace Kendo.Mvc
{
  public interface INavigatable
  {
    string RouteName { get; set; }

    string ControllerName { get; set; }

    string ActionName { get; set; }

    RouteValueDictionary RouteValues { get; }

    string Url { get; set; }
  }
}
