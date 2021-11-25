// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.ChartSeriesLineSettings`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class ChartSeriesLineSettings<T> where T : class
  {
    public string StringWidth { get; set; }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      string stringWidth = this.StringWidth;
      if ((stringWidth != null ? (stringWidth.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["width"] = (object) this.StringWidth;
      return dictionary;
    }

    public string Color { get; set; }

    public double? Opacity { get; set; }

    public double? Width { get; set; }

    public ChartSeriesLineStyle? Style { get; set; }

    public Kendo.Mvc.UI.Chart<T> Chart { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = new Dictionary<string, object>();
      string color = this.Color;
      if ((color != null ? (color.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["color"] = (object) this.Color;
      double? nullable = this.Opacity;
      if (nullable.HasValue)
        dictionary1["opacity"] = (object) this.Opacity;
      nullable = this.Width;
      if (nullable.HasValue)
        dictionary1["width"] = (object) this.Width;
      ChartSeriesLineStyle? style = this.Style;
      if (style.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        style = this.Style;
        ref ChartSeriesLineStyle? local = ref style;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["style"] = (object) str;
      }
      return dictionary1;
    }
  }
}
