// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.TreeListColumnSortableSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class TreeListColumnSortableSettingsBuilder<T> where T : class
  {
    public TreeListColumnSortableSettingsBuilder(TreeListColumnSortableSettings<T> container) => this.Container = container;

    protected TreeListColumnSortableSettings<T> Container { get; private set; }

    public TreeListColumnSortableSettingsBuilder<T> Compare(
      string handler)
    {
      this.Container.Compare = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public TreeListColumnSortableSettingsBuilder<T> Compare(
      Func<object, object> handler)
    {
      this.Container.Compare = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }
  }
}
