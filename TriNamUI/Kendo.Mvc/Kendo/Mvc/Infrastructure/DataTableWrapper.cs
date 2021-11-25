// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.Infrastructure.DataTableWrapper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace Kendo.Mvc.Infrastructure
{
  internal class DataTableWrapper : IEnumerable<DataRowView>, IEnumerable
  {
    internal DataTableWrapper(DataTable dataTable) => this.Table = dataTable;

    public DataTable Table { get; private set; }

    public IEnumerator<DataRowView> GetEnumerator()
    {
      if (this.Table != null)
      {
        foreach (DataRow row in (InternalDataCollectionBase) this.Table.Rows)
          yield return this.Table.DefaultView[this.Table.Rows.IndexOf(row)];
      }
    }

    IEnumerator IEnumerable.GetEnumerator() => (IEnumerator) this.GetEnumerator();
  }
}
