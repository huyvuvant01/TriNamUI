// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.FileManagerBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System;
using System.Linq.Expressions;

namespace Kendo.Mvc.UI.Fluent
{
  public class FileManagerBuilder : WidgetBuilderBase<FileManager, FileManagerBuilder>
  {
    public FileManagerBuilder(FileManager component)
      : base(component)
    {
    }

    public FileManagerBuilder UploadUrl(
      string actionName,
      string controllerName,
      RouteValueDictionary routeValues)
    {
      NavigatableExtensions.Action(this.Component.UploadAction, actionName, controllerName, routeValues);
      return this;
    }

    public FileManagerBuilder UploadUrl(
      string actionName,
      string controllerName,
      object routeValues)
    {
      this.Component.UploadAction.Action(actionName, controllerName, routeValues);
      return this;
    }

    public FileManagerBuilder UploadUrl(string actionName, string controllerName) => this.UploadUrl(actionName, controllerName, (object) null);

    public FileManagerBuilder UploadUrl(RouteValueDictionary routeValues)
    {
      this.Component.UploadAction.Action(routeValues);
      return this;
    }

    public FileManagerBuilder UploadUrl(
      string routeName,
      RouteValueDictionary routeValues)
    {
      NavigatableExtensions.Route(this.Component.UploadAction, routeName, routeValues);
      return this;
    }

    public FileManagerBuilder UploadUrl(string routeName, object routeValues)
    {
      this.Component.UploadAction.Route(routeName, routeValues);
      return this;
    }

    public FileManagerBuilder UploadUrl<TController>(
      Expression<Action<TController>> controllerAction)
      where TController : Controller
    {
      this.Component.UploadAction.Action<TController>(controllerAction);
      return this;
    }

    public FileManagerBuilder DataSource(
      Action<FileManagerDataSourceBuilder<object>> configurator)
    {
      configurator(new FileManagerDataSourceBuilder<object>(this.Component.DataSource, this.Component.ViewContext, this.Component.UrlGenerator));
      return this;
    }

    public FileManagerBuilder DataSource(string dataSourceId)
    {
      this.Component.DataSourceId = dataSourceId;
      return this;
    }

    public FileManagerBuilder Width(double value)
    {
      this.Container.Width = new double?(value);
      return this;
    }

    public FileManagerBuilder Height(double value)
    {
      this.Container.Height = new double?(value);
      return this;
    }

    public FileManagerBuilder InitialView(string value)
    {
      this.Container.InitialView = value;
      return this;
    }

    public FileManagerBuilder Resizable(bool value)
    {
      this.Container.Resizable = new bool?(value);
      return this;
    }

    public FileManagerBuilder Draggable(bool value)
    {
      this.Container.Draggable = new bool?(value);
      return this;
    }

    public FileManagerBuilder UploadUrl(string value)
    {
      this.Container.UploadUrl = value;
      return this;
    }

    public FileManagerBuilder Upload(
      Action<FileManagerUploadSettingsBuilder> configurator)
    {
      this.Container.Upload.FileManager = this.Container;
      configurator(new FileManagerUploadSettingsBuilder(this.Container.Upload));
      return this;
    }

    public FileManagerBuilder Toolbar(
      Action<FileManagerToolbarSettingsBuilder> configurator)
    {
      this.Container.Toolbar.Enabled = new bool?(true);
      this.Container.Toolbar.FileManager = this.Container;
      configurator(new FileManagerToolbarSettingsBuilder(this.Container.Toolbar));
      return this;
    }

    public FileManagerBuilder Toolbar(bool enabled)
    {
      this.Container.Toolbar.Enabled = new bool?(enabled);
      return this;
    }

    public FileManagerBuilder Dialogs(
      Action<FileManagerDialogsSettingsBuilder> configurator)
    {
      this.Container.Dialogs.FileManager = this.Container;
      configurator(new FileManagerDialogsSettingsBuilder(this.Container.Dialogs));
      return this;
    }

    public FileManagerBuilder ContextMenu(
      Action<FileManagerContextMenuSettingsBuilder> configurator)
    {
      this.Container.ContextMenu.Enabled = new bool?(true);
      this.Container.ContextMenu.FileManager = this.Container;
      configurator(new FileManagerContextMenuSettingsBuilder(this.Container.ContextMenu));
      return this;
    }

    public FileManagerBuilder ContextMenu(bool enabled)
    {
      this.Container.ContextMenu.Enabled = new bool?(enabled);
      return this;
    }

    public FileManagerBuilder Views(
      Action<FileManagerViewsSettingsBuilder> configurator)
    {
      this.Container.Views.FileManager = this.Container;
      configurator(new FileManagerViewsSettingsBuilder(this.Container.Views));
      return this;
    }

    public FileManagerBuilder PreviewPane(
      Action<FileManagerPreviewPaneSettingsBuilder> configurator)
    {
      this.Container.PreviewPane.FileManager = this.Container;
      configurator(new FileManagerPreviewPaneSettingsBuilder(this.Container.PreviewPane));
      return this;
    }

    public FileManagerBuilder Breadcrumb(
      Action<FileManagerBreadcrumbSettingsBuilder> configurator)
    {
      this.Container.Breadcrumb.Enabled = new bool?(true);
      this.Container.Breadcrumb.FileManager = this.Container;
      configurator(new FileManagerBreadcrumbSettingsBuilder(this.Container.Breadcrumb));
      return this;
    }

    public FileManagerBuilder Breadcrumb(bool enabled)
    {
      this.Container.Breadcrumb.Enabled = new bool?(enabled);
      return this;
    }

    public FileManagerBuilder Messages(
      Action<FileManagerMessagesSettingsBuilder> configurator)
    {
      this.Container.Messages.FileManager = this.Container;
      configurator(new FileManagerMessagesSettingsBuilder(this.Container.Messages));
      return this;
    }

    public FileManagerBuilder Events(Action<FileManagerEventBuilder> configurator)
    {
      configurator(new FileManagerEventBuilder(this.Container.Events));
      return this;
    }
  }
}
