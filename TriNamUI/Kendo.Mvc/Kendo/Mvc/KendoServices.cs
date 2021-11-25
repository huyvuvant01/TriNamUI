// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.KendoServices
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Rendering;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;


#nullable enable
namespace Kendo.Mvc
{
  public class KendoServices
  {
    public static 
    #nullable disable
    IEnumerable<ServiceDescriptor> GetServices()
    {
      yield return ServiceDescriptor.Transient<IKendoHtmlGenerator, KendoHtmlGenerator>();
      yield return ServiceDescriptor.Transient<IUrlGenerator, UrlGenerator>();
    }
  }
}
