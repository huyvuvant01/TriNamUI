// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.GanttColumnSortableSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class GanttColumnSortableSettingsBuilder
  {
    private readonly GanttColumnSortableSettings container;

    public GanttColumnSortableSettingsBuilder(GanttColumnSortableSettings settings) => this.container = settings;

    public GanttColumnSortableSettingsBuilder Compare(
      Func<object, object> handler)
    {
      this.container.Compare.TemplateDelegate = handler;
      return this;
    }

    public GanttColumnSortableSettingsBuilder Compare(
      string handler)
    {
      this.container.Compare.HandlerName = handler;
      return this;
    }
  }
}
