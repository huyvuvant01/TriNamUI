// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.EditorImageBrowserTransportSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class EditorImageBrowserTransportSettingsBuilder
  {
    public EditorImageBrowserTransportSettingsBuilder(EditorImageBrowserTransportSettings container) => this.Container = container;

    protected EditorImageBrowserTransportSettings Container { get; private set; }

    public EditorImageBrowserTransportSettingsBuilder Read(
      Action<EditorImageBrowserTransportReadSettingsBuilder> configurator)
    {
      this.Container.Read.Editor = this.Container.Editor;
      configurator(new EditorImageBrowserTransportReadSettingsBuilder(this.Container.Read));
      return this;
    }

    public EditorImageBrowserTransportSettingsBuilder ThumbnailUrl(
      string value)
    {
      this.Container.ThumbnailUrlHandler = (ClientHandlerDescriptor) null;
      this.Container.ThumbnailUrl = value;
      return this;
    }

    public EditorImageBrowserTransportSettingsBuilder ThumbnailUrlHandler(
      string handler)
    {
      this.Container.ThumbnailUrl = (string) null;
      this.Container.ThumbnailUrlHandler = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public EditorImageBrowserTransportSettingsBuilder ThumbnailUrlHandler(
      Func<object, object> handler)
    {
      this.Container.ThumbnailUrl = (string) null;
      this.Container.ThumbnailUrlHandler = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public EditorImageBrowserTransportSettingsBuilder UploadUrl(
      string value)
    {
      this.Container.UploadUrl = value;
      return this;
    }

    public EditorImageBrowserTransportSettingsBuilder ImageUrl(
      string value)
    {
      this.Container.ImageUrlHandler = (ClientHandlerDescriptor) null;
      this.Container.ImageUrl = value;
      return this;
    }

    public EditorImageBrowserTransportSettingsBuilder ImageUrlHandler(
      string handler)
    {
      this.Container.ImageUrl = (string) null;
      this.Container.ImageUrlHandler = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public EditorImageBrowserTransportSettingsBuilder ImageUrlHandler(
      Func<object, object> handler)
    {
      this.Container.ImageUrl = (string) null;
      this.Container.ImageUrlHandler = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public EditorImageBrowserTransportSettingsBuilder Destroy(
      Action<EditorImageBrowserTransportDestroySettingsBuilder> configurator)
    {
      this.Container.Destroy.Editor = this.Container.Editor;
      configurator(new EditorImageBrowserTransportDestroySettingsBuilder(this.Container.Destroy));
      return this;
    }

    public EditorImageBrowserTransportSettingsBuilder Create(
      Action<EditorImageBrowserTransportCreateSettingsBuilder> configurator)
    {
      this.Container.Create.Editor = this.Container.Editor;
      configurator(new EditorImageBrowserTransportCreateSettingsBuilder(this.Container.Create));
      return this;
    }
  }
}
