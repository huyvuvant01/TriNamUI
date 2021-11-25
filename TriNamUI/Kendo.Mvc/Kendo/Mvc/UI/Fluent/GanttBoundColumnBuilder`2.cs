﻿// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.GanttBoundColumnBuilder`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class GanttBoundColumnBuilder<TTaskModel, TDependenciesModel> : 
    GanttColumnBuilder<TTaskModel, TDependenciesModel>
    where TTaskModel : class, IGanttTask
    where TDependenciesModel : class, IGanttDependency
  {
    public GanttBoundColumnBuilder(GanttColumn<TTaskModel, TDependenciesModel> column)
      : base(column)
    {
    }

    public GanttBoundColumnBuilder<TTaskModel, TDependenciesModel> Editor(
      Func<object, object> handler)
    {
      this.Container.Editor.TemplateDelegate = handler;
      return this;
    }

    public GanttBoundColumnBuilder<TTaskModel, TDependenciesModel> Editor(
      string handlerName)
    {
      this.Container.Editor.HandlerName = handlerName;
      return this;
    }
  }
}
