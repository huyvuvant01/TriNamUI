// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.GridBoundColumnGroupableSortSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class GridBoundColumnGroupableSortSettings : JsonObject
  {
    public ClientHandlerDescriptor Compare { get; set; }

    public ListSortDirection? Dir { get; set; }

    public GridBoundColumnGroupableSortSettings() => this.Compare = new ClientHandlerDescriptor();

    protected override void Serialize(IDictionary<string, object> json)
    {
      if (this.Compare.HasValue())
        json["compare"] = (object) this.Compare;
      ListSortDirection? dir = this.Dir;
      if (!dir.HasValue)
        return;
      IDictionary<string, object> dictionary = json;
      dir = this.Dir;
      ListSortDirection listSortDirection = ListSortDirection.Ascending;
      string str = dir.GetValueOrDefault() == listSortDirection & dir.HasValue ? "asc" : "desc";
      dictionary["dir"] = (object) str;
    }
  }
}
