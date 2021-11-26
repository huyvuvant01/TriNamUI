// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.EditorFileBrowserController
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Hosting;
using System;

namespace Kendo.Mvc.UI
{
  [Obsolete("EditorFileBrowserController is deprecated and its code is moved to our demos source code and can be found at https://demos.telerik.com/aspnet-core/editor.")]
  public abstract class EditorFileBrowserController : FileBrowserController
  {
    public override string Filter => "*.*";

    public EditorFileBrowserController(IHostingEnvironment hostingEnvironment)
      : base(hostingEnvironment)
    {
    }
  }
}
