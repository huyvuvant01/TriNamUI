// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.ContentBrowser
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class ContentBrowser : IContentBrowser
  {
    public virtual IHostingEnvironment HostingEnvironment { get; set; }

    public IEnumerable<FileManagerEntry> GetFiles(
      string path,
      string filter)
    {
      DirectoryInfo directoryInfo = new DirectoryInfo(path);
      return ((IEnumerable<string>) (filter ?? "*").Split(new string[4]
      {
        ", ",
        ",",
        "; ",
        ";"
      }, StringSplitOptions.RemoveEmptyEntries)).SelectMany<string, FileInfo>(new Func<string, IEnumerable<FileInfo>>(directoryInfo.GetFiles)).Select<FileInfo, FileManagerEntry>((Func<FileInfo, FileManagerEntry>) (file => new FileManagerEntry()
      {
        Name = Path.GetFileNameWithoutExtension(file.Name),
        Size = file.Length,
        Path = file.FullName,
        Extension = file.Extension,
        IsDirectory = false,
        HasDirectories = false,
        Created = file.CreationTime,
        CreatedUtc = file.CreationTimeUtc,
        Modified = file.LastWriteTime,
        ModifiedUtc = file.LastWriteTimeUtc
      }));
    }

    public IEnumerable<FileManagerEntry> GetDirectories(string path) => ((IEnumerable<DirectoryInfo>) new DirectoryInfo(path).GetDirectories()).Select<DirectoryInfo, FileManagerEntry>((Func<DirectoryInfo, FileManagerEntry>) (subDirectory => new FileManagerEntry()
    {
      Name = subDirectory.Name,
      Path = subDirectory.FullName,
      Extension = subDirectory.Extension,
      IsDirectory = true,
      HasDirectories = (uint) subDirectory.GetDirectories().Length > 0U,
      Created = subDirectory.CreationTime,
      CreatedUtc = subDirectory.CreationTimeUtc,
      Modified = subDirectory.LastWriteTime,
      ModifiedUtc = subDirectory.LastWriteTimeUtc
    }));

    public FileManagerEntry GetDirectory(string path)
    {
      DirectoryInfo directoryInfo = new DirectoryInfo(path);
      return new FileManagerEntry()
      {
        Name = directoryInfo.Name,
        Path = directoryInfo.FullName,
        Extension = directoryInfo.Extension,
        IsDirectory = true,
        HasDirectories = (uint) directoryInfo.GetDirectories().Length > 0U,
        Created = directoryInfo.CreationTime,
        CreatedUtc = directoryInfo.CreationTimeUtc,
        Modified = directoryInfo.LastWriteTime,
        ModifiedUtc = directoryInfo.LastWriteTimeUtc
      };
    }

    public FileManagerEntry GetFile(string path)
    {
      FileInfo fileInfo = new FileInfo(path);
      return new FileManagerEntry()
      {
        Name = Path.GetFileNameWithoutExtension(fileInfo.Name),
        Path = fileInfo.FullName,
        Size = fileInfo.Length,
        Extension = fileInfo.Extension,
        IsDirectory = false,
        HasDirectories = false,
        Created = fileInfo.CreationTime,
        CreatedUtc = fileInfo.CreationTimeUtc,
        Modified = fileInfo.LastWriteTime,
        ModifiedUtc = fileInfo.LastWriteTimeUtc
      };
    }
  }
}
