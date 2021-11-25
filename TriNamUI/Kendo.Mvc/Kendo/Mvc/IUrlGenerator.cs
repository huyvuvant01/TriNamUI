// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.IUrlGenerator
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace Kendo.Mvc
{
  public interface IUrlGenerator
  {
    string Generate(ActionContext context, INavigatable navigationItem);

    string Generate(
      ActionContext context,
      INavigatable navigationItem,
      RouteValueDictionary routeValues);

    string Generate(ActionContext context, string url);
  }
}
