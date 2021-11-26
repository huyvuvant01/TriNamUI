// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.EditorFileBrowserTransportSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class EditorFileBrowserTransportSettingsBuilder
  {
    public EditorFileBrowserTransportSettingsBuilder(EditorFileBrowserTransportSettings container) => this.Container = container;

    protected EditorFileBrowserTransportSettings Container { get; private set; }

    public EditorFileBrowserTransportSettingsBuilder Read(
      Action<EditorFileBrowserTransportReadSettingsBuilder> configurator)
    {
      this.Container.Read.Editor = this.Container.Editor;
      configurator(new EditorFileBrowserTransportReadSettingsBuilder(this.Container.Read));
      return this;
    }

    public EditorFileBrowserTransportSettingsBuilder UploadUrl(
      string value)
    {
      this.Container.UploadUrl = value;
      return this;
    }

    public EditorFileBrowserTransportSettingsBuilder FileUrl(
      string value)
    {
      this.Container.FileUrlHandler = (ClientHandlerDescriptor) null;
      this.Container.FileUrl = value;
      return this;
    }

    public EditorFileBrowserTransportSettingsBuilder FileUrlHandler(
      string handler)
    {
      this.Container.FileUrl = (string) null;
      this.Container.FileUrlHandler = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public EditorFileBrowserTransportSettingsBuilder FileUrlHandler(
      Func<object, object> handler)
    {
      this.Container.FileUrl = (string) null;
      this.Container.FileUrlHandler = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public EditorFileBrowserTransportSettingsBuilder Destroy(
      Action<EditorFileBrowserTransportDestroySettingsBuilder> configurator)
    {
      this.Container.Destroy.Editor = this.Container.Editor;
      configurator(new EditorFileBrowserTransportDestroySettingsBuilder(this.Container.Destroy));
      return this;
    }

    public EditorFileBrowserTransportSettingsBuilder Create(
      Action<EditorFileBrowserTransportCreateSettingsBuilder> configurator)
    {
      this.Container.Create.Editor = this.Container.Editor;
      configurator(new EditorFileBrowserTransportCreateSettingsBuilder(this.Container.Create));
      return this;
    }
  }
}
