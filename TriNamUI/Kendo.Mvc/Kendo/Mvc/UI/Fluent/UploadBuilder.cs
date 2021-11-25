// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.UploadBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class UploadBuilder : WidgetBuilderBase<Upload, UploadBuilder>
  {
    public UploadBuilder(Upload component)
      : base(component)
    {
    }

    public UploadBuilder Enable(bool value)
    {
      this.Container.Enabled = new bool?(value);
      return this;
    }

    public UploadBuilder Messages(Action<UploadMessagesSettingsBuilder> configurator)
    {
      configurator(new UploadMessagesSettingsBuilder(this.Container.Messages));
      return this;
    }

    public UploadBuilder Async(Action<UploadAsyncSettingsBuilder> configurator)
    {
      this.Container.Async.Upload = this.Container;
      configurator(new UploadAsyncSettingsBuilder(this.Container.Async));
      return this;
    }

    public UploadBuilder Directory(bool value)
    {
      this.Container.Directory = new bool?(value);
      return this;
    }

    public UploadBuilder Directory()
    {
      this.Container.Directory = new bool?(true);
      return this;
    }

    public UploadBuilder DirectoryDrop(bool value)
    {
      this.Container.DirectoryDrop = new bool?(value);
      return this;
    }

    public UploadBuilder DirectoryDrop()
    {
      this.Container.DirectoryDrop = new bool?(true);
      return this;
    }

    public UploadBuilder DropZone(string value)
    {
      this.Container.DropZone = value;
      return this;
    }

    public UploadBuilder Files(Action<UploadFileFactory> configurator)
    {
      configurator(new UploadFileFactory(this.Container.Files)
      {
        Upload = this.Container
      });
      return this;
    }

    public UploadBuilder Multiple(bool value)
    {
      this.Container.Multiple = new bool?(value);
      return this;
    }

    public UploadBuilder ShowFileList(bool value)
    {
      this.Container.ShowFileList = new bool?(value);
      return this;
    }

    public UploadBuilder Template(string value)
    {
      this.Container.Template = value;
      return this;
    }

    public UploadBuilder TemplateId(string templateId)
    {
      this.Container.TemplateId = templateId;
      return this;
    }

    public UploadBuilder Validation(
      Action<UploadValidationSettingsBuilder> configurator)
    {
      this.Container.Validation.Upload = this.Container;
      configurator(new UploadValidationSettingsBuilder(this.Container.Validation));
      return this;
    }

    public UploadBuilder Events(Action<UploadEventBuilder> configurator)
    {
      configurator(new UploadEventBuilder(this.Container.Events));
      return this;
    }
  }
}
