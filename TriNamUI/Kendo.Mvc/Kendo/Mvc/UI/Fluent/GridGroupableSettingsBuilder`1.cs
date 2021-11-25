// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.GridGroupableSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class GridGroupableSettingsBuilder<T> where T : class
  {
    public GridGroupableSettingsBuilder(GridGroupableSettings<T> container) => this.Container = container;

    protected GridGroupableSettings<T> Container { get; private set; }

    public GridGroupableSettingsBuilder<T> Messages(
      Action<GridGroupableMessagesBuilder> configurator)
    {
      configurator(new GridGroupableMessagesBuilder(this.Container.Messages));
      return this;
    }

    public GridGroupableSettingsBuilder<T> Enabled(bool value)
    {
      this.Container.Enabled = new bool?(value);
      return this;
    }

    public GridGroupableSettingsBuilder<T> ShowFooter(bool value)
    {
      this.Container.ShowFooter = new bool?(value);
      return this;
    }

    public GridGroupableSettingsBuilder<T> ShowFooter()
    {
      this.Container.ShowFooter = new bool?(true);
      return this;
    }

    public GridGroupableSettingsBuilder<T> Sort(
      Action<GridGroupableSortSettingsBuilder<T>> configurator)
    {
      this.Container.Sort.Grid = this.Container.Grid;
      configurator(new GridGroupableSortSettingsBuilder<T>(this.Container.Sort));
      return this;
    }
  }
}
