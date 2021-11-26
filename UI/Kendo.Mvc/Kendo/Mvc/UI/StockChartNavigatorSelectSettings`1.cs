// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.StockChartNavigatorSelectSettings`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class StockChartNavigatorSelectSettings<T> where T : class
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public DateTime? From { get; set; }

    public StockChartNavigatorSelectMousewheelSettings<T> Mousewheel { get; } = new StockChartNavigatorSelectMousewheelSettings<T>();

    public DateTime? To { get; set; }

    public Kendo.Mvc.UI.StockChart<T> StockChart { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.From.HasValue)
        dictionary["from"] = (object) this.From;
      Dictionary<string, object> source = this.Mousewheel.Serialize();
      if (source.Any<KeyValuePair<string, object>>())
        dictionary["mousewheel"] = (object) source;
      else if (this.Mousewheel.Enabled.HasValue)
        dictionary["mousewheel"] = (object) this.Mousewheel.Enabled;
      if (this.To.HasValue)
        dictionary["to"] = (object) this.To;
      return dictionary;
    }
  }
}
