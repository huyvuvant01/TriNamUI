// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.FileManagerToolbarSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class FileManagerToolbarSettingsBuilder
  {
    public FileManagerToolbarSettingsBuilder(FileManagerToolbarSettings container) => this.Container = container;

    protected FileManagerToolbarSettings Container { get; private set; }

    public FileManagerToolbarSettingsBuilder Items(
      Action<FileManagerToolbarSettingsItemFactory> configurator)
    {
      configurator(new FileManagerToolbarSettingsItemFactory(this.Container.Items)
      {
        FileManager = this.Container.FileManager
      });
      return this;
    }

    public FileManagerToolbarSettingsBuilder Click(string handler)
    {
      this.Container.Click = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public FileManagerToolbarSettingsBuilder Click(
      Func<object, object> handler)
    {
      this.Container.Click = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public FileManagerToolbarSettingsBuilder Close(string handler)
    {
      this.Container.Close = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public FileManagerToolbarSettingsBuilder Close(
      Func<object, object> handler)
    {
      this.Container.Close = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public FileManagerToolbarSettingsBuilder Open(string handler)
    {
      this.Container.Open = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public FileManagerToolbarSettingsBuilder Open(
      Func<object, object> handler)
    {
      this.Container.Open = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public FileManagerToolbarSettingsBuilder Toggle(string handler)
    {
      this.Container.Toggle = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public FileManagerToolbarSettingsBuilder Toggle(
      Func<object, object> handler)
    {
      this.Container.Toggle = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public FileManagerToolbarSettingsBuilder OverflowClose(
      string handler)
    {
      this.Container.OverflowClose = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public FileManagerToolbarSettingsBuilder OverflowClose(
      Func<object, object> handler)
    {
      this.Container.OverflowClose = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public FileManagerToolbarSettingsBuilder OverflowOpen(
      string handler)
    {
      this.Container.OverflowOpen = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public FileManagerToolbarSettingsBuilder OverflowOpen(
      Func<object, object> handler)
    {
      this.Container.OverflowOpen = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }
  }
}
