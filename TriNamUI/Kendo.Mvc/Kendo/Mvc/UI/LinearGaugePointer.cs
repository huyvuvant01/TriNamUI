// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.LinearGaugePointer
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class LinearGaugePointer
  {
    public LinearGaugePointerBorderSettings Border { get; } = new LinearGaugePointerBorderSettings();

    public string Color { get; set; }

    public LinearGaugePointerMarginSettings Margin { get; set; } = new LinearGaugePointerMarginSettings();

    public double? Opacity { get; set; }

    public GaugeLinearPointerShape? Shape { get; set; }

    public double? Size { get; set; }

    public LinearGaugePointerTrackSettings Track { get; } = new LinearGaugePointerTrackSettings();

    public double? Value { get; set; }

    public LinearGauge LinearGauge { get; set; }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary1 = new Dictionary<string, object>();
      Dictionary<string, object> source1 = this.Border.Serialize();
      if (source1.Any<KeyValuePair<string, object>>())
        dictionary1["border"] = (object) source1;
      string color = this.Color;
      if ((color != null ? (color.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["color"] = (object) this.Color;
      Dictionary<string, object> source2 = this.Margin.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
        dictionary1["margin"] = (object) source2;
      if (this.Opacity.HasValue)
        dictionary1["opacity"] = (object) this.Opacity;
      if (this.Shape.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        GaugeLinearPointerShape? shape = this.Shape;
        ref GaugeLinearPointerShape? local = ref shape;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["shape"] = (object) str;
      }
      if (this.Size.HasValue)
        dictionary1["size"] = (object) this.Size;
      Dictionary<string, object> source3 = this.Track.Serialize();
      if (source3.Any<KeyValuePair<string, object>>())
        dictionary1["track"] = (object) source3;
      if (this.Value.HasValue)
        dictionary1["value"] = (object) this.Value;
      return dictionary1;
    }
  }
}
