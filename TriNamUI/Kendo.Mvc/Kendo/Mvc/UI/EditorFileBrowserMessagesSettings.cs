// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.EditorFileBrowserMessagesSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class EditorFileBrowserMessagesSettings
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string UploadFile { get; set; }

    public string OrderBy { get; set; }

    public string OrderByName { get; set; }

    public string OrderBySize { get; set; }

    public string DirectoryNotFound { get; set; }

    public string EmptyFolder { get; set; }

    public string DeleteFile { get; set; }

    public string InvalidFileType { get; set; }

    public string OverwriteFile { get; set; }

    public string Search { get; set; }

    public Editor Editor { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string uploadFile = this.UploadFile;
      if ((uploadFile != null ? (uploadFile.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["uploadFile"] = (object) this.UploadFile;
      string orderBy = this.OrderBy;
      if ((orderBy != null ? (orderBy.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["orderBy"] = (object) this.OrderBy;
      string orderByName = this.OrderByName;
      if ((orderByName != null ? (orderByName.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["orderByName"] = (object) this.OrderByName;
      string orderBySize = this.OrderBySize;
      if ((orderBySize != null ? (orderBySize.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["orderBySize"] = (object) this.OrderBySize;
      string directoryNotFound = this.DirectoryNotFound;
      if ((directoryNotFound != null ? (directoryNotFound.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["directoryNotFound"] = (object) this.DirectoryNotFound;
      string emptyFolder = this.EmptyFolder;
      if ((emptyFolder != null ? (emptyFolder.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["emptyFolder"] = (object) this.EmptyFolder;
      string deleteFile = this.DeleteFile;
      if ((deleteFile != null ? (deleteFile.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["deleteFile"] = (object) this.DeleteFile;
      string invalidFileType = this.InvalidFileType;
      if ((invalidFileType != null ? (invalidFileType.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["invalidFileType"] = (object) this.InvalidFileType;
      string overwriteFile = this.OverwriteFile;
      if ((overwriteFile != null ? (overwriteFile.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["overwriteFile"] = (object) this.OverwriteFile;
      string search = this.Search;
      if ((search != null ? (search.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["search"] = (object) this.Search;
      return dictionary;
    }
  }
}
