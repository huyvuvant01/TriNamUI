// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.GanttColumnFilterableSettingsBuilder`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class GanttColumnFilterableSettingsBuilder<TTaskModel, TDependenciesModel>
    where TTaskModel : class, IGanttTask
    where TDependenciesModel : class, IGanttDependency
  {
    public GanttColumnFilterableSettingsBuilder(
      GanttColumnFilterableSettings<TTaskModel, TDependenciesModel> container)
    {
      this.Container = container;
    }

    protected GanttColumnFilterableSettings<TTaskModel, TDependenciesModel> Container { get; private set; }

    public GanttColumnFilterableSettingsBuilder<TTaskModel, TDependenciesModel> Ui(
      Func<object, object> handler)
    {
      this.Container.Ui.TemplateDelegate = handler;
      return this;
    }

    public GanttColumnFilterableSettingsBuilder<TTaskModel, TDependenciesModel> Ui(
      string handler)
    {
      this.Container.Ui.HandlerName = handler;
      return this;
    }
  }
}
