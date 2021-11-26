// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.FileManagerUploadSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class FileManagerUploadSettingsBuilder
  {
    public FileManagerUploadSettingsBuilder(FileManagerUploadSettings container) => this.Container = container;

    protected FileManagerUploadSettings Container { get; private set; }

    public FileManagerUploadSettingsBuilder Cancel(string handler)
    {
      this.Container.Cancel = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public FileManagerUploadSettingsBuilder Cancel(
      Func<object, object> handler)
    {
      this.Container.Cancel = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public FileManagerUploadSettingsBuilder Clear(string handler)
    {
      this.Container.Clear = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public FileManagerUploadSettingsBuilder Clear(
      Func<object, object> handler)
    {
      this.Container.Clear = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public FileManagerUploadSettingsBuilder Complete(string handler)
    {
      this.Container.Complete = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public FileManagerUploadSettingsBuilder Complete(
      Func<object, object> handler)
    {
      this.Container.Complete = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public FileManagerUploadSettingsBuilder Error(string handler)
    {
      this.Container.Error = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public FileManagerUploadSettingsBuilder Error(
      Func<object, object> handler)
    {
      this.Container.Error = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public FileManagerUploadSettingsBuilder Pause(string handler)
    {
      this.Container.Pause = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public FileManagerUploadSettingsBuilder Pause(
      Func<object, object> handler)
    {
      this.Container.Pause = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public FileManagerUploadSettingsBuilder Progress(string handler)
    {
      this.Container.Progress = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public FileManagerUploadSettingsBuilder Progress(
      Func<object, object> handler)
    {
      this.Container.Progress = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public FileManagerUploadSettingsBuilder Resume(string handler)
    {
      this.Container.Resume = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public FileManagerUploadSettingsBuilder Resume(
      Func<object, object> handler)
    {
      this.Container.Resume = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public FileManagerUploadSettingsBuilder Remove(string handler)
    {
      this.Container.Remove = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public FileManagerUploadSettingsBuilder Remove(
      Func<object, object> handler)
    {
      this.Container.Remove = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public FileManagerUploadSettingsBuilder Select(string handler)
    {
      this.Container.Select = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public FileManagerUploadSettingsBuilder Select(
      Func<object, object> handler)
    {
      this.Container.Select = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public FileManagerUploadSettingsBuilder Success(string handler)
    {
      this.Container.Success = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public FileManagerUploadSettingsBuilder Success(
      Func<object, object> handler)
    {
      this.Container.Success = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public FileManagerUploadSettingsBuilder Upload(string handler)
    {
      this.Container.Upload = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public FileManagerUploadSettingsBuilder Upload(
      Func<object, object> handler)
    {
      this.Container.Upload = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public FileManagerUploadSettingsBuilder Async(
      Action<FileManagerUploadAsyncSettingsBuilder> configurator)
    {
      this.Container.Async.FileManager = this.Container.FileManager;
      configurator(new FileManagerUploadAsyncSettingsBuilder(this.Container.Async));
      return this;
    }

    public FileManagerUploadSettingsBuilder Directory(bool value)
    {
      this.Container.Directory = new bool?(value);
      return this;
    }

    public FileManagerUploadSettingsBuilder Localization(
      Action<FileManagerUploadLocalizationSettingsBuilder> configurator)
    {
      this.Container.Localization.FileManager = this.Container.FileManager;
      configurator(new FileManagerUploadLocalizationSettingsBuilder(this.Container.Localization));
      return this;
    }

    public FileManagerUploadSettingsBuilder Multiple(bool value)
    {
      this.Container.Multiple = new bool?(value);
      return this;
    }

    public FileManagerUploadSettingsBuilder ShowFileList(bool value)
    {
      this.Container.ShowFileList = new bool?(value);
      return this;
    }

    public FileManagerUploadSettingsBuilder Validation(
      Action<FileManagerUploadValidationSettingsBuilder> configurator)
    {
      this.Container.Validation.FileManager = this.Container.FileManager;
      configurator(new FileManagerUploadValidationSettingsBuilder(this.Container.Validation));
      return this;
    }
  }
}
