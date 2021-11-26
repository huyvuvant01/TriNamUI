// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.EditorImportSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq.Expressions;

namespace Kendo.Mvc.UI.Fluent
{
  public class EditorImportSettingsBuilder : IHideObjectMembers
  {
    private readonly EditorImportSettings container;

    public EditorImportSettingsBuilder(EditorImportSettings settings) => this.container = settings;

    public EditorImportSettingsBuilder AllowedExtensions(string[] value)
    {
      this.container.AllowedExtensions = value;
      return this;
    }

    public EditorImportSettingsBuilder MaxFileSize(double? value)
    {
      this.container.MaxFileSize = value;
      return this;
    }

    public EditorImportSettingsBuilder Proxy(
      string actionName,
      string controllerName)
    {
      this.container.Proxy.Action(actionName, controllerName, (object) null);
      return this;
    }

    public EditorImportSettingsBuilder Proxy<TController>(
      Expression<Action<TController>> controllerAction)
      where TController : Controller
    {
      this.container.Proxy.Action<TController>(controllerAction);
      return this;
    }

    public EditorImportSettingsBuilder Error(
      Func<object, object> inlineCodeBlock)
    {
      this.container.Error.TemplateDelegate = inlineCodeBlock;
      return this;
    }

    public EditorImportSettingsBuilder Error(string onErrorHandlerName)
    {
      this.container.Error.HandlerName = onErrorHandlerName;
      return this;
    }

    public EditorImportSettingsBuilder Complete(
      Func<object, object> inlineCodeBlock)
    {
      this.container.Complete.TemplateDelegate = inlineCodeBlock;
      return this;
    }

    public EditorImportSettingsBuilder Complete(
      string onCompleteHandlerName)
    {
      this.container.Complete.HandlerName = onCompleteHandlerName;
      return this;
    }

    public EditorImportSettingsBuilder Select(
      Func<object, object> inlineCodeBlock)
    {
      this.container.Select.TemplateDelegate = inlineCodeBlock;
      return this;
    }

    public EditorImportSettingsBuilder Select(string onSelectHandlerName)
    {
      this.container.Select.HandlerName = onSelectHandlerName;
      return this;
    }

    public EditorImportSettingsBuilder Success(
      Func<object, object> inlineCodeBlock)
    {
      this.container.Success.TemplateDelegate = inlineCodeBlock;
      return this;
    }

    public EditorImportSettingsBuilder Success(
      string onSuccessHandlerName)
    {
      this.container.Success.HandlerName = onSuccessHandlerName;
      return this;
    }

    public EditorImportSettingsBuilder Progress(
      Func<object, object> inlineCodeBlock)
    {
      this.container.Progress.TemplateDelegate = inlineCodeBlock;
      return this;
    }

    public EditorImportSettingsBuilder Progress(
      string onProgressHandlerName)
    {
      this.container.Progress.HandlerName = onProgressHandlerName;
      return this;
    }

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
