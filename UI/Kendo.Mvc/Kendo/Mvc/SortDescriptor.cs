// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.SortDescriptor
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc
{
  public class SortDescriptor : JsonObject, IDescriptor
  {
    public SortDescriptor()
      : this((string) null, ListSortDirection.Ascending)
    {
    }

    public SortDescriptor(string member, ListSortDirection order)
    {
      this.Member = member;
      this.SortDirection = order;
    }

    public string Member { get; set; }

    public ListSortDirection SortDirection { get; set; }

    public ClientHandlerDescriptor SortCompare { get; set; }

    public void Deserialize(string source)
    {
      string[] strArray = source.Split(new char[1]{ '-' });
      if (strArray.Length > 1)
        this.Member = strArray[0];
      this.SortDirection = ((IEnumerable<string>) strArray).Last<string>() == "desc" ? ListSortDirection.Descending : ListSortDirection.Ascending;
    }

    public string Serialize() => "{0}-{1}".FormatWith((object) this.Member, this.SortDirection == ListSortDirection.Ascending ? (object) "asc" : (object) "desc");

    protected override void Serialize(IDictionary<string, object> json)
    {
      json["field"] = (object) this.Member;
      json["dir"] = this.SortDirection == ListSortDirection.Ascending ? (object) "asc" : (object) "desc";
      if (this.SortCompare == null || !this.SortCompare.HasValue())
        return;
      json["compare"] = (object) this.SortCompare;
    }
  }
}
