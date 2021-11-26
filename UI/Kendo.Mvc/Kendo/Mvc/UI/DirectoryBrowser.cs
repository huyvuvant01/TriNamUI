// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.DirectoryBrowser
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
  public class DirectoryBrowser : IDirectoryBrowser
  {
    public virtual IHostingEnvironment HostingEnvironment { get; set; }

    public IEnumerable<FileBrowserEntry> GetFiles(
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
      }, StringSplitOptions.RemoveEmptyEntries)).SelectMany<string, FileInfo>(new Func<string, IEnumerable<FileInfo>>(directoryInfo.GetFiles)).Select<FileInfo, FileBrowserEntry>((Func<FileInfo, FileBrowserEntry>) (file => new FileBrowserEntry()
      {
        Name = file.Name,
        Size = file.Length,
        EntryType = FileBrowserEntryType.File
      }));
    }

    public IEnumerable<FileBrowserEntry> GetDirectories(string path) => ((IEnumerable<DirectoryInfo>) new DirectoryInfo(path).GetDirectories()).Select<DirectoryInfo, FileBrowserEntry>((Func<DirectoryInfo, FileBrowserEntry>) (subDirectory => new FileBrowserEntry()
    {
      Name = subDirectory.Name,
      EntryType = FileBrowserEntryType.Directory
    }));
  }
}
