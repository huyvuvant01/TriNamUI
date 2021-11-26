// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.FileManagerUploadLocalizationSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class FileManagerUploadLocalizationSettingsBuilder
  {
    public FileManagerUploadLocalizationSettingsBuilder(
      FileManagerUploadLocalizationSettings container)
    {
      this.Container = container;
    }

    protected FileManagerUploadLocalizationSettings Container { get; private set; }

    public FileManagerUploadLocalizationSettingsBuilder Cancel(
      string value)
    {
      this.Container.Cancel = value;
      return this;
    }

    public FileManagerUploadLocalizationSettingsBuilder ClearSelectedFiles(
      string value)
    {
      this.Container.ClearSelectedFiles = value;
      return this;
    }

    public FileManagerUploadLocalizationSettingsBuilder DropFilesHere(
      string value)
    {
      this.Container.DropFilesHere = value;
      return this;
    }

    public FileManagerUploadLocalizationSettingsBuilder HeaderStatusUploaded(
      string value)
    {
      this.Container.HeaderStatusUploaded = value;
      return this;
    }

    public FileManagerUploadLocalizationSettingsBuilder HeaderStatusUploading(
      string value)
    {
      this.Container.HeaderStatusUploading = value;
      return this;
    }

    public FileManagerUploadLocalizationSettingsBuilder InvalidFileExtension(
      string value)
    {
      this.Container.InvalidFileExtension = value;
      return this;
    }

    public FileManagerUploadLocalizationSettingsBuilder InvalidFiles(
      string value)
    {
      this.Container.InvalidFiles = value;
      return this;
    }

    public FileManagerUploadLocalizationSettingsBuilder InvalidMaxFileSize(
      string value)
    {
      this.Container.InvalidMaxFileSize = value;
      return this;
    }

    public FileManagerUploadLocalizationSettingsBuilder InvalidMinFileSize(
      string value)
    {
      this.Container.InvalidMinFileSize = value;
      return this;
    }

    public FileManagerUploadLocalizationSettingsBuilder Remove(
      string value)
    {
      this.Container.Remove = value;
      return this;
    }

    public FileManagerUploadLocalizationSettingsBuilder Retry(
      string value)
    {
      this.Container.Retry = value;
      return this;
    }

    public FileManagerUploadLocalizationSettingsBuilder Select(
      string value)
    {
      this.Container.Select = value;
      return this;
    }

    public FileManagerUploadLocalizationSettingsBuilder StatusFailed(
      string value)
    {
      this.Container.StatusFailed = value;
      return this;
    }

    public FileManagerUploadLocalizationSettingsBuilder StatusUploaded(
      string value)
    {
      this.Container.StatusUploaded = value;
      return this;
    }

    public FileManagerUploadLocalizationSettingsBuilder StatusUploading(
      string value)
    {
      this.Container.StatusUploading = value;
      return this;
    }

    public FileManagerUploadLocalizationSettingsBuilder UploadSelectedFiles(
      string value)
    {
      this.Container.UploadSelectedFiles = value;
      return this;
    }
  }
}
