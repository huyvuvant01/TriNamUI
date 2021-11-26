// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.GridColumnExtensions
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  internal static class GridColumnExtensions
  {
    public static string GroupTitleForMember(
      this IEnumerable<IGridColumn> columns,
      string memberName)
    {
      IGridBoundColumn gridBoundColumn = columns.OfType<IGridBoundColumn>().FirstOrDefault<IGridBoundColumn>((Func<IGridBoundColumn, bool>) (c => c.Member == memberName));
      if (gridBoundColumn == null)
        return memberName.AsTitle();
      return gridBoundColumn.Title.HasValue() ? gridBoundColumn.Title : gridBoundColumn.Member.AsTitle();
    }

    public static IEnumerable<IGridColumn> ColumnParents(
      this IEnumerable<IGridColumn> columns,
      IGridColumn column)
    {
      return columns.ColumnParentsAndSelf(column).Where<IGridColumn>((Func<IGridColumn, bool>) (c => c != column));
    }

    public static IEnumerable<IGridColumn> ColumnParentsAndSelf(
      this IEnumerable<IGridColumn> columns,
      IGridColumn column)
    {
      List<IGridColumn> first = new List<IGridColumn>();
      if (columns.Any<IGridColumn>((Func<IGridColumn, bool>) (c => c == column)))
      {
        first.Add(column);
        return (IEnumerable<IGridColumn>) first;
      }
      foreach (IGridColumnGroup gridColumnGroup in columns.OfType<IGridColumnGroup>())
      {
        IEnumerable<IGridColumn> gridColumns = gridColumnGroup.Columns.ColumnParentsAndSelf(column);
        if (gridColumns.Any<IGridColumn>())
        {
          first.Add((IGridColumn) gridColumnGroup);
          first = first.Concat<IGridColumn>(gridColumns).ToList<IGridColumn>();
          break;
        }
      }
      return (IEnumerable<IGridColumn>) first;
    }

    public static int ColumnLevel(this IEnumerable<IGridColumn> columns, IGridColumn column)
    {
      columns = columns.Where<IGridColumn>((Func<IGridColumn, bool>) (c => c.Visible));
      if (!columns.Any<IGridColumn>())
        return 0;
      int num1 = 1;
      if (columns.Any<IGridColumn>((Func<IGridColumn, bool>) (c => c == column)))
        return num1;
      IEnumerable<IGridColumn> gridColumns = columns.SelectMany<IGridColumn, IGridColumn>(new Func<IGridColumn, IEnumerable<IGridColumn>>(GridColumnExtensions.GetChildColumnsForLevel));
      int num2;
      return gridColumns.Any<IGridColumn>() ? (num2 = num1 + gridColumns.ColumnLevel(column)) : num1;
    }

    public static IEnumerable<IGridColumn> FlatColumns(
      this IEnumerable<IGridColumn> columns)
    {
      return columns.SelectRecursive<IGridColumn>(new Func<IGridColumn, IEnumerable<IGridColumn>>(GridColumnExtensions.GetChildColumns));
    }

    public static IEnumerable<IGridColumn> LeafColumns(
      this IEnumerable<IGridColumn> columns)
    {
      return columns.SelectRecursive<IGridColumn>(new Func<IGridColumn, IEnumerable<IGridColumn>>(GridColumnExtensions.GetChildColumns)).Where<IGridColumn>((Func<IGridColumn, bool>) (c => !(c is IGridColumnGroup)));
    }

    private static IEnumerable<IGridColumn> GetChildColumns(IGridColumn column) => column is IGridColumnGroup ? ((IGridColumnGroup) column).Columns : (IEnumerable<IGridColumn>) null;

    private static IEnumerable<IGridColumn> GetChildColumnsForLevel(
      IGridColumn column)
    {
      return column is IGridColumnGroup ? ((IGridColumnGroup) column).Columns : (IEnumerable<IGridColumn>) new IGridColumn[0];
    }
  }
}
