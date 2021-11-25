// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.EditorImageBrowserController
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Infrastructure;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Kendo.Mvc.UI
{
  [Obsolete("EditorImageBrowserController is deprecated and its code is moved to our demos source code and can be found at https://demos.telerik.com/aspnet-core/editor/imagebrowser.")]
  public abstract class EditorImageBrowserController : 
    FileBrowserController,
    IImageBrowserController,
    IFileBrowserController
  {
    protected EditorImageBrowserController(IHostingEnvironment hostingEnvironment)
      : this(DI.Current.Resolve<IDirectoryBrowser>(), DI.Current.Resolve<IDirectoryPermission>(), hostingEnvironment)
    {
    }

    protected EditorImageBrowserController(
      IDirectoryBrowser directoryBrowser,
      IDirectoryPermission permission,
      IHostingEnvironment hostingEnvironment)
      : base(directoryBrowser, permission, hostingEnvironment)
    {
    }

    public override string Filter => "*.png,*.gif,*.jpg,*.jpeg";

    public virtual bool AuthorizeThumbnail(string path) => this.CanAccess(path);

    public virtual IActionResult Thumbnail(string path) => (IActionResult) null;
  }
}
