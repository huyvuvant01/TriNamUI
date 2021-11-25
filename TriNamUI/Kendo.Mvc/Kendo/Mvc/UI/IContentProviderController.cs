// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.IContentProviderController
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Kendo.Mvc.UI
{
  public interface IContentProviderController
  {
    JsonResult Read(string target);

    ActionResult Destroy(FileManagerEntry entry);

    ActionResult Create(string target, FileManagerEntry entry);

    ActionResult Update(string target, FileManagerEntry entry);

    ActionResult Upload(string path, IFormFile file);
  }
}
