// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.GridColumnMenuSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class GridColumnMenuSettingsBuilder<T> where T : class
  {
    public GridColumnMenuSettingsBuilder(GridColumnMenuSettings<T> container) => this.Container = container;

    protected GridColumnMenuSettings<T> Container { get; private set; }

    public GridColumnMenuSettingsBuilder<T> Messages(
      Action<GridColumnMenuMessagesBuilder> configurator)
    {
      configurator(new GridColumnMenuMessagesBuilder(this.Container.Messages));
      return this;
    }

    public GridColumnMenuSettingsBuilder<T> Enabled(bool value)
    {
      this.Container.Enabled = new bool?(value);
      return this;
    }

    public GridColumnMenuSettingsBuilder<T> Columns(
      Action<GridColumnMenuColumnsSettingsBuilder<T>> configurator)
    {
      this.Container.Columns.Enabled = new bool?(true);
      this.Container.Columns.Grid = this.Container.Grid;
      configurator(new GridColumnMenuColumnsSettingsBuilder<T>(this.Container.Columns));
      return this;
    }

    public GridColumnMenuSettingsBuilder<T> Columns(bool enabled)
    {
      this.Container.Columns.Enabled = new bool?(enabled);
      return this;
    }

    public GridColumnMenuSettingsBuilder<T> Filterable(bool value)
    {
      this.Container.Filterable = new bool?(value);
      return this;
    }

    public GridColumnMenuSettingsBuilder<T> ComponentType(string value)
    {
      this.Container.ComponentType = value;
      return this;
    }

    public GridColumnMenuSettingsBuilder<T> Sortable(bool value)
    {
      this.Container.Sortable = new bool?(value);
      return this;
    }
  }
}
