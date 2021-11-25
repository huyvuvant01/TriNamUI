// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.GridGroupableMessages
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Resources;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class GridGroupableMessages
  {
    private const string DefaultEmpty = "Drag a column header and drop it here to group by that column";

    public string Empty { get; set; } = Messages.Group_Empty;

    public IDictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.Empty != "Drag a column header and drop it here to group by that column")
        dictionary["empty"] = (object) this.Empty;
      return (IDictionary<string, object>) dictionary;
    }
  }
}
