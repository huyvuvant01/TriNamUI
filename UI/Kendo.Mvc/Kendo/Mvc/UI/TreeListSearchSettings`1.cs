// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.TreeListSearchSettings`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class TreeListSearchSettings<T> where T : class
  {
    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      List<string> fields = this.Fields;
      if ((fields != null ? (fields.Any<string>() ? 1 : 0) : 0) != 0)
        dictionary["fields"] = (object) this.Fields;
      return dictionary;
    }

    public List<string> Fields { get; set; } = new List<string>();

    public Kendo.Mvc.UI.TreeList<T> TreeList { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings() => new Dictionary<string, object>();
  }
}
