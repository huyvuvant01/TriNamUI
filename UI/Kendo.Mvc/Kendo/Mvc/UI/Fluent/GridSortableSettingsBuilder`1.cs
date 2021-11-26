// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.GridSortableSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class GridSortableSettingsBuilder<T> where T : class
  {
    public GridSortableSettingsBuilder(GridSortableSettings<T> container) => this.Container = container;

    protected GridSortableSettings<T> Container { get; private set; }

    public virtual GridSortableSettingsBuilder<T> Enabled(bool value)
    {
      this.Container.Enabled = new bool?(value);
      return this;
    }

    public GridSortableSettingsBuilder<T> AllowUnsort(bool value)
    {
      this.Container.AllowUnsort = new bool?(value);
      return this;
    }

    public GridSortableSettingsBuilder<T> ShowIndexes(bool value)
    {
      this.Container.ShowIndexes = new bool?(value);
      return this;
    }

    public GridSortableSettingsBuilder<T> InitialDirection(string value)
    {
      this.Container.InitialDirection = value;
      return this;
    }

    public GridSortableSettingsBuilder<T> SortMode(GridSortMode value)
    {
      this.Container.SortMode = new GridSortMode?(value);
      return this;
    }
  }
}
