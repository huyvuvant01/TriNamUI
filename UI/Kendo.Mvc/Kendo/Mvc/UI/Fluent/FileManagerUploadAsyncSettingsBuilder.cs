// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.FileManagerUploadAsyncSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class FileManagerUploadAsyncSettingsBuilder
  {
    public FileManagerUploadAsyncSettingsBuilder(FileManagerUploadAsyncSettings container) => this.Container = container;

    protected FileManagerUploadAsyncSettings Container { get; private set; }

    public FileManagerUploadAsyncSettingsBuilder AutoUpload(
      bool value)
    {
      this.Container.AutoUpload = new bool?(value);
      return this;
    }

    public FileManagerUploadAsyncSettingsBuilder Batch(
      bool value)
    {
      this.Container.Batch = new bool?(value);
      return this;
    }

    public FileManagerUploadAsyncSettingsBuilder ChunkSize(
      double value)
    {
      this.Container.ChunkSize = new double?(value);
      return this;
    }

    public FileManagerUploadAsyncSettingsBuilder Concurrent(
      bool value)
    {
      this.Container.Concurrent = new bool?(value);
      return this;
    }

    public FileManagerUploadAsyncSettingsBuilder AutoRetryAfter(
      double value)
    {
      this.Container.AutoRetryAfter = new double?(value);
      return this;
    }

    public FileManagerUploadAsyncSettingsBuilder MaxAutoRetries(
      double value)
    {
      this.Container.MaxAutoRetries = new double?(value);
      return this;
    }

    public FileManagerUploadAsyncSettingsBuilder SaveField(
      string value)
    {
      this.Container.SaveField = value;
      return this;
    }

    public FileManagerUploadAsyncSettingsBuilder SaveUrl(
      string value)
    {
      this.Container.SaveUrl = value;
      return this;
    }

    public FileManagerUploadAsyncSettingsBuilder UseArrayBuffer(
      bool value)
    {
      this.Container.UseArrayBuffer = new bool?(value);
      return this;
    }

    public FileManagerUploadAsyncSettingsBuilder WithCredentials(
      bool value)
    {
      this.Container.WithCredentials = new bool?(value);
      return this;
    }
  }
}
