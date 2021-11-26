// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.TreeListColumnFactory`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class TreeListColumnFactory<T> where T : class
  {
    private TreeListColumnGroup<T> ColumnGroup;

    public TreeListColumnFactory(List<TreeListColumn<T>> container) => this.Container = container;

    public TreeListColumnFactory(TreeListColumnGroup<T> columnGroup)
    {
      this.ColumnGroup = columnGroup;
      this.Container = columnGroup.Columns;
    }

    protected List<TreeListColumn<T>> Container { get; private set; }

    public virtual TreeListColumnGroupBuilder<T> Group(
      Action<TreeListColumnGroupBuilder<T>> configurator)
    {
      TreeListColumnGroup<T> column = new TreeListColumnGroup<T>();
      column.TreeList = this.TreeList;
      if (this.ColumnGroup != null)
      {
        column.TreeList = this.ColumnGroup.TreeList;
        this.ColumnGroup.Columns.Add((TreeListColumn<T>) column);
      }
      else
        this.Container.Add((TreeListColumn<T>) column);
      TreeListColumnGroupBuilder<T> columnGroupBuilder = new TreeListColumnGroupBuilder<T>(column);
      configurator(columnGroupBuilder);
      return columnGroupBuilder;
    }

    public Kendo.Mvc.UI.TreeList<T> TreeList { get; set; }

    public virtual TreeListColumnBuilder<T> Add()
    {
      TreeListColumn<T> container = new TreeListColumn<T>();
      container.TreeList = this.TreeList;
      this.Container.Add(container);
      return new TreeListColumnBuilder<T>(container);
    }
  }
}
