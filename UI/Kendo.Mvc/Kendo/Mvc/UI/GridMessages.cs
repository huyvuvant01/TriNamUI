// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.GridMessages
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class GridMessages : JsonObject
  {
    public string ЕxpandCollapseColumnHeader { get; set; }

    public string NoRecords { get; set; }

    public string GroupHeader { get; set; }

    public string UngroupHeader { get; set; }

    protected override void Serialize(IDictionary<string, object> json)
    {
      if (this.ЕxpandCollapseColumnHeader.HasValue())
        json["expandCollapseColumnHeader"] = (object) this.ЕxpandCollapseColumnHeader;
      if (this.NoRecords.HasValue())
        json["noRecords"] = (object) this.NoRecords;
      if (this.GroupHeader.HasValue())
        json["groupHeader"] = (object) this.GroupHeader;
      if (!this.UngroupHeader.HasValue())
        return;
      json["ungroupHeader"] = (object) this.UngroupHeader;
    }
  }
}
