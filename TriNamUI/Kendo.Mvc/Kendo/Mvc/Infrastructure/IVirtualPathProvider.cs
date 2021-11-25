// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.Infrastructure.IVirtualPathProvider
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.Infrastructure
{
  public interface IVirtualPathProvider
  {
    bool DirectoryExists(string virtualPath);

    bool FileExists(string virtualPath);

    string GetDirectory(string virtualPath);

    string GetFile(string virtualPath);

    string GetExtension(string virtualPath);

    string CombinePaths(string basePath, string relativePath);

    string ReadAllText(string virtualPath);

    string ToAbsolute(string virtualPath);

    string AppendTrailingSlash(string virtualPath);
  }
}
