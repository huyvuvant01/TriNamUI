// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.GridColumnGroup`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class GridColumnGroup<T> : 
    GridColumnBase<T>,
    IGridColumnGroup,
    IGridColumn,
    IGridColumnContainer<T>
    where T : class
  {
    public GridColumnGroup(Grid<T> grid)
      : base(grid)
    {
      this.Columns = (IList<GridColumnBase<T>>) new List<GridColumnBase<T>>();
    }

    protected override void Serialize(IDictionary<string, object> json)
    {
      base.Serialize(json);
      IEnumerable<IDictionary<string, object>> source = this.VisibleColumns.OfType<JsonObject>().Select<JsonObject, IDictionary<string, object>>((Func<JsonObject, IDictionary<string, object>>) (c => c.ToJson()));
      if (!source.Any<IDictionary<string, object>>())
        return;
      json["columns"] = (object) source;
    }

    public override bool Visible
    {
      get => base.Visible && ((IEnumerable<IGridColumn>) this.Columns).FlatColumns().Where<IGridColumn>((Func<IGridColumn, bool>) (c => c.Visible)).Any<IGridColumn>();
      set => base.Visible = value;
    }

    public IList<GridColumnBase<T>> Columns { get; private set; }

    public IEnumerable<IGridColumn> VisibleColumns => (IEnumerable<IGridColumn>) this.Columns.Where<GridColumnBase<T>>((Func<GridColumnBase<T>, bool>) (c => c.Visible));

    IEnumerable<IGridColumn> IGridColumnGroup.Columns => this.Columns.Cast<IGridColumn>();
  }
}
