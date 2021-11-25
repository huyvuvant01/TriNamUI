// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.GridBoundColumnSortableSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class GridBoundColumnSortableSettings : JsonObject
  {
    public GridBoundColumnSortableSettings() => this.Compare = new ClientHandlerDescriptor();

    public bool? AllowUnsort { get; set; }

    public ClientHandlerDescriptor Compare { get; set; }

    public ListSortDirection? SortOrder { get; set; }

    protected override void Serialize(IDictionary<string, object> json)
    {
      if (this.AllowUnsort.HasValue)
        json["allowUnsort"] = (object) this.AllowUnsort;
      if (this.Compare.HasValue())
        json["compare"] = (object) this.Compare;
      if (!this.SortOrder.HasValue)
        return;
      IDictionary<string, object> dictionary = json;
      ListSortDirection? sortOrder = this.SortOrder;
      ListSortDirection listSortDirection = ListSortDirection.Ascending;
      string str = sortOrder.GetValueOrDefault() == listSortDirection & sortOrder.HasValue ? "asc" : "desc";
      dictionary["initialDirection"] = (object) str;
    }
  }
}
