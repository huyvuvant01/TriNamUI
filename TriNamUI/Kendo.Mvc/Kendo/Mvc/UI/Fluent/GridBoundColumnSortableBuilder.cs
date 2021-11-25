// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.GridBoundColumnSortableBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class GridBoundColumnSortableBuilder : IHideObjectMembers
  {
    private readonly GridBoundColumnSortableSettings settings;

    public GridBoundColumnSortableBuilder(GridBoundColumnSortableSettings settings) => this.settings = settings;

    public GridBoundColumnSortableBuilder AllowUnsort(bool allowUnsort)
    {
      this.settings.AllowUnsort = new bool?(allowUnsort);
      return this;
    }

    public GridBoundColumnSortableBuilder Compare(
      Func<object, object> handler)
    {
      this.settings.Compare = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public GridBoundColumnSortableBuilder Compare(string handler)
    {
      this.settings.Compare = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public GridBoundColumnSortableBuilder InitialDirection(
      ListSortDirection initialDirection)
    {
      this.settings.SortOrder = new ListSortDirection?(initialDirection);
      return this;
    }

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
