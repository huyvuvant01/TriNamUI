// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.EditorExportAsSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq.Expressions;

namespace Kendo.Mvc.UI.Fluent
{
  public class EditorExportAsSettingsBuilder : IHideObjectMembers
  {
    private readonly EditorExportAsSettings settings;

    public EditorExportAsSettingsBuilder(EditorExportAsSettings settings) => this.settings = settings;

    public EditorExportAsSettingsBuilder FileName(string fileName)
    {
      this.settings.FileName = fileName;
      return this;
    }

    public EditorExportAsSettingsBuilder Proxy(
      string actionName,
      string controllerName)
    {
      this.settings.Proxy.Action(actionName, controllerName, (object) null);
      return this;
    }

    public EditorExportAsSettingsBuilder Proxy(string routeName)
    {
      this.settings.Proxy.Route(routeName, (object) null);
      return this;
    }

    public EditorExportAsSettingsBuilder Proxy<TController>(
      Expression<Action<TController>> controllerAction)
      where TController : Controller
    {
      this.settings.Proxy.Action<TController>(controllerAction);
      return this;
    }

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
