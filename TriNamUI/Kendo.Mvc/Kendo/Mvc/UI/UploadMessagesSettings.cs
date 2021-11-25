// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.UploadMessagesSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class UploadMessagesSettings
  {
    public string Cancel { get; set; }

    public string DropFilesHere { get; set; }

    public string HeaderStatusPaused { get; set; }

    public string HeaderStatusUploaded { get; set; }

    public string HeaderStatusUploading { get; set; }

    public string Remove { get; set; }

    public string Retry { get; set; }

    public string Select { get; set; }

    public string StatusFailed { get; set; }

    public string StatusUploaded { get; set; }

    public string StatusUploading { get; set; }

    public string UploadSuccess { get; set; }

    public string UploadFail { get; set; }

    public string UploadSelectedFiles { get; set; }

    public string InvalidMaxFileSize { get; set; }

    public string InvalidMinFileSize { get; set; }

    public string InvalidFileExtension { get; set; }

    public string ClearSelectedFiles { get; set; }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.Cancel.HasValue())
        dictionary["cancel"] = (object) this.Cancel;
      if (this.DropFilesHere.HasValue())
        dictionary["dropFilesHere"] = (object) this.DropFilesHere;
      if (this.HeaderStatusPaused.HasValue())
        dictionary["headerStatusPaused"] = (object) this.HeaderStatusPaused;
      if (this.HeaderStatusUploaded.HasValue())
        dictionary["headerStatusUploaded"] = (object) this.HeaderStatusUploaded;
      if (this.HeaderStatusUploading.HasValue())
        dictionary["headerStatusUploading"] = (object) this.HeaderStatusUploading;
      if (this.Remove.HasValue())
        dictionary["remove"] = (object) this.Remove;
      if (this.Retry.HasValue())
        dictionary["retry"] = (object) this.Retry;
      if (this.Select.HasValue())
        dictionary["select"] = (object) this.Select;
      if (this.StatusFailed.HasValue())
        dictionary["statusFailed"] = (object) this.StatusFailed;
      if (this.StatusUploaded.HasValue())
        dictionary["statusUploaded"] = (object) this.StatusUploaded;
      if (this.StatusUploading.HasValue())
        dictionary["statusUploading"] = (object) this.StatusUploading;
      if (this.UploadSelectedFiles.HasValue())
        dictionary["uploadSelectedFiles"] = (object) this.UploadSelectedFiles;
      if (this.InvalidMaxFileSize.HasValue())
        dictionary["invalidMaxFileSize"] = (object) this.InvalidMaxFileSize;
      if (this.InvalidMinFileSize.HasValue())
        dictionary["invalidMinFileSize"] = (object) this.InvalidMinFileSize;
      if (this.InvalidFileExtension.HasValue())
        dictionary["invalidFileExtension"] = (object) this.InvalidFileExtension;
      if (this.ClearSelectedFiles.HasValue())
        dictionary["clearSelectedFiles"] = (object) this.ClearSelectedFiles;
      if (this.UploadSuccess.HasValue())
        dictionary["uploadSuccess"] = (object) this.UploadSuccess;
      if (this.UploadFail.HasValue())
        dictionary["uploadFail"] = (object) this.UploadFail;
      return dictionary;
    }
  }
}
