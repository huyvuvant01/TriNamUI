// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.Extensions.DataTableWrapperExtensions
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Infrastructure;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Kendo.Mvc.Extensions
{
  internal static class DataTableWrapperExtensions
  {
    internal static DataTableWrapper WrapAsEnumerable(this DataTable dataTable) => new DataTableWrapper(dataTable);

    internal static IEnumerable SerializeToDictionary(
      this IEnumerable enumerable,
      DataTable ownerDataTable)
    {
      switch (enumerable)
      {
        case IEnumerable<AggregateFunctionsGroup> _:
        case IEnumerable<IGroup> _:
          return (IEnumerable) enumerable.OfType<IGroup>().Select<IGroup, Dictionary<string, object>>((Func<IGroup, Dictionary<string, object>>) (group => DataTableWrapperExtensions.SerializeGroupItem(ownerDataTable, group)));
        default:
          return (IEnumerable) enumerable.OfType<DataRowView>().Select<DataRowView, Dictionary<string, object>>((Func<DataRowView, Dictionary<string, object>>) (row =>
          {
            Dictionary<string, object> owner = new Dictionary<string, object>();
            DataTableWrapperExtensions.SerializeRow(ownerDataTable, row, owner);
            return owner;
          }));
      }
    }

    private static Dictionary<string, object> SerializeGroupItem(
      DataTable ownerDataTable,
      IGroup group)
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>()
      {
        {
          "Key",
          group.Key
        },
        {
          "HasSubgroups",
          (object) group.HasSubgroups
        },
        {
          "Member",
          (object) group.Member
        },
        {
          "Items",
          (object) group.Items.SerializeToDictionary(ownerDataTable)
        },
        {
          "Subgroups",
          (object) group.Subgroups.SerializeToDictionary(ownerDataTable)
        }
      };
      if (group is AggregateFunctionsGroup aggregateFunctionsGroup)
      {
        dictionary.Add("AggregateFunctionsProjection", aggregateFunctionsGroup.AggregateFunctionsProjection);
        dictionary.Add("Aggregates", (object) aggregateFunctionsGroup.Aggregates);
      }
      return dictionary;
    }

    public static Dictionary<string, object> SerializeRow(this DataRowView row)
    {
      DataTable table = row.DataView.Table;
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      DataRowView row1 = row;
      Dictionary<string, object> owner = dictionary;
      DataTableWrapperExtensions.SerializeRow(table, row1, owner);
      return dictionary;
    }

    public static Dictionary<string, object> SerializeRow(this DataRow row) => row.Table.Columns.Cast<DataColumn>().ToDictionary<DataColumn, string, object>((Func<DataColumn, string>) (column => column.ColumnName), (Func<DataColumn, object>) (column => row[column.ColumnName]));

    private static void SerializeRow(
      DataTable dataTable,
      DataRowView row,
      Dictionary<string, object> owner)
    {
      foreach (DataColumn column in (InternalDataCollectionBase) dataTable.Columns)
        owner.Add(column.ColumnName, row.Row[column.ColumnName]);
    }
  }
}
