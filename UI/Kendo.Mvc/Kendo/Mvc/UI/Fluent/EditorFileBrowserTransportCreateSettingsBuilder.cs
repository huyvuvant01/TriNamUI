// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.EditorFileBrowserTransportCreateSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class EditorFileBrowserTransportCreateSettingsBuilder
  {
    public EditorFileBrowserTransportCreateSettingsBuilder(
      EditorFileBrowserTransportCreateSettings container)
    {
      this.Container = container;
    }

    protected EditorFileBrowserTransportCreateSettings Container { get; private set; }

    public EditorFileBrowserTransportCreateSettingsBuilder ContentType(
      string value)
    {
      this.Container.ContentType = value;
      return this;
    }

    public EditorFileBrowserTransportCreateSettingsBuilder DataType(
      string value)
    {
      this.Container.DataType = value;
      return this;
    }

    public EditorFileBrowserTransportCreateSettingsBuilder Type(
      string value)
    {
      this.Container.Type = value;
      return this;
    }

    public EditorFileBrowserTransportCreateSettingsBuilder Url(
      string value)
    {
      this.Container.UrlHandler = (ClientHandlerDescriptor) null;
      this.Container.Url = value;
      return this;
    }

    public EditorFileBrowserTransportCreateSettingsBuilder UrlHandler(
      string handler)
    {
      this.Container.Url = (string) null;
      this.Container.UrlHandler = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public EditorFileBrowserTransportCreateSettingsBuilder UrlHandler(
      Func<object, object> handler)
    {
      this.Container.Url = (string) null;
      this.Container.UrlHandler = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }
  }
}
