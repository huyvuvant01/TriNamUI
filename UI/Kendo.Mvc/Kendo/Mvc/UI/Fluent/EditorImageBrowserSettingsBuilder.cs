// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.EditorImageBrowserSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class EditorImageBrowserSettingsBuilder
  {
    public EditorImageBrowserSettingsBuilder(EditorImageBrowserSettings container) => this.Container = container;

    protected EditorImageBrowserSettings Container { get; private set; }

    public EditorImageBrowserSettingsBuilder Create(
      string actionName,
      string controllerName)
    {
      return this.Create(actionName, controllerName, (object) null);
    }

    public EditorImageBrowserSettingsBuilder Create(
      string actionName,
      string controllerName,
      RouteValueDictionary routeValues)
    {
      NavigatableExtensions.Action(this.Container.Create, actionName, controllerName, routeValues);
      this.SetUrl((INavigatable) this.Container.Create);
      return this;
    }

    public EditorImageBrowserSettingsBuilder Create(
      string actionName,
      string controllerName,
      object routeValues)
    {
      this.Container.Create.Action(actionName, controllerName, routeValues);
      this.SetUrl((INavigatable) this.Container.Create);
      return this;
    }

    public EditorImageBrowserSettingsBuilder Create(
      Action<EditorImageBrowserOperationBuilder> configurator)
    {
      configurator(new EditorImageBrowserOperationBuilder(this.Container.Create, this.Container.Editor.ViewContext, this.Container.Editor.UrlGenerator));
      return this;
    }

    public EditorImageBrowserSettingsBuilder Destroy(
      string actionName,
      string controllerName)
    {
      return this.Destroy(actionName, controllerName, (object) null);
    }

    public EditorImageBrowserSettingsBuilder Destroy(
      string actionName,
      string controllerName,
      RouteValueDictionary routeValues)
    {
      NavigatableExtensions.Action(this.Container.Destroy, actionName, controllerName, routeValues);
      this.SetUrl((INavigatable) this.Container.Destroy);
      return this;
    }

    public EditorImageBrowserSettingsBuilder Destroy(
      string actionName,
      string controllerName,
      object routeValues)
    {
      this.Container.Destroy.Action(actionName, controllerName, routeValues);
      this.SetUrl((INavigatable) this.Container.Destroy);
      return this;
    }

    public EditorImageBrowserSettingsBuilder Destroy(
      Action<EditorImageBrowserOperationBuilder> configurator)
    {
      configurator(new EditorImageBrowserOperationBuilder(this.Container.Destroy, this.Container.Editor.ViewContext, this.Container.Editor.UrlGenerator));
      return this;
    }

    public EditorImageBrowserSettingsBuilder Image(
      string actionName,
      string controllerName)
    {
      return this.Image(actionName, controllerName, (object) null);
    }

    public EditorImageBrowserSettingsBuilder Image(string url)
    {
      this.Container.Image.Url = this.Container.Editor.UrlGenerator.Generate((ActionContext) this.Container.Editor.ViewContext, url);
      return this;
    }

    public EditorImageBrowserSettingsBuilder Image(
      string actionName,
      string controllerName,
      RouteValueDictionary routeValues)
    {
      NavigatableExtensions.Action(this.Container.Image, actionName, controllerName, routeValues);
      this.SetUrl((INavigatable) this.Container.Image);
      return this;
    }

    public EditorImageBrowserSettingsBuilder Image(
      string actionName,
      string controllerName,
      object routeValues)
    {
      this.Container.Image.Action(actionName, controllerName, routeValues);
      this.SetUrl((INavigatable) this.Container.Image);
      return this;
    }

    public EditorImageBrowserSettingsBuilder Image(
      Action<EditorImageBrowserOperationBuilder> configurator)
    {
      configurator(new EditorImageBrowserOperationBuilder(this.Container.Image, this.Container.Editor.ViewContext, this.Container.Editor.UrlGenerator));
      return this;
    }

    public EditorImageBrowserSettingsBuilder Read(
      string actionName,
      string controllerName)
    {
      return this.Read(actionName, controllerName, (object) null);
    }

    public EditorImageBrowserSettingsBuilder Read(
      string actionName,
      string controllerName,
      RouteValueDictionary routeValues)
    {
      NavigatableExtensions.Action(this.Container.Read, actionName, controllerName, routeValues);
      this.SetUrl((INavigatable) this.Container.Read);
      return this;
    }

    public EditorImageBrowserSettingsBuilder Read(
      string actionName,
      string controllerName,
      object routeValues)
    {
      this.Container.Read.Action(actionName, controllerName, routeValues);
      this.SetUrl((INavigatable) this.Container.Read);
      return this;
    }

    public EditorImageBrowserSettingsBuilder Read(
      Action<EditorImageBrowserOperationBuilder> configurator)
    {
      configurator(new EditorImageBrowserOperationBuilder(this.Container.Read, this.Container.Editor.ViewContext, this.Container.Editor.UrlGenerator));
      return this;
    }

    public EditorImageBrowserSettingsBuilder Thumbnail(
      string actionName,
      string controllerName)
    {
      return this.Thumbnail(actionName, controllerName, (object) null);
    }

    public EditorImageBrowserSettingsBuilder Thumbnail(
      string actionName,
      string controllerName,
      RouteValueDictionary routeValues)
    {
      NavigatableExtensions.Action(this.Container.Thumbnail, actionName, controllerName, routeValues);
      this.SetUrl((INavigatable) this.Container.Thumbnail);
      return this;
    }

    public EditorImageBrowserSettingsBuilder Thumbnail(
      string actionName,
      string controllerName,
      object routeValues)
    {
      this.Container.Thumbnail.Action(actionName, controllerName, routeValues);
      this.SetUrl((INavigatable) this.Container.Thumbnail);
      return this;
    }

    public EditorImageBrowserSettingsBuilder Thumbnail(
      Action<EditorImageBrowserOperationBuilder> configurator)
    {
      configurator(new EditorImageBrowserOperationBuilder(this.Container.Thumbnail, this.Container.Editor.ViewContext, this.Container.Editor.UrlGenerator));
      return this;
    }

    public EditorImageBrowserSettingsBuilder Upload(
      string actionName,
      string controllerName)
    {
      return this.Upload(actionName, controllerName, (object) null);
    }

    public EditorImageBrowserSettingsBuilder Upload(
      string actionName,
      string controllerName,
      RouteValueDictionary routeValues)
    {
      NavigatableExtensions.Action(this.Container.Upload, actionName, controllerName, routeValues);
      this.SetUrl((INavigatable) this.Container.Upload);
      return this;
    }

    public EditorImageBrowserSettingsBuilder Upload(
      string actionName,
      string controllerName,
      object routeValues)
    {
      this.Container.Upload.Action(actionName, controllerName, routeValues);
      this.SetUrl((INavigatable) this.Container.Upload);
      return this;
    }

    public EditorImageBrowserSettingsBuilder Upload(
      Action<EditorImageBrowserOperationBuilder> configurator)
    {
      configurator(new EditorImageBrowserOperationBuilder(this.Container.Upload, this.Container.Editor.ViewContext, this.Container.Editor.UrlGenerator));
      return this;
    }

    private void SetUrl(INavigatable operation) => operation.Url = operation.GenerateUrl(this.Container.Editor.ViewContext, this.Container.Editor.UrlGenerator);

    public EditorImageBrowserSettingsBuilder FileTypes(string value)
    {
      this.Container.FileTypes = value;
      return this;
    }

    public EditorImageBrowserSettingsBuilder Path(string value)
    {
      this.Container.Path = value;
      return this;
    }

    public EditorImageBrowserSettingsBuilder Transport(
      Action<EditorImageBrowserTransportSettingsBuilder> configurator)
    {
      this.Container.Transport.Editor = this.Container.Editor;
      configurator(new EditorImageBrowserTransportSettingsBuilder(this.Container.Transport));
      return this;
    }

    public EditorImageBrowserSettingsBuilder Schema(
      Action<EditorImageBrowserSchemaSettingsBuilder> configurator)
    {
      this.Container.Schema.Editor = this.Container.Editor;
      configurator(new EditorImageBrowserSchemaSettingsBuilder(this.Container.Schema));
      return this;
    }

    public EditorImageBrowserSettingsBuilder Messages(
      Action<EditorImageBrowserMessagesSettingsBuilder> configurator)
    {
      this.Container.Messages.Editor = this.Container.Editor;
      configurator(new EditorImageBrowserMessagesSettingsBuilder(this.Container.Messages));
      return this;
    }
  }
}
