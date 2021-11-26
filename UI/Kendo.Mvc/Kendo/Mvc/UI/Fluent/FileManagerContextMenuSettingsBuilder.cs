// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.FileManagerContextMenuSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class FileManagerContextMenuSettingsBuilder
  {
    public FileManagerContextMenuSettingsBuilder(FileManagerContextMenuSettings container) => this.Container = container;

    protected FileManagerContextMenuSettings Container { get; private set; }

    public FileManagerContextMenuSettingsBuilder Items(
      Action<FileManagerContextMenuSettingsItemFactory> configurator)
    {
      configurator(new FileManagerContextMenuSettingsItemFactory(this.Container.Items)
      {
        FileManager = this.Container.FileManager
      });
      return this;
    }

    public FileManagerContextMenuSettingsBuilder Close(
      string handler)
    {
      this.Container.Close = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public FileManagerContextMenuSettingsBuilder Close(
      Func<object, object> handler)
    {
      this.Container.Close = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public FileManagerContextMenuSettingsBuilder Open(
      string handler)
    {
      this.Container.Open = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public FileManagerContextMenuSettingsBuilder Open(
      Func<object, object> handler)
    {
      this.Container.Open = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public FileManagerContextMenuSettingsBuilder Activate(
      string handler)
    {
      this.Container.Activate = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public FileManagerContextMenuSettingsBuilder Activate(
      Func<object, object> handler)
    {
      this.Container.Activate = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public FileManagerContextMenuSettingsBuilder Deactivate(
      string handler)
    {
      this.Container.Deactivate = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public FileManagerContextMenuSettingsBuilder Deactivate(
      Func<object, object> handler)
    {
      this.Container.Deactivate = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public FileManagerContextMenuSettingsBuilder Select(
      string handler)
    {
      this.Container.Select = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public FileManagerContextMenuSettingsBuilder Select(
      Func<object, object> handler)
    {
      this.Container.Select = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }
  }
}
