// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.FileManagerUploadLocalizationSettingsTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("localization", ParentTag = "upload", TagStructure = TagStructure.WithoutEndTag)]
  [SuppressTagRendering]
  public class FileManagerUploadLocalizationSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (FileManagerUploadSettingsTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as FileManagerUploadSettingsTagHelper).Localization = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Cancel { get; set; }

    public string ClearSelectedFiles { get; set; }

    public string DropFilesHere { get; set; }

    public string HeaderStatusUploaded { get; set; }

    public string HeaderStatusUploading { get; set; }

    public string InvalidFileExtension { get; set; }

    public string InvalidFiles { get; set; }

    public string InvalidMaxFileSize { get; set; }

    public string InvalidMinFileSize { get; set; }

    public string Remove { get; set; }

    public string Retry { get; set; }

    public string Select { get; set; }

    public string StatusFailed { get; set; }

    public string StatusUploaded { get; set; }

    public string StatusUploading { get; set; }

    public string UploadSelectedFiles { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string cancel = this.Cancel;
      if ((cancel != null ? (cancel.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["cancel"] = (object) this.Cancel;
      string clearSelectedFiles = this.ClearSelectedFiles;
      if ((clearSelectedFiles != null ? (clearSelectedFiles.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["clearSelectedFiles"] = (object) this.ClearSelectedFiles;
      string dropFilesHere = this.DropFilesHere;
      if ((dropFilesHere != null ? (dropFilesHere.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dropFilesHere"] = (object) this.DropFilesHere;
      string headerStatusUploaded = this.HeaderStatusUploaded;
      if ((headerStatusUploaded != null ? (headerStatusUploaded.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["headerStatusUploaded"] = (object) this.HeaderStatusUploaded;
      string headerStatusUploading = this.HeaderStatusUploading;
      if ((headerStatusUploading != null ? (headerStatusUploading.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["headerStatusUploading"] = (object) this.HeaderStatusUploading;
      string invalidFileExtension = this.InvalidFileExtension;
      if ((invalidFileExtension != null ? (invalidFileExtension.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["invalidFileExtension"] = (object) this.InvalidFileExtension;
      string invalidFiles = this.InvalidFiles;
      if ((invalidFiles != null ? (invalidFiles.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["invalidFiles"] = (object) this.InvalidFiles;
      string invalidMaxFileSize = this.InvalidMaxFileSize;
      if ((invalidMaxFileSize != null ? (invalidMaxFileSize.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["invalidMaxFileSize"] = (object) this.InvalidMaxFileSize;
      string invalidMinFileSize = this.InvalidMinFileSize;
      if ((invalidMinFileSize != null ? (invalidMinFileSize.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["invalidMinFileSize"] = (object) this.InvalidMinFileSize;
      string remove = this.Remove;
      if ((remove != null ? (remove.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["remove"] = (object) this.Remove;
      string retry = this.Retry;
      if ((retry != null ? (retry.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["retry"] = (object) this.Retry;
      string select = this.Select;
      if ((select != null ? (select.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["select"] = (object) this.Select;
      string statusFailed = this.StatusFailed;
      if ((statusFailed != null ? (statusFailed.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["statusFailed"] = (object) this.StatusFailed;
      string statusUploaded = this.StatusUploaded;
      if ((statusUploaded != null ? (statusUploaded.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["statusUploaded"] = (object) this.StatusUploaded;
      string statusUploading = this.StatusUploading;
      if ((statusUploading != null ? (statusUploading.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["statusUploading"] = (object) this.StatusUploading;
      string uploadSelectedFiles = this.UploadSelectedFiles;
      if ((uploadSelectedFiles != null ? (uploadSelectedFiles.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["uploadSelectedFiles"] = (object) this.UploadSelectedFiles;
      return dictionary;
    }
  }
}
