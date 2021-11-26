// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.StockChartNavigatorSeriesMarkersSettings`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class StockChartNavigatorSeriesMarkersSettings<T> where T : class
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Background { get; set; }

    public StockChartNavigatorSeriesMarkersBorderSettings<T> Border { get; } = new StockChartNavigatorSeriesMarkersBorderSettings<T>();

    public double? Rotation { get; set; }

    public double? Size { get; set; }

    public string Type { get; set; }

    public bool? Visible { get; set; }

    public Kendo.Mvc.UI.StockChart<T> StockChart { get; set; }

    protected Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string background = this.Background;
      if ((background != null ? (background.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["background"] = (object) this.Background;
      Dictionary<string, object> source = this.Border.Serialize();
      if (source.Any<KeyValuePair<string, object>>())
        dictionary["border"] = (object) source;
      double? nullable = this.Rotation;
      if (nullable.HasValue)
        dictionary["rotation"] = (object) this.Rotation;
      nullable = this.Size;
      if (nullable.HasValue)
        dictionary["size"] = (object) this.Size;
      string type = this.Type;
      if ((type != null ? (type.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["type"] = (object) this.Type;
      if (this.Visible.HasValue)
        dictionary["visible"] = (object) this.Visible;
      return dictionary;
    }
  }
}
