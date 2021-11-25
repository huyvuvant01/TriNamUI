// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Html.FileDependencyBootstrapper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Infrastructure;
using System;

namespace Kendo.Mvc.UI.Html
{
  internal static class FileDependencyBootstrapper
  {
    public static void Setup()
    {
      DI.Current.Register<IDirectoryBrowser>((Func<IDirectoryBrowser>) (() => (IDirectoryBrowser) new DirectoryBrowser()));
      DI.Current.Register<IDirectoryPermission>((Func<IDirectoryPermission>) (() => (IDirectoryPermission) new DirectoryPermission()));
    }
  }
}
