// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.UploadMessagesSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class UploadMessagesSettingsBuilder
  {
    public UploadMessagesSettingsBuilder(UploadMessagesSettings container) => this.Container = container;

    protected UploadMessagesSettings Container { get; private set; }

    public UploadMessagesSettingsBuilder Cancel(string value)
    {
      this.Container.Cancel = value;
      return this;
    }

    public UploadMessagesSettingsBuilder DropFilesHere(string value)
    {
      this.Container.DropFilesHere = value;
      return this;
    }

    public UploadMessagesSettingsBuilder HeaderStatusPaused(
      string value)
    {
      this.Container.HeaderStatusPaused = value;
      return this;
    }

    public UploadMessagesSettingsBuilder HeaderStatusUploaded(
      string value)
    {
      this.Container.HeaderStatusUploaded = value;
      return this;
    }

    public UploadMessagesSettingsBuilder HeaderStatusUploading(
      string value)
    {
      this.Container.HeaderStatusUploading = value;
      return this;
    }

    public UploadMessagesSettingsBuilder UploadSuccess(string value)
    {
      this.Container.UploadSuccess = value;
      return this;
    }

    public UploadMessagesSettingsBuilder UploadFail(string value)
    {
      this.Container.UploadFail = value;
      return this;
    }

    public UploadMessagesSettingsBuilder Remove(string value)
    {
      this.Container.Remove = value;
      return this;
    }

    public UploadMessagesSettingsBuilder Retry(string value)
    {
      this.Container.Retry = value;
      return this;
    }

    public UploadMessagesSettingsBuilder Select(string value)
    {
      this.Container.Select = value;
      return this;
    }

    public UploadMessagesSettingsBuilder StatusFailed(string value)
    {
      this.Container.StatusFailed = value;
      return this;
    }

    public UploadMessagesSettingsBuilder StatusUploaded(string value)
    {
      this.Container.StatusUploaded = value;
      return this;
    }

    public UploadMessagesSettingsBuilder StatusUploading(string value)
    {
      this.Container.StatusUploading = value;
      return this;
    }

    public UploadMessagesSettingsBuilder UploadSelectedFiles(
      string value)
    {
      this.Container.UploadSelectedFiles = value;
      return this;
    }

    public UploadMessagesSettingsBuilder InvalidMaxFileSize(
      string value)
    {
      this.Container.InvalidMaxFileSize = value;
      return this;
    }

    public UploadMessagesSettingsBuilder InvalidMinFileSize(
      string value)
    {
      this.Container.InvalidMinFileSize = value;
      return this;
    }

    public UploadMessagesSettingsBuilder InvalidFileExtension(
      string value)
    {
      this.Container.InvalidFileExtension = value;
      return this;
    }

    public UploadMessagesSettingsBuilder ClearSelectedFiles(
      string value)
    {
      this.Container.ClearSelectedFiles = value;
      return this;
    }
  }
}
