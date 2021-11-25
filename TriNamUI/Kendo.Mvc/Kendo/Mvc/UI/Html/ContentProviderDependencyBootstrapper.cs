// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Html.ContentProviderDependencyBootstrapper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Infrastructure;
using System;

namespace Kendo.Mvc.UI.Html
{
  internal static class ContentProviderDependencyBootstrapper
  {
    public static void Setup()
    {
      DI.Current.Register<IContentBrowser>((Func<IContentBrowser>) (() => (IContentBrowser) new ContentBrowser()));
      DI.Current.Register<IContentPermission>((Func<IContentPermission>) (() => (IContentPermission) new ContentPermission()));
    }
  }
}
