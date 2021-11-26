// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.FileBrowserController
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Infrastructure;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;

namespace Kendo.Mvc.UI
{
  [Obsolete("FileBrowserController is deprecated and its code is moved to our demos source code and can be found at https://demos.telerik.com/aspnet-core/editor.")]
  public abstract class FileBrowserController : Controller, IFileBrowserController
  {
    private readonly IDirectoryBrowser directoryBrowser;
    private readonly IDirectoryPermission permission;
    protected readonly IHostingEnvironment HostingEnvironment;

    protected FileBrowserController(IHostingEnvironment hostingEnvironment)
      : this(DI.Current.Resolve<IDirectoryBrowser>(), DI.Current.Resolve<IDirectoryPermission>(), hostingEnvironment)
    {
    }

    protected FileBrowserController(
      IDirectoryBrowser directoryBrowser,
      IDirectoryPermission permission,
      IHostingEnvironment hostingEnvironment)
    {
      this.directoryBrowser = directoryBrowser;
      this.directoryBrowser.HostingEnvironment = hostingEnvironment;
      this.permission = permission;
      this.HostingEnvironment = hostingEnvironment;
    }

    public abstract string ContentPath { get; }

    public virtual string Filter => "*.*";

    [AcceptVerbs("POST")]
    public virtual ActionResult Create(string path, FileBrowserEntry entry)
    {
      string str = this.NormalizePath(path);
      string name = entry.Name;
      string path1 = name.HasValue() && this.AuthorizeCreateDirectory(str, name) ? Path.Combine(str, name) : throw new Exception("Forbidden");
      if (!Directory.Exists(path1))
        Directory.CreateDirectory(path1);
      return (ActionResult) this.Json((object) entry);
    }

    public virtual bool AuthorizeCreateDirectory(string path, string name) => this.CanAccess(path);

    public virtual JsonResult Read(string path)
    {
      string path1 = this.NormalizePath(path);
      if (!this.AuthorizeRead(path1))
        throw new Exception("Forbidden");
      try
      {
        return this.Json((object) this.directoryBrowser.GetFiles(path1, this.Filter).Concat<FileBrowserEntry>(this.directoryBrowser.GetDirectories(path1)).ToArray<FileBrowserEntry>());
      }
      catch (DirectoryNotFoundException ex)
      {
        throw new Exception("File Not Found");
      }
    }

    public virtual bool AuthorizeRead(string path) => this.CanAccess(path);

    protected virtual bool CanAccess(string path) => this.permission.CanAccess(Path.GetFullPath(Path.Combine(this.HostingEnvironment.WebRootPath, this.ContentPath)), path);

    protected string NormalizePath(string path) => string.IsNullOrEmpty(path) ? Path.GetFullPath(Path.Combine(this.HostingEnvironment.WebRootPath, this.ContentPath)) : Path.GetFullPath(Path.Combine(this.HostingEnvironment.WebRootPath, this.ContentPath, path));

    [AcceptVerbs("POST")]
    public virtual ActionResult Destroy(string path, FileBrowserEntry entry)
    {
      string path1 = this.NormalizePath(path);
      if (entry == null)
        throw new Exception("File Not Found");
      string path2 = Path.Combine(path1, entry.Name);
      if (entry.EntryType == FileBrowserEntryType.File)
        this.DeleteFile(path2);
      else
        this.DeleteDirectory(path2);
      return (ActionResult) this.Json((object) new object[0]);
    }

    public virtual bool AuthorizeDeleteFile(string path) => this.CanAccess(path);

    public virtual bool AuthorizeDeleteDirectory(string path) => this.CanAccess(path);

    protected virtual void DeleteFile(string path)
    {
      if (!this.AuthorizeDeleteFile(path))
        throw new Exception("Forbidden");
      if (!File.Exists(path))
        return;
      File.Delete(path);
    }

    protected virtual void DeleteDirectory(string path)
    {
      if (!this.AuthorizeDeleteDirectory(path))
        throw new Exception("Forbidden");
      if (!Directory.Exists(path))
        return;
      Directory.Delete(path, true);
    }

    [AcceptVerbs("POST")]
    public virtual ActionResult Upload(string path, IFormFile file)
    {
      string str = this.NormalizePath(path);
      if (!this.AuthorizeUpload(str, file))
        throw new Exception("Forbidden");
      this.SaveFile(file, str);
      return (ActionResult) this.Json((object) new FileBrowserEntry()
      {
        Size = file.Length,
        Name = this.GetFileName(file)
      });
    }

    protected virtual void SaveFile(IFormFile file, string pathToSave)
    {
      try
      {
        using (FileStream fileStream = File.Create(Path.Combine(pathToSave, this.GetFileName(file))))
          file.CopyTo((Stream) fileStream);
      }
      catch (Exception ex)
      {
        throw new Exception(ex.Message);
      }
    }

    public virtual bool AuthorizeUpload(string path, IFormFile file) => this.CanAccess(path) && this.IsValidFile(this.GetFileName(file));

    private bool IsValidFile(string fileName)
    {
      string extension = Path.GetExtension(fileName);
      return ((IEnumerable<string>) this.Filter.Split(',')).Any<string>((Func<string, bool>) (e => e.Equals("*.*") || e.EndsWith(extension, StringComparison.OrdinalIgnoreCase)));
    }

    public virtual string GetFileName(IFormFile file) => Path.GetFileName(ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.ToString().Trim('"'));
  }
}
