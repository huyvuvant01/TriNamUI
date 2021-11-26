// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.GridColumnMenuColumnsSettingsGroupFactory`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class GridColumnMenuColumnsSettingsGroupFactory<T> where T : class
  {
    public GridColumnMenuColumnsSettingsGroupFactory(
      List<GridColumnMenuColumnsSettingsGroup<T>> container)
    {
      this.Container = container;
    }

    protected List<GridColumnMenuColumnsSettingsGroup<T>> Container { get; private set; }

    public Kendo.Mvc.UI.Grid<T> Grid { get; set; }

    public virtual GridColumnMenuColumnsSettingsGroupBuilder<T> Add()
    {
      GridColumnMenuColumnsSettingsGroup<T> columnsSettingsGroup = new GridColumnMenuColumnsSettingsGroup<T>();
      columnsSettingsGroup.Grid = this.Grid;
      this.Container.Add(columnsSettingsGroup);
      return new GridColumnMenuColumnsSettingsGroupBuilder<T>(columnsSettingsGroup);
    }
  }
}
