// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.EditorFileBrowserSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class EditorFileBrowserSettingsBuilder
  {
    public EditorFileBrowserSettingsBuilder(EditorFileBrowserSettings container) => this.Container = container;

    protected EditorFileBrowserSettings Container { get; private set; }

    public EditorFileBrowserSettingsBuilder Create(
      string actionName,
      string controllerName)
    {
      return this.Create(actionName, controllerName, (object) null);
    }

    public EditorFileBrowserSettingsBuilder Create(
      string actionName,
      string controllerName,
      RouteValueDictionary routeValues)
    {
      NavigatableExtensions.Action(this.Container.Create, actionName, controllerName, routeValues);
      this.SetUrl((INavigatable) this.Container.Create);
      return this;
    }

    public EditorFileBrowserSettingsBuilder Create(
      string actionName,
      string controllerName,
      object routeValues)
    {
      this.Container.Create.Action(actionName, controllerName, routeValues);
      this.SetUrl((INavigatable) this.Container.Create);
      return this;
    }

    public EditorFileBrowserSettingsBuilder Create(
      Action<EditorFileBrowserOperationBuilder> configurator)
    {
      configurator(new EditorFileBrowserOperationBuilder(this.Container.Create, this.Container.Editor.ViewContext, this.Container.Editor.UrlGenerator));
      return this;
    }

    public EditorFileBrowserSettingsBuilder Destroy(
      string actionName,
      string controllerName)
    {
      return this.Destroy(actionName, controllerName, (object) null);
    }

    public EditorFileBrowserSettingsBuilder Destroy(
      string actionName,
      string controllerName,
      RouteValueDictionary routeValues)
    {
      NavigatableExtensions.Action(this.Container.Destroy, actionName, controllerName, routeValues);
      this.SetUrl((INavigatable) this.Container.Destroy);
      return this;
    }

    public EditorFileBrowserSettingsBuilder Destroy(
      string actionName,
      string controllerName,
      object routeValues)
    {
      this.Container.Destroy.Action(actionName, controllerName, routeValues);
      this.SetUrl((INavigatable) this.Container.Destroy);
      return this;
    }

    public EditorFileBrowserSettingsBuilder Destroy(
      Action<EditorFileBrowserOperationBuilder> configurator)
    {
      configurator(new EditorFileBrowserOperationBuilder(this.Container.Destroy, this.Container.Editor.ViewContext, this.Container.Editor.UrlGenerator));
      return this;
    }

    public EditorFileBrowserSettingsBuilder File(
      string actionName,
      string controllerName)
    {
      return this.File(actionName, controllerName, (object) null);
    }

    public EditorFileBrowserSettingsBuilder File(string url)
    {
      this.Container.File.Url = this.Container.Editor.UrlGenerator.Generate((ActionContext) this.Container.Editor.ViewContext, url);
      return this;
    }

    public EditorFileBrowserSettingsBuilder File(
      string actionName,
      string controllerName,
      RouteValueDictionary routeValues)
    {
      NavigatableExtensions.Action(this.Container.File, actionName, controllerName, routeValues);
      this.SetUrl((INavigatable) this.Container.File);
      return this;
    }

    public EditorFileBrowserSettingsBuilder File(
      string actionName,
      string controllerName,
      object routeValues)
    {
      this.Container.File.Action(actionName, controllerName, routeValues);
      this.SetUrl((INavigatable) this.Container.File);
      return this;
    }

    public EditorFileBrowserSettingsBuilder File(
      Action<EditorFileBrowserOperationBuilder> configurator)
    {
      configurator(new EditorFileBrowserOperationBuilder(this.Container.File, this.Container.Editor.ViewContext, this.Container.Editor.UrlGenerator));
      return this;
    }

    public EditorFileBrowserSettingsBuilder Read(
      string actionName,
      string controllerName)
    {
      return this.Read(actionName, controllerName, (object) null);
    }

    public EditorFileBrowserSettingsBuilder Read(
      string actionName,
      string controllerName,
      object routeValues)
    {
      this.Container.Read.Action(actionName, controllerName, routeValues);
      this.SetUrl((INavigatable) this.Container.Read);
      return this;
    }

    public EditorFileBrowserSettingsBuilder Read(
      string actionName,
      string controllerName,
      RouteValueDictionary routeValues)
    {
      NavigatableExtensions.Action(this.Container.Read, actionName, controllerName, routeValues);
      this.SetUrl((INavigatable) this.Container.Read);
      return this;
    }

    public EditorFileBrowserSettingsBuilder Read(
      Action<EditorFileBrowserOperationBuilder> configurator)
    {
      configurator(new EditorFileBrowserOperationBuilder(this.Container.Read, this.Container.Editor.ViewContext, this.Container.Editor.UrlGenerator));
      return this;
    }

    public EditorFileBrowserSettingsBuilder Upload(
      string actionName,
      string controllerName)
    {
      return this.Upload(actionName, controllerName, (object) null);
    }

    public EditorFileBrowserSettingsBuilder Upload(
      string actionName,
      string controllerName,
      RouteValueDictionary routeValues)
    {
      NavigatableExtensions.Action(this.Container.Upload, actionName, controllerName, routeValues);
      this.SetUrl((INavigatable) this.Container.Upload);
      return this;
    }

    public EditorFileBrowserSettingsBuilder Upload(
      string actionName,
      string controllerName,
      object routeValues)
    {
      this.Container.Upload.Action(actionName, controllerName, routeValues);
      this.SetUrl((INavigatable) this.Container.Upload);
      return this;
    }

    public EditorFileBrowserSettingsBuilder Upload(
      Action<EditorFileBrowserOperationBuilder> configurator)
    {
      configurator(new EditorFileBrowserOperationBuilder(this.Container.Upload, this.Container.Editor.ViewContext, this.Container.Editor.UrlGenerator));
      return this;
    }

    private void SetUrl(INavigatable operation) => operation.Url = operation.GenerateUrl(this.Container.Editor.ViewContext, this.Container.Editor.UrlGenerator);

    public EditorFileBrowserSettingsBuilder FileTypes(string value)
    {
      this.Container.FileTypes = value;
      return this;
    }

    public EditorFileBrowserSettingsBuilder Path(string value)
    {
      this.Container.Path = value;
      return this;
    }

    public EditorFileBrowserSettingsBuilder Transport(
      Action<EditorFileBrowserTransportSettingsBuilder> configurator)
    {
      this.Container.Transport.Editor = this.Container.Editor;
      configurator(new EditorFileBrowserTransportSettingsBuilder(this.Container.Transport));
      return this;
    }

    public EditorFileBrowserSettingsBuilder Schema(
      Action<EditorFileBrowserSchemaSettingsBuilder> configurator)
    {
      this.Container.Schema.Editor = this.Container.Editor;
      configurator(new EditorFileBrowserSchemaSettingsBuilder(this.Container.Schema));
      return this;
    }

    public EditorFileBrowserSettingsBuilder Messages(
      Action<EditorFileBrowserMessagesSettingsBuilder> configurator)
    {
      this.Container.Messages.Editor = this.Container.Editor;
      configurator(new EditorFileBrowserMessagesSettingsBuilder(this.Container.Messages));
      return this;
    }
  }
}
