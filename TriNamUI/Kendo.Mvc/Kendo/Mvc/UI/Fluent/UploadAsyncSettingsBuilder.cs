// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.UploadAsyncSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System;
using System.Linq.Expressions;

namespace Kendo.Mvc.UI.Fluent
{
  public class UploadAsyncSettingsBuilder
  {
    public UploadAsyncSettingsBuilder(UploadAsyncSettings container) => this.Container = container;

    protected UploadAsyncSettings Container { get; private set; }

    public UploadAsyncSettingsBuilder Save(
      string actionName,
      string controllerName,
      RouteValueDictionary routeValues)
    {
      NavigatableExtensions.Action(this.Container.Save, actionName, controllerName, routeValues);
      return this;
    }

    public UploadAsyncSettingsBuilder Save(
      string actionName,
      string controllerName,
      object routeValues)
    {
      this.Container.Save.Action(actionName, controllerName, routeValues);
      return this;
    }

    public UploadAsyncSettingsBuilder Save(
      string actionName,
      string controllerName)
    {
      return this.Save(actionName, controllerName, (object) null);
    }

    public UploadAsyncSettingsBuilder Save(string routeName) => this.Save(routeName, (object) null);

    public UploadAsyncSettingsBuilder Save(
      RouteValueDictionary routeValues)
    {
      this.Container.Save.Action(routeValues);
      return this;
    }

    public UploadAsyncSettingsBuilder Save(
      string routeName,
      RouteValueDictionary routeValues)
    {
      NavigatableExtensions.Route(this.Container.Save, routeName, routeValues);
      return this;
    }

    public UploadAsyncSettingsBuilder Save(
      string routeName,
      object routeValues)
    {
      this.Container.Save.Route(routeName, routeValues);
      return this;
    }

    public UploadAsyncSettingsBuilder Save<TController>(
      Expression<Action<TController>> controllerAction)
      where TController : Controller
    {
      this.Container.Save.Action<TController>(controllerAction);
      return this;
    }

    public UploadAsyncSettingsBuilder Remove(
      string actionName,
      string controllerName,
      RouteValueDictionary routeValues)
    {
      NavigatableExtensions.Action(this.Container.Remove, actionName, controllerName, routeValues);
      return this;
    }

    public UploadAsyncSettingsBuilder Remove(
      string actionName,
      string controllerName,
      object routeValues)
    {
      this.Container.Remove.Action(actionName, controllerName, routeValues);
      return this;
    }

    public UploadAsyncSettingsBuilder Remove(
      string actionName,
      string controllerName)
    {
      return this.Remove(actionName, controllerName, (object) null);
    }

    public UploadAsyncSettingsBuilder Remove(string routeName) => this.Remove(routeName, (object) null);

    public UploadAsyncSettingsBuilder Remove(
      RouteValueDictionary routeValues)
    {
      this.Container.Remove.Action(routeValues);
      return this;
    }

    public UploadAsyncSettingsBuilder Remove(
      string routeName,
      RouteValueDictionary routeValues)
    {
      NavigatableExtensions.Route(this.Container.Remove, routeName, routeValues);
      return this;
    }

    public UploadAsyncSettingsBuilder Remove(
      string routeName,
      object routeValues)
    {
      this.Container.Remove.Route(routeName, routeValues);
      return this;
    }

    public UploadAsyncSettingsBuilder Remove<TController>(
      Expression<Action<TController>> controllerAction)
      where TController : Controller
    {
      this.Container.Remove.Action<TController>(controllerAction);
      return this;
    }

    public UploadAsyncSettingsBuilder AutoUpload(bool value)
    {
      this.Container.AutoUpload = new bool?(value);
      return this;
    }

    public UploadAsyncSettingsBuilder Batch(bool value)
    {
      this.Container.Batch = new bool?(value);
      return this;
    }

    public UploadAsyncSettingsBuilder Batch()
    {
      this.Container.Batch = new bool?(true);
      return this;
    }

    public UploadAsyncSettingsBuilder ChunkSize(double value)
    {
      this.Container.ChunkSize = new double?(value);
      return this;
    }

    public UploadAsyncSettingsBuilder Concurrent(bool value)
    {
      this.Container.Concurrent = new bool?(value);
      return this;
    }

    public UploadAsyncSettingsBuilder Concurrent()
    {
      this.Container.Concurrent = new bool?(true);
      return this;
    }

    public UploadAsyncSettingsBuilder AutoRetryAfter(double value)
    {
      this.Container.AutoRetryAfter = new double?(value);
      return this;
    }

    public UploadAsyncSettingsBuilder MaxAutoRetries(double value)
    {
      this.Container.MaxAutoRetries = new double?(value);
      return this;
    }

    public UploadAsyncSettingsBuilder RemoveField(string value)
    {
      this.Container.RemoveField = value;
      return this;
    }

    public UploadAsyncSettingsBuilder RemoveUrl(string value)
    {
      this.Container.RemoveUrl = value;
      return this;
    }

    public UploadAsyncSettingsBuilder RemoveVerb(string value)
    {
      this.Container.RemoveVerb = value;
      return this;
    }

    public UploadAsyncSettingsBuilder SaveField(string value)
    {
      this.Container.SaveField = value;
      return this;
    }

    public UploadAsyncSettingsBuilder SaveUrl(string value)
    {
      this.Container.SaveUrl = value;
      return this;
    }

    public UploadAsyncSettingsBuilder UseArrayBuffer(bool value)
    {
      this.Container.UseArrayBuffer = new bool?(value);
      return this;
    }

    public UploadAsyncSettingsBuilder UseArrayBuffer()
    {
      this.Container.UseArrayBuffer = new bool?(true);
      return this;
    }

    public UploadAsyncSettingsBuilder WithCredentials(bool value)
    {
      this.Container.WithCredentials = new bool?(value);
      return this;
    }
  }
}
