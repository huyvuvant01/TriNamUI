// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.ChartValueAxisPlotBand`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class ChartValueAxisPlotBand<T> where T : class
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Color { get; set; }

    public object From { get; set; }

    public ChartValueAxisPlotBandLabelSettings<T> Label { get; } = new ChartValueAxisPlotBandLabelSettings<T>();

    public double? Opacity { get; set; }

    public object To { get; set; }

    public Kendo.Mvc.UI.Chart<T> Chart { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string color = this.Color;
      if ((color != null ? (color.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["color"] = (object) this.Color;
      if (this.From != null)
        dictionary["from"] = this.From;
      Dictionary<string, object> source = this.Label.Serialize();
      if (source.Any<KeyValuePair<string, object>>())
        dictionary["label"] = (object) source;
      if (this.Opacity.HasValue)
        dictionary["opacity"] = (object) this.Opacity;
      if (this.To != null)
        dictionary["to"] = this.To;
      return dictionary;
    }
  }
}
