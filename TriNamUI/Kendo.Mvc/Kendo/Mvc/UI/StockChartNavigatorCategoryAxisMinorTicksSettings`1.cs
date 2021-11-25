// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.StockChartNavigatorCategoryAxisMinorTicksSettings`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class StockChartNavigatorCategoryAxisMinorTicksSettings<T> where T : class
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Color { get; set; }

    public double? Size { get; set; }

    public bool? Visible { get; set; }

    public double? Width { get; set; }

    public double? Step { get; set; }

    public double? Skip { get; set; }

    public Kendo.Mvc.UI.StockChart<T> StockChart { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string color = this.Color;
      if ((color != null ? (color.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["color"] = (object) this.Color;
      double? nullable = this.Size;
      if (nullable.HasValue)
        dictionary["size"] = (object) this.Size;
      if (this.Visible.HasValue)
        dictionary["visible"] = (object) this.Visible;
      nullable = this.Width;
      if (nullable.HasValue)
        dictionary["width"] = (object) this.Width;
      nullable = this.Step;
      if (nullable.HasValue)
        dictionary["step"] = (object) this.Step;
      nullable = this.Skip;
      if (nullable.HasValue)
        dictionary["skip"] = (object) this.Skip;
      return dictionary;
    }
  }
}
