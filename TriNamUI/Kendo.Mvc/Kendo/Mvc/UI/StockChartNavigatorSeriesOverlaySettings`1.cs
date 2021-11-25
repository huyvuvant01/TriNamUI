// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.StockChartNavigatorSeriesOverlaySettings`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class StockChartNavigatorSeriesOverlaySettings<T> where T : class
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Gradient { get; set; }

    public Kendo.Mvc.UI.StockChart<T> StockChart { get; set; }

    protected Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string gradient = this.Gradient;
      if ((gradient != null ? (gradient.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["gradient"] = (object) this.Gradient;
      return dictionary;
    }
  }
}
