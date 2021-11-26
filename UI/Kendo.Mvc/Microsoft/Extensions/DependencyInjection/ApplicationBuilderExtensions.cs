// Decompiled with JetBrains decompiler
// Type: Microsoft.Extensions.DependencyInjection.ApplicationBuilderExtensions
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using System;
using System.ComponentModel;

namespace Microsoft.Extensions.DependencyInjection
{
  public static class ApplicationBuilderExtensions
  {
    [Obsolete("The method is deprecated as of R2 2018 and is required for previous versions only.")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static void UseKendo(this IApplicationBuilder app, IHostingEnvironment env)
    {
    }
  }
}
