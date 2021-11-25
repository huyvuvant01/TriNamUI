// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.PivotGridExcelSettings`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class PivotGridExcelSettings<T> where T : class
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string FileName { get; set; }

    public bool? Filterable { get; set; }

    public bool? ForceProxy { get; set; }

    public string ProxyURL { get; set; }

    public Kendo.Mvc.UI.PivotGrid<T> PivotGrid { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string fileName = this.FileName;
      if ((fileName != null ? (fileName.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["fileName"] = (object) this.FileName;
      bool? nullable = this.Filterable;
      if (nullable.HasValue)
        dictionary["filterable"] = (object) this.Filterable;
      nullable = this.ForceProxy;
      if (nullable.HasValue)
        dictionary["forceProxy"] = (object) this.ForceProxy;
      string proxyUrl = this.ProxyURL;
      if ((proxyUrl != null ? (proxyUrl.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["proxyURL"] = (object) this.ProxyURL;
      return dictionary;
    }
  }
}
