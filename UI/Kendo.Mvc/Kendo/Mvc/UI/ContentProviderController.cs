// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.ContentProviderController
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

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
  [Obsolete("ContentProviderController is deprecated and its code is moved to our demos source code and can be found at https://demos.telerik.com/aspnet-core/filemanager/index.")]
  public abstract class ContentProviderController : Controller, IContentProviderController
  {
    private readonly IContentBrowser directoryBrowser;
    private readonly IContentPermission permission;
    protected readonly IHostingEnvironment HostingEnvironment;

    protected ContentProviderController(IHostingEnvironment hostingEnvironment)
      : this(DI.Current.Resolve<IContentBrowser>(), DI.Current.Resolve<IContentPermission>(), hostingEnvironment)
    {
    }

    protected ContentProviderController(
      IContentBrowser directoryBrowser,
      IContentPermission permission,
      IHostingEnvironment hostingEnvironment)
    {
      this.directoryBrowser = directoryBrowser;
      this.directoryBrowser.HostingEnvironment = hostingEnvironment;
      this.permission = permission;
      this.HostingEnvironment = hostingEnvironment;
    }

    public abstract string ContentPath { get; }

    public virtual string Filter => "*.*";

    public virtual bool Authorize(string path) => this.CanAccess(path);

    protected virtual bool CanAccess(string path) => this.permission.CanAccess(Path.GetFullPath(Path.Combine(this.HostingEnvironment.WebRootPath, this.ContentPath)), path);

    protected virtual string NormalizePath(string path) => string.IsNullOrEmpty(path) ? Path.GetFullPath(Path.Combine(this.HostingEnvironment.WebRootPath, this.ContentPath)) : Path.GetFullPath(Path.Combine(this.HostingEnvironment.WebRootPath, this.ContentPath, path));

    protected virtual FileManagerEntry VirtualizePath(FileManagerEntry entry)
    {
      entry.Path = entry.Path.Replace(Path.Combine(this.HostingEnvironment.WebRootPath, this.ContentPath), "").Replace("\\", "/").TrimStart('/');
      return entry;
    }

    public virtual ActionResult Create(string target, FileManagerEntry entry)
    {
      if (!this.Authorize(this.NormalizePath(target)))
        throw new Exception("Forbidden");
      return (ActionResult) this.Json((object) this.VirtualizePath(!string.IsNullOrEmpty(entry.Path) ? this.CopyEntry(target, entry) : this.CreateNewFolder(target, entry)));
    }

    protected virtual FileManagerEntry CopyEntry(
      string target,
      FileManagerEntry entry)
    {
      string str1 = this.NormalizePath(entry.Path);
      string str2 = this.EnsureUniqueName(this.NormalizePath(target), entry);
      FileManagerEntry fileManagerEntry;
      if (entry.IsDirectory)
      {
        this.CopyDirectory(new DirectoryInfo(str1), Directory.CreateDirectory(str2));
        fileManagerEntry = this.directoryBrowser.GetDirectory(str2);
      }
      else
      {
        File.Copy(str1, str2);
        fileManagerEntry = this.directoryBrowser.GetFile(str2);
      }
      return fileManagerEntry;
    }

    protected virtual void CopyDirectory(DirectoryInfo source, DirectoryInfo target)
    {
      foreach (FileInfo file in source.GetFiles())
      {
        Console.WriteLine("Copying {0}\\{1}", (object) target.FullName, (object) file.Name);
        file.CopyTo(Path.Combine(target.FullName, file.Name), true);
      }
      foreach (DirectoryInfo directory in source.GetDirectories())
      {
        DirectoryInfo subdirectory = target.CreateSubdirectory(directory.Name);
        this.CopyDirectory(directory, subdirectory);
      }
    }

    protected virtual FileManagerEntry CreateNewFolder(
      string target,
      FileManagerEntry entry)
    {
      string path = this.EnsureUniqueName(this.NormalizePath(target), entry);
      Directory.CreateDirectory(path);
      return this.directoryBrowser.GetDirectory(path);
    }

    protected virtual string EnsureUniqueName(string target, FileManagerEntry entry)
    {
      string path2_1 = entry.Name + entry.Extension;
      int num = 0;
      string path = Path.Combine(this.NormalizePath(target), path2_1);
      if (!this.Authorize(this.NormalizePath(path)))
        throw new Exception("Forbidden");
      string path2_2;
      string path2_3;
      if (entry.IsDirectory)
      {
        for (; Directory.Exists(path); path = Path.Combine(this.NormalizePath(target), path2_2))
          path2_2 = entry.Name + string.Format("({0})", (object) ++num);
      }
      else
      {
        for (; File.Exists(path); path = Path.Combine(this.NormalizePath(target), path2_3))
          path2_3 = entry.Name + string.Format("({0})", (object) ++num) + entry.Extension;
      }
      return path;
    }

    public virtual ActionResult Destroy(FileManagerEntry entry)
    {
      string path = this.NormalizePath(entry.Path);
      if (string.IsNullOrEmpty(path))
        throw new Exception("File Not Found");
      if (entry.IsDirectory)
        this.DeleteDirectory(path);
      else
        this.DeleteFile(path);
      return (ActionResult) this.Json((object) new object[0]);
    }

    protected virtual void DeleteFile(string path)
    {
      string path1 = this.Authorize(path) ? this.NormalizePath(path) : throw new Exception("Forbidden");
      if (!File.Exists(path1))
        return;
      File.Delete(path1);
    }

    protected virtual void DeleteDirectory(string path)
    {
      string path1 = this.Authorize(path) ? this.NormalizePath(path) : throw new Exception("Forbidden");
      if (!Directory.Exists(path1))
        return;
      Directory.Delete(path1, true);
    }

    public virtual JsonResult Read(string target)
    {
      string path = this.NormalizePath(target);
      if (!this.Authorize(path))
        throw new Exception("Forbidden");
      try
      {
        return this.Json((object) this.directoryBrowser.GetFiles(path, this.Filter).Concat<FileManagerEntry>(this.directoryBrowser.GetDirectories(path)).Select<FileManagerEntry, FileManagerEntry>(new Func<FileManagerEntry, FileManagerEntry>(this.VirtualizePath)).ToArray<FileManagerEntry>());
      }
      catch (DirectoryNotFoundException ex)
      {
        throw new Exception("File Not Found");
      }
    }

    public virtual ActionResult Update(string target, FileManagerEntry entry)
    {
      if (!this.Authorize(this.NormalizePath(entry.Path)) && !this.Authorize(this.NormalizePath(target)))
        throw new Exception("Forbidden");
      return (ActionResult) this.Json((object) this.VirtualizePath(this.RenameEntry(entry)));
    }

    protected virtual FileManagerEntry RenameEntry(FileManagerEntry entry)
    {
      string path = this.NormalizePath(entry.Path);
      string str1 = path;
      string str2 = this.EnsureUniqueName(Path.GetDirectoryName(path), entry);
      FileManagerEntry fileManagerEntry;
      if (entry.IsDirectory)
      {
        Directory.Move(str1, str2);
        fileManagerEntry = this.directoryBrowser.GetDirectory(str2);
      }
      else
      {
        File.Move(new FileInfo(str1).FullName, str2);
        fileManagerEntry = this.directoryBrowser.GetFile(str2);
      }
      return fileManagerEntry;
    }

    public virtual bool AuthorizeUpload(string path, IFormFile file)
    {
      if (!this.CanAccess(path))
        throw new DirectoryNotFoundException(string.Format("The specified path cannot be found - {0}", (object) path));
      if (!this.IsValidFile(this.GetFileName(file)))
        throw new InvalidDataException(string.Format("The type of file is not allowed. Only {0} extensions are allowed.", (object) this.Filter));
      return true;
    }

    private bool IsValidFile(string fileName)
    {
      string extension = Path.GetExtension(fileName);
      return ((IEnumerable<string>) this.Filter.Split(',')).Any<string>((Func<string, bool>) (e => e.Equals("*.*") || e.EndsWith(extension, StringComparison.OrdinalIgnoreCase)));
    }

    [AcceptVerbs("POST")]
    public virtual ActionResult Upload(string path, IFormFile file)
    {
      path = this.NormalizePath(path);
      string fileName = Path.GetFileName(file.FileName);
      if (!this.AuthorizeUpload(path, file))
        throw new Exception("Forbidden");
      this.SaveFile(file, path);
      return (ActionResult) this.Json((object) this.VirtualizePath(this.directoryBrowser.GetFile(Path.Combine(path, fileName))));
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

    public virtual string GetFileName(IFormFile file) => Path.GetFileName(ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.ToString().Trim('"'));
  }
}
